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
        private Insured user = null;

        public FindInsuredForm(GraphClient client)
        {
            this.client = client;
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
                    user = ((IRawGraphClient)client).ExecuteGetCypherResults<Insured>(query).SingleOrDefault();

                    showUserData();
                    allowActions();
                }
                else if (rbMail.Checked)
                {
                    var query = new CypherQuery("MATCH (i:Insured) WHERE i.MailAddress = '" + tbMailAddress.Text 
                        + "' RETURN i", new Dictionary<string, object>(), CypherResultMode.Set);
                    user = ((IRawGraphClient)client).ExecuteGetCypherResults<Insured>(query).SingleOrDefault();

                    showUserData();
                    allowActions();
                }
                else if (rbCreditCard.Checked)
                {
                    var query = new CypherQuery("MATCH (i:Insured) WHERE i.CreditCard = '" + tbCreditCard.Text
                        + "' RETURN i", new Dictionary<string, object>(), CypherResultMode.Set);
                    user = ((IRawGraphClient)client).ExecuteGetCypherResults<Insured>(query).SingleOrDefault();

                    showUserData();
                    allowActions();
                }
                else
                {
                    var query = new CypherQuery("MATCH (i:Insured) WHERE i.PhoneNumber = '" + tbPhoneNumber.Text
                        + "' RETURN i", new Dictionary<string, object>(), CypherResultMode.Set);
                    user = ((IRawGraphClient)client).ExecuteGetCypherResults<Insured>(query).SingleOrDefault();

                    showUserData();
                    allowActions();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FindInsured_Load(object sender, EventArgs e)
        {
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
                    tbPhoneNumber.Enabled = false;
                    break;
                case "CreditCard":
                    tbCreditCard.Enabled = true;
                    tbIdentifier.Enabled = false;
                    tbMailAddress.Enabled = false;
                    tbPhoneNumber.Enabled = false;
                    break;
                case "MailAddress":
                    tbMailAddress.Enabled = true;
                    tbIdentifier.Enabled = false;
                    tbCreditCard.Enabled = false;
                    tbPhoneNumber.Enabled = false;
                    break;
                case "Rest":
                    tbPhoneNumber.Enabled = true;
                    tbIdentifier.Enabled = false;
                    tbCreditCard.Enabled = false;
                    tbMailAddress.Enabled = false;
                    break;
            }
        }

        private void showUserData()
        {
            if (user == null)
            {
                MessageBox.Show("Nije pronadjen korisnik.");
            }
            else
            {
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

        private void allowActions()
        {
            if (user != null)
            {
                btnUpdateInsured.Enabled = true;
                btnRemoveInsured.Enabled = true;
            }
            else
            {
                btnUpdateInsured.Enabled = false;
                btnRemoveInsured.Enabled = false;
            }
        }

        private void btnAddPolicy_Click(object sender, EventArgs e)
        {
            if(cbInsuranceType.Text == "Putno osiguranje")
            {
                TravelInsuranceForm travelForm = new TravelInsuranceForm(long.Parse(tbIdentifier.Text), client);
                travelForm.Show();
            }
            else if(cbInsuranceType.Text == "Zivotno osiguranje")
            {
                LifeInsuranceForm lifeInsuranceForm = new LifeInsuranceForm(client, long.Parse(tbIdentifier.Text), tbGenderInfo.Text, DateTime.Parse(tbBirthDateInfo.Text));
                lifeInsuranceForm.Show();
            }
            else if(cbInsuranceType.Text == "Zdravstveno osiguranje")
            {
                HealthInsuranceForm healthInsuranceForm = new HealthInsuranceForm(client, long.Parse(tbIdentifier.Text));
                healthInsuranceForm.Show();
            }
        }

        private void btnUpdateInsured_Click(object sender, EventArgs e)
        {
            try
            {
                var query = new CypherQuery("MATCH (i { Identifier: '" + long.Parse(tbIdentifierInfo.Text)
                    + "' }) SET i.FirstName = '" + tbFirstNameInfo.Text + "', i.LastName = '" + tbLastNameInfo.Text
                    + "', i.Address = '" + tbAddressInfo.Text + "', i.CreditCard = '" + tbCreditCardInfo.Text +
                    "', i.PhoneNumber = '" + tbPhoneNumberInfo.Text + "', i.MailAddress = '" + tbMailAddressInfo.Text + "'",
                    new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(query);

                lbStatus.Text = "Uspesno azuriran korisnik.";
                lbStatus.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnShowPolicies_Click(object sender, EventArgs e)
        {
            PoliciesForm policiesForm = new PoliciesForm(long.Parse(tbIdentifierInfo.Text), client);
            policiesForm.Show();
        }

        private void btnRemoveInsured_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni?", "Ukloni korisnika", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var query = new CypherQuery("MATCH (i:Insured { Identifier: '" + long.Parse(tbIdentifier.Text) + "' }) DETACH DELETE i",
                        new Dictionary<string, object>(), CypherResultMode.Set);
                    ((IRawGraphClient)client).ExecuteCypher(query);

                    gbData.Visible = false;
                    lbStatus.Text = "Korisnik uspesno obrisan";
                    lbStatus.Visible = true;

                    user = null;
                    allowActions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
                CreateEventForm createEventForm = new CreateEventForm(client, user);
                createEventForm.Show();
        }

        private void btnFindEvents_Click(object sender, EventArgs e)
        {
            ShowEventsForm showEventsForm = new ShowEventsForm(client, long.Parse(tbIdentifierInfo.Text));
            showEventsForm.Show();
        }
    }
}
