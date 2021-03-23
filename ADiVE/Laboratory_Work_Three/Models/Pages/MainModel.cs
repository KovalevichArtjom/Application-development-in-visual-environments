using System.Linq;
using System;
using Laboratory_Work_Three.Interfaces;

namespace Laboratory_Work_Three.Models.Pages
{
    class MainModel : ModelBase
    {
        public IResultCalculaction GetResult(double xn, double xk, double n, double h)
        {
            double summa = 0;
            double steps = 0;
            double calcFunctionY = 0;
            ResultCalculaction resultCalculaction = new ResultCalculaction();

            for (; steps <= xk;)
            {
                calcFunctionY = Truncate(CalcFunctionY(steps), 3);
                summa += Truncate(CalcFunctionX(xn, n), 3);

                resultCalculaction.ValueX += String.Format(ResultCalculaction.ValueXStr, steps.ToString("N3"), Environment.NewLine);
                resultCalculaction.ValueY += String.Format(ResultCalculaction.ValueYStr, calcFunctionY.ToString("N3"), Environment.NewLine);
                resultCalculaction.CalculationFunction += String.Format(ResultCalculaction.CalculationFunctionStr, summa.ToString("N2"), Environment.NewLine);

                steps += h;
            }

            return resultCalculaction;
        }

        double CalcFunctionY(double x)
        {
            return Math.Exp(x * Math.Cos(Math.PI / 4)) * Math.Cos(x * Math.Sin(Math.PI / 4));
        }

        double CalcFunctionX(double x, double n)
        {
            return ((Math.Cos(n) * (Math.PI / 4)) / n) * Math.Pow(x, n);
        }

        public double Truncate(double value, int places)
        {
            string str = value.ToString();
            int pos = Math.Min(str.Length, str.IndexOf(".") + places + 1);

            if (pos > 0)
                str = str.Substring(0, pos);

            return Convert.ToDouble(str);
        }


        public double CaclVariableH(double xn, double xk, double n)
        {
            return (xk - xn) / n;
        }
    }
}
