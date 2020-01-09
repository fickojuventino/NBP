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
            this.SuspendLayout();
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(13, 13);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(287, 78);
            this.tbDescription.TabIndex = 0;
            this.tbDescription.Text = "Dodaj opis";
            // 
            // tbPayoutAmount
            // 
            this.tbPayoutAmount.Location = new System.Drawing.Point(13, 97);
            this.tbPayoutAmount.Name = "tbPayoutAmount";
            this.tbPayoutAmount.Size = new System.Drawing.Size(287, 22);
            this.tbPayoutAmount.TabIndex = 1;
            this.tbPayoutAmount.Text = "Suma za isplatu";
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(122, 125);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(75, 23);
            this.btnCreateEvent.TabIndex = 2;
            this.btnCreateEvent.Text = "Kreiraj dogadjaj";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(13, 153);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(46, 17);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "label1";
            this.lbStatus.Visible = false;
            // 
            // CreateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 173);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.tbPayoutAmount);
            this.Controls.Add(this.tbDescription);
            this.Name = "CreateEventForm";
            this.Text = "Novi dogadjaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPayoutAmount;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Label lbStatus;
    }
}