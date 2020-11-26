using System;

namespace Students
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] subjects = { "Math", "PE", "English", "Literature", "Physics", "IT" };

            Student st1 = new Student("alexandr.alexandrov@epam.com");
            Student st2 = new Student("boris.borisov@epam.com");
            Student st3 = new Student("vasiliy.vasilyev@epam.com");

            Student st4 = new Student("Alexandr", "Alexandrov");
            Student st5 = new Student("Boris", "Borisov");
            Student st6 = new Student("Vasiliy", "Vasilyev");



        }
    }
}
