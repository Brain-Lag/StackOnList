using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOnList.Exceptions
{
    internal class ContainerException : Exception
    {
        public ContainerException(string message) : base(message) { }
    }
}
