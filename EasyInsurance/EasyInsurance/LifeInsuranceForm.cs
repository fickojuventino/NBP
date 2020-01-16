using EasyInsurance.Models;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EasyInsurance
{
    public partial class LifeInsuranceForm : Form
    {
        private GraphClient client;
        private long identifier;
        private string gender;
        private DateTime birthDate;

        public LifeInsuranceForm()
        {
            InitializeComponent();
        }

        public LifeInsuranceForm(GraphClient client, long id, string gender, DateTime birthDate)
        {
            this.client = client;
            identifier = id;
            this.gender = gender;
            this.birthDate = birthDate;
            InitializeComponent();
        }

        private void btnInsure_Click(object sender, EventArgs e)
        {
            try
            {
                var pusac = rbYes.Checked ? "Da" : "Ne";
                if (cbInsuranceKind.Text == "Individualno")
                {
                    tbSecondIdentifier.Enabled = false;
                    tbThirdIdentifier.Enabled = false;
                    tbFourthIdentifier.Enabled = false;

                    var query = new CypherQuery("Match (i:Insured), (p:Policy) where i.Identifier = '" + identifier + "' and p.Tip = 'Zivotno Osiguranje' and p.Vrsta = '" + cbInsuranceKind.Text + "'" +
                        " create (i)-[r:HAS_POLICY{Razlog:'" + cbReason.Text + "', Pusac: '" +
                        pusac + "', Uplata: '"
                        + tbInsuranceStake.Text + "', OsiguravajucaSuma: '" + tbInsurancePayout.Text + "'}]->(p)", new Dictionary<string, object>(), CypherResultMode.Set);
                    ((IRawGraphClient)client).ExecuteCypher(query);

                    lbStatus.Text = "Uspesno kreirana polisa. Korisnik osiguran.";
                    lbStatus.Visible = true;
                }
                else if (cbInsuranceKind.Text == "Porodicno")
                {
                    string first = "";
                    string second = "";
                    string third = "";

                    if (tbSecondIdentifier.Text != string.Empty)
                    {
                        var query = new CypherQuery("MATCH (i:Insured) where i.Identifier = '" + long.Parse(tbSecondIdentifier.Text) + "' return i"
                            , new Dictionary<string, object>(), CypherResultMode.Set);
                        var user = ((IRawGraphClient)client).ExecuteGetCypherResults<Insured>(query).SingleOrDefault();
                        if (user == null)
                        {
                            throw new Exception("Ne postoji 2. clan porodice sa prosledjenim jmbg-om");
                        }
                        first = tbSecondIdentifier.Text;
                    }
                    else
                    {
                        throw new Exception("Za porodicno osiguranje je neophodan jmbg 2. clana porodice.");
                    }
                    if (tbThirdIdentifier.Text != string.Empty)
                    {
                        var query = new CypherQuery("MATCH (i:Insured) where i.Identifier = '" + long.Parse(tbThirdIdentifier.Text) + "' return i"
                            , new Dictionary<string, object>(), CypherResultMode.Set);
                        var user = ((IRawGraphClient)client).ExecuteGetCypherResults<Insured>(query).SingleOrDefault();
                        if (user == null)
                        {
                            throw new Exception("Ne postoji 3. clan porodice sa prosledjenim jmbg-om");
                        }
                        second = tbThirdIdentifier.Text;
                    }
                    if (tbFourthIdentifier.Text != string.Empty)
                    {
                        var query = new CypherQuery("MATCH (i:Insured) where i.Identifier = '" + long.Parse(tbFourthIdentifier.Text) + "' return i"
                            , new Dictionary<string, object>(), CypherResultMode.Set);
                        var user = ((IRawGraphClient)client).ExecuteGetCypherResults<Insured>(query).SingleOrDefault();
                        if (user == null)
                        {
                            throw new Exception("Ne postoji 4. clan porodice sa prosledjenim jmbg-om");
                        }
                        third = tbFourthIdentifier.Text;
                    }

                    var queryString = new CypherQuery("Match (i:Insured), (p:Policy) where i.Identifier = '"
                        + identifier + "' and p.Tip = 'Zivotno Osiguranje' and p.Vrsta = '" + cbInsuranceKind.Text + "'" +
                        " create (i)-[r:HAS_GROUP_POLICY{Razlog:'" + cbReason.Text + "', Pusac: '" +
                        pusac + "', Uplata: '"
                        + tbInsuranceStake.Text + "', OsiguravajucaSuma: '" + tbInsurancePayout.Text +
                        "', DrugiClan: '" + first + "', TreciClan: '" + second + "', CetvrtiClan: '" + third + "'}]->(p)",
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
            if (cbInsuranceKind.Text == "Individualno")
            {
                tbSecondIdentifier.Enabled = false;
                tbThirdIdentifier.Enabled = false;
                tbFourthIdentifier.Enabled = false;
            }
            else if (cbInsuranceKind.Text == "Porodicno")
            {
                tbSecondIdentifier.Enabled = true;
                tbThirdIdentifier.Enabled = true;
                tbFourthIdentifier.Enabled = true;
            }
        }
    }
}
