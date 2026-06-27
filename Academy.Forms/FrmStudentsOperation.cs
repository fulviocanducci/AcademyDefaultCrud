using Academy.Dals;
using Academy.Models;
using Academy.Validations;
using Academy.Validations.Utils;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Academy.Forms
{
    public partial class FrmStudentsOperation : Form
    {
        public int Id { get; private set; }
        public SqlConnection Connection { get; private set; }
        public DalStudent DalStudent { get; private set; }
        public StudentValidation StudentValidation { get; private set; }

        public FrmStudentsOperation(SqlConnection connection, int id = 0)
        {
            InitializeComponent();
            Id = id;
            Connection = connection;
            DalStudent = new DalStudent(connection);
            StudentValidation = new StudentValidation();
        }

        public FrmStudentsOperation(DalStudent dalStudent, int id = 0)
        {
            InitializeComponent();
            Id = id;
            DalStudent = dalStudent;
            StudentValidation = new StudentValidation();
        }

        private void FrmStudentsOperation_Load(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                Student model = DalStudent.Find(Id);
                if (model != null)
                {
                    TxtName.Text = model.Name;
                    MskDateBirthday.Text = model.DateBirthday.ToDateOrDefault();
                }
            }
            ToolTipStudent.IsBalloon = false;
            ToolTipStudent.ToolTipIcon = ToolTipIcon.Error;
            ToolTipStudent.ToolTipTitle = "Validação";
            MskDateBirthday.Text = "00/00/0000";
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Student model = new Student
                {
                    Id = Id,
                    Name = TxtName.Text,
                    DateBirthday = MskDateBirthday.Text.ToDateOrDefault()
                };
                var result = StudentValidation.Validate(model);
                if (result.IsValid)
                {
                    if (Id == 0)
                    {
                        DalStudent.Insert(model);
                        Message.SuccessInsert();
                        Close();
                    }
                    else
                    {
                        DalStudent.Update(model);
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
                Message.ErrorValidation(ErrorProviderStudent.ErrorsToString(this));
            }
        }

        private void ButClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            void ErrorProviderAndToolTipShow()
            {
                ErrorProviderStudent.SetError(TxtName, "Nome é obrigatório");
                ToolTipStudent.Show("Nome é obrigatório", TxtName, 3000);
            }
            ErrorProviderStudent.SetError(TxtName, null);
            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                ErrorProviderAndToolTipShow();
                e.Cancel = true;
            }
        }

        private void MskDateBirthday_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            void ErrorProviderAndToolTipShow()
            {
                ErrorProviderStudent.SetError(MskDateBirthday, "Data inválida");
                ToolTipStudent.Show("Data inválida", MskDateBirthday, 3000);
            }

            string numbers = MskDateBirthday.Text.GetNumbers();
            ErrorProviderStudent.SetError(MskDateBirthday, null);
            if (numbers.Length > 0 && numbers.Length < 8)
            {
                ErrorProviderAndToolTipShow();
                e.Cancel = true;
                return;
            }
            if (numbers.Length == 8 && !ValidationCustom.IsDateTime(MskDateBirthday.Text.ToDate()))
            {
                ErrorProviderAndToolTipShow();
                e.Cancel = true;
                return;
            }
        }

        private void FrmStudentsOperation_Shown(object sender, EventArgs e)
        {

        }
    }
}