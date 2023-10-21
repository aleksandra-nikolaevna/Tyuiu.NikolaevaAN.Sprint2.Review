using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NikolaevaAN.Sprint2.Review.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            double pi = Math.PI;
            if ((x >= 0) && (x <= pi) && (y >= 0) && (y <= 0.5) && (y < Math.Sin(x)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
