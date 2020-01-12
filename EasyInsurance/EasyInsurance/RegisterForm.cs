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
        public RegisterForm(GraphClient client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery($"MATCH (w:Worker) WHERE w.UserName = '{tbUserName.Text}'" +
                    $" RETURN w", new Dictionary<string, object>(), CypherResultMode.Set);

                var user = ((IRawGraphClient)client).ExecuteGetCypherResults<Worker>(query).SingleOrDefault();

                if (user == null)
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

                    query = new Neo4jClient.Cypher.CypherQuery("Create (n:Worker {UserName: '"
                        + worker.UserName + "', FirstName: '" + worker.FirstName + "', LastName: '"
                        + worker.LastName + "', Password: '" + worker.Password + "'})", queryDict, CypherResultMode.Set);

                    ((IRawGraphClient)client).ExecuteCypher(query);

                    lbStatus.Text = "Registracija uspesna.";
                    lbStatus.Visible = true;
                }
                else
                {
                    lbStatus.Text = "Korisnicko ime je zauzeto.";
                    lbStatus.Visible = true;
                }
            }
            catch(Exception ex)
            {
                lbStatus.Text = ex.Message;
                lbStatus.Visible = true;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
        }
    }
}
