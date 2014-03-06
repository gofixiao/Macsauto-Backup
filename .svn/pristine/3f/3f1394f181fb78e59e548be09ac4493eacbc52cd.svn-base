using System.Windows.Forms;
using Autofac;

namespace Macsauto.Presentation.WinForm
{
    public class FormFactory : IFormFactory
    {
        private readonly IContainer _container;

        public FormFactory(IContainer container)
        {
            _container = container;
        }

        public  T CreateForm<T>()
        {
            var form = _container.Resolve<T>();

            return form;
        }
    }
}