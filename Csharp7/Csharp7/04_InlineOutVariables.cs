using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp7
{
    public class InlineOutVariables
    {
        void _()
        {
            // C# 6
            int a;
            int.TryParse("1", out a);

            // C# 7
            int.TryParse("1", out var b);










            // scoping trouble



            int c;
            if (int.TryParse("1", out c))
            {
                Use(c);
            }

            // and it is still available here
            Use(c);


            if (int.TryParse("1", out var d))
            {
                // we need d here
                Use(d);
            }

            // and it is available here (but was not in some versions of C# 7)
            Use(d);

            // same for while
           


            // but it does not always escape the scope (in for, foreach, using and while)
            for (int.TryParse("1", out var h);;)
            {
                Use(h);
            }

            // but it's not available here
            //use(h);

            while (int.TryParse("1", out var e))
            {
                Use(e);
            }

            // but it's not available here
            // use(e);

            // and for switch it works yet another way, and it scopes to a single case


        }

        public void Use(int i)
        {
        }
    }
}
