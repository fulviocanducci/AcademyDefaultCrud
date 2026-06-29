namespace Academy.Forms
{
    partial class FrmEnterpriseOperation
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
            this.components = new System.ComponentModel.Container();
            this.ButClose = new System.Windows.Forms.Button();
            this.ButSave = new System.Windows.Forms.Button();
            this.GroupBoxStudent = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.ErrorProviderEnterprise = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBoxStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderEnterprise)).BeginInit();
            this.SuspendLayout();
            // 
            // ButClose
            // 
            this.ButClose.CausesValidation = false;
            this.ButClose.Location = new System.Drawing.Point(268, 130);
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(75, 23);
            this.ButClose.TabIndex = 7;
            this.ButClose.Text = "&Sair";
            this.ButClose.UseVisualStyleBackColor = true;
            this.ButClose.Click += new System.EventHandler(this.ButClose_Click);
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(12, 130);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(75, 23);
            this.ButSave.TabIndex = 6;
            this.ButSave.Text = "S&alvar";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // GroupBoxStudent
            // 
            this.GroupBoxStudent.Controls.Add(this.ChkActive);
            this.GroupBoxStudent.Controls.Add(this.label2);
            this.GroupBoxStudent.Controls.Add(this.label1);
            this.GroupBoxStudent.Controls.Add(this.TxtName);
            this.GroupBoxStudent.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxStudent.Name = "GroupBoxStudent";
            this.GroupBoxStudent.Size = new System.Drawing.Size(331, 112);
            this.GroupBoxStudent.TabIndex = 5;
            this.GroupBoxStudent.TabStop = false;
            this.GroupBoxStudent.Text = "Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status da Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome (Razão Social)";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(11, 36);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(301, 20);
            this.TxtName.TabIndex = 0;
            // 
            // ChkActive
            // 
            this.ChkActive.AutoSize = true;
            this.ChkActive.Location = new System.Drawing.Point(13, 83);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(56, 17);
            this.ChkActive.TabIndex = 4;
            this.ChkActive.Text = "Status";
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // ErrorProviderEnterprise
            // 
            this.ErrorProviderEnterprise.ContainerControl = this;
            // 
            // FrmEnterpriseOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 160);
            this.Controls.Add(this.ButClose);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.GroupBoxStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnterpriseOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.FrmEnterpriseOperation_Load);
            this.GroupBoxStudent.ResumeLayout(false);
            this.GroupBoxStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderEnterprise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButClose;
        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.GroupBox GroupBoxStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.ErrorProvider ErrorProviderEnterprise;
    }
}