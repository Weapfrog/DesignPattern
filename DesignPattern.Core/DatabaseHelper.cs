using DesignPattern.Core.Common;
using DesignPattern.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core
{
    public class DatabaseHelper : IDatabaseHelper
    {
        private readonly string ConnectionString;
        SqlConnection connection;
        public DatabaseHelper()
        {
            ConnectionString = ConnectionHelper.ConnectionString;
            this.connection = new SqlConnection(ConnectionString);
        }
        public (bool Success, string Message) Insert(Students student)
        {
            try
            {
                if (this.connection.State == System.Data.ConnectionState.Closed)
                {
                    this.connection.Open();
                }

                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("StudentName", student.StudentName);
                cmd.Parameters.AddWithValue("StudentSurname", student.StudentSurname);
                cmd.CommandText = "INSERT INTO Students(StudentName,StudentSurname) VALUES(@StudentName,@StudentSurname)";
                cmd.Connection = connection;
                var exception = cmd.ExecuteNonQuery();
                if (exception == 1)
                {
                    this.connection.Close();
                    return (true, "Student added!");
                }
                else
                {
                    this.connection.Close();
                    return (false, "Failed!");
                }

            }
            catch (Exception ex)
            {
                this.connection.Close();
                return (false, ex.ToString());
            }
        }
        public (bool Success, string Message) Insert(Lectures lecture)
        {
            try
            {
                if (this.connection.State == System.Data.ConnectionState.Closed)
                {
                    this.connection.Open();
                }

                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("LectureName", lecture.LectureName);
                cmd.CommandText = "INSERT INTO Lectures(LectureName) VALUES(@LectureName)";
                cmd.Connection = connection;
                var exception = cmd.ExecuteNonQuery();
                if (exception == 1)
                {
                    this.connection.Close();
                    return (true, "Lecture added!");
                }
                else
                {
                    this.connection.Close();
                    return (false, "Failed!");
                }

            }
            catch (Exception ex)
            {
                this.connection.Close();
                return (false, ex.ToString());
            }
        }
        public (bool Success, string Message, List<Students> studentTable, List<Lectures> lectureTable, List<Grades> gradesTable) Select(string tableName)
        {
            if (tableName == "Students")
            {
                List<Students> student = new List<Students>();
                try
                {
                    if (this.connection.State == System.Data.ConnectionState.Closed)
                    {
                        this.connection.Open();
                    }

                    SqlCommand cmd = new SqlCommand();
                    string query = "SELECT * FROM Students";
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var StudentID = reader.GetInt32(0);
                        var StudentName = reader.GetString(1);
                        var StudentSurname = reader.GetString(2);

                        Students students = new Students()
                        {
                            StudentID = StudentID,
                            StudentName = StudentName,
                            StudentSurname = StudentSurname
                        };
                        student.Add(students);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    this.connection.Close();
                    return (false, ex.ToString(), student, new List<Lectures>(), new List<Grades>());
                }
                return (true, "Success", student, new List<Lectures>(), new List<Grades>());
            }
            else if (tableName == "Lectures")
            {
                List<Lectures> lecture = new List<Lectures>();
                try
                {
                    if (this.connection.State == System.Data.ConnectionState.Closed)
                    {
                        this.connection.Open();
                    }

                    SqlCommand cmd = new SqlCommand();
                    string query = "SELECT * FROM Lectures";
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var LectureID = reader.GetInt32(0);
                        var LectureName = reader.GetString(1);

                        Lectures lectures = new Lectures()
                        {
                            LectureID = LectureID,
                            LectureName = LectureName,
                        };
                        lecture.Add(lectures);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    this.connection.Close();
                    return (false, ex.ToString(), new List<Students>(), lecture, new List<Grades>());
                }
                return (true, "Success", new List<Students>(), lecture, new List<Grades>());
            }
            else if (tableName == "Grades")
            {
                List<Grades> grade = new List<Grades>();
                try
                {
                    if (this.connection.State == System.Data.ConnectionState.Closed)
                    {
                        this.connection.Open();
                    }

                    SqlCommand cmd = new SqlCommand();
                    string query = "SELECT * FROM Grades";
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var GradesID = reader.GetInt32(0);
                        var StudentID = reader.GetInt32(1);
                        var LectureID = reader.GetInt32(2);
                        var Grade1 = reader.GetInt32(3);
                        var Grade2 = reader.GetInt32(4);
                        var Average = reader.GetInt32(5);
                        var StudentState = reader.GetBoolean(6);

                        Grades grades = new Grades()
                        {
                            GradeID = GradesID,
                            StudentID = StudentID,
                            LectureID = LectureID,
                            Grade1 = Grade1,
                            Grade2 = Grade2,
                            Average = Average,
                            StudentState = StudentState
                        };
                        grade.Add(grades);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    this.connection.Close();
                    return (false, ex.ToString(), new List<Students>(), new List<Lectures>(), grade);
                }
                return (true, "Success", new List<Students>(), new List<Lectures>(), grade);
            }
            return (false, "Select a table!", new List<Students>(), new List<Lectures>(), new List<Grades>());

        }
        public (bool Success, string Message) Delete(int studentID)
        {
            try
            {
                if (this.connection.State == System.Data.ConnectionState.Closed)
                {
                    this.connection.Open();
                }

                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("StudentID", studentID);
                var query = "DELETE FROM Students WHERE StudentID = @StudentID";
                cmd.CommandText = query;
                cmd.Connection = connection;
                var exception = cmd.ExecuteNonQuery();

                if (exception == 1)
                {
                    this.connection.Close();
                    return (true, "Deleted!");
                }
                else
                {
                    this.connection.Close();
                    return (false, "Delete operation failed!");
                }

            }
            catch (Exception ex)
            {

                this.connection.Close();
                return (false, ex.ToString());
            }
        }
        public (bool Success, string Message) Update(Students student)
        {
            try
            {
                if (this.connection.State == System.Data.ConnectionState.Closed)
                {
                    this.connection.Open();
                }

                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("StudentID", student.StudentID);
                cmd.Parameters.AddWithValue("StudentName", student.StudentName);
                cmd.Parameters.AddWithValue("StudentSurname", student.StudentSurname);
                var query = @"UPDATE Students SET StudentName = @StudentName, 
                            StudentSurname = @StudentSurname WHERE StudentID = @StudentID";
                cmd.CommandText = query;
                cmd.Connection = connection;
                var exception = cmd.ExecuteNonQuery();
                if (exception == 1)
                {
                    this.connection.Close();
                    return (true, "Update student successful!");
                }
                else
                {
                    this.connection.Close();
                    return (false, "Student update is failed!");
                }

            }
            catch (Exception ex)
            {
                this.connection.Close();
                return (false, ex.ToString());
            }
        }
        public (bool Success, string Message) Update(Grades grade)
        {
            try
            {
                if (this.connection.State == System.Data.ConnectionState.Closed)
                {
                    this.connection.Open();
                }

                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("GradeID", grade.GradeID);
                cmd.Parameters.AddWithValue("Grade1", grade.Grade1);
                cmd.Parameters.AddWithValue("Grade2", grade.Grade2);
                cmd.Parameters.AddWithValue("Average", (grade.Grade1 + grade.Grade2)/2);
                cmd.Parameters.AddWithValue("StudentState", ((grade.Grade1 + grade.Grade2) / 2) > 50);
                var query = @"UPDATE Grades SET Grade1 = @Grade1, 
                            Grade2 = @Grade2, Average= @Average, StudentState = @StudentState WHERE GradeID = @GradeID";
                cmd.CommandText = query;
                cmd.Connection = connection;
                var exception = cmd.ExecuteNonQuery();
                if (exception == 1)
                {
                    this.connection.Close();
                    return (true, "Update grade successful!");
                }
                else
                {
                    this.connection.Close();
                    return (false, "Grade update is failed!");
                }

            }
            catch (Exception ex)
            {
                this.connection.Close();
                return (false, ex.ToString());
            }
        }
        public (bool Success, string Message, List<Students> table) Find(Students student)
        {
            List<Students> students = new List<Students>();
            try
            {
                if (this.connection.State == System.Data.ConnectionState.Closed)
                {
                    this.connection.Open();
                }

                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@StudentName", "%" + student.StudentName + "%");
                cmd.Parameters.AddWithValue("@StudentSurname", "%" + student.StudentSurname + "%");
                cmd.Parameters.AddWithValue("@StudentID", student.StudentID);

                var query = @"SELECT * FROM Students WHERE StudentName LIKE @StudentName OR StudentSurname LIKE @StudentSurname OR StudentID=@StudentID; ";
                cmd.CommandText = query;
                cmd.Connection = connection;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var StudentID = reader.GetInt32(0);
                    var StudentName = reader.GetString(1);
                    var StudentSurname = reader.GetString(2);

                    Students contains = new Students()
                    {
                        StudentID = StudentID,
                        StudentName = StudentName,
                        StudentSurname = StudentSurname
                    };
                    students.Add(contains);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                this.connection.Close();
                return (false, ex.ToString(), students);
            }
            return (true, "Success!", students);
        }
        public (bool Success, string Message, List<Procedure> table) Procedure()
        {
            List<Procedure> procedures = new List<Procedure>();
            try
            {
                if (this.connection.State == System.Data.ConnectionState.Closed)
                    this.connection.Open();
                SqlCommand cmd = new SqlCommand();
                string query = @"SELECT Grades.GradeID,Students.StudentName + ' ' + Students.StudentSurname AS StudentName,
                               Lectures.LectureName,Grades.Grade1,Grades.Grade2,Grades.Average,
                               Grades.StudentState FROM Grades INNER JOIN Students ON Grades.StudentID = Students.StudentID
                               INNER JOIN Lectures ON Grades.LectureID = Lectures.LectureID";
                cmd.CommandText = query;
                cmd.Connection = connection;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var GradeID = reader.GetInt32(0);
                    var StudentName = reader.GetString(1);
                    var LectureName = reader.GetString(2);
                    var Grade1 = reader.GetInt32(3);
                    var Grade2 = reader.GetInt32(4);
                    var Average = reader.GetInt32(5);
                    var StudentState = reader.GetBoolean(6);

                    Procedure procedure = new Procedure()
                    {
                        GradeID = GradeID,
                        StudentName = StudentName,
                        LectureName = LectureName,
                        Grade1 = Grade1,
                        Grade2 = Grade2,
                        Average = Average,
                        StudentState = StudentState
                    };
                    procedures.Add(procedure);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                this.connection.Close();
                return (false, ex.ToString(), procedures);
            }
            this.connection.Close();
            return (true, "Procedure!", procedures);
        }
        public (bool Success, string Message,List<Grades> tableGrades,List<Lectures> tableLectures,List<Students> tableStudents) Find (int tableID,string tableName)
        {
            List<Grades> grade = new List<Grades>();
            List<Lectures> lecture = new List<Lectures>();
            List<Students> student = new List<Students>();

            if(tableName == "Grades")
            {
                try
                {
                    if (this.connection.State == System.Data.ConnectionState.Closed)
                    {
                        this.connection.Open();
                    }

                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("GradeID", tableID);
                    string query = "SELECT * FROM Grades WHERE GradeID = @GradeID";
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var GradesID = reader.GetInt32(0);
                        var StudentID = reader.GetInt32(1);
                        var LectureID = reader.GetInt32(2);
                        var Grade1 = reader.GetInt32(3);
                        var Grade2 = reader.GetInt32(4);
                        var Average = reader.GetInt32(5);
                        var StudentState = reader.GetBoolean(6);

                        Grades grades = new Grades()
                        {
                            GradeID = GradesID,
                            StudentID = StudentID,
                            LectureID = LectureID,
                            Grade1 = Grade1,
                            Grade2 = Grade2,
                            Average = Average,
                            StudentState = StudentState
                        };
                        grade.Add(grades);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    this.connection.Close();
                    return (false, ex.ToString(), grade,lecture,student);
                }
                return (true, "Success", grade,lecture,student);
            }
            else if(tableName == "Lectures")
            {
                try
                {
                    if (this.connection.State == System.Data.ConnectionState.Closed)
                    {
                        this.connection.Open();
                    }

                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("LectureID", tableID);
                    string query = "SELECT * FROM Lectures WHERE LectureID = @LectureID";
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var LectureID = reader.GetInt32(0);
                        var LectureName = reader.GetString(1);

                        Lectures lectures = new Lectures()
                        {
                            LectureID = LectureID,
                            LectureName = LectureName
                        };
                        lecture.Add(lectures);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    this.connection.Close();
                    return (false, ex.ToString(), grade,lecture,student);
                }
                return (true, "Success", grade,lecture,student);
            }
            else if (tableName == "Students")
            {
                try
                {
                    if (this.connection.State == System.Data.ConnectionState.Closed)
                    {
                        this.connection.Open();
                    }

                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("StudentID", tableID);
                    string query = "SELECT * FROM Students WHERE StudentID = @StudentID";
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var LectureID = reader.GetInt32(0);
                        var LectureName = reader.GetString(1);

                        Students students = new Students()
                        {
                            StudentID = reader.GetInt32(0),
                            StudentName = reader.GetString(1),
                            StudentSurname = reader.GetString(2)
                        };
                        student.Add(students);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    this.connection.Close();
                    return (false, ex.ToString(), grade, lecture,student);
                }
                return (true, "Success", grade, lecture,student);
            }


            return (false, "Select a table name",grade,lecture,student);

        }

    }
}
