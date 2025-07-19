using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class Admin:Person
    {
        public Role Role { get; set; }

        public Admin(string fristName, string lastName, int age,Role role) : base(fristName, lastName, age)
        {
            Role = role;
        }

        public override string GetDetails()
        {
            return $"{fristname} {lastname} {Role}";
        }

    }
}
