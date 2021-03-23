using Laboratory_Work_Three.Interfaces;
using Laboratory_Work_Three.Models.Pages;
using System;
using System.Text;

namespace Laboratory_Work_Three.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        MainModel Model = new MainModel();

        event EventHandler RecalculateEventHandlerChanged;

        #region TextBoxs Text
        public double VariableXkTextBox
        {
            get
            {
                return variableXk;
            }
            set
            {
                if (value != variableXk)
                {
                    variableXk = value;
                    RecalculateEventHandlerChanged?.Invoke(this, new EventArgs());
                    OnPropertyChanged(nameof(VariableXkTextBox));
                }
            }
        }
        double variableXk = 1;

        public double VariableXnTextBox
        {
            get
            {
                return variableXn;
            }
            set
            {
                if (value != variableXn)
                {
                    variableXn = value;
                    RecalculateEventHandlerChanged?.Invoke(this, new EventArgs());
                    OnPropertyChanged(nameof(VariableXnTextBox));
                }
            }
        }
        double variableXn = 0.1;

        public double VariableNTextBox
        {
            get
            {
                return variableN;
            }
            set
            {
                if (value != variableN)
                {
                    variableN = value;
                    RecalculateEventHandlerChanged?.Invoke(this, new EventArgs());
                    OnPropertyChanged(nameof(VariableNTextBox));
                }
            }
        }
        double variableN = 12;

        public double VariableHTextBox
        {
            get
            {
                return variableH;
            }
            set
            {
                if (value != variableH)
                {
                    variableH = value;
                    RecalculateEventHandlerChanged?.Invoke(this, new EventArgs());
                    OnPropertyChanged(nameof(VariableHTextBox));
                }
            }
        }
        double variableH;
        #endregion

        #region TextBoxs Enabled
        public bool VariableXkEnabled
        {
            get
            {
                return variableXkEnabled;
            }
            set
            {
                if (value != variableXkEnabled)
                {
                    variableXkEnabled = value;
                    OnPropertyChanged(nameof(VariableXkEnabled));
                }
            }
        }
        bool variableXkEnabled = false;

        public bool VariableXnEnabled
        {
            get
            {
                return variableXnEnabled;
            }
            set
            {
                if (value != variableXnEnabled)
                {
                    variableXnEnabled = value;
                    OnPropertyChanged(nameof(VariableXnEnabled));
                }
            }
        }
        bool variableXnEnabled = false;

        public bool VariableNEnabled
        {
            get
            {
                return variableNEnabled;
            }
            set
            {
                if (value != variableNEnabled)
                {
                    variableNEnabled = value;
                    OnPropertyChanged(nameof(VariableNEnabled));
                }
            }
        }
        bool variableNEnabled = false;

        public bool VariableHEnabled
        {
            get
            {
                return variableHEnabled;
            }
            set
            {
                if (value != variableHEnabled)
                {
                    variableHEnabled = value;
                    OnPropertyChanged(nameof(VariableHEnabled));
                }
            }
        }
        bool variableHEnabled = false;
        #endregion

        #region TextBlocks
        public string ResulctCalculationFunctionTextBlock
        {
            get
            {
                return resulctCalculationFunctionTextBlock;
            }
            set
            {
                if (value != resulctCalculationFunctionTextBlock)
                {
                    resulctCalculationFunctionTextBlock = value;
                    OnPropertyChanged(nameof(ResulctCalculationFunctionTextBlock));
                }
            }
        }
        string resulctCalculationFunctionTextBlock;

        public string ValueYTextBlock
        {
            get
            {
                return valueYTextBlock;
            }
            set
            {
                if (value != valueYTextBlock)
                {
                    valueYTextBlock = value;
                    OnPropertyChanged(nameof(ValueYTextBlock));
                }
            }
        }
        string valueYTextBlock;

        public string ValueXTextBlock
        {
            get
            {
                return valueXTextBlock;
            }
            set
            {
                if (value != valueXTextBlock)
                {
                    valueXTextBlock = value;
                    OnPropertyChanged(nameof(ValueXTextBlock));
                }
            }
        }
        string valueXTextBlock;
        #endregion

        public MainViewModel()
        {
            RecalculateEventHandlerChanged += MainViewModel_RecalculateEventHandlerChanged;
            VariableHTextBox = Model.CaclVariableH(VariableXnTextBox, VariableXkTextBox, VariableNTextBox);
        }

        private void MainViewModel_RecalculateEventHandlerChanged(object sender, EventArgs e)
        {
            IResultCalculaction resultCalculaction = Model.GetResult(VariableXnTextBox, VariableXkTextBox, VariableNTextBox, variableH);

            ValueXTextBlock = resultCalculaction.ValueX;
            ValueYTextBlock = resultCalculaction.ValueY;
            ResulctCalculationFunctionTextBlock = resultCalculaction.CalculationFunction;
        }
    }
}