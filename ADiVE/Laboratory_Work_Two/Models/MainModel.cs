using Laboratory_Work_Two.Enums;
using Laboratory_Work_Two.Interfaces;
using System.Linq;
using System;

namespace Laboratory_Work_Two.Models
{
    class MainModel : ModelBase
    {
        public const string NumberMaskStr = "0.##";
        public const string MaxVariableStr = "Max = ";
        public const string MaxAbsVariableStr = "MaxAbs = ";
        public const string ResultCalculationStr = "Result calculation = ";

        public double MaxVaribale
        {
            get
            {
                return maxVaribale;
            }
            private set
            {
                if (value != maxVaribale)
                    maxVaribale = value;
            }
        }
        double maxVaribale;

        double Calc(double x, double y, double z)
        {
            double[] varCollection = { x, y, z };
            MaxVaribale = varCollection.Max();

            double condition = x - y;
            double res = 0;

            if (condition == 0)
                res = Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Sin(y);
            else if (condition > 0)
                res = Math.Pow((x - y), 2) + Math.Cos(y);
            else if (condition < 0)
                res = Math.Pow((y - x), 2) + Math.Tan(y);

            return res;
        }
        
        public double Calc(double x, double y, double z, FunctionType functionType)
        {
            double overrideX = 0;
            switch (functionType)
            {
                case FunctionType.Fist:
                    //TODO: Math.Asinh not found
                    overrideX = Math.Asin(x);
                    break;
                case FunctionType.Second:
                    overrideX = Math.Pow(x, 2);
                    break;
                case FunctionType.Third:
                    overrideX = Math.Exp(x);
                    break;
            }

            return Calc(overrideX, y, z);
        }

        public double Calc(double x, double y, double z, FunctionType functionType, bool IsAbsMax)
        {

            if (IsAbsMax)
            {
                x = Math.Abs(x);
                y = Math.Abs(y);
                z = Math.Abs(z);
            }

            return Calc(x, y, z, functionType);
        }
    }
}
