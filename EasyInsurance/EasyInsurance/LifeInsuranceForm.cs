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
                if(cbInsuranceKind.Text == "Individualno")
                {
                    tbSecondIdentifier.Enabled = false;
                    tbThirdIdentifier.Enabled = false;
                    tbFourthIdentifier.Enabled = false;

                    var pusac = rbYes.Checked ? "Da" : "Ne";

                    var query = new CypherQuery("Match (i:Insured), (p:Policy) where i.Identifier = '" + identifier + "' and p.Tip = 'Zivotno Osiguranje' and p.Vrsta = '" + cbInsuranceKind.Text + "'" +
                        " create (i)-[r:HAS_POLICY{Razlog:'" + cbReason.Text + "', Pusac: '" +
                        pusac + "', Uplata: '"
                        + tbInsuranceStake.Text + "', OsiguravajucaSuma: '" + tbInsurancePayout.Text + "'}]->(p)", new Dictionary<string, object>(), CypherResultMode.Set);
                    ((IRawGraphClient)client).ExecuteCypher(query);

                    lbStatus.Text = "Uspesno kreirana polisa. Korisnik osiguran.";
                    lbStatus.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
