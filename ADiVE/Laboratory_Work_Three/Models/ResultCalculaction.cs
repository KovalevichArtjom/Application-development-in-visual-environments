using Laboratory_Work_Three.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_Three.Models
{
    class ResultCalculaction : IResultCalculaction
    {
        public const string ValueXStr = "at Xn = {0}{1}";
        public const string ValueYStr = "at Y = {0}{1}";
        public const string CalculationFunctionStr = "sum = {0}{1}";

        public string ValueX { get; set; }
        public string ValueY { get; set; }
        public string CalculationFunction { get; set; }
    }
}
