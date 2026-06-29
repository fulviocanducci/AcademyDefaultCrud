using Academy.Dals;
using Academy.Models;
using System;
using System.Windows.Forms;

namespace Academy.Forms
{
    public partial class FrmEnterpriseOperation : Form
    {
        public int Id { get; set; }
        public DalEnterprise DalEnterprise { get; }

        public FrmEnterpriseOperation(DalEnterprise dalEnterprise, int id = 0)
        {
            InitializeComponent();
            Id = id;
            DalEnterprise = dalEnterprise;
        }

        private void FrmEnterpriseOperation_Load(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                var result = DalEnterprise.Find(Id);
                if (result != null)
                {
                    TxtName.Text = result.Name;
                    ChkActive.Checked = result.Active;
                }
            }

        }

        private bool FormValid()
        {
            ErrorProviderEnterprise.SetError(TxtName, null);
            // Test TxtName
            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                ErrorProviderEnterprise.SetError(TxtName, "Nome é obrigatório");
            }
            return ErrorProviderEnterprise.GetErrors(this).Count == 0;
        }

        private void ButClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            bool formValid = FormValid();
            if (formValid)
            {
                Enterprise enterprise = new Enterprise()
                {
                    Name = TxtName.Text,
                    Active = ChkActive.Checked
                };
            }
            else
            {
                Message.ErrorValidation(ErrorProviderEnterprise.ErrorsToString(this));
            }
        }
    }
}
