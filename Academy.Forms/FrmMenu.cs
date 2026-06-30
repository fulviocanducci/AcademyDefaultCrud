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
            using (var frmSplash = new FrmSplash())
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
        }

        private void MenuItemSystemEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
