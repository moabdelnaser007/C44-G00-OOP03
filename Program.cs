
using System.Runtime.Serialization;
using System.Threading.Channels;
using System.Xml.Schema;

namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {


           //Person p = new Person("mohamed","ali",25);

           // p.GetDetails();

           // Person s = new Student("ahmed","omar",66,3.2);

           //s.GetDetails();


           // Person t = new Teacher("khaled","waleed",45,"math");

           // t.GetDetails();

           // Person a = new Admin("abdullah","taha",47, Role.Secretary);

           // a.GetDetails();


            List<Person> people = new List<Person>();

            people.Add(new Student("Ali", "Omar", 22 ,2.7));
            people.Add(new Student("Sara", "Ibrahim", 19 ,3.6));

            people.Add(new Teacher("Mr.", "Kamal", 36 ,"Math"));

            people.Add(new Admin("Fatima", "Hassan", 41 ,Role.Coordinator));

            
            foreach (Person person in people)
            {
                Console.WriteLine(person.GetDetails());
            }

        }
    }
}
