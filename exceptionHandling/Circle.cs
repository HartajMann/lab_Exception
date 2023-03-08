using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else if(value==0)
                {
                    throw new InvalidRadiusException("Radius Cannot be zero");

                }
                else
                {
                    throw new InvalidRadiusException(value);
                }
            }
        }

        public override string ToString()
        {
            return "Circle [radius = " + radius + "]";
        }
    }
}


