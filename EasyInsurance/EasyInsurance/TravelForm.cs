using EasyInsurance.Models;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyInsurance
{
    public partial class TravelForm : Form
    {
        private long identifier;
        private GraphClient client;

        public TravelForm()
        {
            InitializeComponent();
        }

        public TravelForm(long identifier, GraphClient client)
        {
            InitializeComponent();
            this.identifier = identifier;
            this.client = client;
        }

        private void btnInsure_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbInsuranceKind.Text == "Individualno")
                {
                    tbSecondIdentifier.Enabled = false;
                    tbThirdIdentifier.Enabled = false;
                    tbFourthIdentifier.Enabled = false;

                    var query = new CypherQuery("Match (i:Insured), (p:Policy) where i.Identifier = '" + identifier + "' and p.Tip = 'Putno osiguranje' and p.Vrsta = '" + cbInsuranceKind.Text + "'" +
                        " create (i)-[r:HAS_POLICY{Svrha:'" + tbPurpose.Text + "', Destinacija: '" +
                        tbDestination.Text + "', DatumOd: '"
                        + dtpDateSince.Value.Date + "', DatumDo: '"
                        + dtpDateTo.Value.Date + "', Uplata: '"
                        + tbInsuranceStake.Text + "', OsiguravajucaSuma: '" + tbInsurancePayout.Text + "'}]->(p)", new Dictionary<string, object>(), CypherResultMode.Set);
                    ((IRawGraphClient)client).ExecuteCypher(query);

                    lbStatus.Text = "Uspesno kreirana polisa. Korisnik osiguran.";
                    lbStatus.Visible = true;
                }
                else if(cbInsuranceKind.Text == "Porodicno")
                {
                    string queryFamily = "";
                    string queryWhere = ""; 
                    if(tbSecondIdentifier.Text != string.Empty)
                    {
                        var query = new CypherQuery("MATCH (i:Insured) where i.Identifier = '" + long.Parse(tbSecondIdentifier.Text) + "' return i"
                            , new Dictionary<string, object>(), CypherResultMode.Set);
                        var user = ((IRawGraphClient)client).ExecuteGetCypherResults<Insured>(query).SingleOrDefault();
                        if(user == null)
                        {
                            throw new Exception("Ne postoji 2. clan porodice sa prosledjenim jmbg-om");
                        }
                        queryFamily += "(i1:Insured),";
                        queryWhere += "and i1.Identifier = '" + long.Parse(tbSecondIdentifier.Text) + "'";
                    }
                    else
                    {
                        throw new Exception("Za porodicno osiguranje je neophodan jmbg 2. clana porodice.");
                    }
                    
                    var queryString = new CypherQuery("Match (i:Insured), " + queryFamily + " (p:Policy) where i.Identifier = '" 
                        + identifier + "' " + queryWhere + " and p.Tip = 'Putno osiguranje' and p.Vrsta = '" + cbInsuranceKind.Text + "'" +
                        " create (i)-[r:HAS_POLICY{Svrha:'" + tbPurpose.Text + "', Destinacija: '" +
                        tbDestination.Text + "', DatumOd: '"
                        + dtpDateSince.Value.Date + "', DatumDo: '"
                        + dtpDateTo.Value.Date + "', Uplata: '"
                        + tbInsuranceStake.Text + "', OsiguravajucaSuma: '" + tbInsurancePayout.Text + "'}]->(p)",
                        new Dictionary<string, object>(), CypherResultMode.Set);
                    ((IRawGraphClient)client).ExecuteCypher(queryString);
                    lbStatus.Text = "Uspesno kreirana polisa. Korisnik osiguran.";
                    lbStatus.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbInsuranceKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbInsuranceKind.Text == "Individualno")
            {
                tbSecondIdentifier.Enabled = false;
                tbThirdIdentifier.Enabled = false;
                tbFourthIdentifier.Enabled = false;
            }
            else if(cbInsuranceKind.Text == "Porodicno")
            {
                tbSecondIdentifier.Enabled = true;
                tbThirdIdentifier.Enabled = true;
                tbFourthIdentifier.Enabled = true;
            }
        }
    }
}
