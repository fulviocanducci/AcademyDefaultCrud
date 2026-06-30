using Academy.Dals;
using Academy.Forms.Utils;
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
        public DebounceTimer DebounceTimer { get; }
        public FrmStudents(SqlConnection connection)
        {
            InitializeComponent();
            DalStudent = new DalStudent(connection);
            DebounceTimer = new DebounceTimer(500, (s, e) =>
            {
                LoadAndUpdateDataGridViewStudents();
            });
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            LoadAndUpdateDataGridViewStudents();
        }

        private void LoadAndUpdateDataGridViewStudents()
        {
            DataGridViewStudents.DataSource = DalStudent.GetAll(TxtSearch.Text ?? "").ToList();
            DataGridViewStudents.Update();
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
            DataGridView dataGridView = (DataGridView)sender;
            if (dataGridView.TryGetRowId(e.RowIndex, out int id))
            {
                LoadFrmStudentsOperation(id);
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

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DebounceTimer.Execute();
        }

        private void DataGridViewStudents_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (dataGridView.TryGetSelectedId(e, out int id))
            {
                LoadFrmStudentsOperation(id);
            }
        }

        private void FrmStudents_KeyDown(object sender, KeyEventArgs e)
        {
            ButNew.ClickWhenPressed(e, Keys.F4);
        }
    }
}
