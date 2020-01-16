using EasyInsurance.Models;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace EasyInsurance
{
    public partial class EasyInsurance : Form
    {
        private GraphClient client;

        public EasyInsurance()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(client);
            registerForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery($"MATCH (w:Worker) WHERE w.UserName = '{tbLoginUser.Text}'" +
                    $" and w.Password = '{tbLoginPassword.Text}' RETURN w", new Dictionary<string, object>(), CypherResultMode.Set);

                var user = ((IRawGraphClient)client).ExecuteGetCypherResults<Worker>(query).SingleOrDefault();

                if (user == null)
                {
                    lbStatus.Text = "Ne postoji korisnik sa tim korisnickim imenom i sifrom.";
                    lbStatus.Visible = true;
                }
                else
                {
                    var t = new Thread(() => Application.Run(new WorkerForm(client, this)));
                    t.Start();
                    this.Close();
                    //WorkerForm workerForm = new WorkerForm(client, this);
                    //workerForm.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EasyInsurance_Load(object sender, EventArgs e)
        {
            tbLoginPassword.PasswordChar = '*';

            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "graph");
            try
            {
                client.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
