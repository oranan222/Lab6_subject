using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_subject
{
    internal abstract class Person
    {
        protected string name;
        public Person(string name)
        {
            this.name = name;
        }
        public abstract void Display();
    }
}
