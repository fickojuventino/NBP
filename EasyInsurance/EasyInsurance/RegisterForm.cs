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
    public partial class RegisterForm : Form
    {
        private GraphClient client;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Worker worker = new Worker
                {
                    UserName = tbUserName.Text,
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    Password = tbPassword.Text
                };

                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("UserName", worker.UserName);
                queryDict.Add("FirstName", worker.FirstName);
                queryDict.Add("LastName", worker.LastName);
                queryDict.Add("Password", worker.Password);

                var query = new Neo4jClient.Cypher.CypherQuery("Create (n:Worker {UserName: '"
                    + worker.UserName + "', FirstName: '" + worker.FirstName + "', LastName: '"
                    + worker.LastName + "', Password: '" + worker.Password + "'})", queryDict, CypherResultMode.Set);

                ((IRawGraphClient)client).ExecuteCypher(query);

                lbStatus.Text = "Successfully registered";
                lbStatus.Visible = true;
            }
            catch(Exception ex)
            {
                lbStatus.Text = ex.Message;
                lbStatus.Visible = true;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';

            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "graph");
            try
            {
                client.Connect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
