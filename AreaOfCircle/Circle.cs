using System;
using System.Collections.Generic;
using System.Text;


namespace AreaOfCircle
{
   
    public static class Circle
    {

        public static double CalcArea(double radius)
        {
            double value = Math.Pow(radius, 2);
            return Math.PI * value;

            
        }
        public static double Circumference(double radius)
        {
            
            return 2 * Math.PI * radius;


        }
        public static double CalcDiameter(double radius)
        {
           
            return 2 * radius;


        }

    }
}
