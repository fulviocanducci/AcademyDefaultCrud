using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Academy.Forms
{
    public partial class FormMenu : Form
    {
        public string SqlConnectionString = "Server=192.168.2.65,1433;Database=Academy;User Id=sa;Password=770301Ab@;TrustServerCertificate=True;";
        public SqlConnection Connection { get; private set; }

        public FormMenu()
        {
            InitializeComponent();
            Connection = new SqlConnection(SqlConnectionString);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void MenuItemStudents_Click(object sender, EventArgs e)
        {
            using (FrmStudents frm = new FrmStudents(Connection))
            {
                frm.ShowDialog();
            }
        }
    }
}
