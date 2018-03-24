using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2
{
    /*
    class Foo
    {
        protected class Quux
        {
            public Quux()
            {
                Console.WriteLine("FOO - QUUX");
            }
        }
    }

    class Bar : Foo
    {
        new class Quux
        {
            public Quux()
            {
                Console.WriteLine("BAR - QUUX");
            }
        }
    }

    class Batman: Bar
    {
        public Batman()
        {
            new Quux();
        }
    }*/

    struct Foo
    {
        public int Value;
        public void Change(int newValue)
        {
            Value = newValue;

        }
    }

    class Bar
    {
        public Foo Foo { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*new Batman();*/

            var bar = new Bar { Foo = new Foo()};
            bar.Foo.Change(5);

            Console.WriteLine(bar.Foo.Value);
            // Будет 0, т.к. свойствео возвращает новый объект
            // так делать нельзя
        }
    }
}