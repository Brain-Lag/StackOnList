﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOnList.Exceptions
{
    internal class ContainerCapacityException : ContainerException
    {
        public ContainerCapacityException(string message) : base(message) 
        {
        }
    }
}
