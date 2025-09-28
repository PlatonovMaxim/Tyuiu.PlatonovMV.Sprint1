using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PlatonovMV.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            // Формула: (cos(x²) + sin(y²)) / (sin y + 1) - (x*y - 12) / (15 + cos x)

            double cosX2 = Math.Cos(x * x);    
            double sinY2 = Math.Sin(y * y);    
            double sinY = Math.Sin(y);       
            double cosX = Math.Cos(x);        

            double numerator1 = cosX2 + sinY2;
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