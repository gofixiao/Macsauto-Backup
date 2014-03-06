namespace Macsauto.Presentation.WPF.Common
{
    using System.ComponentModel;

    using Macsauto.Infrastructure.Helper.Extension;

    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;

            if (!handler.IsNull())
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}