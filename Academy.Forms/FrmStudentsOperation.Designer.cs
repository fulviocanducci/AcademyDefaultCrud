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
            this.components = new System.ComponentModel.Container();
            this.GroupBoxStudent = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MskDateBirthday = new System.Windows.Forms.MaskedTextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.ButSave = new System.Windows.Forms.Button();
            this.ButClose = new System.Windows.Forms.Button();
            this.ErrorProviderStudent = new System.Windows.Forms.ErrorProvider(this.components);
            this.ToolTipStudent = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBoxStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxStudent
            // 
            this.GroupBoxStudent.Controls.Add(this.label2);
            this.GroupBoxStudent.Controls.Add(this.label1);
            this.GroupBoxStudent.Controls.Add(this.MskDateBirthday);
            this.GroupBoxStudent.Controls.Add(this.TxtName);
            this.GroupBoxStudent.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxStudent.Name = "GroupBoxStudent";
            this.GroupBoxStudent.Size = new System.Drawing.Size(331, 112);
            this.GroupBoxStudent.TabIndex = 0;
            this.GroupBoxStudent.TabStop = false;
            this.GroupBoxStudent.Text = "Dados";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Completo";
            // 
            // MskDateBirthday
            // 
            this.MskDateBirthday.Location = new System.Drawing.Point(11, 80);
            this.MskDateBirthday.Mask = "00/00/0000";
            this.MskDateBirthday.Name = "MskDateBirthday";
            this.MskDateBirthday.Size = new System.Drawing.Size(97, 20);
            this.MskDateBirthday.TabIndex = 1;
            this.MskDateBirthday.ValidatingType = typeof(System.DateTime);
            this.MskDateBirthday.Validating += new System.ComponentModel.CancelEventHandler(this.MskDateBirthday_Validating);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(11, 36);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(301, 20);
            this.TxtName.TabIndex = 0;
            this.TxtName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtName_Validating);
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
            this.ButClose.CausesValidation = false;
            this.ButClose.Location = new System.Drawing.Point(268, 130);
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(75, 23);
            this.ButClose.TabIndex = 4;
            this.ButClose.Text = "&Sair";
            this.ButClose.UseVisualStyleBackColor = true;
            this.ButClose.Click += new System.EventHandler(this.ButClose_Click);
            // 
            // ErrorProviderStudent
            // 
            this.ErrorProviderStudent.ContainerControl = this;
            // 
            // FrmStudentsOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 161);
            this.Controls.Add(this.ButClose);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.GroupBoxStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStudentsOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudante";
            this.Load += new System.EventHandler(this.FrmStudentsOperation_Load);
            this.Shown += new System.EventHandler(this.FrmStudentsOperation_Shown);
            this.GroupBoxStudent.ResumeLayout(false);
            this.GroupBoxStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskDateBirthday;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.Button ButClose;
        private System.Windows.Forms.ErrorProvider ErrorProviderStudent;
        private System.Windows.Forms.ToolTip ToolTipStudent;
    }
}