namespace EasyInsurance
{
    partial class WorkerForm
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
            this.tbFindInsured = new System.Windows.Forms.Button();
            this.lbLogout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnAddInsured
            // 
            this.btnAddInsured.Location = new System.Drawing.Point(13, 13);
            this.btnAddInsured.Name = "btnAddInsured";
            this.btnAddInsured.Size = new System.Drawing.Size(246, 43);
            this.btnAddInsured.TabIndex = 0;
            this.btnAddInsured.Text = "Dodaj osiguranika";
            this.btnAddInsured.UseVisualStyleBackColor = true;
            this.btnAddInsured.Click += new System.EventHandler(this.btnAddInsured_Click);
            // 
            // tbFindInsured
            // 
            this.tbFindInsured.Location = new System.Drawing.Point(13, 62);
            this.tbFindInsured.Name = "tbFindInsured";
            this.tbFindInsured.Size = new System.Drawing.Size(246, 43);
            this.tbFindInsured.TabIndex = 1;
            this.tbFindInsured.Text = "Pronadji osiguranika";
            this.tbFindInsured.UseVisualStyleBackColor = true;
            this.tbFindInsured.Click += new System.EventHandler(this.tbFindInsured_Click);
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Location = new System.Drawing.Point(192, 124);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(67, 17);
            this.lbLogout.TabIndex = 3;
            this.lbLogout.TabStop = true;
            this.lbLogout.Text = "Izloguj se";
            this.lbLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLogout_LinkClicked);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 149);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.tbFindInsured);
            this.Controls.Add(this.btnAddInsured);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddInsured;
        private System.Windows.Forms.Button tbFindInsured;
        private System.Windows.Forms.LinkLabel lbLogout;
    }
}