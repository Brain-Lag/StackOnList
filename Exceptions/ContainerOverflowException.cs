using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOnList.Exceptions
{
    internal class ContainerOverflowException : ContainerCapacityException
    {
        public ContainerOverflowException(string message) : base(message)
        {
        }
    }
}
