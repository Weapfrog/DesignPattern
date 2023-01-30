
namespace DesignPattern.App
{
    partial class FrmDesign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxGrades = new System.Windows.Forms.GroupBox();
            this.textBoxGrade2 = new System.Windows.Forms.NumericUpDown();
            this.textBoxGrade1 = new System.Windows.Forms.NumericUpDown();
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateGradesBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gradeAvgLabel = new System.Windows.Forms.Label();
            this.grade2Label = new System.Windows.Forms.Label();
            this.grade1Label = new System.Windows.Forms.Label();
            this.textBoxAvg = new System.Windows.Forms.TextBox();
            this.studentBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.lectureBtn = new System.Windows.Forms.Button();
            this.gradesBtn = new System.Windows.Forms.Button();
            this.prosedurBtn = new System.Windows.Forms.Button();
            this.groupBoxLectures = new System.Windows.Forms.GroupBox();
            this.textBoxLectureID = new System.Windows.Forms.TextBox();
            this.lectureIDLabel = new System.Windows.Forms.Label();
            this.lectureNameLabel = new System.Windows.Forms.Label();
            this.textBoxLectureName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.groupBoxStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            this.groupBoxGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxGrade2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxGrade1)).BeginInit();
            this.groupBoxLectures.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToResizeColumns = false;
            this.dataGridViewList.AllowUserToResizeRows = false;
            this.dataGridViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Location = new System.Drawing.Point(18, 17);
            this.dataGridViewList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewList.MultiSelect = false;
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            this.dataGridViewList.RowHeadersWidth = 51;
            this.dataGridViewList.RowTemplate.Height = 24;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(736, 276);
            this.dataGridViewList.TabIndex = 0;
            this.dataGridViewList.Click += new System.EventHandler(this.dataGridViewList_Click);
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.numericUpDownID);
            this.groupBoxStudent.Controls.Add(this.textBoxSurname);
            this.groupBoxStudent.Controls.Add(this.idLabel);
            this.groupBoxStudent.Controls.Add(this.surnameLabel);
            this.groupBoxStudent.Controls.Add(this.nameLabel);
            this.groupBoxStudent.Controls.Add(this.textBoxName);
            this.groupBoxStudent.Location = new System.Drawing.Point(189, 301);
            this.groupBoxStudent.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStudent.Size = new System.Drawing.Size(282, 203);
            this.groupBoxStudent.TabIndex = 2;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Student";
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(129, 149);
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(100, 29);
            this.numericUpDownID.TabIndex = 5;
            this.numericUpDownID.ValueChanged += new System.EventHandler(this.numericUpDownID_ValueChanged);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(129, 98);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 29);
            this.textBoxSurname.TabIndex = 4;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(87, 149);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(36, 22);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID:";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(22, 101);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(101, 22);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Surname:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(54, 52);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(69, 22);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(129, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 29);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // groupBoxGrades
            // 
            this.groupBoxGrades.Controls.Add(this.textBoxGrade2);
            this.groupBoxGrades.Controls.Add(this.textBoxGrade1);
            this.groupBoxGrades.Controls.Add(this.clearBtn);
            this.groupBoxGrades.Controls.Add(this.updateGradesBtn);
            this.groupBoxGrades.Controls.Add(this.calculateBtn);
            this.groupBoxGrades.Controls.Add(this.textBoxState);
            this.groupBoxGrades.Controls.Add(this.label1);
            this.groupBoxGrades.Controls.Add(this.gradeAvgLabel);
            this.groupBoxGrades.Controls.Add(this.grade2Label);
            this.groupBoxGrades.Controls.Add(this.grade1Label);
            this.groupBoxGrades.Controls.Add(this.textBoxAvg);
            this.groupBoxGrades.Location = new System.Drawing.Point(479, 301);
            this.groupBoxGrades.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxGrades.Name = "groupBoxGrades";
            this.groupBoxGrades.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxGrades.Size = new System.Drawing.Size(275, 365);
            this.groupBoxGrades.TabIndex = 3;
            this.groupBoxGrades.TabStop = false;
            this.groupBoxGrades.Text = "Grades";
            // 
            // textBoxGrade2
            // 
            this.textBoxGrade2.Location = new System.Drawing.Point(155, 95);
            this.textBoxGrade2.Name = "textBoxGrade2";
            this.textBoxGrade2.Size = new System.Drawing.Size(100, 29);
            this.textBoxGrade2.TabIndex = 22;
            this.textBoxGrade2.ValueChanged += new System.EventHandler(this.textBoxGrade2_ValueChanged);
            // 
            // textBoxGrade1
            // 
            this.textBoxGrade1.Location = new System.Drawing.Point(155, 49);
            this.textBoxGrade1.Name = "textBoxGrade1";
            this.textBoxGrade1.Size = new System.Drawing.Size(100, 29);
            this.textBoxGrade1.TabIndex = 6;
            this.textBoxGrade1.ValueChanged += new System.EventHandler(this.textBoxGrade1_ValueChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(56, 325);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(164, 40);
            this.clearBtn.TabIndex = 21;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // updateGradesBtn
            // 
            this.updateGradesBtn.Location = new System.Drawing.Point(56, 279);
            this.updateGradesBtn.Name = "updateGradesBtn";
            this.updateGradesBtn.Size = new System.Drawing.Size(164, 40);
            this.updateGradesBtn.TabIndex = 20;
            this.updateGradesBtn.Text = "UPDATE";
            this.updateGradesBtn.UseVisualStyleBackColor = true;
            this.updateGradesBtn.Click += new System.EventHandler(this.updateGradesBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(56, 233);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(164, 40);
            this.calculateBtn.TabIndex = 19;
            this.calculateBtn.Text = "CALCULATE";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(155, 184);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(100, 29);
            this.textBoxState.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "State:";
            // 
            // gradeAvgLabel
            // 
            this.gradeAvgLabel.AutoSize = true;
            this.gradeAvgLabel.Location = new System.Drawing.Point(80, 145);
            this.gradeAvgLabel.Name = "gradeAvgLabel";
            this.gradeAvgLabel.Size = new System.Drawing.Size(57, 22);
            this.gradeAvgLabel.TabIndex = 10;
            this.gradeAvgLabel.Text = "AVG:";
            // 
            // grade2Label
            // 
            this.grade2Label.AutoSize = true;
            this.grade2Label.Location = new System.Drawing.Point(52, 101);
            this.grade2Label.Name = "grade2Label";
            this.grade2Label.Size = new System.Drawing.Size(85, 22);
            this.grade2Label.TabIndex = 9;
            this.grade2Label.Text = "Grade2:";
            // 
            // grade1Label
            // 
            this.grade1Label.AutoSize = true;
            this.grade1Label.Location = new System.Drawing.Point(52, 52);
            this.grade1Label.Name = "grade1Label";
            this.grade1Label.Size = new System.Drawing.Size(85, 22);
            this.grade1Label.TabIndex = 6;
            this.grade1Label.Text = "Grade1:";
            // 
            // textBoxAvg
            // 
            this.textBoxAvg.Location = new System.Drawing.Point(155, 142);
            this.textBoxAvg.Name = "textBoxAvg";
            this.textBoxAvg.Size = new System.Drawing.Size(100, 29);
            this.textBoxAvg.TabIndex = 8;
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(18, 301);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(164, 40);
            this.studentBtn.TabIndex = 11;
            this.studentBtn.Text = "STUDENT LIST";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(18, 350);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(164, 40);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(18, 396);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(164, 40);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "DELETE(id)";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(18, 442);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(164, 40);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "UPDATE(id)";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(18, 488);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(164, 40);
            this.findBtn.TabIndex = 15;
            this.findBtn.Text = "FIND";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // lectureBtn
            // 
            this.lectureBtn.Location = new System.Drawing.Point(18, 534);
            this.lectureBtn.Name = "lectureBtn";
            this.lectureBtn.Size = new System.Drawing.Size(164, 40);
            this.lectureBtn.TabIndex = 16;
            this.lectureBtn.Text = "LECTURE LIST";
            this.lectureBtn.UseVisualStyleBackColor = true;
            this.lectureBtn.Click += new System.EventHandler(this.lectureBtn_Click);
            // 
            // gradesBtn
            // 
            this.gradesBtn.Location = new System.Drawing.Point(18, 580);
            this.gradesBtn.Name = "gradesBtn";
            this.gradesBtn.Size = new System.Drawing.Size(164, 40);
            this.gradesBtn.TabIndex = 17;
            this.gradesBtn.Text = "GRADES LIST";
            this.gradesBtn.UseVisualStyleBackColor = true;
            this.gradesBtn.Click += new System.EventHandler(this.gradesBtn_Click);
            // 
            // prosedurBtn
            // 
            this.prosedurBtn.Location = new System.Drawing.Point(18, 626);
            this.prosedurBtn.Name = "prosedurBtn";
            this.prosedurBtn.Size = new System.Drawing.Size(164, 40);
            this.prosedurBtn.TabIndex = 18;
            this.prosedurBtn.Text = "PROSEDURE";
            this.prosedurBtn.UseVisualStyleBackColor = true;
            this.prosedurBtn.Click += new System.EventHandler(this.prosedurBtn_Click);
            // 
            // groupBoxLectures
            // 
            this.groupBoxLectures.Controls.Add(this.textBoxLectureID);
            this.groupBoxLectures.Controls.Add(this.lectureIDLabel);
            this.groupBoxLectures.Controls.Add(this.lectureNameLabel);
            this.groupBoxLectures.Controls.Add(this.textBoxLectureName);
            this.groupBoxLectures.Location = new System.Drawing.Point(189, 512);
            this.groupBoxLectures.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLectures.Name = "groupBoxLectures";
            this.groupBoxLectures.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLectures.Size = new System.Drawing.Size(282, 154);
            this.groupBoxLectures.TabIndex = 6;
            this.groupBoxLectures.TabStop = false;
            this.groupBoxLectures.Text = "Lectures";
            // 
            // textBoxLectureID
            // 
            this.textBoxLectureID.Location = new System.Drawing.Point(158, 98);
            this.textBoxLectureID.Name = "textBoxLectureID";
            this.textBoxLectureID.Size = new System.Drawing.Size(100, 29);
            this.textBoxLectureID.TabIndex = 4;
            // 
            // lectureIDLabel
            // 
            this.lectureIDLabel.AutoSize = true;
            this.lectureIDLabel.Location = new System.Drawing.Point(40, 101);
            this.lectureIDLabel.Name = "lectureIDLabel";
            this.lectureIDLabel.Size = new System.Drawing.Size(112, 22);
            this.lectureIDLabel.TabIndex = 2;
            this.lectureIDLabel.Text = "Lecture ID:";
            // 
            // lectureNameLabel
            // 
            this.lectureNameLabel.AutoSize = true;
            this.lectureNameLabel.Location = new System.Drawing.Point(7, 52);
            this.lectureNameLabel.Name = "lectureNameLabel";
            this.lectureNameLabel.Size = new System.Drawing.Size(145, 22);
            this.lectureNameLabel.TabIndex = 1;
            this.lectureNameLabel.Text = "Lecture Name:";
            // 
            // textBoxLectureName
            // 
            this.textBoxLectureName.Location = new System.Drawing.Point(158, 49);
            this.textBoxLectureName.Name = "textBoxLectureName";
            this.textBoxLectureName.Size = new System.Drawing.Size(100, 29);
            this.textBoxLectureName.TabIndex = 0;
            // 
            // FrmDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 680);
            this.Controls.Add(this.groupBoxLectures);
            this.Controls.Add(this.prosedurBtn);
            this.Controls.Add(this.gradesBtn);
            this.Controls.Add(this.lectureBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.groupBoxGrades);
            this.Controls.Add(this.groupBoxStudent);
            this.Controls.Add(this.dataGridViewList);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDesign";
            this.Text = "data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            this.groupBoxGrades.ResumeLayout(false);
            this.groupBoxGrades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxGrade2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxGrade1)).EndInit();
            this.groupBoxLectures.ResumeLayout(false);
            this.groupBoxLectures.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxGrades;
        private System.Windows.Forms.Label gradeAvgLabel;
        private System.Windows.Forms.Label grade2Label;
        private System.Windows.Forms.Label grade1Label;
        private System.Windows.Forms.TextBox textBoxAvg;
        private System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button lectureBtn;
        private System.Windows.Forms.Button gradesBtn;
        private System.Windows.Forms.Button prosedurBtn;
        private System.Windows.Forms.GroupBox groupBoxLectures;
        private System.Windows.Forms.TextBox textBoxLectureID;
        private System.Windows.Forms.Label lectureIDLabel;
        private System.Windows.Forms.Label lectureNameLabel;
        private System.Windows.Forms.TextBox textBoxLectureName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateGradesBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.NumericUpDown numericUpDownID;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.NumericUpDown textBoxGrade2;
        private System.Windows.Forms.NumericUpDown textBoxGrade1;
    }
}

