using Macsauto.Domain.SalesModule;

namespace Macsauto.Presentation.WinForm
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;
    using Autofac;
    using Macsauto.Domain.Shared;
    using Macsauto.Domain.UserManagementModule;
    using Macsauto.Infrastructure.NHibernate;
    using NHibernate;

    public partial class SplashScreen : Form
    {
        private ICityRepository _cityRepo;
        private IProvinceRepository _provinceRepo;
        private IUserRepository _userRepo;
        private int _percentage;
        private bool _isFirstStartUp;
        private Autofac.IContainer _container;

        public event EventHandler<SplashEventArgs> DoneStartup;

        public SplashScreen(bool isFirstStartUp)
        {
            _isFirstStartUp = isFirstStartUp;

            var backgroundWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };

            backgroundWorker.DoWork += backgroundWorker_doWork;
            backgroundWorker.ProgressChanged += backgroundWorker_progressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_runWorkerCompleted;

            InitializeComponent();

            backgroundWorker.RunWorkerAsync();
        }

        public int Percentage
        {
            get { return _percentage; }
            set
            {
                _percentage = value;

                prgBarBootstrap.Value = _percentage;
            }
        }

        private void backgroundWorker_runWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            OnDoneStartup();

            Dispose(true);
        }

        private void backgroundWorker_progressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgBarBootstrap.Value = e.ProgressPercentage;
            lblProgress.Text = e.UserState.ToString();
        }

        private void backgroundWorker_doWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            if (worker == null) return;

            try
            {
                BootStrap.ProgressChanged += (s, pe) => worker.ReportProgress(pe.ProgressPercentage, s);

                _container = BootStrap.Strap();

                worker.ReportProgress(30, @"Creating local session..");

                NHibernateSessionManager.SetConnectionStrings(@"Server=codebrosdb.c7n7mt4zucyl.ap-southeast-1.rds.amazonaws.com;User Id=codebros;Password=codebros");
                NHibernateSessionManager.GetLocalSession();

                worker.ReportProgress(40, @"Creating branch sessions..");

                //NHibernateSessionManager.InitializeBranchSession();

                worker.ReportProgress(50, @"All sessions created");
            }
            catch (Exception ex)
            {
                throw;

                if (MessageBox.Show(@"Currently cannot connect to main branch. Do you want to continue?", @"Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    worker.CancelAsync();

                    MessageBox.Show(@"Please inform your support about the exception");

                    Application.Exit();
                }

                worker.ReportProgress(50, @"Skipped branch session");
            }

            worker.ReportProgress(60, @"Checking startup");

            if (_isFirstStartUp)
            {
                DoStartupConfiguration(worker);
            }

            worker.ReportProgress(80, @"Skipping startup configuration");

            worker.ReportProgress(100, @"Finishing configuration");
        }

        private void DoStartupConfiguration(BackgroundWorker worker)
        {
            worker.ReportProgress(70, @"Doing startup configuration");

            _userRepo = _container.Resolve<IUserRepository>();

            var startupLoader = new StartupDataLoader(
                _container.Resolve<IProvinceRepository>(),
                _container.Resolve<ICityRepository>(),
                _container.Resolve<IUserRepository>(),
                _container.Resolve<IVehicleBrandRepository>(),
                _container.Resolve<IVehicleModelRepository>()
            );

            startupLoader.LoadAll();

            worker.ReportProgress(80, @"Startup configuration finished");

            _isFirstStartUp = false;
        }

        protected virtual void OnDoneStartup()
        {
            EventHandler<SplashEventArgs> handler = DoneStartup;

            if (handler != null) handler(this, new SplashEventArgs(_container));
        }

        private void FillStartupData()
        {
            

        }
    }
}