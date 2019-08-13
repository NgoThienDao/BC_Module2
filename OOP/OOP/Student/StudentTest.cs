using System;
using System.Collections.Generic;
using System.Text;
using OOP.Student;

namespace OOP.Student
{
    class StudentTest
    {
        static void Main()
        {
            Student student = new Student();
            Console.WriteLine("Name: {0}", student.Name);
            Console.WriteLine("Age: {0}", student.Age);
            Console.WriteLine("Class: {0}", student.Class_Student);
            Console.WriteLine("School: {0}", student.School);
            Console.ReadKey();
        }
    }
}
