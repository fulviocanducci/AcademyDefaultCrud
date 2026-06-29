using Academy.Dals;
using Academy.Dals.Contexts;
using System;
using System.Windows.Forms;

namespace Academy.Forms
{
    public partial class FrmEnterprise : Form
    {
        public DatabaseContext DatabaseContext { get; }
        public DalEnterprise DalEnterprise { get; }
        public FrmEnterprise(DatabaseContext databaseContext)
        {
            InitializeComponent();
            DatabaseContext = databaseContext;
            DalEnterprise = new DalEnterprise(DatabaseContext);
        }

        private void FrmEnterprise_Load(object sender, EventArgs e)
        {
            LoadAndUpdateDataGridViewEnterprise();
        }

        private void LoadAndUpdateDataGridViewEnterprise()
        {
            DataGridViewEnterprise.DataSource = DalEnterprise.GetAll();
            DataGridViewEnterprise.Update();
        }

        private void LoadFrmEnterpriseOperation(int id = 0)
        {
            using (FrmEnterpriseOperation frm = new FrmEnterpriseOperation(DalEnterprise, id))
            {
                frm.ShowDialog();
                LoadAndUpdateDataGridViewEnterprise();
            }
        }

        private void ButNew_Click(object sender, EventArgs e)
        {
            LoadFrmEnterpriseOperation();
        }

        private void DataGridViewEnterprise_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (int.TryParse(DataGridViewEnterprise.CurrentRow.Cells[0].Value.ToString(), out int id))
                {
                    LoadFrmEnterpriseOperation(id);
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
                LoadAndUpdateDataGridViewEnterprise();
            }
        }
    }
}
