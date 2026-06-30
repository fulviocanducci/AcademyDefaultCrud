using Academy.Dals.Contexts;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Academy.Forms
{
    public partial class FrmMenu : Form
    {
        public SqlConnection Connection { get; private set; }
        public DatabaseContext DatabaseContext { get; private set; }

        public FrmMenu()
        {
            InitializeComponent();
            Connection = ConnectionSqlServer.Instance;
            DatabaseContext = new DatabaseContext(ConnectionSqlServer.ConnectionString);
        }

        private async void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void MenuItemStudents_Click(object sender, EventArgs e)
        {
            using (FrmStudents frm = new FrmStudents(Connection))
            {
                frm.ShowDialog();
            }
        }

        private void MenuItemEntreprise_Click(object sender, EventArgs e)
        {
            using (FrmEnterprise frm = new FrmEnterprise(DatabaseContext))
            {
                frm.ShowDialog();
            }
        }

        private async void FrmMenu_Shown(object sender, EventArgs e)
        {
            MenuStripForm.Visible = false;
            ToolStripMenu.Visible = false;
            using (FrmSplash frmSplash = new FrmSplash())
            {
                frmSplash.Show();
                Application.DoEvents();
                await Task.Run(() =>
                {
                    DatabaseContext.Database.Initialize(false);
                });
                frmSplash.Close();
            }
            MenuStripForm.Visible = true;
            ToolStripMenu.Visible = true;
        }

        private void MenuItemSystemEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripButStudent_Click(object sender, EventArgs e)
        {
            MenuItemStudents.PerformClick();
        }

        private void ToolStripButEnterprise_Click(object sender, EventArgs e)
        {
            MenuItemEntreprise.PerformClick();
        }

        private void ToolStripButEnd_Click(object sender, EventArgs e)
        {
            MenuItemSystemEnd.PerformClick();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
