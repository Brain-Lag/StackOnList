using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOnList.Exceptions
{
    internal class IndexValueException : ValueException
    {
        public int Index;
        public IndexValueException(string message, int index) : base(message) 
        {
            Index = index;
        }
    }
}
