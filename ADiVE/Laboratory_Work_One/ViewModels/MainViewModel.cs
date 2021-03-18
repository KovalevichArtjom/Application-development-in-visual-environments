using Laboratory_Work_One.Interfaces;
using Laboratory_Work_One.Models;
using System;

namespace Laboratory_Work_One.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        MainModel Model = new MainModel();

        public double VariableXTextBox
        {
            get
            {
                return variableX;
            }
            set
            {
                if (value != variableX)
                {
                    variableX = value;
                    ResulctCalcTextBlock = Convert.ToString(Model.Calc(VariableXTextBox, VariableYTextBox, value));
                    OnPropertyChanged(nameof(VariableXTextBox));
                }
            }
        }
        double variableX;

        public double VariableYTextBox
        {
            get
            {
                return variableY;
            }
            set
            {
                if (value != variableY)
                {
                    variableY = value;
                    ResulctCalcTextBlock = Convert.ToString(Model.Calc(VariableXTextBox, VariableYTextBox, value));
                    OnPropertyChanged(nameof(VariableYTextBox));
                }
            }
        }
        double variableY;

        public double VariableZTextBox
        {
            get
            {
                return variableZ;
            }
            set
            {
                if (value != variableZ)
                {
                    variableZ = value;
                    ResulctCalcTextBlock = Convert.ToString(Model.Calc(VariableXTextBox, VariableYTextBox, value));
                    OnPropertyChanged(nameof(VariableZTextBox));
                }
            }
        }
        double variableZ;

        public string ResulctCalcTextBlock
        {
            get
            {
                return resulctCalcTextBlock;
            }
            set
            {
                if (value != resulctCalcTextBlock)
                {
                    resulctCalcTextBlock = String.Format(MainModel.TemplateStr, Convert.ToDouble(value));
                    OnPropertyChanged(nameof(ResulctCalcTextBlock));
                }
            }
        }
        string resulctCalcTextBlock;
    }
}
