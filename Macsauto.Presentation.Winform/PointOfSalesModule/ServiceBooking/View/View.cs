namespace Macsauto.Presentation.WinForm.PointOfSalesModule.ServiceBooking
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;

    public partial class View : Form
    {
        private readonly ViewPresenter _presenter;
        private readonly IFormFactory _formFactory;
        private IList<ServiceBooking> _pendingBookings;

        public View(ViewPresenter presenter, IFormFactory formFactory)
        {
            _presenter = presenter;
            _formFactory = formFactory;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<ServiceBooking> PendingBookings
        {
            get { return _pendingBookings; }
            set
            {
                _pendingBookings = value;

                dgvPendingBookings.Rows.Clear();

                foreach (var serviceBooking in _pendingBookings)
                {
                    dgvPendingBookings.Rows.Add(
                        serviceBooking.Id,
                        serviceBooking.Code,
                        serviceBooking.Customer.ToString(),
                        serviceBooking.Customer.CellPhone,
                        serviceBooking.DueDate,
                        serviceBooking.CreatedOn.ToString(@"d")
                    );
                }
            }
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            var add = _formFactory.CreateForm<Create>();

            //add.FormTransactionSuccess += add_FormTransactionSuccess;

            add.ShowDialog();
        }

        private void add_FormTransactionSuccess(object sender, FormTransactionSuccessArgs<ServiceBooking> e)
        {
            _presenter.SetForm(this);
        }

        private void View_Load(object sender, System.EventArgs e)
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }
    }
}