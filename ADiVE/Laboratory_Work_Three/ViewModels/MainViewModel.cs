using Laboratory_Work_Three.Interfaces;
using Laboratory_Work_Three.Models;
using System;
using System.Text;

namespace Laboratory_Work_Three.ViewModels
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
    }
}
