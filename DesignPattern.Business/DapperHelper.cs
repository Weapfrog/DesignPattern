using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DesignPattern.Core.Common;
using DesignPattern.Core;
using DesignPattern.Domain;

namespace DesignPattern.Business
{
    public class DapperHelper
    {
        private readonly string ConnectionString;
        SqlConnection connection;

        public DapperHelper()
        {
            ConnectionString = ConnectionHelper.ConnectionString;
            this.connection = new SqlConnection(ConnectionString);
        }

        public List<Students> ListStudents()
        {
            try
            {
                if (this.connection.State == System.Data.ConnectionState.Closed)
                    this.connection.Open();

                return connection.Query<Students>("SELECT * FROM Students", null, null, true, null, System.Data.CommandType.Text).ToList();

            }
            catch (Exception ex)
            {

                return new List<Students>();
            }

        }
        public List<Lectures> ListLectures()
        {
            try
            {
                if (this.connection.State == System.Data.ConnectionState.Closed)
                    this.connection.Open();

                return connection.Query<Lectures>("SELECT * FROM Lectures", null, null, true, null, System.Data.CommandType.Text).ToList();

            }
            catch (Exception ex)
            {

                return new List<Lectures>();
            }

        }
        public List<Grades> ListGrades()
        {
            try
            {
                if (this.connection.State == System.Data.ConnectionState.Closed)
                    this.connection.Open();

                return connection.Query<Grades>("SELECT * FROM Grades", null, null, true, null, System.Data.CommandType.Text).ToList();

            }
            catch (Exception ex)
            {

                return new List<Grades>();
            }

        }
        public List<Procedure> ListProcedure()
        {
            try
            {
                if (this.connection.State == System.Data.ConnectionState.Closed)
                    this.connection.Open();

                string query = @"SELECT Grades.GradeID,Students.StudentName + ' ' + Students.StudentSurname AS StudentName,
                               Lectures.LectureName,Grades.Grade1,Grades.Grade2,Grades.Average,
                               Grades.StudentState FROM Grades INNER JOIN Students ON Grades.StudentID = Students.StudentID
                               INNER JOIN Lectures ON Grades.LectureID = Lectures.LectureID";
                return connection.Query<Procedure>(query, null, null, true, null, System.Data.CommandType.Text).ToList();

            }
            catch (Exception ex)
            {

                return new List<Procedure>();
            }
        }

    }
}
