using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp7
{
    class ThrowExpressions
    {
        string ToUpper6 (string s)
        {
            if (s == null)
                throw new ArgumentNullException();

            return s.ToUpper();
        }

        string ToUpper7(string s)
        {
            //stupid example but before you could not throw from null-coalescing
            return (s ?? throw new ArgumentNullException()).ToUpper();
        }
    }
}
