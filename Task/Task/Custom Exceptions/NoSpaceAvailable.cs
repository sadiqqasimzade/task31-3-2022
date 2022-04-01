using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Custom_Exceptions
{
    internal class NoSpaceAvailable : Exception
    {
        public NoSpaceAvailable()
        { }
        public NoSpaceAvailable(string message) : base(message)
        {
        }
    }
}
