namespace Academy.Forms
{
    partial class FrmEnterprise
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.ButNew = new System.Windows.Forms.Button();
            this.ButClose = new System.Windows.Forms.Button();
            this.DataGridViewEnterprise = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEnterprise)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(62, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(615, 20);
            this.TxtSearch.TabIndex = 8;
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // ButNew
            // 
            this.ButNew.Location = new System.Drawing.Point(12, 241);
            this.ButNew.Name = "ButNew";
            this.ButNew.Size = new System.Drawing.Size(75, 23);
            this.ButNew.TabIndex = 7;
            this.ButNew.Text = "&Novo";
            this.ButNew.UseVisualStyleBackColor = true;
            this.ButNew.Click += new System.EventHandler(this.ButNew_Click);
            // 
            // ButClose
            // 
            this.ButClose.Location = new System.Drawing.Point(602, 241);
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(75, 23);
            this.ButClose.TabIndex = 6;
            this.ButClose.Text = "&Sair";
            this.ButClose.UseVisualStyleBackColor = true;
            this.ButClose.Click += new System.EventHandler(this.ButClose_Click);
            // 
            // DataGridViewEnterprise
            // 
            this.DataGridViewEnterprise.AllowUserToAddRows = false;
            this.DataGridViewEnterprise.AllowUserToDeleteRows = false;
            this.DataGridViewEnterprise.AllowUserToResizeColumns = false;
            this.DataGridViewEnterprise.AllowUserToResizeRows = false;
            this.DataGridViewEnterprise.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewEnterprise.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewEnterprise.ColumnHeadersHeight = 30;
            this.DataGridViewEnterprise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewEnterprise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DataGridViewEnterprise.Location = new System.Drawing.Point(12, 29);
            this.DataGridViewEnterprise.MultiSelect = false;
            this.DataGridViewEnterprise.Name = "DataGridViewEnterprise";
            this.DataGridViewEnterprise.ReadOnly = true;
            this.DataGridViewEnterprise.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewEnterprise.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewEnterprise.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewEnterprise.ShowCellErrors = false;
            this.DataGridViewEnterprise.ShowCellToolTips = false;
            this.DataGridViewEnterprise.ShowEditingIcon = false;
            this.DataGridViewEnterprise.ShowRowErrors = false;
            this.DataGridViewEnterprise.Size = new System.Drawing.Size(665, 208);
            this.DataGridViewEnterprise.TabIndex = 5;
            this.DataGridViewEnterprise.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewEnterprise_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pesquisa:";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Nome Completo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 396;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Active";
            this.Column3.HeaderText = "Ativo";
            this.Column3.Image = null;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 110;
            // 
            // FrmEnterprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 273);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.ButNew);
            this.Controls.Add(this.ButClose);
            this.Controls.Add(this.DataGridViewEnterprise);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnterprise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.FrmEnterprise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEnterprise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button ButNew;
        private System.Windows.Forms.Button ButClose;
        private System.Windows.Forms.DataGridView DataGridViewEnterprise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
    }
}