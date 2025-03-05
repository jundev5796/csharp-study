using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9_part8_inheritance
{
    // call base parent
    class Parent
    {
        public virtual void ShowMessage()
        {
            Console.WriteLine("parent class message");
        }
    }

    class Child : Parent
    {
        public override void ShowMessage()
        {
            Console.WriteLine("child class message");
            base.ShowMessage();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.ShowMessage();
        }
    }
}
