using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace Csharp7
{
    class ExpressionBodies
    {
        string Property6 => "hello";
        string Method6() => "hello";



        string _property7;
        string Property7
        {
            // you can use expression bodies in properties;
            get => _property7;
            set => _property7 = value;
        }
    }



    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //you can use expression body for constructor and destructor
        // and you can combine it with tuples for syntax that looks nothing like C#
        public User(string name, int age) => (Name, Age) = (name, age);
        

    
        // you can also do stuff like this: 

        //define a way to deconstruct our object
        public void Deconstruct(out string name, out int age) => (name, age) = (Name, Age);
        //and use that to populate another object
        public void CopyTo(User other) => (other.Name, other.Age) = this;
    }
}
