namespace EasyInsurance
{
    partial class CreateEventForm
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
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbPayoutAmount = new System.Windows.Forms.TextBox();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbPolicies = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(16, 64);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(287, 78);
            this.tbDescription.TabIndex = 0;
            this.tbDescription.Text = "Dodaj opis";
            // 
            // tbPayoutAmount
            // 
            this.tbPayoutAmount.Location = new System.Drawing.Point(16, 148);
            this.tbPayoutAmount.Name = "tbPayoutAmount";
            this.tbPayoutAmount.Size = new System.Drawing.Size(287, 22);
            this.tbPayoutAmount.TabIndex = 1;
            this.tbPayoutAmount.Text = "Suma za isplatu";
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(111, 176);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(75, 23);
            this.btnCreateEvent.TabIndex = 2;
            this.btnCreateEvent.Text = "Kreiraj dogadjaj";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(13, 213);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(46, 17);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "label1";
            this.lbStatus.Visible = false;
            // 
            // cbPolicies
            // 
            this.cbPolicies.FormattingEnabled = true;
            this.cbPolicies.Location = new System.Drawing.Point(16, 34);
            this.cbPolicies.Name = "cbPolicies";
            this.cbPolicies.Size = new System.Drawing.Size(287, 24);
            this.cbPolicies.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Polise osiguranja";
            this.label1.Visible = false;
            // 
            // CreateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 235);
            this.Controls.Add(this.cbPolicies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.tbPayoutAmount);
            this.Controls.Add(this.tbDescription);
            this.Name = "CreateEventForm";
            this.Text = "Novi dogadjaj";
            this.Load += new System.EventHandler(this.CreateEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPayoutAmount;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbPolicies;
        private System.Windows.Forms.Label label1;
    }
}