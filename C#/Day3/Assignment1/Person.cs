using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        // Fields
        private string name;
        private int age;

        // Properties
        protected string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Fields With different access modifiers
        internal string internalField = "Internal Field";
        protected string protectedField = "Protected Field";
        protected internal string protectedInternalField = "Protected Internal Field";

        // Method
        public void ShowData()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        // Aggregation / Assosiation (person has favorite color)
        public Color FavoriteColor { get; set; }

        public void ShowFavoriteColor()
        {
            if (FavoriteColor != null)
            {
                Console.WriteLine($"Favorite Color: {FavoriteColor.Name}");
            }
            else
            {
                Console.WriteLine("No favorite color set.");
            }
        }
    }


}
