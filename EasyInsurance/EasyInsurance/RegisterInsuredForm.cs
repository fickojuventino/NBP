using EasyInsurance.Models;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EasyInsurance
{
    public partial class RegisterInsuredForm : Form
    {
        private GraphClient client;
        public RegisterInsuredForm(GraphClient client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void btnAddInsured_Click(object sender, EventArgs e)
        {
            try
            {
                var query = new CypherQuery($"MATCH (i:Insured) WHERE i.Identifier = '{long.Parse(tbIdentifier.Text)}'" +
                        $" or i.MailAddress = '" + tbMail.Text + "' or i.PhoneNumber = '" + tbPhoneNumber.Text + 
                        "' or i.CreditCard = '" + tbCreditCard.Text +  "' RETURN i", new Dictionary<string, object>(), CypherResultMode.Set);

                var user = ((IRawGraphClient)client).ExecuteGetCypherResults<Insured>(query).ToList().FirstOrDefault();

                if (user == null && checkRequirements())
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

                    query = new CypherQuery("Create (i:Insured {FirstName: '"
                        + insured.FirstName + "', LastName: '" + insured.LastName + "', Identifier: '"
                        + insured.Identifier + "', Address: '" + insured.Address + "', MailAddress: '" + insured.MailAddress
                        + "', BirthDate: '" + insured.BirthDate + "', CreditCard: '" + insured.CreditCard 
                        + "', Gender: '" + insured.Gender + "', PhoneNumber: '" + insured.PhoneNumber + "'})",
                        queryDict, CypherResultMode.Set);

                    ((IRawGraphClient)client).ExecuteCypher(query);

                    lbStatus.Text = "Registracija osiguranika uspesna.";
                    lbStatus.Visible = true;
                }
                else if(user != null)
                {
                    MessageBox.Show("JMBG, broj telefona, mejl adresa i broj racuna moraju biti jedinstveni.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegisterInsuredForm_Load(object sender, EventArgs e)
        {
            
        }

        private bool checkRequirements()
        {
            var response = "";

            if(tbFirstName.Text.Length < 3) {
                response += "Ime mora imati minimum 3 karaktera.\n";
            }
            if(tbLastName.Text.Length < 3)
            {
                response += "Prezime mora imati minimum 3 karaktera.\n";
            }
            if(tbIdentifier.Text.Length < 13)
            {
                response += "JMBG mora sadrzati 13 cifara.\n";
            }
            if(tbAddress.Text.Length < 10)
            {
                response += "Adresa mora biti minimalne duzine od 10 karaktera. Uneti i broj ulice i stana.\n";
            }
            if(cbGender.Text != "M" && cbGender.Text != "Z")
            {
                response += "Morate izabrati pol.\n";
            }
            if(tbCreditCard.Text.Split('-').Length < 3)
            {
                response += "Broj racuna mora biti u formatu XXX-XXXXX-XXX\n";
            }
            if(tbPhoneNumber.Text.Length < 9)
            {
                response += "Broj telefona mora imati najmanje 9 karaktera.\n";
            }
            if(tbMail.Text.Split('@').Length < 2)
            {
                response += "Format mejl adrese text@text.text.\n";
            }
            if(response.Length > 0)
            {
                MessageBox.Show(response);
                return false;
            }

            return true;
        }
    }
}
