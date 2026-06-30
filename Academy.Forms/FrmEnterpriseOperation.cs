using Academy.Dals;
using Academy.Models;
using Academy.Validations;
using System;
using System.Windows.Forms;

namespace Academy.Forms
{
    public partial class FrmEnterpriseOperation : Form
    {
        public int Id { get; set; }
        public DalEnterprise DalEnterprise { get; }
        public EnterpriseValidation EnterpriseValidation { get; }

        public FrmEnterpriseOperation(DalEnterprise dalEnterprise, int id = 0)
        {
            InitializeComponent();
            Id = id;
            DalEnterprise = dalEnterprise;
            EnterpriseValidation = new EnterpriseValidation();
        }

        private void FrmEnterpriseOperation_Load(object sender, EventArgs e)
        {
            ButSave.LabelNew();
            if (Id > 0)
            {
                ButSave.LabelUpdate();
                var result = DalEnterprise.Get(Id);
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
            return ErrorProviderEnterprise.GetErrors(GroupBoxEnterprise).Count == 0;
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
                    Id = Id,
                    Name = TxtName.Text,
                    Active = ChkActive.Checked
                };
                var result = EnterpriseValidation.Validate(enterprise);
                if (result.IsValid)
                {
                    if (Id == 0)
                    {
                        DalEnterprise.Insert(enterprise);
                        Message.SuccessInsert();
                        Close();
                    }
                    else
                    {
                        DalEnterprise.Update(enterprise);
                        Message.SuccessUpdate();
                        Close();
                    }
                }
                else
                {
                    Message.ErrorValidation(result.ErrorsToString());
                }
            }
            else
            {
                Message.ErrorValidation(ErrorProviderEnterprise.ErrorsToString(this));
            }
        }
    }
}
