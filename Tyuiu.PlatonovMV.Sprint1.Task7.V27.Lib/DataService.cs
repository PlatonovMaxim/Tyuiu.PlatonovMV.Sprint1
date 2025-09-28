using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PlatonovMV.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            // (cos²x + sin²y)/(sin y + 1) - (x*y - 12)/(15 + cos x)

            double cosX = Math.Cos(x);
            double sinY = Math.Sin(y);

            
            double numerator1 = Math.Pow(cosX, 2) + Math.Pow(sinY, 2);
            double denominator1 = sinY + 1;
            double fraction1 = numerator1 / denominator1;

            
            double numerator2 = x * y - 12;
            double denominator2 = 15 + cosX;
            double fraction2 = numerator2 / denominator2;

            
            double result = fraction1 - fraction2;
            return Math.Round(result, 3);
        }
    }
}