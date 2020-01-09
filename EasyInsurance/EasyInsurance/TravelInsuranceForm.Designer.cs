namespace EasyInsurance
{
    partial class TravelInsuranceForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbInsuranceKind = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSecondIdentifier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbThirdIdentifier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFourthIdentifier = new System.Windows.Forms.TextBox();
            this.gbFamily = new System.Windows.Forms.GroupBox();
            this.tbPurpose = new System.Windows.Forms.TextBox();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.dtpDateSince = new System.Windows.Forms.DateTimePicker();
            this.labela = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.tbInsuranceStake = new System.Windows.Forms.TextBox();
            this.tbInsurancePayout = new System.Windows.Forms.TextBox();
            this.btnInsure = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.gbFamily.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vrsta osiguranja";
            // 
            // cbInsuranceKind
            // 
            this.cbInsuranceKind.FormattingEnabled = true;
            this.cbInsuranceKind.Items.AddRange(new object[] {
            "Individualno",
            "Porodicno"});
            this.cbInsuranceKind.Location = new System.Drawing.Point(12, 29);
            this.cbInsuranceKind.Name = "cbInsuranceKind";
            this.cbInsuranceKind.Size = new System.Drawing.Size(152, 24);
            this.cbInsuranceKind.TabIndex = 0;
            this.cbInsuranceKind.SelectedIndexChanged += new System.EventHandler(this.cbInsuranceKind_SelectedIndexChanged);
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
            // tbSecondIdentifier
            // 
            this.tbSecondIdentifier.Enabled = false;
            this.tbSecondIdentifier.Location = new System.Drawing.Point(6, 48);
            this.tbSecondIdentifier.Name = "tbSecondIdentifier";
            this.tbSecondIdentifier.Size = new System.Drawing.Size(247, 22);
            this.tbSecondIdentifier.TabIndex = 1;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "JMBG 4. clana porodice";
            // 
            // tbFourthIdentifier
            // 
            this.tbFourthIdentifier.Enabled = false;
            this.tbFourthIdentifier.Location = new System.Drawing.Point(6, 154);
            this.tbFourthIdentifier.Name = "tbFourthIdentifier";
            this.tbFourthIdentifier.Size = new System.Drawing.Size(247, 22);
            this.tbFourthIdentifier.TabIndex = 3;
            // 
            // gbFamily
            // 
            this.gbFamily.Controls.Add(this.label4);
            this.gbFamily.Controls.Add(this.tbFourthIdentifier);
            this.gbFamily.Controls.Add(this.tbSecondIdentifier);
            this.gbFamily.Controls.Add(this.label6);
            this.gbFamily.Controls.Add(this.label5);
            this.gbFamily.Controls.Add(this.tbThirdIdentifier);
            this.gbFamily.Location = new System.Drawing.Point(12, 59);
            this.gbFamily.Name = "gbFamily";
            this.gbFamily.Size = new System.Drawing.Size(266, 190);
            this.gbFamily.TabIndex = 3;
            this.gbFamily.TabStop = false;
            this.gbFamily.Text = "Clanovi Porodice";
            // 
            // tbPurpose
            // 
            this.tbPurpose.Location = new System.Drawing.Point(18, 268);
            this.tbPurpose.Name = "tbPurpose";
            this.tbPurpose.Size = new System.Drawing.Size(247, 22);
            this.tbPurpose.TabIndex = 4;
            this.tbPurpose.Text = "Svrha putovanja";
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(18, 296);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(247, 22);
            this.tbDestination.TabIndex = 5;
            this.tbDestination.Text = "Destinacija";
            // 
            // dtpDateSince
            // 
            this.dtpDateSince.Location = new System.Drawing.Point(15, 355);
            this.dtpDateSince.Name = "dtpDateSince";
            this.dtpDateSince.Size = new System.Drawing.Size(247, 22);
            this.dtpDateSince.TabIndex = 6;
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(15, 335);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(68, 17);
            this.labela.TabIndex = 1;
            this.labela.Text = "DatumOd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DatumDo";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(15, 400);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(247, 22);
            this.dtpDateTo.TabIndex = 7;
            // 
            // tbInsuranceStake
            // 
            this.tbInsuranceStake.Location = new System.Drawing.Point(15, 437);
            this.tbInsuranceStake.Name = "tbInsuranceStake";
            this.tbInsuranceStake.Size = new System.Drawing.Size(247, 22);
            this.tbInsuranceStake.TabIndex = 8;
            this.tbInsuranceStake.Text = "Uplata";
            // 
            // tbInsurancePayout
            // 
            this.tbInsurancePayout.Location = new System.Drawing.Point(15, 465);
            this.tbInsurancePayout.Name = "tbInsurancePayout";
            this.tbInsurancePayout.Size = new System.Drawing.Size(247, 22);
            this.tbInsurancePayout.TabIndex = 9;
            this.tbInsurancePayout.Text = "Osiguravajuca suma";
            // 
            // btnInsure
            // 
            this.btnInsure.Location = new System.Drawing.Point(102, 499);
            this.btnInsure.Name = "btnInsure";
            this.btnInsure.Size = new System.Drawing.Size(75, 23);
            this.btnInsure.TabIndex = 10;
            this.btnInsure.Text = "Osiguraj";
            this.btnInsure.UseVisualStyleBackColor = true;
            this.btnInsure.Click += new System.EventHandler(this.btnInsure_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(12, 524);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(46, 17);
            this.lbStatus.TabIndex = 11;
            this.lbStatus.Text = "label3";
            this.lbStatus.Visible = false;
            // 
            // TravelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 550);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnInsure);
            this.Controls.Add(this.tbInsurancePayout);
            this.Controls.Add(this.tbInsuranceStake);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dtpDateSince);
            this.Controls.Add(this.gbFamily);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.tbPurpose);
            this.Controls.Add(this.cbInsuranceKind);
            this.Name = "TravelForm";
            this.Text = "Putno Osiguranje";
            this.gbFamily.ResumeLayout(false);
            this.gbFamily.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbInsuranceKind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSecondIdentifier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbThirdIdentifier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFourthIdentifier;
        private System.Windows.Forms.GroupBox gbFamily;
        private System.Windows.Forms.TextBox tbPurpose;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.DateTimePicker dtpDateSince;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.TextBox tbInsuranceStake;
        private System.Windows.Forms.TextBox tbInsurancePayout;
        private System.Windows.Forms.Button btnInsure;
        private System.Windows.Forms.Label lbStatus;
    }
}