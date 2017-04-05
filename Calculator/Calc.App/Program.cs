using System;
using static System.Console;
using static Calc.App.Calculator;

namespace Calc.App
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("Use :quit to exit.\n");
                Write("> ");
                var line = ReadLine();
                if (line == ":quit")
                    return;

                var x = int.Parse(line[0].ToString());
                var op = line[1];
                var y = int.Parse(line[2].ToString());
                var result = Calculate(x, op, y);
                WriteLine(result);
            }
        }
    }

    public class Calculator
    {
        public static int Calculate(int x, char operation, int y)
        {
            switch (operation)
            {
                case '+':
                    return x + y;
                case '-':
                    return x - y;
                case '*':
                    return x * y;
                case '/':
                    return x / y;
                case '%':
                    return x % y;
                default:
                    return 0;
            }
        }
    }
}
