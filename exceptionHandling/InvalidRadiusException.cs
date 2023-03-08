using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    public class InvalidRadiusException : Exception
    {
        public InvalidRadiusException() : base("Invalid Radius: radius cant be zero")
        {
        }

        public InvalidRadiusException(double radius) : base("Invalid Radius: " + radius)
        {
        }
    }
}
