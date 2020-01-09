namespace EasyInsurance
{
    partial class PoliciesForm
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
            this.dgvPolicies = new System.Windows.Forms.DataGridView();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izmeni = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPolicies
            // 
            this.dgvPolicies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolicies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tip,
            this.Vrsta,
            this.Izmeni});
            this.dgvPolicies.Location = new System.Drawing.Point(12, 12);
            this.dgvPolicies.Name = "dgvPolicies";
            this.dgvPolicies.RowHeadersWidth = 51;
            this.dgvPolicies.RowTemplate.Height = 24;
            this.dgvPolicies.Size = new System.Drawing.Size(526, 264);
            this.dgvPolicies.TabIndex = 0;
            this.dgvPolicies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolicies_CellContentClick);
            // 
            // Tip
            // 
            this.Tip.DataPropertyName = "Tip";
            this.Tip.HeaderText = "Tip";
            this.Tip.MinimumWidth = 6;
            this.Tip.Name = "Tip";
            this.Tip.Width = 125;
            // 
            // Vrsta
            // 
            this.Vrsta.DataPropertyName = "Vrsta";
            this.Vrsta.HeaderText = "Vrsta";
            this.Vrsta.MinimumWidth = 6;
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.Width = 125;
            // 
            // Izmeni
            // 
            this.Izmeni.DataPropertyName = "Izmeni";
            this.Izmeni.HeaderText = "";
            this.Izmeni.MinimumWidth = 6;
            this.Izmeni.Name = "Izmeni";
            this.Izmeni.Text = "Izmeni";
            this.Izmeni.Width = 125;
            // 
            // PoliciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 288);
            this.Controls.Add(this.dgvPolicies);
            this.Name = "PoliciesForm";
            this.Text = "PoliciesForm";
            this.Load += new System.EventHandler(this.PoliciesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPolicies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
        private System.Windows.Forms.DataGridViewButtonColumn Izmeni;
    }
}