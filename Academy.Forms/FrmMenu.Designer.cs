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
            this.StatusBarMenu = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripMenu = new System.Windows.Forms.ToolStrip();
            this.ToolStripButStudent = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButEnterprise = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButEnd = new System.Windows.Forms.ToolStripButton();
            this.MenuStripForm.SuspendLayout();
            this.StatusBarMenu.SuspendLayout();
            this.ToolStripMenu.SuspendLayout();
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
            this.MenuItemStudents.Size = new System.Drawing.Size(126, 22);
            this.MenuItemStudents.Text = "&Estudante";
            this.MenuItemStudents.Click += new System.EventHandler(this.MenuItemStudents_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(123, 6);
            // 
            // MenuItemEntreprise
            // 
            this.MenuItemEntreprise.Image = global::Academy.Forms.Resources.employee;
            this.MenuItemEntreprise.Name = "MenuItemEntreprise";
            this.MenuItemEntreprise.Size = new System.Drawing.Size(126, 22);
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
            // StatusBarMenu
            // 
            this.StatusBarMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.StatusBarMenu.Location = new System.Drawing.Point(0, 428);
            this.StatusBarMenu.Name = "StatusBarMenu";
            this.StatusBarMenu.Size = new System.Drawing.Size(800, 22);
            this.StatusBarMenu.TabIndex = 1;
            this.StatusBarMenu.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(125, 17);
            this.toolStripStatusLabel1.Text = "Sistema de Academias";
            // 
            // ToolStripMenu
            // 
            this.ToolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButStudent,
            this.ToolStripButEnterprise,
            this.toolStripSeparator1,
            this.ToolStripButEnd});
            this.ToolStripMenu.Location = new System.Drawing.Point(0, 24);
            this.ToolStripMenu.Name = "ToolStripMenu";
            this.ToolStripMenu.Size = new System.Drawing.Size(800, 25);
            this.ToolStripMenu.TabIndex = 2;
            // 
            // ToolStripButStudent
            // 
            this.ToolStripButStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButStudent.Image = global::Academy.Forms.Resources.student;
            this.ToolStripButStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButStudent.Name = "ToolStripButStudent";
            this.ToolStripButStudent.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButStudent.Text = "Estudante";
            this.ToolStripButStudent.Click += new System.EventHandler(this.ToolStripButStudent_Click);
            // 
            // ToolStripButEnterprise
            // 
            this.ToolStripButEnterprise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButEnterprise.Image = global::Academy.Forms.Resources.employee;
            this.ToolStripButEnterprise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButEnterprise.Name = "ToolStripButEnterprise";
            this.ToolStripButEnterprise.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButEnterprise.Text = "Empresa";
            this.ToolStripButEnterprise.Click += new System.EventHandler(this.ToolStripButEnterprise_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButEnd
            // 
            this.ToolStripButEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButEnd.Image = global::Academy.Forms.Resources.door;
            this.ToolStripButEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButEnd.Name = "ToolStripButEnd";
            this.ToolStripButEnd.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButEnd.Text = "Sair";
            this.ToolStripButEnd.Click += new System.EventHandler(this.ToolStripButEnd_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToolStripMenu);
            this.Controls.Add(this.StatusBarMenu);
            this.Controls.Add(this.MenuStripForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStripForm;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.Shown += new System.EventHandler(this.FrmMenu_Shown);
            this.MenuStripForm.ResumeLayout(false);
            this.MenuStripForm.PerformLayout();
            this.StatusBarMenu.ResumeLayout(false);
            this.StatusBarMenu.PerformLayout();
            this.ToolStripMenu.ResumeLayout(false);
            this.ToolStripMenu.PerformLayout();
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
        private System.Windows.Forms.StatusStrip StatusBarMenu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip ToolStripMenu;
        private System.Windows.Forms.ToolStripButton ToolStripButStudent;
        private System.Windows.Forms.ToolStripButton ToolStripButEnterprise;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolStripButEnd;
    }
}

