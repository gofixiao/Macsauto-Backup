using Macsauto.Domain.SalesModule;

namespace Macsauto.Presentation.WinForm.ManagementModule.Customer
{
    public class ViewPresenter
    {
        private readonly ICustomerRepository _customerRepository;
        private View _view;

        public ViewPresenter(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void SetForm(View view)
        {
            _view = view;

            _view.Customers = _customerRepository.GetAll();
        }
    }
}