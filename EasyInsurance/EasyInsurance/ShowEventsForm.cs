using EasyInsurance.Models;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EasyInsurance
{
    public partial class ShowEventsForm : Form
    {
        private readonly GraphClient client;
        private readonly long identifier;

        public ShowEventsForm(GraphClient client, long id)
        {
            this.client = client;
            identifier = id;
            InitializeComponent();
        }

        private void btnFindEvents_Click(object sender, EventArgs e)
        {
            try
            {
                var query = new CypherQuery("Match (e:Event{InsuredId:'" + identifier + "'})-[r:INSURED_BY]->(p:Policy{Tip: '" +
                    cbType.Text + "', Vrsta: '" + cbKind.Text + "'}) return e",
                        new Dictionary<string, object>(), CypherResultMode.Set);
                var eventi = ((IRawGraphClient)client).ExecuteGetCypherResults<Event>(query).ToList();

                DataTable table = new DataTable();

                table.Columns.Add("Datum", typeof(string));
                table.Columns.Add("Opis", typeof(string));
                table.Columns.Add("Uplata", typeof(decimal));
                table.Columns.Add("Isplata", typeof(decimal));

                foreach(var ev in eventi)
                {
                    table.Rows.Add(ev.Date.ToString(), ev.Description, ev.Stake, ev.Payout);
                }

                dgvEvents.DataSource = table;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
