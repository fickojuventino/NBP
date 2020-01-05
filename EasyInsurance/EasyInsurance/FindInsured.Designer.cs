namespace EasyInsurance
{
    partial class FindInsured
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
            this.btnFindInsured = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbMailAddress = new System.Windows.Forms.TextBox();
            this.rbIdentifier = new System.Windows.Forms.RadioButton();
            this.rbMail = new System.Windows.Forms.RadioButton();
            this.rbRest = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.tbCreditCard = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbIdentifier = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbCreditCard = new System.Windows.Forms.Label();
            this.lbBrojTelefona = new System.Windows.Forms.Label();
            this.lbMailAddress = new System.Windows.Forms.Label();
            this.gbSearch.SuspendLayout();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbIdentifier
            // 
            this.tbIdentifier.Location = new System.Drawing.Point(127, 0);
            this.tbIdentifier.Name = "tbIdentifier";
            this.tbIdentifier.Size = new System.Drawing.Size(278, 22);
            this.tbIdentifier.TabIndex = 0;
            // 
            // btnFindInsured
            // 
            this.btnFindInsured.Location = new System.Drawing.Point(330, 157);
            this.btnFindInsured.Name = "btnFindInsured";
            this.btnFindInsured.Size = new System.Drawing.Size(75, 118);
            this.btnFindInsured.TabIndex = 1;
            this.btnFindInsured.Text = "Pretraga";
            this.btnFindInsured.UseVisualStyleBackColor = true;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.tbPhoneNumber);
            this.gbSearch.Controls.Add(this.tbAddress);
            this.gbSearch.Controls.Add(this.tbLastName);
            this.gbSearch.Controls.Add(this.tbFirstName);
            this.gbSearch.Location = new System.Drawing.Point(13, 139);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(291, 136);
            this.gbSearch.TabIndex = 3;
            this.gbSearch.TabStop = false;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(7, 22);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(278, 22);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.Text = "Ime";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(7, 50);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(278, 22);
            this.tbLastName.TabIndex = 0;
            this.tbLastName.Text = "Prezime";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(6, 78);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(278, 22);
            this.tbAddress.TabIndex = 0;
            this.tbAddress.Text = "Adresa";
            // 
            // tbMailAddress
            // 
            this.tbMailAddress.Location = new System.Drawing.Point(127, 36);
            this.tbMailAddress.Name = "tbMailAddress";
            this.tbMailAddress.Size = new System.Drawing.Size(278, 22);
            this.tbMailAddress.TabIndex = 0;
            // 
            // rbIdentifier
            // 
            this.rbIdentifier.AutoSize = true;
            this.rbIdentifier.Location = new System.Drawing.Point(12, 0);
            this.rbIdentifier.Name = "rbIdentifier";
            this.rbIdentifier.Size = new System.Drawing.Size(67, 21);
            this.rbIdentifier.TabIndex = 4;
            this.rbIdentifier.TabStop = true;
            this.rbIdentifier.Text = "JMBG";
            this.rbIdentifier.UseVisualStyleBackColor = true;
            // 
            // rbMail
            // 
            this.rbMail.AutoSize = true;
            this.rbMail.Location = new System.Drawing.Point(12, 37);
            this.rbMail.Name = "rbMail";
            this.rbMail.Size = new System.Drawing.Size(102, 21);
            this.rbMail.TabIndex = 4;
            this.rbMail.TabStop = true;
            this.rbMail.Text = "Mejl adresa";
            this.rbMail.UseVisualStyleBackColor = true;
            // 
            // rbRest
            // 
            this.rbRest.AutoSize = true;
            this.rbRest.Location = new System.Drawing.Point(13, 112);
            this.rbRest.Name = "rbRest";
            this.rbRest.Size = new System.Drawing.Size(70, 21);
            this.rbRest.TabIndex = 4;
            this.rbRest.TabStop = true;
            this.rbRest.Text = "Ostalo";
            this.rbRest.UseVisualStyleBackColor = true;
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(12, 75);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(102, 21);
            this.rbCreditCard.TabIndex = 4;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Broj racuna";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            // 
            // tbCreditCard
            // 
            this.tbCreditCard.Location = new System.Drawing.Point(127, 75);
            this.tbCreditCard.Name = "tbCreditCard";
            this.tbCreditCard.Size = new System.Drawing.Size(278, 22);
            this.tbCreditCard.TabIndex = 0;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(6, 106);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(278, 22);
            this.tbPhoneNumber.TabIndex = 0;
            this.tbPhoneNumber.Text = "Broj Telefona";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(18, 27);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(30, 17);
            this.lbFirstName.TabIndex = 5;
            this.lbFirstName.Text = "Ime";
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.lbMailAddress);
            this.gbData.Controls.Add(this.lbBrojTelefona);
            this.gbData.Controls.Add(this.lbCreditCard);
            this.gbData.Controls.Add(this.lbBirthDate);
            this.gbData.Controls.Add(this.lbGender);
            this.gbData.Controls.Add(this.lbAddress);
            this.gbData.Controls.Add(this.lbIdentifier);
            this.gbData.Controls.Add(this.lbLastName);
            this.gbData.Controls.Add(this.lbFirstName);
            this.gbData.Location = new System.Drawing.Point(424, 9);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(547, 266);
            this.gbData.TabIndex = 6;
            this.gbData.TabStop = false;
            this.gbData.Text = "Informacije o osiguraniku";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(18, 54);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(59, 17);
            this.lbLastName.TabIndex = 5;
            this.lbLastName.Text = "Prezime";
            // 
            // lbIdentifier
            // 
            this.lbIdentifier.AutoSize = true;
            this.lbIdentifier.Location = new System.Drawing.Point(18, 81);
            this.lbIdentifier.Name = "lbIdentifier";
            this.lbIdentifier.Size = new System.Drawing.Size(46, 17);
            this.lbIdentifier.TabIndex = 5;
            this.lbIdentifier.Text = "JMBG";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(18, 108);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(53, 17);
            this.lbAddress.TabIndex = 5;
            this.lbAddress.Text = "Adresa";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(18, 130);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(28, 17);
            this.lbGender.TabIndex = 5;
            this.lbGender.Text = "Pol";
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Location = new System.Drawing.Point(18, 158);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(109, 17);
            this.lbBirthDate.TabIndex = 5;
            this.lbBirthDate.Text = "Datum Rodjenja";
            // 
            // lbCreditCard
            // 
            this.lbCreditCard.AutoSize = true;
            this.lbCreditCard.Location = new System.Drawing.Point(18, 185);
            this.lbCreditCard.Name = "lbCreditCard";
            this.lbCreditCard.Size = new System.Drawing.Size(81, 17);
            this.lbCreditCard.TabIndex = 5;
            this.lbCreditCard.Text = "Broj racuna";
            // 
            // lbBrojTelefona
            // 
            this.lbBrojTelefona.AutoSize = true;
            this.lbBrojTelefona.Location = new System.Drawing.Point(18, 214);
            this.lbBrojTelefona.Name = "lbBrojTelefona";
            this.lbBrojTelefona.Size = new System.Drawing.Size(88, 17);
            this.lbBrojTelefona.TabIndex = 5;
            this.lbBrojTelefona.Text = "Broj telefona";
            // 
            // lbMailAddress
            // 
            this.lbMailAddress.AutoSize = true;
            this.lbMailAddress.Location = new System.Drawing.Point(18, 246);
            this.lbMailAddress.Name = "lbMailAddress";
            this.lbMailAddress.Size = new System.Drawing.Size(81, 17);
            this.lbMailAddress.TabIndex = 5;
            this.lbMailAddress.Text = "Mejl adresa";
            // 
            // FindInsured
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 287);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.tbCreditCard);
            this.Controls.Add(this.tbMailAddress);
            this.Controls.Add(this.rbCreditCard);
            this.Controls.Add(this.rbRest);
            this.Controls.Add(this.rbMail);
            this.Controls.Add(this.rbIdentifier);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.btnFindInsured);
            this.Controls.Add(this.tbIdentifier);
            this.Name = "FindInsured";
            this.Text = "FindInsured";
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdentifier;
        private System.Windows.Forms.Button btnFindInsured;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbMailAddress;
        private System.Windows.Forms.RadioButton rbIdentifier;
        private System.Windows.Forms.RadioButton rbMail;
        private System.Windows.Forms.RadioButton rbRest;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.TextBox tbCreditCard;
        private System.Windows.Forms.TextBox tbPhoneNumber;
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
    }
}