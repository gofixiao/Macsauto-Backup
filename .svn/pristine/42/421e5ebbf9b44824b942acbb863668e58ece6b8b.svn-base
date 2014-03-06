namespace Macsauto.Presentation.WinForm
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Domain.Shared;
    using Macsauto.Domain.UserManagementModule;
    using Macsauto.Infrastructure.NHibernate;
    using OfficeOpenXml;

    public class StartupDataLoader
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IUserRepository _userRepository;
        private readonly IVehicleBrandRepository _vehicleBrandRepository;
        private readonly IVehicleModelRepository _vehicleModelRepository;
        private FileInfo _file;

        public StartupDataLoader(IProvinceRepository provinceRepository, ICityRepository cityRepository, IUserRepository userRepository, IVehicleBrandRepository vehicleBrandRepository, IVehicleModelRepository vehicleModelRepository)
        {
            _provinceRepository = provinceRepository;
            _cityRepository = cityRepository;
            _userRepository = userRepository;
            _vehicleBrandRepository = vehicleBrandRepository;
            _vehicleModelRepository = vehicleModelRepository;
        }

        public void LoadAll()
        {
            LoadProvince();
            LoadCity();
            LoadBrand();
            LoadModel();

            using (var tx = NHibernateSessionManager.GetLocalSession().BeginTransaction())
            {
                var superAdmin = new User(
                    new Employee(
                        new Branch(
                            @"MAI",
                            @"MACSAUTO JAKARTA",
                            new Address(
                                _cityRepository.FindByName(@"ADMINISTRASI JAKARTA BARAT"),
                                @"11720",
                                @"KAPUK"
                            )
                        ),
                        Position.STOREMANAGER,
                        new PersonName(@"SUPERADMIN"),
                        Gender.Male
                    ),
                    @"SUPERADMINMAI",
                    @"SUPERADMINMAI"
                );

                _userRepository.Insert(superAdmin);

                var provinces = _provinceRepository.GetAll();
                var cities = _cityRepository.GetAll();

                foreach (var province in provinces)
                {
                    province.CreatedBy = superAdmin.Employee;

                    _provinceRepository.Update(province);
                }

                foreach (var city in cities)
                {
                    city.CreatedBy = superAdmin.Employee;

                    _cityRepository.Update(city);
                }

                tx.Commit();
            }
        }

        private void LoadProvince()
        {
            _file = new FileInfo(Application.StartupPath + @"\\Province.xlsx");

            using (var package = new ExcelPackage(_file))
            {
                var workbook = package.Workbook;

                using (var tx = NHibernateSessionManager.GetLocalSession().BeginTransaction())
                {
                    var provinceWs = workbook.Worksheets[@"Province"];

                    for (var i = 1; i < provinceWs.Dimension.End.Row + 1; i++)
                    {
                        var newProvince = new Province(provinceWs.Cells[i, 1].Value.ToString());

                        _provinceRepository.Insert(newProvince);
                    }

                    tx.Commit();
                }
            }
        }

        private void LoadCity()
        {
            _file = new FileInfo(Application.StartupPath + @"\\Province.xlsx");

            using (var package = new ExcelPackage(_file))
            {
                var workbook = package.Workbook;

                using (var tx = NHibernateSessionManager.GetLocalSession().BeginTransaction())
                {
                    var provinces = _provinceRepository.GetAll();
                    var cityWs = workbook.Worksheets[@"City"];

                    for (var i = 1; i < cityWs.Dimension.End.Row + 1; i++)
                    {
                        var newCity = new City(
                            cityWs.Cells[i, 1].Value.ToString(),
                            provinces.FirstOrDefault(x => x.Name == cityWs.Cells[i, 2].Value.ToString())
                            );

                        _cityRepository.Insert(newCity);
                    }

                    tx.Commit();
                }
            }
        }

        private void LoadBrand()
        {
            _file = new FileInfo(Application.StartupPath + @"\\Vehicle.xlsx");

            using (var package = new ExcelPackage(_file))
            {
                var workbook = package.Workbook;

                using (var tx = NHibernateSessionManager.GetLocalSession().BeginTransaction())
                {
                    var ws = workbook.Worksheets[@"Brand"];

                    for (var i = 1; i < ws.Dimension.End.Row + 1; i++)
                    {
                        var newBrand = new VehicleBrand(
                            ws.Cells[i, 1].Value.ToString(),
                            ws.Cells[i, 2].Value.ToString()
                        );

                        _vehicleBrandRepository.Insert(newBrand);
                    }

                    tx.Commit();
                }
            }
        }

        private void LoadModel()
        {
            _file = new FileInfo(Application.StartupPath + @"\\Vehicle.xlsx");

            using (var package = new ExcelPackage(_file))
            {
                var workbook = package.Workbook;

                using (var tx = NHibernateSessionManager.GetLocalSession().BeginTransaction())
                {
                    var ws = workbook.Worksheets[@"Model"];
                    var brands = _vehicleBrandRepository.GetAll();

                    for (var i = 1; i < ws.Dimension.End.Row + 1; i++)
                    {
                        VehicleSize size;

                        Enum.TryParse(ws.Cells[i, 3].Value.ToString(), out size);

                        var newModel = new VehicleModel(
                            ws.Cells[i, 1].Value.ToString(),
                            ws.Cells[i, 2].Value.ToString(),
                            brands.FirstOrDefault(x => x.Code == ws.Cells[i, 3].Value.ToString()),
                            size,
                            VehicleType.CAR
                        );

                        _vehicleModelRepository.Insert(newModel);
                    }

                    tx.Commit();
                }
            }
        }
    }
}