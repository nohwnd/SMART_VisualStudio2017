using System;
using System.Runtime.InteropServices.ComTypes;

namespace Csharp7
{
    class TupleDeconstruction
    {
        internal void DeconstructTuple()
        {
            var tuple = (1, 3, 5);


            // deconstruct to new variables
            var (a,b,c) = tuple;


            // deconstruct to existing variables
            int g, e, f =0;

            (g,e,f) = tuple;
        }
    }

    class Deconstructable
    {
        public Deconstructable(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        // special method that allows you to define type specific deconstructions
        // (also available as extension method)
        internal void Deconstruct(out string name, out int age)
        {
            name = Name;
            age = Age;
        }
    }

    class Deconstructor
    {
        void GetClassData()
        {
            
             var d  = new Deconstructable("Jakub", 28);


            (string name, int age) = d;


            // now I have two new local variables
            // string name and int age 

            var a = age;
            var n = name;
        }
    }
}
