using SquareLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SquareLib
{
    public class Square
    {
        #region Площадь треугольника
        public double? TriangleSquare(double a, double b, double c)
        {
            double result = 0;

            if (CheckTriangleExist(a, b, c))
            {
                double p = (a + b + c) / 2;
                result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return result;
            }

            return null;
        }

        public bool RightTrinagle(double a, double b, double c)
        {
            if (c * c == (a * a + b * b) || a * a == (c * c + b * b) || b * b == (a * a + c * c))
                return true;
            return false;
        }

        private bool CheckTriangleExist(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                return false;
            else return true;
        }
        #endregion

        #region Площадь окружности

        public double CircleSquare()
        {
            double result = 0;
            const double P = 3.14;

            double r = CircleFig.radius;

            result = P * (r * r);

            Console.WriteLine($"Площадь круга = {result}");
            return result;
        }

        #endregion

        #region Дополнительные функции для проверки ввода

        public double? CheckNumber(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                if (str.Contains('.'))
                {
                    str = str.Replace('.', ',');
                }
                double num;
                bool isNumeric = double.TryParse(str, out num);
                if (isNumeric)
                    return Double.Parse(str);
            }
            return null;
        }

        #endregion
    }
}
