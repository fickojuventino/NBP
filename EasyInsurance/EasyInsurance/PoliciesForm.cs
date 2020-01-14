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
                //var query = new CypherQuery("Match (i:Insured {Identifier: '" + identifier + "'})-[r:HAS_POLICY]->(p:Policy) return p",
                //    new Dictionary<string, object>(), CypherResultMode.Set);
                //var policies = ((IRawGraphClient)client).ExecuteGetCypherResults<Policy>(query).ToList();

                //dgvPolicies.AutoGenerateColumns = false;
                //dgvPolicies.AllowUserToAddRows = false;
                //dgvPolicies.DataSource = policies;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbKind.Text == "Individualno")
                {
                    var query = new CypherQuery("Match (i:Insured {Identifier: '" + identifier +
                    "'})-[r:HAS_POLICY]->(p:Policy) where p.Tip = '" + cbType.Text + "' and p.Vrsta = '" + cbKind.Text + "' return r",
                    new Dictionary<string, object>(), CypherResultMode.Set);
                    if (cbType.Text == "Zdravstveno osiguranje")
                    {
                        var policies = ((IRawGraphClient)client).ExecuteGetCypherResults<IndividualHealth>(query).ToList();

                        DataTable table = new DataTable();

                        table.Columns.Add("Vanbolnicko", typeof(string));
                        table.Columns.Add("Bolnicko", typeof(string));
                        table.Columns.Add("Uplata", typeof(decimal));
                        table.Columns.Add("Isplata", typeof(decimal));

                        foreach (var policy in policies)
                        {
                            table.Rows.Add(policy.Vanbolnicko, policy.Bolnicko, policy.Uplata, policy.Isplata);
                        }
                        dgvPolicies.DataSource = table;
                    }
                    else if(cbType.Text == "Putno osiguranje")
                    {
                        var policies = ((IRawGraphClient)client).ExecuteGetCypherResults<IndividualTravel>(query).ToList();

                        DataTable table = new DataTable();

                        table.Columns.Add("Datum od", typeof(DateTime));
                        table.Columns.Add("Datum do", typeof(DateTime));
                        table.Columns.Add("Uplata", typeof(decimal));
                        table.Columns.Add("Osiguravajuca suma", typeof(decimal));
                        table.Columns.Add("Destinacija", typeof(string));
                        table.Columns.Add("Svrha", typeof(string));

                        foreach (var policy in policies)
                        {
                            table.Rows.Add(policy.DatumOd, policy.DatumDo, policy.Uplata, policy.OsiguravajucaSuma, policy.Destinacija, policy.Svrha);
                        }
                        dgvPolicies.DataSource = table;
                    }
                    else if(cbType.Text == "Zivotno Osiguranje")
                    {

                    }
                }
                else
                {
                    if(cbType.Text == "Putno osiguranje")
                    {

                    }
                    else if(cbType.Text == "Zivotno Osiguranje")
                    {

                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class IndividualHealth
    {
        public decimal Uplata { get; set; }
        public decimal Isplata { get; set; }
        public string Vanbolnicko { get; set; }
        public string Bolnicko { get; set; }
    }

    public class IndividualTravel
    {
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string Destinacija { get; set; }
        public decimal OsiguravajucaSuma { get; set; }
        public string Svrha { get; set; }
        public decimal Uplata { get; set; }
    }
}
