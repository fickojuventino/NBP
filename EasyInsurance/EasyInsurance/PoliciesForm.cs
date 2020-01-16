using EasyInsurance.Models.Relationships;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbKind.Text == "Individualno")
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
                    else if (cbType.Text == "Putno osiguranje")
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
                    else if (cbType.Text == "Zivotno Osiguranje")
                    {
                        var policies = ((IRawGraphClient)client).ExecuteGetCypherResults<IndividualLife>(query).ToList();

                        DataTable table = new DataTable();

                        table.Columns.Add("Razlog", typeof(string));
                        table.Columns.Add("Pusac", typeof(string));
                        table.Columns.Add("Uplata", typeof(decimal));
                        table.Columns.Add("OsiguravajucaSuma", typeof(decimal));

                        foreach (var policy in policies)
                        {
                            table.Rows.Add(policy.Razlog, policy.Pusac, policy.Uplata, policy.OsiguravajucaSuma);
                        }

                        dgvPolicies.DataSource = table;
                    }
                }
                else if (cbKind.Text == "Porodicno")
                {
                    var query = new CypherQuery("Match (i:Insured {Identifier: '" + identifier +
                    "'})-[r:HAS_GROUP_POLICY]->(p:Policy) where p.Tip = '" + cbType.Text + "' and p.Vrsta = '" + cbKind.Text + "' return r",
                    new Dictionary<string, object>(), CypherResultMode.Set);

                    if (cbType.Text == "Putno osiguranje")
                    {
                        var policies = ((IRawGraphClient)client).ExecuteGetCypherResults<GroupTravel>(query).ToList();

                        DataTable table = new DataTable();

                        table.Columns.Add("Datum od", typeof(DateTime));
                        table.Columns.Add("Datum do", typeof(DateTime));
                        table.Columns.Add("Uplata", typeof(decimal));
                        table.Columns.Add("Osiguravajuca suma", typeof(decimal));
                        table.Columns.Add("Destinacija", typeof(string));
                        table.Columns.Add("Svrha", typeof(string));
                        table.Columns.Add("DrugiClan", typeof(string));
                        table.Columns.Add("TreciClan", typeof(string));
                        table.Columns.Add("CetvrtiClan", typeof(string));

                        foreach (var policy in policies)
                        {
                            table.Rows.Add(policy.DatumOd, policy.DatumDo, policy.Uplata, policy.OsiguravajucaSuma, policy.Destinacija, policy.Svrha, policy.DrugiClan, policy.TreciClan, policy.CetvrtiClan);
                        }
                        dgvPolicies.DataSource = table;
                    }
                    else if (cbType.Text == "Zivotno Osiguranje")
                    {
                        var policies = ((IRawGraphClient)client).ExecuteGetCypherResults<GroupLife>(query).ToList();

                        DataTable table = new DataTable();

                        table.Columns.Add("Razlog", typeof(string));
                        table.Columns.Add("Pusac", typeof(string));
                        table.Columns.Add("Uplata", typeof(decimal));
                        table.Columns.Add("OsiguravajucaSuma", typeof(decimal));
                        table.Columns.Add("DrugiClan", typeof(string));
                        table.Columns.Add("TreciClan", typeof(string));
                        table.Columns.Add("CetvrtiClan", typeof(string));

                        foreach (var policy in policies)
                        {
                            table.Rows.Add(policy.Razlog, policy.Pusac, policy.Uplata, policy.OsiguravajucaSuma, policy.DrugiClan, policy.TreciClan, policy.CetvrtiClan);
                        }

                        dgvPolicies.DataSource = table;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class asd
    {
        public string Tip { get; set; }
        public string Vrsta { get; set; }
        //public int Ukupno { get; set; }
    }
}
