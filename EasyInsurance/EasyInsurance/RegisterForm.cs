using EasyInsurance.Models;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
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
                var query = new CypherQuery($"MATCH (w:Worker) WHERE w.UserName = '{tbUserName.Text}'" +
                    $" RETURN w", new Dictionary<string, object>(), CypherResultMode.Set);

                var user = ((IRawGraphClient)client).ExecuteGetCypherResults<Worker>(query).SingleOrDefault();

                if (user == null && checkRequirements())
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
                else if(user != null)
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

        private bool checkRequirements()
        {
            var response = "";
            if(tbUserName.Text.Length < 5)
            {
                response += "Korisnicko ime mora biti duze od 5 karaktera.";
            }
            if(tbFirstName.Text.Length < 3)
            {
                response += "Ime mora biti duze od 3 karaktera.";
            }
            if(tbLastName.Text.Length < 3)
            {
                response += "Prezime mora biti duze od 3 karaktera.";
            }
            if(tbPassword.Text.Length < 6 && tbPassword.Text.Length > 25)
            {
                response += "Lozinka mora biti duzine izmedju 6-25 karaktera.";
            }
            if(tbPassword.Text != tbPasswordRepeat.Text)
            {
                response += "Sifre se ne podudaraju.";
            }

            if(response.Length > 0)
            {
                MessageBox.Show(response);
                return false;
            }
            return true;
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Sifra" || tbPassword.TextLength == 0)
            {
                tbPassword.Text = "";
                tbPassword.PasswordChar = '*';
            }
        }

        private void tbPasswordRepeat_Enter(object sender, EventArgs e)
        {
            if (tbPasswordRepeat.Text == "Ponovi sifru" || tbPasswordRepeat.TextLength == 0)
            {
                tbPasswordRepeat.Text = "";
                tbPasswordRepeat.PasswordChar = '*';
            }
        }

        private void tbPasswordRepeat_Leave(object sender, EventArgs e)
        {
            if(tbPasswordRepeat.Text.Length == 0)
            {
                tbPasswordRepeat.PasswordChar = '\0';
                tbPasswordRepeat.Text = "Ponovi sifru";
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length == 0)
            {
                tbPassword.PasswordChar = '\0';
                tbPassword.Text = "Sifra";
            }
        }

        private void cbReveal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReveal.Checked)
            {
                tbPassword.PasswordChar = '\0';
                tbPasswordRepeat.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
                tbPasswordRepeat.PasswordChar = '*';
            }
        }
    }
}
