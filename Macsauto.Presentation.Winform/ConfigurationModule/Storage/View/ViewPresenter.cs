using Macsauto.Domain.SalesModule;

namespace Macsauto.Presentation.WinForm.ConfigurationModule.Storage
{
    public class ViewPresenter
    {
        private readonly IStorageRepository _storageRepository;
        private View _form;

        public ViewPresenter(IStorageRepository storageRepository)
        {
            _storageRepository = storageRepository;
        }

        public void SetForm(View form)
        {
            _form = form;

            _form.Storages = _storageRepository.GetAll();
        }
    }
}