
namespace Macsauto.Presentation.WPF.Common
{
    using System;
    using System.Windows.Input;

    public abstract class CommandBase : ICommand
    {
        #region Methods (ICommand)

        public abstract void Execute(object parameter);
        public abstract bool CanExecute(object parameter);

        #endregion

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}