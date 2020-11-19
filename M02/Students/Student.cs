using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Student
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }


        public Student()
        {
        }
        public Student(string email)
        {
            Email = email;
        }
        public Student(string name, string surname)
        {
            FullName = name + ' ' + surname;
        }
    }
}
