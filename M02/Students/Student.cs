using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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

            string n = "";
            Regex spliters = new Regex("[@.0-9]");
            string[] name = spliters.Split(email);
            for (int i = 0; i <= 1; i++)
            {
                n = name[i];
                name[i] = char.ToUpper(n[0]) + n.Substring(1);
            }
            FullName = name[0] + ' ' + name[1];

        }
        public Student(string name, string surname)
        {
            FullName = name + ' ' + surname;
            Email = name.ToLower() + '.' + surname.ToLower() + "@epam.com";
        }
    }
}
