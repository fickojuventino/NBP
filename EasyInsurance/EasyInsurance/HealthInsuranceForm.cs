using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EasyInsurance
{
    public partial class HealthInsuranceForm : Form
    {
        private GraphClient client;
        private long identifier;

        public HealthInsuranceForm(GraphClient client, long identifier)
        {
            this.client = client;
            this.identifier = identifier;
            InitializeComponent();
        }

        private void btnInsure_Click(object sender, EventArgs e)
        {
            try
            {
                var outpatient = chbOutpatient.Checked ? "Da" : "Ne";
                var hospital = chbHospital.Checked ? "Da" : "Ne";

                var query = new CypherQuery("Match (i:Insured), (p:Policy) where i.Identifier = '" + identifier + 
                    "' and p.Tip = 'Zdravstveno osiguranje' create (i)-[r:HAS_POLICY{Vanbolnicko: '" + outpatient + "', Bolnicko: '" + hospital 
                    + "', Uplata: '" + decimal.Parse(tbInsuranceStake.Text) + "', Isplata: '" + decimal.Parse(tbInsurancePayout.Text) + "'}]->(p)", new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(query);

                lbStatus.Text = "Uspesno kreirana polisa";
                lbStatus.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
