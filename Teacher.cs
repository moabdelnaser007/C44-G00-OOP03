using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class Teacher : Person
    {
        public string Subject;

        public string subject
        {
            get {  return Subject; }
            set { Subject = value; }
        }

        public Teacher(string fristName, string lastName, int age, string subject) : base(fristName, lastName, age)
        {
            Subject = subject;
            
        }

        public override string GetDetails()
        {
            return $"{fristname} {lastname} {subject}";
        }
    }
}
