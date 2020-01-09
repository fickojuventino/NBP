namespace EasyInsurance
{
    partial class LifeInsuranceForm
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
            this.cbInsuranceKind = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFamily = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFourthIdentifier = new System.Windows.Forms.TextBox();
            this.tbSecondIdentifier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbThirdIdentifier = new System.Windows.Forms.TextBox();
            this.cbReason = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.tbInsurancePayout = new System.Windows.Forms.TextBox();
            this.tbInsuranceStake = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnInsure = new System.Windows.Forms.Button();
            this.gbFamily.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbInsuranceKind
            // 
            this.cbInsuranceKind.FormattingEnabled = true;
            this.cbInsuranceKind.Items.AddRange(new object[] {
            "Individualno",
            "Porodicno"});
            this.cbInsuranceKind.Location = new System.Drawing.Point(12, 34);
            this.cbInsuranceKind.Name = "cbInsuranceKind";
            this.cbInsuranceKind.Size = new System.Drawing.Size(167, 24);
            this.cbInsuranceKind.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vrsta osiguranja";
            // 
            // gbFamily
            // 
            this.gbFamily.Controls.Add(this.label4);
            this.gbFamily.Controls.Add(this.tbFourthIdentifier);
            this.gbFamily.Controls.Add(this.tbSecondIdentifier);
            this.gbFamily.Controls.Add(this.label6);
            this.gbFamily.Controls.Add(this.label5);
            this.gbFamily.Controls.Add(this.tbThirdIdentifier);
            this.gbFamily.Location = new System.Drawing.Point(12, 74);
            this.gbFamily.Name = "gbFamily";
            this.gbFamily.Size = new System.Drawing.Size(266, 190);
            this.gbFamily.TabIndex = 4;
            this.gbFamily.TabStop = false;
            this.gbFamily.Text = "Clanovi Porodice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "JMBG 2. clana porodice";
            // 
            // tbFourthIdentifier
            // 
            this.tbFourthIdentifier.Enabled = false;
            this.tbFourthIdentifier.Location = new System.Drawing.Point(6, 154);
            this.tbFourthIdentifier.Name = "tbFourthIdentifier";
            this.tbFourthIdentifier.Size = new System.Drawing.Size(247, 22);
            this.tbFourthIdentifier.TabIndex = 3;
            // 
            // tbSecondIdentifier
            // 
            this.tbSecondIdentifier.Enabled = false;
            this.tbSecondIdentifier.Location = new System.Drawing.Point(6, 48);
            this.tbSecondIdentifier.Name = "tbSecondIdentifier";
            this.tbSecondIdentifier.Size = new System.Drawing.Size(247, 22);
            this.tbSecondIdentifier.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "JMBG 4. clana porodice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "JMBG 3. clana porodice";
            // 
            // tbThirdIdentifier
            // 
            this.tbThirdIdentifier.Enabled = false;
            this.tbThirdIdentifier.Location = new System.Drawing.Point(6, 102);
            this.tbThirdIdentifier.Name = "tbThirdIdentifier";
            this.tbThirdIdentifier.Size = new System.Drawing.Size(247, 22);
            this.tbThirdIdentifier.TabIndex = 2;
            // 
            // cbReason
            // 
            this.cbReason.FormattingEnabled = true;
            this.cbReason.Items.AddRange(new object[] {
            "Zbog podizanja kredita kod banke (Riziko)",
            "Zelim da osiguram zivot i steknem ustedjevinu",
            "Zelim da obezbedim ustedjevinu za dete (studiranje, osamostaljenje)",
            "Zelim da \"orocim\" steceni novac uz dobru kamatnu stopu"});
            this.cbReason.Location = new System.Drawing.Point(12, 293);
            this.cbReason.Name = "cbReason";
            this.cbReason.Size = new System.Drawing.Size(253, 24);
            this.cbReason.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Razlog";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pusac?";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(74, 324);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(47, 21);
            this.rbYes.TabIndex = 8;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Da";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Checked = true;
            this.rbNo.Location = new System.Drawing.Point(127, 324);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(47, 21);
            this.rbNo.TabIndex = 8;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "Ne";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // tbInsurancePayout
            // 
            this.tbInsurancePayout.Location = new System.Drawing.Point(12, 379);
            this.tbInsurancePayout.Name = "tbInsurancePayout";
            this.tbInsurancePayout.Size = new System.Drawing.Size(253, 22);
            this.tbInsurancePayout.TabIndex = 11;
            this.tbInsurancePayout.Text = "Osiguravajuca suma";
            // 
            // tbInsuranceStake
            // 
            this.tbInsuranceStake.Location = new System.Drawing.Point(12, 351);
            this.tbInsuranceStake.Name = "tbInsuranceStake";
            this.tbInsuranceStake.Size = new System.Drawing.Size(253, 22);
            this.tbInsuranceStake.TabIndex = 10;
            this.tbInsuranceStake.Text = "Uplata";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(14, 445);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(46, 17);
            this.lbStatus.TabIndex = 13;
            this.lbStatus.Text = "label3";
            this.lbStatus.Visible = false;
            // 
            // btnInsure
            // 
            this.btnInsure.Location = new System.Drawing.Point(104, 420);
            this.btnInsure.Name = "btnInsure";
            this.btnInsure.Size = new System.Drawing.Size(75, 23);
            this.btnInsure.TabIndex = 12;
            this.btnInsure.Text = "Osiguraj";
            this.btnInsure.UseVisualStyleBackColor = true;
            this.btnInsure.Click += new System.EventHandler(this.btnInsure_Click);
            // 
            // LifeInsuranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 468);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnInsure);
            this.Controls.Add(this.tbInsurancePayout);
            this.Controls.Add(this.tbInsuranceStake);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbReason);
            this.Controls.Add(this.gbFamily);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbInsuranceKind);
            this.Name = "LifeInsuranceForm";
            this.Text = "LifeInsuranceForm";
            this.gbFamily.ResumeLayout(false);
            this.gbFamily.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInsuranceKind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFamily;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFourthIdentifier;
        private System.Windows.Forms.TextBox tbSecondIdentifier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbThirdIdentifier;
        private System.Windows.Forms.ComboBox cbReason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.TextBox tbInsurancePayout;
        private System.Windows.Forms.TextBox tbInsuranceStake;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnInsure;
    }
}