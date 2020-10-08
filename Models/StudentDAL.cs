using System;
using System.Collections.Generic;


namespace MVCModelView.Models
{
    public class StudentDAL
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                Code = "St11",
                EnrollmentNo = "123",
                Name = "Test",
                StudentId = 101
            });
            students.Add(new Student
            {
                Code = "St111",
                EnrollmentNo = "1234",
                Name = "Test1",
                StudentId = 1012
            });
            students.Add(new Student
            {
                Code = "St112",
                EnrollmentNo = "12",
                Name = "Test2",
                StudentId = 1013
            });
            students.Add(new Student
            {
                Code = "St113",
                EnrollmentNo = "123456",
                Name = "Test3",
                StudentId = 1014
            });
            return students;

        }
    }
}