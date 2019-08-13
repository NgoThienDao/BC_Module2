using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Student
{
    class Student
    {
        private String name = "Dao";
        private int age = 23;
        private String class_Student = "C06";
        private String school = "CodeGym";

        public Student()
        {

        }

        public Student(string name, int age, string class_Student, string school)
        {
            this.name = name;
            this.age = age;
            this.class_Student = class_Student;
            this.school = school;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Class_Student
        {
            get { return class_Student; }
            set { Class_Student = value; }
        }

        public string School
        {
            get { return school; }
            set { school = value; }
        }
    }
}
