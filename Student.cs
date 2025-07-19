using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class Student : Person
    {
        public double GradeLevel;

        public Student(string fristName, string lastName, int age, double gradelevel) : base(fristName, lastName, age)
        {
            GradeLevel = gradelevel;
        }

        public double gradelevel
        {
            get { return GradeLevel; }
            set { GradeLevel = value; }

        }

        public override string GetDetails()
        {
            return $"{fristname} {lastname} {gradelevel}";
        }

    }
}
