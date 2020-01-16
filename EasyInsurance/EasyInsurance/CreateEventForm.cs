using EasyInsurance.Models;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EasyInsurance
{
    public partial class CreateEventForm : Form
    {
        private GraphClient client;
        private Insured insured;

        public CreateEventForm()
        {
            InitializeComponent();
        }

        public CreateEventForm(GraphClient client, Insured insured)
        {
            this.insured = insured;
            this.client = client;
            InitializeComponent();
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            try
            {
                var policy = new Policy
                {
                    Tip = cbPolicies.Text.Split('-')[0],
                    Vrsta = cbPolicies.Text.Split('-')[1]
                };
                var date = DateTime.Now;

                var getStakeQuery = new CypherQuery("MATCH (i:Insured)-[r:HAS_POLICY]->(p:Policy) where i.Identifier = '" + insured.Identifier +
                    "' and p.Tip = '" + policy.Tip + "' and p.Vrsta = '" + policy.Vrsta + "' return r.Uplata", new Dictionary<string, object>(), CypherResultMode.Set);
                var stake = ((IRawGraphClient)client).ExecuteGetCypherResults<string>(getStakeQuery).SingleOrDefault();

                var createEventQuery = new CypherQuery("Create (e:Event {InsuredId: '" + insured.Identifier + "', Description:'" + tbDescription.Text + "', Payout: '" +
                    decimal.Parse(tbPayoutAmount.Text) + "', Stake: '" + stake + "', Date: '" + date + "'})",
                    new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(createEventQuery);

                var connectEventQuery = new CypherQuery("MATCH (e:Event), (p:Policy) where e.InsuredId = '" + insured.Identifier 
                    + "' and e.Date = '" + date + "' and p.Tip = '" + policy.Tip + "' and p.Vrsta = '" + policy.Vrsta + "' create (e)-[r:INSURED_BY]->(p)", new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(connectEventQuery);

                var deleteInsurancePolicy = new CypherQuery("MATCH (i:Insured { Identifier: '" + insured.Identifier + "' })-[r:HAS_POLICY]->(p:Policy{Tip: '" + policy.Tip +
                    "', Vrsta: '" + policy.Vrsta + "'}) DELETE r", new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(deleteInsurancePolicy);

                lbStatus.Text = "Uspesno kreiran dogadjaj.";
                lbStatus.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateEventForm_Load(object sender, EventArgs e)
        {
            var query = new CypherQuery("Match (i:Insured {Identifier: '" + insured.Identifier + "'})-[r:HAS_POLICY]->(p:Policy) return p",
                    new Dictionary<string, object>(), CypherResultMode.Set);
            var policies = ((IRawGraphClient)client).ExecuteGetCypherResults<Policy>(query).ToList();

            foreach (var policy in policies)
            {
                cbPolicies.Items.Add(policy.Tip + "-" + policy.Vrsta);
            }
        }
    }
}
