namespace Academy.Forms
{
    partial class FrmStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudents));
            this.DataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButClose = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewStudents
            // 
            this.DataGridViewStudents.AllowUserToAddRows = false;
            this.DataGridViewStudents.AllowUserToDeleteRows = false;
            this.DataGridViewStudents.AllowUserToResizeColumns = false;
            this.DataGridViewStudents.AllowUserToResizeRows = false;
            this.DataGridViewStudents.BackgroundColor = System.Drawing.Color.Snow;
            this.DataGridViewStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewStudents.ColumnHeadersHeight = 30;
            this.DataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewStudents.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewStudents.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridViewStudents.Location = new System.Drawing.Point(12, 30);
            this.DataGridViewStudents.MultiSelect = false;
            this.DataGridViewStudents.Name = "DataGridViewStudents";
            this.DataGridViewStudents.ReadOnly = true;
            this.DataGridViewStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewStudents.ShowCellErrors = false;
            this.DataGridViewStudents.ShowCellToolTips = false;
            this.DataGridViewStudents.ShowEditingIcon = false;
            this.DataGridViewStudents.ShowRowErrors = false;
            this.DataGridViewStudents.Size = new System.Drawing.Size(665, 208);
            this.DataGridViewStudents.TabIndex = 0;
            this.DataGridViewStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewStudents_CellDoubleClick);
            this.DataGridViewStudents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridViewStudents_KeyDown);
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
            this.Column3.DataPropertyName = "DateBirthday";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Aniversário";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // ButClose
            // 
            this.ButClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButClose.Image = global::Academy.Forms.Resources.end;
            this.ButClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButClose.Location = new System.Drawing.Point(583, 244);
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(94, 27);
            this.ButClose.TabIndex = 1;
            this.ButClose.Text = "&Sair [Esc]";
            this.ButClose.UseVisualStyleBackColor = true;
            this.ButClose.Click += new System.EventHandler(this.ButClose_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(62, 6);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(615, 20);
            this.TxtSearch.TabIndex = 3;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisa:";
            // 
            // ButNew
            // 
            this.ButNew.Image = global::Academy.Forms.Resources.icons8_add_16;
            this.ButNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButNew.Location = new System.Drawing.Point(12, 244);
            this.ButNew.Name = "ButNew";
            this.ButNew.Size = new System.Drawing.Size(94, 27);
            this.ButNew.TabIndex = 2;
            this.ButNew.Text = "&Novo [F4]";
            this.ButNew.UseVisualStyleBackColor = true;
            this.ButNew.Click += new System.EventHandler(this.ButNew_Click);
            // 
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButClose;
            this.ClientSize = new System.Drawing.Size(689, 277);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.ButNew);
            this.Controls.Add(this.ButClose);
            this.Controls.Add(this.DataGridViewStudents);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudantes ...";
            this.Load += new System.EventHandler(this.FrmStudents_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmStudents_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewStudents;
        private System.Windows.Forms.Button ButClose;
        private System.Windows.Forms.Button ButNew;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}