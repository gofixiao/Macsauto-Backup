namespace Macsauto.Presentation.WinForm.ManagementModule.StockMovement
{
    using Macsauto.Domain.SalesModule;

    public class ViewPresenter
    {
        private readonly IStockMovementRepository _movementRepository;
        private View _form;

        public ViewPresenter(IStockMovementRepository movementRepository)
        {
            _movementRepository = movementRepository;
        }

        public void SetForm(View form)
        {
            _form = form;
            
            _form.StockMovements = _movementRepository.GetAll();
        }
    }
}