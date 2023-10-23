using System;

namespace SquareEqualtion_1
{
    public class SquareEqualtion
    {       
        public double[] GetRoots(double a, double b, double c)
        {
            double Discriminant = Calc_Discriminant(a,b,c); 
            double x1, x2;
            
            if (Discriminant > 0)
            {
                x1 = (-1 * b + Math.Sqrt(Discriminant)) / (2 * a);
                x2 = (-1 * b - Math.Sqrt(Discriminant)) / (2 * a);
                double[] Roots = new double[] {x1,x2};
                return Roots;

            }
            else if (Discriminant == 0)
            {

                x1 = (-1 * b) / (2 * a);
                double[] Roots = new double[] {x1};
                return Roots;
            }
            else
            {
                double[] Roots = new double[] {};
                return Roots;
            }
        }

        private double Calc_Discriminant(double a,double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
    }
}
