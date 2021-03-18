using Laboratory_Work_One.Interfaces;
using System;

namespace Laboratory_Work_One.Models
{
    class MainModel : ModelBase
    {
        public const string TemplateStr = "Result calculation = {0:0.##}";

        public double Calc(double x, double y, double z)
        {
            double FirstUp = 1 + Math.Pow(Math.Sin(x + y), 2);
            double FirstDown = Math.Abs(x - (2 * y) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2)));
            double First = (FirstUp / FirstDown) * Math.Pow(x, Math.Abs(y));
            double Second = Math.Cos(Math.Atan(1 / z));

            return First + Second;
        }
    }
}
