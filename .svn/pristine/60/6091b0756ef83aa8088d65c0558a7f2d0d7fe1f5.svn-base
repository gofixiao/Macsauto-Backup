using Macsauto.Infrastructure.NHibernate;
using Macsauto.Infrastructure.NHibernate.Common;

namespace Macsauto.Presentation.WinForm.ConfigurationModule.Storage
{
    using Macsauto.Domain.SalesModule;

    public class AddPresenter
    {
        private readonly IStorageRepository _storageRepository;
        private Add _form;

        public AddPresenter(IStorageRepository storageRepository)
        {
            _storageRepository = storageRepository;
        }

        public void SetForm(Add form)
        {
            _form = form;
        }

        public Storage Save()
        {
            var session = NHibernateSessionManager.GetLocalSession();
            var storage = new Storage(
                _form.StorageCode,
                _form.StorageName,
                _form.StorageDescription
            );

            session.DoTransactional(sess =>
                {
                    storage = _storageRepository.Insert(storage);
                });

            return storage;
        }
    }
}