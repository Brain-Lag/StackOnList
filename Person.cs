using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOnList
{
    internal struct Person : IComparable
    {   
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name; Age = age;
        }

        public int CompareTo(object? o)
        {
            if (o is Person person) return Name.CompareTo(person.Name);
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
}
