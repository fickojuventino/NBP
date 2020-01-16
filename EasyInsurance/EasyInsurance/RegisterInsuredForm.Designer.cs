namespace EasyInsurance
{
    partial class RegisterInsuredForm
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
            this.btnAddInsured = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbIdentifier = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.tbCreditCard = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddInsured
            // 
            this.btnAddInsured.Location = new System.Drawing.Point(115, 266);
            this.btnAddInsured.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddInsured.Name = "btnAddInsured";
            this.btnAddInsured.Size = new System.Drawing.Size(141, 23);
            this.btnAddInsured.TabIndex = 9;
            this.btnAddInsured.Text = "Kreiraj nalog";
            this.btnAddInsured.UseVisualStyleBackColor = true;
            this.btnAddInsured.Click += new System.EventHandler(this.btnAddInsured_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbFirstName.Location = new System.Drawing.Point(45, 12);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(293, 22);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.Text = "Ime";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(45, 39);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(293, 22);
            this.tbLastName.TabIndex = 1;
            this.tbLastName.Text = "Prezime";
            // 
            // tbIdentifier
            // 
            this.tbIdentifier.Location = new System.Drawing.Point(45, 68);
            this.tbIdentifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIdentifier.Name = "tbIdentifier";
            this.tbIdentifier.Size = new System.Drawing.Size(293, 22);
            this.tbIdentifier.TabIndex = 2;
            this.tbIdentifier.Text = "JMBG";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.cbGender.Location = new System.Drawing.Point(45, 124);
            this.cbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 24);
            this.cbGender.TabIndex = 4;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(45, 154);
            this.dtpBirthdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(247, 22);
            this.dtpBirthdate.TabIndex = 5;
            // 
            // tbCreditCard
            // 
            this.tbCreditCard.Location = new System.Drawing.Point(45, 182);
            this.tbCreditCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCreditCard.Name = "tbCreditCard";
            this.tbCreditCard.Size = new System.Drawing.Size(293, 22);
            this.tbCreditCard.TabIndex = 6;
            this.tbCreditCard.Text = "Broj racuna";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(45, 210);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(293, 22);
            this.tbPhoneNumber.TabIndex = 7;
            this.tbPhoneNumber.Text = "Broj telefona";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(45, 238);
            this.tbMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(293, 22);
            this.tbMail.TabIndex = 8;
            this.tbMail.Text = "Mejl adresa";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(45, 96);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(293, 22);
            this.tbAddress.TabIndex = 3;
            this.tbAddress.Text = "Adresa stanovanja";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(142, 295);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(48, 17);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "Status";
            this.lbStatus.Visible = false;
            // 
            // RegisterInsuredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbCreditCard);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.tbIdentifier);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.btnAddInsured);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterInsuredForm";
            this.Text = "RegisterInsuredForm";
            this.Load += new System.EventHandler(this.RegisterInsuredForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddInsured;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbIdentifier;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.TextBox tbCreditCard;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbStatus;
    }
}