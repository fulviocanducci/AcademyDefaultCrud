using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Academy.Forms
{
    public partial class FrmMenu : Form
    {
        public SqlConnection Connection { get; private set; }

        public FrmMenu()
        {
            InitializeComponent();
            Connection = ConnectionSqlServer.Instance;
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
