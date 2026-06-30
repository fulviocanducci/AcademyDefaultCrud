using Academy.Dals;
using Academy.Dals.Contexts;
using Academy.Forms.Models.DTOs;
using Academy.Forms.Utils;
using System;
using System.Windows.Forms;

namespace Academy.Forms
{
    public partial class FrmEnterprise : Form
    {
        public DatabaseContext DatabaseContext { get; }
        public DalEnterprise DalEnterprise { get; }
        public DebounceTimer DebounceTimer { get; }
        public FrmEnterprise(DatabaseContext databaseContext)
        {
            InitializeComponent();
            DatabaseContext = databaseContext;
            DalEnterprise = new DalEnterprise(DatabaseContext);
            DebounceTimer = new DebounceTimer(500, (s, e) =>
            {
                LoadAndUpdateDataGridViewEnterprise();
            });
        }

        private void FrmEnterprise_Load(object sender, EventArgs e)
        {
            LoadAndUpdateDataGridViewEnterprise();
        }

        private void LoadAndUpdateDataGridViewEnterprise()
        {
            DataGridViewEnterprise.DataSource = (EnterpriseListDto)DalEnterprise.GetAll(TxtSearch.Text ?? "");
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
            DataGridView dataGridView = (DataGridView)sender;
            if (dataGridView.TryGetRowId(e.RowIndex, out int id))
            {
                LoadFrmEnterpriseOperation(id);
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

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DebounceTimer.Execute();
        }

        private void DataGridViewEnterprise_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (dataGridView.TryGetSelectedId(e, out int id))
            {
                LoadFrmEnterpriseOperation(id);
            }
        }

        private void FrmEnterprise_KeyDown(object sender, KeyEventArgs e)
        {
            ButNew.ClickWhenPressed(e, Keys.F4);
        }
    }
}
