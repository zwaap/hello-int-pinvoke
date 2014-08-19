using System;
using System.Collections.Generic;
using System.Text;

namespace HelloInt
{
    internal class LibNames
    {
        internal const string HELLO_INT = 
#if __IOS__
            "__Internal";
#else
            "libhello_int";
#endif
    }
}
