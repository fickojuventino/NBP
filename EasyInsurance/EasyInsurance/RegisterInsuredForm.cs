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
    public partial class RegisterInsuredForm : Form
    {
        private GraphClient client;
        public RegisterInsuredForm()
        {
            InitializeComponent();
        }

        private void btnAddInsured_Click(object sender, EventArgs e)
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery($"MATCH (i:Insured) WHERE i.Identifier = '{long.Parse(tbIdentifier.Text)}'" +
                        $" or i.MailAddress = '" + tbMail.Text + "' or i.PhoneNumber = '" + tbPhoneNumber.Text + 
                        "' or i.CreditCard = '" + tbCreditCard.Text +  "' RETURN i", new Dictionary<string, object>(), CypherResultMode.Set);

                var user = ((IRawGraphClient)client).ExecuteGetCypherResults<Insured>(query).ToList().FirstOrDefault();

                if (user == null)
                {
                    Insured insured = new Insured
                    {
                        FirstName = tbFirstName.Text,
                        LastName = tbLastName.Text,
                        Identifier = long.Parse(tbIdentifier.Text),
                        Address = tbAddress.Text,
                        MailAddress = tbMail.Text,
                        BirthDate = dtpBirthdate.Value.Date,
                        CreditCard = tbCreditCard.Text,
                        Gender = cbGender.Text,
                        PhoneNumber = tbPhoneNumber.Text
                    };

                    Dictionary<string, object> queryDict = new Dictionary<string, object>
                    {
                        { "FirstName", insured.FirstName },
                        { "LastName", insured.LastName },
                        { "Identifier", insured.Identifier },
                        { "Address", insured.Address },
                        { "MailAddress", insured.MailAddress },
                        { "BirthDate", insured.BirthDate },
                        { "CreditCard", insured.CreditCard },
                        { "Gender", insured.Gender },
                        { "PhoneNumber", insured.PhoneNumber }
                    };

                    query = new Neo4jClient.Cypher.CypherQuery("Create (i:Insured {FirstName: '"
                        + insured.FirstName + "', LastName: '" + insured.LastName + "', Identifier: '"
                        + insured.Identifier + "', Address: '" + insured.Address + "', MailAddress: '" + insured.MailAddress
                        + "', BirthDate: '" + insured.BirthDate + "', CreditCard: '" + insured.CreditCard 
                        + "', Gender: '" + insured.Gender + "', PhoneNumber: '" + insured.PhoneNumber + "'})",
                        queryDict, CypherResultMode.Set);

                    ((IRawGraphClient)client).ExecuteCypher(query);

                    lbStatus.Text = "Registracija osiguranika uspesna uspesna.";
                    lbStatus.Visible = true;
                }
                else
                {
                    lbStatus.Text = "JMBG, broj telefona, mejl adresa i broj racuna moraju biti jedinstveni.";
                    lbStatus.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegisterInsuredForm_Load(object sender, EventArgs e)
        {
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
