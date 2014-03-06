namespace Macsauto.Presentation.WinForm.ConfigurationModule.Inventory
{
    using Macsauto.Domain.SalesModule;

    public class ViewDetailPresenter
    {
        private readonly IStorageRepository _storageRepository;
        private readonly IStockMovementRepository _movementRepository;
        private ViewDetail _form;

        public ViewDetailPresenter(IStorageRepository storageRepository, IStockMovementRepository movementRepository)
        {
            _storageRepository = storageRepository;
            _movementRepository = movementRepository;
        }

        public void SetForm(ViewDetail form)
        {
            _form = form;
            _form.Storages = _storageRepository.GetStoragesWithInventory(_form.SelectedInventory);
            _form.Movements = _movementRepository.GetMovementsWithInventory(_form.SelectedInventory);
        }
    }
}