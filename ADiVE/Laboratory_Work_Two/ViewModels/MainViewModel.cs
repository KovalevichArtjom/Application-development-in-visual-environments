using Laboratory_Work_Two.Enums;
using Laboratory_Work_Two.Interfaces;
using Laboratory_Work_Two.Models;
using System;
using System.Text;

namespace Laboratory_Work_Two.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        MainModel Model = new MainModel();

        event EventHandler RecalculateEventHandlerChanged;

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
                    RecalculateEventHandlerChanged?.Invoke(this, new EventArgs());
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
                    RecalculateEventHandlerChanged?.Invoke(this, new EventArgs());
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
                    RecalculateEventHandlerChanged?.Invoke(this, new EventArgs());
                    OnPropertyChanged(nameof(VariableZTextBox));
                }
            }
        }
        double variableZ;

        public string ResulctCalcTextBlock
        {
            get
            {
                return resultCalcTextBlock;
            }
            set
            {
                if (value != resultCalcTextBlock)
                {

                    var resultCalc = Convert.ToDouble(value);
                    resultCalcTextBlock = (new StringBuilder())
                        .Append(MaxAbsChecked ? MainModel.MaxAbsVariableStr : MainModel.MaxVariableStr)
                        .Append(Model.MaxVaribale.ToString(MainModel.NumberMaskStr))
                        .Append(Environment.NewLine)
                        .Append(MainModel.ResultCalculationStr)
                        .Append(resultCalc.ToString(MainModel.NumberMaskStr))
                        .ToString();

                    OnPropertyChanged(nameof(ResulctCalcTextBlock));
                }
            }
        }
        string resultCalcTextBlock;

        #region RadioButton
        public bool FirstFunctionChecked
        {
            get
            {
                return firstFunctionChecked;
            }
            set
            {
                if (value != firstFunctionChecked)
                {
                    firstFunctionChecked = value;

                    if (value)
                        FunctionChecked = FunctionType.Fist;

                    OnPropertyChanged(nameof(FirstFunctionChecked));
                }
            }
        }
        bool firstFunctionChecked = true;

        public bool SecondFunctionChecked
        {
            get
            {
                return secondFunctionChecked;
            }
            set
            {
                if (value != secondFunctionChecked)
                {
                    secondFunctionChecked = value;

                    if (value)
                        FunctionChecked = FunctionType.Second;

                    OnPropertyChanged(nameof(SecondFunctionChecked));
                }
            }
        }
        bool secondFunctionChecked = false;

        public bool ThirdFunctionChecked
        {
            get
            {
                return thirdFunctionChecked;
            }
            set
            {
                if (value != thirdFunctionChecked)
                {
                    thirdFunctionChecked = value;

                    if (value)
                        FunctionChecked = FunctionType.Third;

                    OnPropertyChanged(nameof(ThirdFunctionChecked));
                }
            }
        }
        bool thirdFunctionChecked = false;

        public FunctionType FunctionChecked
        {
            get
            {
                return functionChecked;
            }
            private set
            {
                if (value != functionChecked)
                {
                    functionChecked = value;
                    RecalculateEventHandlerChanged?.Invoke(this, new EventArgs());
                }
            }
        }
        FunctionType functionChecked = FunctionType.Fist;
        #endregion

        public bool MaxAbsChecked
        {
            get
            {
                return maxAbsChecked;
            }
            set
            {
                if (value != maxAbsChecked)
                {
                    maxAbsChecked = value;
                    RecalculateEventHandlerChanged?.Invoke(this, new EventArgs());
                    OnPropertyChanged(nameof(MaxAbsChecked));
                }
            }
        }
        bool maxAbsChecked = true;

        public MainViewModel()
        {
            RecalculateEventHandlerChanged += MainViewModel_RecalculateEventHandlerChanged;
        }

        private void MainViewModel_RecalculateEventHandlerChanged(object sender, EventArgs e)
        {
            double calcRes = Model.Calc(VariableXTextBox, VariableYTextBox, VariableZTextBox, FunctionChecked, MaxAbsChecked);
            ResulctCalcTextBlock = calcRes.ToString();
        }
    }
}
