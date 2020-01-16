namespace EasyInsurance
{
    partial class RegisterForm
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
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPasswordRepeat = new System.Windows.Forms.TextBox();
            this.cbReveal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(12, 37);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(329, 22);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.Text = "Ime";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(12, 63);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(329, 22);
            this.tbLastName.TabIndex = 2;
            this.tbLastName.Text = "Prezime";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(129, 169);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(140, 194);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(48, 17);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Status";
            this.lbStatus.Visible = false;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(12, 11);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(329, 22);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.Text = "Korisnicko Ime";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(12, 89);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(329, 22);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Text = "Sifra";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // tbPasswordRepeat
            // 
            this.tbPasswordRepeat.Location = new System.Drawing.Point(12, 115);
            this.tbPasswordRepeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPasswordRepeat.Name = "tbPasswordRepeat";
            this.tbPasswordRepeat.Size = new System.Drawing.Size(329, 22);
            this.tbPasswordRepeat.TabIndex = 3;
            this.tbPasswordRepeat.Text = "Ponovi sifru";
            this.tbPasswordRepeat.Enter += new System.EventHandler(this.tbPasswordRepeat_Enter);
            this.tbPasswordRepeat.Leave += new System.EventHandler(this.tbPasswordRepeat_Leave);
            // 
            // cbReveal
            // 
            this.cbReveal.AutoSize = true;
            this.cbReveal.Location = new System.Drawing.Point(13, 143);
            this.cbReveal.Name = "cbReveal";
            this.cbReveal.Size = new System.Drawing.Size(103, 21);
            this.cbReveal.TabIndex = 5;
            this.cbReveal.Text = "Prikazi sifre";
            this.cbReveal.UseVisualStyleBackColor = true;
            this.cbReveal.CheckedChanged += new System.EventHandler(this.cbReveal_CheckedChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 220);
            this.Controls.Add(this.cbReveal);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbPasswordRepeat);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPasswordRepeat;
        private System.Windows.Forms.CheckBox cbReveal;
    }
}