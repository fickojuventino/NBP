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
    public partial class FindInsuredForm : Form
    {
        GraphClient client;

        public FindInsuredForm()
        {
            InitializeComponent();
        }

        private void btnFindInsured_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbIdentifier.Checked)
                {
                    var query = new CypherQuery("MATCH (i:Insured) WHERE i.Identifier = '" + long.Parse(tbIdentifier.Text)
                        + "' RETURN i", new Dictionary<string, object>(), CypherResultMode.Set);
                    var user = ((IRawGraphClient)client).ExecuteGetCypherResults<Insured>(query).SingleOrDefault();

                    showUserData(user);
                }
                else if (rbMail.Checked)
                {
                    var query = new CypherQuery("MATCH (i:Insured) WHERE i.MailAddress = '" + tbMailAddress.Text 
                        + "' RETURN i", new Dictionary<string, object>(), CypherResultMode.Set);
                    var user = ((IRawGraphClient)client).ExecuteGetCypherResults<Insured>(query).ToList();

                    showUserData(user.FirstOrDefault());
                }
                else if (rbCreditCard.Checked)
                {
                    var query = new CypherQuery("MATCH (i:Insured) WHERE i.CreditCard = '" + tbCreditCard.Text
                        + "' RETURN i", new Dictionary<string, object>(), CypherResultMode.Set);
                    var user = ((IRawGraphClient)client).ExecuteGetCypherResults<Insured>(query).ToList();

                    showUserData(user.FirstOrDefault());
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FindInsured_Load(object sender, EventArgs e)
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "graph");
            try
            {
                client.Connect();
                //this.Size = new Size { Height = 250, Width = 350 };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbIdentifier_CheckedChanged(object sender, EventArgs e)
        {
            updateRadioButtons("Identifier");
        }

        private void rbMail_CheckedChanged(object sender, EventArgs e)
        {
            updateRadioButtons("MailAddress");
        }

        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            updateRadioButtons("CreditCard");
        }

        private void rbRest_CheckedChanged(object sender, EventArgs e)
        {
            updateRadioButtons("Rest");
        }

        private void updateRadioButtons(string field)
        {
            switch (field)
            {
                case "Identifier":
                    tbIdentifier.Enabled = true;
                    tbCreditCard.Enabled = false;
                    tbMailAddress.Enabled = false;
                    tbFirstName.Enabled = false;
                    tbLastName.Enabled = false;
                    tbAddress.Enabled = false;
                    tbPhoneNumber.Enabled = false;
                    break;
                case "CreditCard":
                    tbCreditCard.Enabled = true;
                    tbIdentifier.Enabled = false;
                    tbMailAddress.Enabled = false;
                    tbFirstName.Enabled = false;
                    tbLastName.Enabled = false;
                    tbAddress.Enabled = false;
                    tbPhoneNumber.Enabled = false;
                    break;
                case "MailAddress":
                    tbMailAddress.Enabled = true;
                    tbIdentifier.Enabled = false;
                    tbCreditCard.Enabled = false;
                    tbFirstName.Enabled = false;
                    tbLastName.Enabled = false;
                    tbAddress.Enabled = false;
                    tbPhoneNumber.Enabled = false;
                    break;
                case "Rest":
                    tbFirstName.Enabled = true;
                    tbLastName.Enabled = true;
                    tbAddress.Enabled = true;
                    tbPhoneNumber.Enabled = true;
                    tbIdentifier.Enabled = false;
                    tbCreditCard.Enabled = false;
                    tbMailAddress.Enabled = false;
                    break;
            }
        }

        private void showUserData(Insured user)
        {
            if (user == null)
            {
                MessageBox.Show("Nije pronadjen korisnik.");
            }
            else
            {
                //this.Size = new Size
                //{
                //    Height = 334,
                //    Width = 1448
                //};
                gbData.Visible = true;
                tbFirstNameInfo.Text = user.FirstName;
                tbLastNameInfo.Text = user.LastName;
                tbIdentifierInfo.Text = user.Identifier.ToString();
                tbAddressInfo.Text = user.Address;
                tbGenderInfo.Text = user.Gender;
                tbBirthDateInfo.Text = user.BirthDate.ToString();
                tbCreditCardInfo.Text = user.CreditCard;
                tbPhoneNumberInfo.Text = user.PhoneNumber;
                tbMailAddressInfo.Text = user.MailAddress;
            }
        }

        private void btnAddPolicy_Click(object sender, EventArgs e)
        {
            if(cbInsuranceType.Text == "Putno osiguranje")
            {
                TravelForm travelForm = new TravelForm(long.Parse(tbIdentifier.Text), client);
                travelForm.Show();
            }
        }
    }
}
