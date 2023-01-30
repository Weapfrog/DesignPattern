using DesignPattern.Business;
using DesignPattern.Core;
using DesignPattern.Domain;
using System;
using Dapper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Students = DesignPattern.Domain.Students;

namespace DesignPattern.App
{
    public partial class FrmDesign : Form
    {
        IUnitOfWork uow = new UnitOfWork();
        IDatabaseHelper helper;
        DapperHelper dapper = new DapperHelper();
        public FrmDesign()
        {
            InitializeComponent();
            Setup();
        }

        #region Functions

        public void Setup()
        {
            this.helper = new DatabaseHelper();
            AddValid();
            DeleteValid();
            UpdateValid();
            CalculateValid();
            textBoxGrade1.Enabled = false;
            textBoxGrade2.Enabled = false;
            textBoxState.Enabled = false;
            textBoxAvg.Enabled = false;
            calculateBtn.Enabled = false;
            updateGradesBtn.Enabled = false;
            textBoxAvg.Enabled = false;
            textBoxState.Enabled = false;
        }
        public void AddValid()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxSurname.Text))
            {
                saveBtn.Enabled = false;
            }
            else
                saveBtn.Enabled = true;
        }
        public void DeleteValid()
        {
            if (string.IsNullOrWhiteSpace(numericUpDownID.Text) || numericUpDownID.Value < 1)
            {
                deleteBtn.Enabled = false;
            }
            else
                deleteBtn.Enabled = true;
        }
        public void UpdateValid()
        {
            if (string.IsNullOrWhiteSpace(numericUpDownID.Text) || numericUpDownID.Value < 1 || string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxSurname.Text))
            {
                updateBtn.Enabled = false;
            }
            else
                updateBtn.Enabled = true;
        }
        public void CalculateValid()
        {
            if (string.IsNullOrWhiteSpace(textBoxGrade1.Value.ToString()) || string.IsNullOrWhiteSpace(textBoxGrade2.Value.ToString()) || Convert.ToInt32(textBoxGrade1.Value)>100)
            {
                calculateBtn.Enabled = false;
                updateGradesBtn.Enabled = false;
                clearBtn.Enabled = false;
            }
            else
            {
                calculateBtn.Enabled = true;
                updateGradesBtn.Enabled = true;
                clearBtn.Enabled = true;
            }
        }
        public void GetStudents()
        {
            dataGridViewList.DataSource = dapper.ListStudents();
        }
        public void GetLectures()
        {
            dataGridViewList.DataSource = dapper.ListLectures();
        }
        public void GetGrades()
        {
            dataGridViewList.DataSource = dapper.ListGrades();
        }
        public void GetProcedure()
        {
            dataGridViewList.DataSource = dapper.ListProcedure();
        }
        public void DeleteStudent()
        {
            var response = uow.Delete(Convert.ToInt32(numericUpDownID.Value));
            MessageBox.Show(response.Message);
        }
        public void UpdateStudent()
        {
            Students student = new Students()
            {
                StudentID = Convert.ToInt32(numericUpDownID.Text),
                StudentName = textBoxName.Text,
                StudentSurname = textBoxSurname.Text
            };
            var response = uow.Update(student);
            MessageBox.Show(response.Message);
        }
        public void FindStudent()
        {
            int studentID;
            string studentName, studentSurname;
            if (string.IsNullOrEmpty(numericUpDownID.Text))
                studentID = 0;
            else
                studentID = Convert.ToInt32(numericUpDownID.Text);
            if (string.IsNullOrEmpty(textBoxName.Text))
                studentName = "*";
            else
                studentName = textBoxName.Text;
            if (string.IsNullOrEmpty(textBoxSurname.Text))
                studentSurname = "*";
            else
                studentSurname = textBoxSurname.Text;

            Students student = new Students()
            {
                StudentID = studentID,
                StudentName = studentName,
                StudentSurname = studentSurname
            };
            var response = uow.Find(student);
            dataGridViewList.DataSource = response.table;
        }
        public void ButtonsDisable()
        {
            textBoxName.Enabled = false;
            textBoxSurname.Enabled = false;
            numericUpDownID.Enabled = false;
            textBoxLectureID.Enabled = false;
            textBoxLectureName.Enabled = false;
            textBoxAvg.Enabled = false;
            textBoxState.Enabled = false;
            deleteBtn.Enabled = false;
            saveBtn.Enabled = false;
            studentBtn.Enabled = false;
            updateBtn.Enabled = false;
            findBtn.Enabled = false;
            lectureBtn.Enabled = false;
            gradesBtn.Enabled = false;
            prosedurBtn.Enabled = false;

            textBoxGrade1.Enabled = true;
            textBoxGrade2.Enabled = true;
        }
        public void ButtonsEnable()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            numericUpDownID.Value = 0;
            textBoxLectureID.Clear();
            textBoxLectureName.Clear();
            textBoxGrade1.Value = 0;
            textBoxGrade2.Value = 0;
            textBoxAvg.Clear();
            textBoxState.Clear();

            textBoxName.Enabled = true;
            textBoxSurname.Enabled = true;
            numericUpDownID.Enabled = true;
            textBoxLectureID.Enabled = true;
            textBoxLectureName.Enabled = true;
            studentBtn.Enabled = true;
            findBtn.Enabled = true;
            lectureBtn.Enabled = true;
            gradesBtn.Enabled = true;
            prosedurBtn.Enabled = true;

        }
        public void Calculate()
        {
            int grade1, grade2, avg;
            string state = "";
            grade1 = Convert.ToInt32(textBoxGrade1.Value);
            grade2 = Convert.ToInt32(textBoxGrade2.Value);
            avg = (grade1 + grade2) / 2;
            if (avg >= 50)
                state = "Passed";
            else
                state = "Failed";
            textBoxAvg.Text = avg.ToString();
            textBoxState.Text = state;
        }
        public void UpdateGrade()
        {
            Grades grade = new Grades()
            {
                GradeID = Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value),
                Grade1 = Convert.ToInt32(textBoxGrade1.Value),
                Grade2 = Convert.ToInt32(textBoxGrade2.Value),
            };
            var response = uow.Update(grade);
            MessageBox.Show(response.Message);
            GetProcedure();
        }
        #endregion

        #region Buttons

        private void studentBtn_Click(object sender, EventArgs e)
        {
            GetStudents();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            Students student = new Students()
            {
                StudentName = textBoxName.Text,
                StudentSurname = textBoxSurname.Text
            };
            var response = uow.Insert(student);
            MessageBox.Show(response.Message);

            if (string.IsNullOrWhiteSpace(textBoxLectureName.Text))
            {

            }
            else
            {
                Lectures lecture = new Lectures()
                {
                    LectureName = textBoxLectureName.Text
                };
                var response2 = uow.Insert(lecture);
                MessageBox.Show(response2.Message);
            }
            GetStudents();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteStudent();
            GetStudents();
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateStudent();
            GetStudents();
        }
        private void findBtn_Click(object sender, EventArgs e)
        {
            FindStudent();
        }
        private void lectureBtn_Click(object sender, EventArgs e)
        {
            GetLectures();
        }
        private void gradesBtn_Click(object sender, EventArgs e)
        {
            GetGrades();
        }
        private void prosedurBtn_Click(object sender, EventArgs e)
        {
            GetProcedure();
        }
        private void updateGradesBtn_Click(object sender, EventArgs e)
        {
            UpdateGrade();
        }
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            Calculate();
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            ButtonsEnable();
            calculateBtn.Enabled = false;
            updateGradesBtn.Enabled = false;
        }

        #endregion

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            AddValid();
            UpdateValid();
        }
        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            AddValid();
            UpdateValid();
        }
        private void numericUpDownID_ValueChanged(object sender, EventArgs e)
        {
            DeleteValid();
            UpdateValid();
        }
        private void dataGridViewList_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.SelectedRows.Count > 0 && dataGridViewList.DataSource.GetType().ToString() == "System.Collections.Generic.List`1[DesignPattern.Domain.Procedure]")
            {
                var responseGrade = uow.Find(Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value), "Grades");
                numericUpDownID.Value = responseGrade.tableGrades[0].StudentID;
                textBoxLectureID.Text = responseGrade.tableGrades[0].LectureID.ToString();
                textBoxGrade1.Value = responseGrade.tableGrades[0].Grade1;
                textBoxGrade2.Value = responseGrade.tableGrades[0].Grade2;
                textBoxAvg.Text = responseGrade.tableGrades[0].Average.ToString();
                if (responseGrade.tableGrades[0].StudentState)
                    textBoxState.Text = "Passed";
                else
                    textBoxState.Text = "Failed";

                int studentID = Convert.ToInt32(numericUpDownID.Value);
                var responseStudent = uow.Find(studentID, "Students");
                textBoxName.Text = responseStudent.tableStudents[0].StudentName;
                textBoxSurname.Text = responseStudent.tableStudents[0].StudentSurname;


                int lectureID = Convert.ToInt32(textBoxLectureID.Text);
                var responseLecture = uow.Find(lectureID, "Lectures");
                textBoxLectureName.Text = responseLecture.tableLectures[0].LectureName;

                CalculateValid();
                ButtonsDisable();

            }
        }
        private void textBoxGrade1_ValueChanged(object sender, EventArgs e)
        {
            CalculateValid();
        }
        private void textBoxGrade2_ValueChanged(object sender, EventArgs e)
        {
            CalculateValid();
        }
    }
}
