﻿namespace EasyInsurance
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
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbKind = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPolicies
            // 
            this.dgvPolicies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolicies.Location = new System.Drawing.Point(12, 56);
            this.dgvPolicies.Name = "dgvPolicies";
            this.dgvPolicies.RowHeadersWidth = 51;
            this.dgvPolicies.RowTemplate.Height = 24;
            this.dgvPolicies.Size = new System.Drawing.Size(503, 264);
            this.dgvPolicies.TabIndex = 0;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Putno osiguranje",
            "Zdravstveno osiguranje",
            "Zivotno Osiguranje"});
            this.cbType.Location = new System.Drawing.Point(12, 26);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(197, 24);
            this.cbType.TabIndex = 1;
            // 
            // cbKind
            // 
            this.cbKind.FormattingEnabled = true;
            this.cbKind.Items.AddRange(new object[] {
            "Individualno",
            "Porodicno"});
            this.cbKind.Location = new System.Drawing.Point(215, 26);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(174, 24);
            this.cbKind.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vrsta";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(395, 26);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(120, 24);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Pretraga";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // PoliciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 328);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKind);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.dgvPolicies);
            this.Name = "PoliciesForm";
            this.Text = "PoliciesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPolicies;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbKind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFind;
    }
}