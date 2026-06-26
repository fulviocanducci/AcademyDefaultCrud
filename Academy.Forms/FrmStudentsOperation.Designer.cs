namespace Academy.Forms
{
    partial class FrmStudentsOperation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.MskDateBirthday = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButSave = new System.Windows.Forms.Button();
            this.ButClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MskDateBirthday);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(11, 36);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(307, 20);
            this.TxtName.TabIndex = 0;
            // 
            // MskDateBirthday
            // 
            this.MskDateBirthday.Location = new System.Drawing.Point(11, 80);
            this.MskDateBirthday.Mask = "00/00/0000";
            this.MskDateBirthday.Name = "MskDateBirthday";
            this.MskDateBirthday.Size = new System.Drawing.Size(97, 20);
            this.MskDateBirthday.TabIndex = 1;
            this.MskDateBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aniversário";
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(12, 130);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(75, 23);
            this.ButSave.TabIndex = 3;
            this.ButSave.Text = "S&alvar";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // ButClose
            // 
            this.ButClose.Location = new System.Drawing.Point(268, 130);
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(75, 23);
            this.ButClose.TabIndex = 4;
            this.ButClose.Text = "&Sair";
            this.ButClose.UseVisualStyleBackColor = true;
            this.ButClose.Click += new System.EventHandler(this.ButClose_Click);
            // 
            // FrmStudentsOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 161);
            this.Controls.Add(this.ButClose);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStudentsOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudante";
            this.Load += new System.EventHandler(this.FrmStudentsOperation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskDateBirthday;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.Button ButClose;
    }
}