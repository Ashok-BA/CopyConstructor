using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    public class person
    {
        public int age;
        public string name;

        public person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public person(person previousperson)
        {
            age = previousperson.age;
            name = previousperson.name;
        }

        public string Details()
        {
            return name + "is" + age.ToString();
        }
    }

    internal class program
    {
        static void Main(string[] args)
        {
            person p1 = new person(40, "sam");
            person p2 = new person(p1);
            p1.age = 39;
            p2.age = 42;
            p2.name = "rama";
            Console.WriteLine(p1.Details());
            Console.WriteLine(p2.Details());
        }
    }
}
