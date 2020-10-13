using System;
using System.Collections.Generic;


namespace MVCModelView.Models
{
    public class TeacherDAL
    {
        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher
            {
                TeacherId = 101,
                Name = "Ramesh",
                Code = "Ram101"
            });
            teachers.Add(new Teacher
            {
                TeacherId = 102,
                Name = "Ali",
                Code = "Ali102"
            });
            teachers.Add(new Teacher
            {
                TeacherId = 103,
                Name = "Chris",
                Code = "Chris103"
            });
            teachers.Add(new Teacher
            {
                TeacherId = 104,
                Name = "Bal",
                Code = "Bal104"
            });
            return teachers;

        }
    }
}