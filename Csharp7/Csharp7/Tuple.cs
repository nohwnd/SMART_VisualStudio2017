using System;


namespace Csharp7
{
    internal class PlaygroundTuple
    {
        public void BuildTuple()
        {

            //infers the types 
            var simpleTuple = (1, "a");

            var a = simpleTuple.Item1;
            var b = simpleTuple.Item2;


            var simpleTuple2 = new ValueTuple<int, string>(1, "a");

            var c = simpleTuple2.Item1;
            var d = simpleTuple2.Item2;

            // -- example --

            var namedTuple = (number: 1, text: "a");
            var e = namedTuple.number;
            var f = namedTuple.text;


            (int number, string text) namedTuple2 = (1, "a");
            var g = namedTuple2.number;
            var h = namedTuple2.text;

            //but this won't pass the names through
            (int, string) simpleTuple3 = (number: 1, text: "a");

            // -- example --


            //the names are just syntactic sugar

            var me = new { Name = "Jakub", Age = 28 };
            var me2 = new { FirstName = "Jakub", Years = 28 };

            //does not compile because they are different types
            // me = me2;

            var meTuple = (name: "Jakub", age: 28);
            var meTuple2 = (firstName: "Jakub", years: 28);

            //works just fine because they are structurally the same, just the metadata differ
            meTuple = meTuple2;


            // -- example --
        }


    }

    // useful as return types (but not necessarily for public methods)
    internal static class Math2
    {
        static (int result, int reminder) Divide(int dividend, int divisor)
        {
            return (dividend / divisor, dividend % divisor);
        }
    }

    // or to hold correlated values 
    internal class Session
    {
        private (int r, int g, int b) color = new ValueTuple<int, int, int>();

        // ...
    }

    // you can also use it to simplify try pattern 
    internal class Int2
    {
        static (bool success, int value) TryParse(string text)
        {
            return (int.TryParse(text, out int parsed), parsed);
        }

        // nicer naming but harder to explain
        static (bool success, int value) TryParse2(string value)
        {
            return (int.TryParse(value, out int parsed), parsed);
        }
    }
}
