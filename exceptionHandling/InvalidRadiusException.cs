using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    public class InvalidRadiusException : Exception
    {


        public InvalidRadiusException(double radius) : base("Invalid Radius: " + radius)
        {
        }
        public InvalidRadiusException(string message) : base(message)
        {
        }
    } 
}
