using System;

namespace ConsoleApp3
{
    public class Student
    {
        private String rollNumber;
        private String name;
        private String email;

        public Student()
        {
        }

        public Student(string rollNumber, string name, string email)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.email = email;
        }

        public string RollNumber
        {
            get => rollNumber;
            set => rollNumber = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}