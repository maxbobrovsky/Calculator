using Calculator.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace Calculator.ViewModels
{
    class MainWindowContentControlViewModel : BaseViewModel
    {
        #region Commands

        /// <summary>
        /// Nope!!!
        /// </summary>
        public ICommand NotImplemented { get; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainWindowContentControlViewModel()
        {
            NotImplemented = new RelayCommand(() => MessageBox.Show("Not implemented"));
        }

        #endregion
    }
}
