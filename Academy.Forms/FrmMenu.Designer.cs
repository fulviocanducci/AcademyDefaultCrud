namespace Academy.Forms
{
    partial class FrmMenu
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
            this.MenuStripForm = new System.Windows.Forms.MenuStrip();
            this.MenuItemForm = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEntreprise = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripForm
            // 
            this.MenuStripForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemForm});
            this.MenuStripForm.Location = new System.Drawing.Point(0, 0);
            this.MenuStripForm.Name = "MenuStripForm";
            this.MenuStripForm.Size = new System.Drawing.Size(800, 24);
            this.MenuStripForm.TabIndex = 0;
            this.MenuStripForm.Text = "MenuStripForm";
            // 
            // MenuItemForm
            // 
            this.MenuItemForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStudents,
            this.toolStripMenuItem1,
            this.MenuItemEntreprise});
            this.MenuItemForm.Name = "MenuItemForm";
            this.MenuItemForm.Size = new System.Drawing.Size(71, 20);
            this.MenuItemForm.Text = "Cadastros";
            // 
            // MenuItemStudents
            // 
            this.MenuItemStudents.Name = "MenuItemStudents";
            this.MenuItemStudents.Size = new System.Drawing.Size(180, 22);
            this.MenuItemStudents.Text = "Estudante";
            this.MenuItemStudents.Click += new System.EventHandler(this.MenuItemStudents_Click);
            // 
            // MenuItemEntreprise
            // 
            this.MenuItemEntreprise.Name = "MenuItemEntreprise";
            this.MenuItemEntreprise.Size = new System.Drawing.Size(180, 22);
            this.MenuItemEntreprise.Text = "Empresa";
            this.MenuItemEntreprise.Click += new System.EventHandler(this.MenuItemEntreprise_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuStripForm);
            this.MainMenuStrip = this.MenuStripForm;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.MenuStripForm.ResumeLayout(false);
            this.MenuStripForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripForm;
        private System.Windows.Forms.ToolStripMenuItem MenuItemForm;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStudents;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEntreprise;
    }
}

