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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.MenuStripForm = new System.Windows.Forms.MenuStrip();
            this.MenuItemForm = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemEntreprise = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSystemEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripForm
            // 
            this.MenuStripForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemForm,
            this.MenuItemSystem});
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
            this.MenuItemForm.Text = "&Cadastros";
            // 
            // MenuItemStudents
            // 
            this.MenuItemStudents.Image = global::Academy.Forms.Resources.student;
            this.MenuItemStudents.Name = "MenuItemStudents";
            this.MenuItemStudents.Size = new System.Drawing.Size(180, 22);
            this.MenuItemStudents.Text = "&Estudante";
            this.MenuItemStudents.Click += new System.EventHandler(this.MenuItemStudents_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuItemEntreprise
            // 
            this.MenuItemEntreprise.Image = global::Academy.Forms.Resources.employee;
            this.MenuItemEntreprise.Name = "MenuItemEntreprise";
            this.MenuItemEntreprise.Size = new System.Drawing.Size(180, 22);
            this.MenuItemEntreprise.Text = "E&mpresa";
            this.MenuItemEntreprise.Click += new System.EventHandler(this.MenuItemEntreprise_Click);
            // 
            // MenuItemSystem
            // 
            this.MenuItemSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSystemEnd});
            this.MenuItemSystem.Name = "MenuItemSystem";
            this.MenuItemSystem.Size = new System.Drawing.Size(60, 20);
            this.MenuItemSystem.Text = "&Sistema";
            // 
            // MenuItemSystemEnd
            // 
            this.MenuItemSystemEnd.Image = global::Academy.Forms.Resources.door;
            this.MenuItemSystemEnd.Name = "MenuItemSystemEnd";
            this.MenuItemSystemEnd.Size = new System.Drawing.Size(180, 22);
            this.MenuItemSystemEnd.Text = "Sai&r";
            this.MenuItemSystemEnd.Click += new System.EventHandler(this.MenuItemSystemEnd_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuStripForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStripForm;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.Shown += new System.EventHandler(this.FrmMenu_Shown);
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
        private System.Windows.Forms.ToolStripMenuItem MenuItemSystem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSystemEnd;
    }
}

