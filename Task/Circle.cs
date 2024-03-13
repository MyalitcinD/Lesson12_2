using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    static class Circle
    {

        static public double GetCircumference(double radius)
        {
            return Math.PI * 2 * radius;
        }

        static public double GetArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        static public bool CordCheck(double x, double y, double radius, double x0, double y0)
        {

            //   ((x-x0)*(x-x0)+(y-y0)*(y-y0))<=(radius*radius)
            if((((x - x0) * (x - x0) + (y - y0) * (y - y0)) <= (radius * radius))) {
                return true;
            }
            else {
                return false;
            }



        }
    }
}
