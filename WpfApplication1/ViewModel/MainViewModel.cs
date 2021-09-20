using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Windows.Input;
using System.Collections.ObjectModel;    
using System.Windows;
using System;

namespace WpfApplication1.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Operation = new RelayCommand<string>((arg) => DoCalculation(arg));
        }

        // for the first number
        public string operand1 { get; set; }
        // for the second number
        public string operand2 { get; set; }
        // button commands will be triggered through this ICommand interface
        public ICommand Operation { get; private set; }

        private void DoCalculation (string @operator)
        {
            var result = 0;
            // Calculation will switch depending on which button is pressed
            switch(@operator)
            {
                case "+": result = Convert.ToInt32(operand1) + Convert.ToInt32(operand2); break;
                case "-": result = Convert.ToInt32(operand1) - Convert.ToInt32(operand2); break;
                case "*": result = Convert.ToInt32(operand1) * Convert.ToInt32(operand2); break;
                case "/": result = Convert.ToInt32(operand1) / Convert.ToInt32(operand2); break;
            }
            // Show result on a pop-up message
            MessageBox.Show("Result: " + result.ToString());
        }
    }
}
