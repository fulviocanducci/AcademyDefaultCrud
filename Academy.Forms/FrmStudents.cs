using Academy.Dals;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Academy.Forms
{
    public partial class FrmStudents : Form
    {
        public SqlConnection Connection { get; private set; }
        public DalStudent DalStudent { get; private set; }
        public FrmStudents(SqlConnection connection)
        {
            InitializeComponent();
            DalStudent = new DalStudent(connection);
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            LoadAndUpdateDataGridViewStudents();
        }

        private void LoadAndUpdateDataGridViewStudents()
        {
            DataGridViewStudents.DataSource = DalStudent.GetAll(TxtSearch.Text ?? "").ToList();
        }

        private void LoadFrmStudentsOperation(int id = 0)
        {
            using (FrmStudentsOperation frm = new FrmStudentsOperation(DalStudent, id))
            {
                frm.ShowDialog();
                LoadAndUpdateDataGridViewStudents();
            }
        }

        private void ButNew_Click(object sender, EventArgs e)
        {
            LoadFrmStudentsOperation();
        }

        private void DataGridViewStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (int.TryParse(DataGridViewStudents.CurrentRow.Cells[0].Value.ToString(), out int id))
                {
                    LoadFrmStudentsOperation(id);
                }
            }

        }
        private void ButClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadAndUpdateDataGridViewStudents();
            }
        }
    }
}
