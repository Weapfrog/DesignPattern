using DesignPattern.Core;
using DesignPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Business
{
    public class UnitOfWork : IUnitOfWork
    {
        IDatabaseHelper helper = new DatabaseHelper();

        public (bool Success, string Message) Insert(Students student)
        {
            try
            {
                var response = helper.Insert(student);
                return (true, "Success!");
            }
            catch (Exception ex)
            {
                return (false, ex.ToString());
            }

        }
        public (bool Success, string Message) Insert(Lectures lecture)
        {
            try
            {
                var response = helper.Insert(lecture);
                return (true, response.Message);
            }
            catch (Exception ex)
            {
                return (false, ex.ToString());
            }

        }
        public (bool Success, string Message, List<Students> studentTable, List<Lectures> lectureTable, List<Grades> gradesTable) Select(string tableName)
        {
            var response = helper.Select(tableName);
            try
            {
                return (true, "Success!", response.studentTable, response.lectureTable, response.gradesTable);
            }
            catch (Exception ex)
            {
                return (false, ex.ToString(), response.studentTable, response.lectureTable, response.gradesTable);
            }


        }
        public (bool Success, string Message) Delete(int studentID)
        {
            try
            {
                var response = helper.Delete(studentID);
                return (true, "Deleted!");
            }
            catch (Exception ex)
            {
                return (false, ex.ToString());
            }
        }
        public (bool Success, string Message) Update(Students student)
        {
            try
            {
                var response = helper.Update(student);
                return (true, "Student successfully updated!");
            }
            catch (Exception ex)
            {
                return (false, ex.ToString());
            }
        }
        public (bool Success, string Message) Update(Grades grade)
        {
            try
            {
                var response = helper.Update(grade);
                return (true, "Grade successfully updated!");
            }
            catch (Exception ex)
            {
                return (false, ex.ToString());
            }
        }
        public (bool Success, string Message, List<Students> table) Find(Students student)
        {
            var response = helper.Find(student);
            try
            {
                return (true, "Success!", response.table);
            }
            catch (Exception ex)
            {
                return (false, "Failed!", response.table);
            }
        }
        public (bool Success, string Message, List<Procedure> table) Procedure()
        {
            var response = helper.Procedure();
            try
            {
                return (true, "Procedure", response.table);
            }
            catch (Exception ex)
            {
                return (false, ex.ToString(), response.table);
            }
        }
        public (bool Success, string Message, List<Grades> tableGrades,List<Lectures> tableLectures,List<Students> tableStudents) Find(int tableID,string tableName)
        {
            var response = helper.Find(tableID,tableName);
            try
            {
                return (true, response.Message, response.tableGrades,response.tableLectures,response.tableStudents);
            }
            catch (Exception ex)
            {
                return (false, ex.ToString(), response.tableGrades,response.tableLectures,response.tableStudents);
            }
        }
    }
}
