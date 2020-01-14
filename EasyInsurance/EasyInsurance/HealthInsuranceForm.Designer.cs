namespace EasyInsurance
{
    partial class HealthInsuranceForm
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
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnInsure = new System.Windows.Forms.Button();
            this.tbInsurancePayout = new System.Windows.Forms.TextBox();
            this.tbInsuranceStake = new System.Windows.Forms.TextBox();
            this.chbOutpatient = new System.Windows.Forms.CheckBox();
            this.chbHospital = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(12, 138);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(46, 17);
            this.lbStatus.TabIndex = 15;
            this.lbStatus.Text = "label3";
            this.lbStatus.Visible = false;
            // 
            // btnInsure
            // 
            this.btnInsure.Location = new System.Drawing.Point(101, 120);
            this.btnInsure.Name = "btnInsure";
            this.btnInsure.Size = new System.Drawing.Size(75, 23);
            this.btnInsure.TabIndex = 14;
            this.btnInsure.Text = "Osiguraj";
            this.btnInsure.UseVisualStyleBackColor = true;
            this.btnInsure.Click += new System.EventHandler(this.btnInsure_Click);
            // 
            // tbInsurancePayout
            // 
            this.tbInsurancePayout.Location = new System.Drawing.Point(12, 40);
            this.tbInsurancePayout.Name = "tbInsurancePayout";
            this.tbInsurancePayout.Size = new System.Drawing.Size(247, 22);
            this.tbInsurancePayout.TabIndex = 13;
            this.tbInsurancePayout.Text = "Limit pokrica";
            // 
            // tbInsuranceStake
            // 
            this.tbInsuranceStake.Location = new System.Drawing.Point(12, 12);
            this.tbInsuranceStake.Name = "tbInsuranceStake";
            this.tbInsuranceStake.Size = new System.Drawing.Size(247, 22);
            this.tbInsuranceStake.TabIndex = 12;
            this.tbInsuranceStake.Text = "Uplata mesecno";
            // 
            // chbOutpatient
            // 
            this.chbOutpatient.AutoSize = true;
            this.chbOutpatient.Location = new System.Drawing.Point(15, 69);
            this.chbOutpatient.Name = "chbOutpatient";
            this.chbOutpatient.Size = new System.Drawing.Size(156, 21);
            this.chbOutpatient.TabIndex = 16;
            this.chbOutpatient.Text = "Vanbolnicko lecenje";
            this.chbOutpatient.UseVisualStyleBackColor = true;
            // 
            // chbHospital
            // 
            this.chbHospital.AutoSize = true;
            this.chbHospital.Location = new System.Drawing.Point(15, 93);
            this.chbHospital.Name = "chbHospital";
            this.chbHospital.Size = new System.Drawing.Size(132, 21);
            this.chbHospital.TabIndex = 16;
            this.chbHospital.Text = "Bolnicko lecenje";
            this.chbHospital.UseVisualStyleBackColor = true;
            // 
            // HealthInsuranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 164);
            this.Controls.Add(this.chbHospital);
            this.Controls.Add(this.chbOutpatient);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnInsure);
            this.Controls.Add(this.tbInsurancePayout);
            this.Controls.Add(this.tbInsuranceStake);
            this.Name = "HealthInsuranceForm";
            this.Text = "HealthInsuranceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnInsure;
        private System.Windows.Forms.TextBox tbInsurancePayout;
        private System.Windows.Forms.TextBox tbInsuranceStake;
        private System.Windows.Forms.CheckBox chbOutpatient;
        private System.Windows.Forms.CheckBox chbHospital;
    }
}