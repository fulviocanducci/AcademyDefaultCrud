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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnterpriseOperation));
            this.ButClose = new System.Windows.Forms.Button();
            this.ButSave = new System.Windows.Forms.Button();
            this.GroupBoxEnterprise = new System.Windows.Forms.GroupBox();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.ErrorProviderEnterprise = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBoxEnterprise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderEnterprise)).BeginInit();
            this.SuspendLayout();
            // 
            // ButClose
            // 
            this.ButClose.CausesValidation = false;
            this.ButClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButClose.Image = global::Academy.Forms.Resources.end;
            this.ButClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButClose.Location = new System.Drawing.Point(249, 130);
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(94, 27);
            this.ButClose.TabIndex = 6;
            this.ButClose.Text = "&Sair [Esc]";
            this.ButClose.UseVisualStyleBackColor = true;
            this.ButClose.Click += new System.EventHandler(this.ButClose_Click);
            // 
            // ButSave
            // 
            this.ButSave.Image = global::Academy.Forms.Resources.icons8_save_16;
            this.ButSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButSave.Location = new System.Drawing.Point(12, 130);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(94, 27);
            this.ButSave.TabIndex = 5;
            this.ButSave.Text = "S&alvar";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // GroupBoxEnterprise
            // 
            this.GroupBoxEnterprise.Controls.Add(this.ChkActive);
            this.GroupBoxEnterprise.Controls.Add(this.label2);
            this.GroupBoxEnterprise.Controls.Add(this.label1);
            this.GroupBoxEnterprise.Controls.Add(this.TxtName);
            this.GroupBoxEnterprise.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxEnterprise.Name = "GroupBoxEnterprise";
            this.GroupBoxEnterprise.Size = new System.Drawing.Size(331, 112);
            this.GroupBoxEnterprise.TabIndex = 0;
            this.GroupBoxEnterprise.TabStop = false;
            this.GroupBoxEnterprise.Text = "Dados";
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
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome (Razão Social)";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(11, 36);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(301, 20);
            this.TxtName.TabIndex = 2;
            // 
            // ErrorProviderEnterprise
            // 
            this.ErrorProviderEnterprise.ContainerControl = this;
            // 
            // FrmEnterpriseOperation
            // 
            this.AcceptButton = this.ButSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButClose;
            this.ClientSize = new System.Drawing.Size(353, 160);
            this.Controls.Add(this.ButClose);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.GroupBoxEnterprise);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnterpriseOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.FrmEnterpriseOperation_Load);
            this.GroupBoxEnterprise.ResumeLayout(false);
            this.GroupBoxEnterprise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderEnterprise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButClose;
        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.GroupBox GroupBoxEnterprise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.ErrorProvider ErrorProviderEnterprise;
    }
}