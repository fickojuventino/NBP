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
    public partial class PoliciesForm : Form
    {
        private long identifier;
        private GraphClient client;

        public PoliciesForm()
        {
            InitializeComponent();
        }

        public PoliciesForm(long id, GraphClient client)
        {
            identifier = id;
            this.client = client;
            InitializeComponent();
        }

        private void PoliciesForm_Load(object sender, EventArgs e)
        {
            try
            {
                var query = new CypherQuery("Match (i:Insured {Identifier: '" + identifier + "'})-[r:HAS_POLICY]->(p:Policy) return p",
                    new Dictionary<string, object>(), CypherResultMode.Set);
                var policies = ((IRawGraphClient)client).ExecuteGetCypherResults<Policy>(query).ToList();

                dgvPolicies.AutoGenerateColumns = false;
                dgvPolicies.AllowUserToAddRows = false;
                dgvPolicies.DataSource = policies;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPolicies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var senderGrid = (DataGridView)sender;

            if (dgvPolicies.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var selected = dgvPolicies[0, e.RowIndex].Value.ToString();
                if (selected == "Zivotno Osiguranje")
                {
                    LifeInsuranceForm lifeInsuranceForm = new LifeInsuranceForm();
                    lifeInsuranceForm.Show();
                }
                else if(selected == "Putno osiguranje")
                {
                    TravelInsuranceForm travelInsuranceForm = new TravelInsuranceForm();
                    travelInsuranceForm.Show();
                }
            }
        }
    }
}
