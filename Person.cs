using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class Person
    {
        private string FristName;
        private string LastName;
        private int Age;

        public string fristname
        {
            get {  return FristName; }
            set { FristName = value; }
        }

        public string lastname
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public int age
        {
            get { return Age; }
            set
            {
                if (value >= 0) Age = value;
                else Age = 0;
            }
        }

        public Person(string fristName, string lastName, int age)
        {
            
            FristName = fristName;
            LastName = lastName;
            Age = age;
            
        }

        public virtual string GetDetails()
        {
            return $"{FristName} {LastName} {Age}";

        }

    }
}
