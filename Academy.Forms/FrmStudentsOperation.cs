using Academy.Dals;
using Academy.Models;
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
        public FrmStudentsOperation(SqlConnection connection, int id = 0)
        {
            InitializeComponent();
            Id = id;
            Connection = connection;
            DalStudent = new DalStudent(connection);
        }

        public FrmStudentsOperation(DalStudent dalStudent, int id = 0)
        {
            InitializeComponent();
            Id = id;
            DalStudent = dalStudent;
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
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            Student model = new Student
            {
                Id = Id,
                Name = TxtName.Text,
                DateBirthday = MskDateBirthday.Text.ToDateOrDefault()
            };
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

        private void ButClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}