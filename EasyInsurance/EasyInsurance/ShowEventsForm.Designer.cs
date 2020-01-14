namespace EasyInsurance
{
    partial class ShowEventsForm
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
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbKind = new System.Windows.Forms.ComboBox();
            this.btnFindEvents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvents
            // 
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(13, 73);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersWidth = 51;
            this.dgvEvents.RowTemplate.Height = 24;
            this.dgvEvents.Size = new System.Drawing.Size(450, 365);
            this.dgvEvents.TabIndex = 1;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Zivotno Osiguranje",
            "Zdravstveno osiguranje",
            "Putno osiguranje"});
            this.cbType.Location = new System.Drawing.Point(13, 13);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(288, 24);
            this.cbType.TabIndex = 2;
            // 
            // cbKind
            // 
            this.cbKind.FormattingEnabled = true;
            this.cbKind.Items.AddRange(new object[] {
            "Individualno",
            "Grupno"});
            this.cbKind.Location = new System.Drawing.Point(13, 43);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(288, 24);
            this.cbKind.TabIndex = 2;
            // 
            // btnFindEvents
            // 
            this.btnFindEvents.Location = new System.Drawing.Point(307, 12);
            this.btnFindEvents.Name = "btnFindEvents";
            this.btnFindEvents.Size = new System.Drawing.Size(156, 54);
            this.btnFindEvents.TabIndex = 3;
            this.btnFindEvents.Text = "Pretrazi";
            this.btnFindEvents.UseVisualStyleBackColor = true;
            this.btnFindEvents.Click += new System.EventHandler(this.btnFindEvents_Click);
            // 
            // ShowEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.btnFindEvents);
            this.Controls.Add(this.cbKind);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.dgvEvents);
            this.Name = "ShowEventsForm";
            this.Text = "ShowEventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbKind;
        private System.Windows.Forms.Button btnFindEvents;
    }
}