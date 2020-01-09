namespace EasyInsurance
{
    partial class FindInsuredForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbIdentifier = new System.Windows.Forms.TextBox();
            this.tbMailAddress = new System.Windows.Forms.TextBox();
            this.rbIdentifier = new System.Windows.Forms.RadioButton();
            this.rbMail = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.tbCreditCard = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbInsuranceType = new System.Windows.Forms.ComboBox();
            this.btnAddPolicy = new System.Windows.Forms.Button();
            this.btnRemoveInsured = new System.Windows.Forms.Button();
            this.btnShowPolicies = new System.Windows.Forms.Button();
            this.btnUpdateInsured = new System.Windows.Forms.Button();
            this.tbMailAddressInfo = new System.Windows.Forms.TextBox();
            this.tbPhoneNumberInfo = new System.Windows.Forms.TextBox();
            this.tbCreditCardInfo = new System.Windows.Forms.TextBox();
            this.tbBirthDateInfo = new System.Windows.Forms.TextBox();
            this.tbGenderInfo = new System.Windows.Forms.TextBox();
            this.tbAddressInfo = new System.Windows.Forms.TextBox();
            this.tbIdentifierInfo = new System.Windows.Forms.TextBox();
            this.tbLastNameInfo = new System.Windows.Forms.TextBox();
            this.tbFirstNameInfo = new System.Windows.Forms.TextBox();
            this.lbMailAddress = new System.Windows.Forms.Label();
            this.lbBrojTelefona = new System.Windows.Forms.Label();
            this.lbCreditCard = new System.Windows.Forms.Label();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbIdentifier = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.rbPhoneNumber = new System.Windows.Forms.RadioButton();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnFindInsured = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.gbData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbIdentifier
            // 
            this.tbIdentifier.Location = new System.Drawing.Point(127, 16);
            this.tbIdentifier.Name = "tbIdentifier";
            this.tbIdentifier.Size = new System.Drawing.Size(278, 22);
            this.tbIdentifier.TabIndex = 0;
            // 
            // tbMailAddress
            // 
            this.tbMailAddress.Enabled = false;
            this.tbMailAddress.Location = new System.Drawing.Point(127, 52);
            this.tbMailAddress.Name = "tbMailAddress";
            this.tbMailAddress.Size = new System.Drawing.Size(278, 22);
            this.tbMailAddress.TabIndex = 0;
            // 
            // rbIdentifier
            // 
            this.rbIdentifier.AutoSize = true;
            this.rbIdentifier.Checked = true;
            this.rbIdentifier.Location = new System.Drawing.Point(16, 17);
            this.rbIdentifier.Name = "rbIdentifier";
            this.rbIdentifier.Size = new System.Drawing.Size(67, 21);
            this.rbIdentifier.TabIndex = 4;
            this.rbIdentifier.TabStop = true;
            this.rbIdentifier.Text = "JMBG";
            this.rbIdentifier.UseVisualStyleBackColor = true;
            this.rbIdentifier.CheckedChanged += new System.EventHandler(this.rbIdentifier_CheckedChanged);
            // 
            // rbMail
            // 
            this.rbMail.AutoSize = true;
            this.rbMail.Location = new System.Drawing.Point(16, 55);
            this.rbMail.Name = "rbMail";
            this.rbMail.Size = new System.Drawing.Size(102, 21);
            this.rbMail.TabIndex = 4;
            this.rbMail.Text = "Mejl adresa";
            this.rbMail.UseVisualStyleBackColor = true;
            this.rbMail.CheckedChanged += new System.EventHandler(this.rbMail_CheckedChanged);
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(16, 87);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(102, 21);
            this.rbCreditCard.TabIndex = 4;
            this.rbCreditCard.Text = "Broj racuna";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            this.rbCreditCard.CheckedChanged += new System.EventHandler(this.rbCreditCard_CheckedChanged);
            // 
            // tbCreditCard
            // 
            this.tbCreditCard.Enabled = false;
            this.tbCreditCard.Location = new System.Drawing.Point(127, 86);
            this.tbCreditCard.Name = "tbCreditCard";
            this.tbCreditCard.Size = new System.Drawing.Size(278, 22);
            this.tbCreditCard.TabIndex = 0;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(20, 30);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(30, 17);
            this.lbFirstName.TabIndex = 5;
            this.lbFirstName.Text = "Ime";
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.btnCreateEvent);
            this.gbData.Controls.Add(this.groupBox1);
            this.gbData.Controls.Add(this.btnShowPolicies);
            this.gbData.Controls.Add(this.tbMailAddressInfo);
            this.gbData.Controls.Add(this.tbPhoneNumberInfo);
            this.gbData.Controls.Add(this.tbCreditCardInfo);
            this.gbData.Controls.Add(this.tbBirthDateInfo);
            this.gbData.Controls.Add(this.tbGenderInfo);
            this.gbData.Controls.Add(this.tbAddressInfo);
            this.gbData.Controls.Add(this.tbIdentifierInfo);
            this.gbData.Controls.Add(this.tbLastNameInfo);
            this.gbData.Controls.Add(this.tbFirstNameInfo);
            this.gbData.Controls.Add(this.lbMailAddress);
            this.gbData.Controls.Add(this.lbBrojTelefona);
            this.gbData.Controls.Add(this.lbCreditCard);
            this.gbData.Controls.Add(this.lbBirthDate);
            this.gbData.Controls.Add(this.lbGender);
            this.gbData.Controls.Add(this.lbAddress);
            this.gbData.Controls.Add(this.lbIdentifier);
            this.gbData.Controls.Add(this.lbLastName);
            this.gbData.Controls.Add(this.lbFirstName);
            this.gbData.Location = new System.Drawing.Point(426, 0);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(608, 277);
            this.gbData.TabIndex = 6;
            this.gbData.TabStop = false;
            this.gbData.Text = "Informacije o osiguraniku";
            this.gbData.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbInsuranceType);
            this.groupBox1.Controls.Add(this.btnAddPolicy);
            this.groupBox1.Location = new System.Drawing.Point(435, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 86);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // cbInsuranceType
            // 
            this.cbInsuranceType.FormattingEnabled = true;
            this.cbInsuranceType.Items.AddRange(new object[] {
            "Zdravstveno osiguranje",
            "Zivotno osiguranje",
            "Putno osiguranje"});
            this.cbInsuranceType.Location = new System.Drawing.Point(0, 21);
            this.cbInsuranceType.Name = "cbInsuranceType";
            this.cbInsuranceType.Size = new System.Drawing.Size(155, 24);
            this.cbInsuranceType.TabIndex = 8;
            // 
            // btnAddPolicy
            // 
            this.btnAddPolicy.Location = new System.Drawing.Point(0, 51);
            this.btnAddPolicy.Name = "btnAddPolicy";
            this.btnAddPolicy.Size = new System.Drawing.Size(155, 29);
            this.btnAddPolicy.TabIndex = 7;
            this.btnAddPolicy.Text = "Dodaj polisu";
            this.btnAddPolicy.UseVisualStyleBackColor = true;
            this.btnAddPolicy.Click += new System.EventHandler(this.btnAddPolicy_Click);
            // 
            // btnRemoveInsured
            // 
            this.btnRemoveInsured.Enabled = false;
            this.btnRemoveInsured.Location = new System.Drawing.Point(217, 203);
            this.btnRemoveInsured.Name = "btnRemoveInsured";
            this.btnRemoveInsured.Size = new System.Drawing.Size(188, 54);
            this.btnRemoveInsured.TabIndex = 7;
            this.btnRemoveInsured.Text = "Ukloni korisnika";
            this.btnRemoveInsured.UseVisualStyleBackColor = true;
            this.btnRemoveInsured.Click += new System.EventHandler(this.btnRemoveInsured_Click);
            // 
            // btnShowPolicies
            // 
            this.btnShowPolicies.Location = new System.Drawing.Point(435, 140);
            this.btnShowPolicies.Name = "btnShowPolicies";
            this.btnShowPolicies.Size = new System.Drawing.Size(155, 48);
            this.btnShowPolicies.TabIndex = 7;
            this.btnShowPolicies.Text = "Prikazi ugovore";
            this.btnShowPolicies.UseVisualStyleBackColor = true;
            this.btnShowPolicies.Click += new System.EventHandler(this.btnShowPolicies_Click);
            // 
            // btnUpdateInsured
            // 
            this.btnUpdateInsured.Enabled = false;
            this.btnUpdateInsured.Location = new System.Drawing.Point(16, 203);
            this.btnUpdateInsured.Name = "btnUpdateInsured";
            this.btnUpdateInsured.Size = new System.Drawing.Size(175, 54);
            this.btnUpdateInsured.TabIndex = 7;
            this.btnUpdateInsured.Text = "Azuriraj informacije";
            this.btnUpdateInsured.UseVisualStyleBackColor = true;
            this.btnUpdateInsured.Click += new System.EventHandler(this.btnUpdateInsured_Click);
            // 
            // tbMailAddressInfo
            // 
            this.tbMailAddressInfo.Location = new System.Drawing.Point(142, 249);
            this.tbMailAddressInfo.Name = "tbMailAddressInfo";
            this.tbMailAddressInfo.Size = new System.Drawing.Size(263, 22);
            this.tbMailAddressInfo.TabIndex = 6;
            // 
            // tbPhoneNumberInfo
            // 
            this.tbPhoneNumberInfo.Location = new System.Drawing.Point(142, 221);
            this.tbPhoneNumberInfo.Name = "tbPhoneNumberInfo";
            this.tbPhoneNumberInfo.Size = new System.Drawing.Size(263, 22);
            this.tbPhoneNumberInfo.TabIndex = 6;
            // 
            // tbCreditCardInfo
            // 
            this.tbCreditCardInfo.Location = new System.Drawing.Point(142, 193);
            this.tbCreditCardInfo.Name = "tbCreditCardInfo";
            this.tbCreditCardInfo.Size = new System.Drawing.Size(263, 22);
            this.tbCreditCardInfo.TabIndex = 6;
            // 
            // tbBirthDateInfo
            // 
            this.tbBirthDateInfo.Enabled = false;
            this.tbBirthDateInfo.Location = new System.Drawing.Point(142, 165);
            this.tbBirthDateInfo.Name = "tbBirthDateInfo";
            this.tbBirthDateInfo.Size = new System.Drawing.Size(263, 22);
            this.tbBirthDateInfo.TabIndex = 6;
            // 
            // tbGenderInfo
            // 
            this.tbGenderInfo.Enabled = false;
            this.tbGenderInfo.Location = new System.Drawing.Point(142, 137);
            this.tbGenderInfo.Name = "tbGenderInfo";
            this.tbGenderInfo.Size = new System.Drawing.Size(263, 22);
            this.tbGenderInfo.TabIndex = 6;
            // 
            // tbAddressInfo
            // 
            this.tbAddressInfo.Location = new System.Drawing.Point(142, 109);
            this.tbAddressInfo.Name = "tbAddressInfo";
            this.tbAddressInfo.Size = new System.Drawing.Size(263, 22);
            this.tbAddressInfo.TabIndex = 6;
            // 
            // tbIdentifierInfo
            // 
            this.tbIdentifierInfo.Enabled = false;
            this.tbIdentifierInfo.Location = new System.Drawing.Point(142, 81);
            this.tbIdentifierInfo.Name = "tbIdentifierInfo";
            this.tbIdentifierInfo.Size = new System.Drawing.Size(263, 22);
            this.tbIdentifierInfo.TabIndex = 6;
            // 
            // tbLastNameInfo
            // 
            this.tbLastNameInfo.Location = new System.Drawing.Point(142, 54);
            this.tbLastNameInfo.Name = "tbLastNameInfo";
            this.tbLastNameInfo.Size = new System.Drawing.Size(263, 22);
            this.tbLastNameInfo.TabIndex = 6;
            // 
            // tbFirstNameInfo
            // 
            this.tbFirstNameInfo.Location = new System.Drawing.Point(142, 24);
            this.tbFirstNameInfo.Name = "tbFirstNameInfo";
            this.tbFirstNameInfo.Size = new System.Drawing.Size(263, 22);
            this.tbFirstNameInfo.TabIndex = 6;
            // 
            // lbMailAddress
            // 
            this.lbMailAddress.AutoSize = true;
            this.lbMailAddress.Location = new System.Drawing.Point(18, 252);
            this.lbMailAddress.Name = "lbMailAddress";
            this.lbMailAddress.Size = new System.Drawing.Size(81, 17);
            this.lbMailAddress.TabIndex = 5;
            this.lbMailAddress.Text = "Mejl adresa";
            // 
            // lbBrojTelefona
            // 
            this.lbBrojTelefona.AutoSize = true;
            this.lbBrojTelefona.Location = new System.Drawing.Point(18, 224);
            this.lbBrojTelefona.Name = "lbBrojTelefona";
            this.lbBrojTelefona.Size = new System.Drawing.Size(88, 17);
            this.lbBrojTelefona.TabIndex = 5;
            this.lbBrojTelefona.Text = "Broj telefona";
            // 
            // lbCreditCard
            // 
            this.lbCreditCard.AutoSize = true;
            this.lbCreditCard.Location = new System.Drawing.Point(18, 196);
            this.lbCreditCard.Name = "lbCreditCard";
            this.lbCreditCard.Size = new System.Drawing.Size(81, 17);
            this.lbCreditCard.TabIndex = 5;
            this.lbCreditCard.Text = "Broj racuna";
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Location = new System.Drawing.Point(18, 168);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(109, 17);
            this.lbBirthDate.TabIndex = 5;
            this.lbBirthDate.Text = "Datum Rodjenja";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(18, 140);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(28, 17);
            this.lbGender.TabIndex = 5;
            this.lbGender.Text = "Pol";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(20, 112);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(53, 17);
            this.lbAddress.TabIndex = 5;
            this.lbAddress.Text = "Adresa";
            // 
            // lbIdentifier
            // 
            this.lbIdentifier.AutoSize = true;
            this.lbIdentifier.Location = new System.Drawing.Point(18, 86);
            this.lbIdentifier.Name = "lbIdentifier";
            this.lbIdentifier.Size = new System.Drawing.Size(46, 17);
            this.lbIdentifier.TabIndex = 5;
            this.lbIdentifier.Text = "JMBG";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(20, 57);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(59, 17);
            this.lbLastName.TabIndex = 5;
            this.lbLastName.Text = "Prezime";
            // 
            // rbPhoneNumber
            // 
            this.rbPhoneNumber.AutoSize = true;
            this.rbPhoneNumber.Location = new System.Drawing.Point(16, 126);
            this.rbPhoneNumber.Name = "rbPhoneNumber";
            this.rbPhoneNumber.Size = new System.Drawing.Size(109, 21);
            this.rbPhoneNumber.TabIndex = 4;
            this.rbPhoneNumber.Text = "Broj telefona";
            this.rbPhoneNumber.UseVisualStyleBackColor = true;
            this.rbPhoneNumber.CheckedChanged += new System.EventHandler(this.rbRest_CheckedChanged);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Enabled = false;
            this.tbPhoneNumber.Location = new System.Drawing.Point(127, 126);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(278, 22);
            this.tbPhoneNumber.TabIndex = 0;
            // 
            // btnFindInsured
            // 
            this.btnFindInsured.Location = new System.Drawing.Point(16, 155);
            this.btnFindInsured.Name = "btnFindInsured";
            this.btnFindInsured.Size = new System.Drawing.Size(389, 42);
            this.btnFindInsured.TabIndex = 1;
            this.btnFindInsured.Text = "Pretraga";
            this.btnFindInsured.UseVisualStyleBackColor = true;
            this.btnFindInsured.Click += new System.EventHandler(this.btnFindInsured_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(13, 284);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(46, 17);
            this.lbStatus.TabIndex = 7;
            this.lbStatus.Text = "label1";
            this.lbStatus.Visible = false;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(435, 221);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(155, 50);
            this.btnCreateEvent.TabIndex = 10;
            this.btnCreateEvent.Text = "Kreiraj dogadjaj";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // FindInsuredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 307);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnRemoveInsured);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.btnUpdateInsured);
            this.Controls.Add(this.tbCreditCard);
            this.Controls.Add(this.tbMailAddress);
            this.Controls.Add(this.rbCreditCard);
            this.Controls.Add(this.rbPhoneNumber);
            this.Controls.Add(this.rbMail);
            this.Controls.Add(this.rbIdentifier);
            this.Controls.Add(this.btnFindInsured);
            this.Controls.Add(this.tbIdentifier);
            this.Name = "FindInsuredForm";
            this.Text = "FindInsured";
            this.Load += new System.EventHandler(this.FindInsured_Load);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdentifier;
        private System.Windows.Forms.TextBox tbMailAddress;
        private System.Windows.Forms.RadioButton rbIdentifier;
        private System.Windows.Forms.RadioButton rbMail;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.TextBox tbCreditCard;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label lbMailAddress;
        private System.Windows.Forms.Label lbBrojTelefona;
        private System.Windows.Forms.Label lbCreditCard;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbIdentifier;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox tbMailAddressInfo;
        private System.Windows.Forms.TextBox tbPhoneNumberInfo;
        private System.Windows.Forms.TextBox tbCreditCardInfo;
        private System.Windows.Forms.TextBox tbBirthDateInfo;
        private System.Windows.Forms.TextBox tbGenderInfo;
        private System.Windows.Forms.TextBox tbAddressInfo;
        private System.Windows.Forms.TextBox tbIdentifierInfo;
        private System.Windows.Forms.TextBox tbLastNameInfo;
        private System.Windows.Forms.TextBox tbFirstNameInfo;
        private System.Windows.Forms.Button btnUpdateInsured;
        private System.Windows.Forms.Button btnRemoveInsured;
        private System.Windows.Forms.Button btnShowPolicies;
        private System.Windows.Forms.Button btnAddPolicy;
        private System.Windows.Forms.ComboBox cbInsuranceType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPhoneNumber;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Button btnFindInsured;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnCreateEvent;
    }
}