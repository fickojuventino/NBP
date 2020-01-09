namespace EasyInsurance
{
    partial class FindPolicyForm
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
            this.cbInsuranceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbInsuranceKind = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbInsuranceType
            // 
            this.cbInsuranceType.FormattingEnabled = true;
            this.cbInsuranceType.Items.AddRange(new object[] {
            "Zdravstveno osiguranje",
            "Zivotno osiguranje",
            "Putno osiguranje"});
            this.cbInsuranceType.Location = new System.Drawing.Point(12, 31);
            this.cbInsuranceType.Name = "cbInsuranceType";
            this.cbInsuranceType.Size = new System.Drawing.Size(173, 24);
            this.cbInsuranceType.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tip polise:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vrsta polise";
            // 
            // cbInsuranceKind
            // 
            this.cbInsuranceKind.FormattingEnabled = true;
            this.cbInsuranceKind.Items.AddRange(new object[] {
            "Individualno",
            "Porodicno"});
            this.cbInsuranceKind.Location = new System.Drawing.Point(12, 88);
            this.cbInsuranceKind.Name = "cbInsuranceKind";
            this.cbInsuranceKind.Size = new System.Drawing.Size(173, 24);
            this.cbInsuranceKind.TabIndex = 11;
            // 
            // FindPolicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 295);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbInsuranceKind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbInsuranceType);
            this.Name = "FindPolicyForm";
            this.Text = "FindPolicyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInsuranceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbInsuranceKind;
    }
}