using DesignPattern.Domain;
using System.Collections.Generic;

namespace DesignPattern.Core
{
    public interface IDatabaseHelper
    {
        (bool Success,string Message) Insert(Students student);
        (bool Success, string Message) Insert(Lectures lecture);
        (bool Success, string Message,List<Students> studentTable,List<Lectures> lectureTable,List<Grades> gradesTable) Select(string tableName);
        (bool Success, string Message) Delete(int studentID);
        (bool Success, string Message) Update(Students student);
        (bool Success, string Message) Update(Grades grade);
        (bool Success, string Message,List<Students> table) Find(Students student);
        (bool Success, string Message, List<Grades> tableGrades, List<Lectures> tableLectures,List<Students> tableStudents) Find(int tableID,string tableName);
        (bool Success, string Message, List<Procedure> table) Procedure();
    }
}