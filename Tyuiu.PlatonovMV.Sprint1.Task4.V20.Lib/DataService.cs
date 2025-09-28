using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PlatonovMV.Sprint1.Task4.V20.Lib
{
    public class DataService : ISprint1Task4V20
    {
        public double Calculate(double x, double y)
        {
            //  1+x/|x-√(2+y)| 
            double result = (1 + x) / Math.Abs(x - Math.Sqrt(2 + y));
            return Math.Round(result, 3);
        }
    }
}