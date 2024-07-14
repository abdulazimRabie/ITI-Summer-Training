using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Child : Person
    {
        public void ShowFields()
        {
            Console.WriteLine(internalField);  // Accessible because it's internal within the same assembly
            Console.WriteLine(protectedField); // Accessible because it's protected and this is a derived class
            Console.WriteLine(protectedInternalField); // Accessible because it's protected internal and this is a derived class within the same assembly
        }

        public void SetData(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

}
