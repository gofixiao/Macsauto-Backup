using System.Windows.Forms;
using Autofac;
using Macsauto.Domain.SalesModule;
using Macsauto.Presentation.WinForm.ConfigurationModule.Branch;
using Macsauto.Presentation.WinForm.Properties;
using Add = Macsauto.Presentation.WinForm.ManagementModule.Customer.Add;
using VehicleConfigs = Macsauto.Presentation.WinForm.ConfigurationModule.Vehicle;
using StorageConfigs = Macsauto.Presentation.WinForm.ConfigurationModule.Storage;
using MeasurementConfigs = Macsauto.Presentation.WinForm.ConfigurationModule.UnitOfMeasurement;
using ProductCategoryConfigs = Macsauto.Presentation.WinForm.ConfigurationModule.ProductCategory;
using ServiceCategoryConfigs = Macsauto.Presentation.WinForm.ConfigurationModule.ServiceCategory;
using InventoryConfigs = Macsauto.Presentation.WinForm.ConfigurationModule.Inventory;

using View = Macsauto.Presentation.WinForm.ManagementModule.Customer.View;

namespace Macsauto.Presentation.WinForm.ConfigurationModule
{
    public class MenuFactory
    {
        private readonly IContainer _container;
        private readonly MainWindow _mainWindow;

        public MenuFactory(IContainer container, MainWindow mainWindow)
        {
            _container = container;
            _mainWindow = mainWindow;
        }

        public Menu[] GetMenus()
        {
            var menus = new[]
                {
                    new Menu(@"1", @"Home", Resources.Home2),
                    new Menu(@"2", @"Management", Resources.Window_App_SplitScreen, new[]
                        {
                            new Menu(@"2.0", @"Branch management", new[]
                                {
                                    new Menu(@"2.0.0", @"Branch", new[]
                                        {
                                            new Menu(@"2.0.0.0", @"View all", () => ShowForm(_container.Resolve<ViewAll>())),
                                            new Menu(@"2.0.0.1", @"Create new", () => ShowForm(_container.Resolve<Branch.Add>())),
                                            new Menu(@"2.0.0.2", @"Export configuration"),
                                        }),
                                    new Menu(@"2.0.1", @"Employee", new[]
                                        {
                                            new Menu(@"2.0.1.0", @"View all"),
                                            new Menu(@"2.0.1.1", @"Create new"),
                                        }),
                                }),
                            new Menu(@"2.1", @"Sales management", new[]
                                {
                                    new Menu(@"2.1.0", @"Customer", new[]
                                        {
                                            new Menu(@"2.1.0.0", @"View all", () => ShowForm(_container.Resolve<View>())),
                                            new Menu(@"2.1.0.1", @"Create new", () => ShowForm(_container.Resolve<Add>(), false, FormWindowState.Normal)),
                                        }),
                                    new Menu(@"2.1.1", @"Service", new[]
                                        {
                                            new Menu(@"2.1.1.0", @"View all", () => ShowForm(_container.Resolve<ManagementModule.Service.View>())),
                                            new Menu(@"2.1.1.1", @"Create new", () => ShowForm(_container.Resolve<ManagementModule.Service.Add>(), false, FormWindowState.Normal)),
                                        })
                                }),
                            new Menu(@"2.2", @"Inventory management", new[]
                                {
                                    new Menu(@"2.2.0", @"Stock movement", new[]
                                        {
                                            new Menu(@"2.2.0.0", @"View all", () => ShowForm(_container.Resolve<ManagementModule.StockMovement.View>()))
                                        }),
                                    new Menu(@"2.2.1", @"Merchandise", new []
                                        {
                                            new Menu(@"2.2.1.0", @"View all", () => ShowForm(_container.Resolve<ManagementModule.Merchandise.View>())),
                                            new Menu(@"2.2.1.1", @"Create new", () => ShowForm(_container.Resolve<ManagementModule.Merchandise.AddFromInventory>(), false, FormWindowState.Normal)),
                                        }),
                                    new Menu(@"2.2.2", @"Product", new []
                                        {
                                            new Menu(@"2.2.2.0", @"View all", () => ShowForm(_container.Resolve<ManagementModule.Product.View>())),
                                            new Menu(@"2.2.2.1", @"Create new", () => ShowForm(_container.Resolve<ManagementModule.Product.AddFromInventory>(), false, FormWindowState.Normal)),
                                        })
                                }),
                        }),
                    new Menu(@"3", @"Configuration", Resources.Gear, new[]
                        {
                            new Menu(@"3.0", @"Vehicle", new[]
                                {
                                    new Menu(@"3.0.0", @"Brand", new[]
                                        {
                                            new Menu(@"3.0.0.0", @"View all", () => ShowForm(_container.Resolve<Vehicle.Brand.View>(), false, FormWindowState.Normal)),
                                            new Menu(@"3.0.0.1", @"Create new", () => ShowForm(_container.Resolve<Vehicle.Brand.Add>(), false, FormWindowState.Normal))
                                        }),
                                    new Menu(@"3.0.1", @"Model", new[]
                                        {
                                            new Menu(@"3.0.1.0", @"View all", () => ShowForm(_container.Resolve<Vehicle.Model.View>(), false, FormWindowState.Normal)),
                                            new Menu(@"3.0.1.1", @"Create new", () => ShowForm(_container.Resolve<Vehicle.Model.Add>(), false, FormWindowState.Normal))
                                        })
                                }),
                            new Menu(@"3.1", @"Storage", new[]
                                {
                                    new Menu(@"3.1.0", @"View all", () => ShowForm(_container.Resolve<StorageConfigs.View>(), false, FormWindowState.Normal)), 
                                    new Menu(@"3.1.1", @"Create new", () => ShowForm(_container.Resolve<StorageConfigs.Add>(), false, FormWindowState.Normal)),
                                }), 
                            new Menu(@"3.2", @"Inventory", new[]
                                {
                                    new Menu(@"3.2.0", @"View all", () => ShowForm(_container.Resolve<InventoryConfigs.View>(), false, FormWindowState.Normal)), 
                                    new Menu(@"3.2.1", @"Create new", () => ShowForm(_container.Resolve<InventoryConfigs.Add>(), false, FormWindowState.Normal)),
                                }), 
                            new Menu(@"3.3", @"Unit of measurement", new[]
                                {
                                    new Menu(@"3.3.0", @"View all", () => ShowForm(_container.Resolve<MeasurementConfigs.View>(), false, FormWindowState.Normal)), 
                                    new Menu(@"3.3.1", @"Create new", () => ShowForm(_container.Resolve<MeasurementConfigs.Add>(), false, FormWindowState.Normal)),
                                }), 
                            new Menu(@"3.4", @"Product category", new[]
                                {
                                    new Menu(@"3.4.0", @"View all", () => ShowForm(_container.Resolve<ProductCategoryConfigs.View>(), false, FormWindowState.Normal)), 
                                    new Menu(@"3.4.1", @"Create new", () => ShowForm(_container.Resolve<ProductCategoryConfigs.Add>(), false, FormWindowState.Normal)),
                                }),
                            new Menu(@"3.5", @"Service category", new[]
                                {
                                    new Menu(@"3.5.0", @"View all", () => ShowForm(_container.Resolve<ServiceCategoryConfigs.View>(), false, FormWindowState.Normal)), 
                                    new Menu(@"3.5.1", @"Create new", () => ShowForm(_container.Resolve<ServiceCategoryConfigs.Add>(), false, FormWindowState.Normal)),
                                }),
                        }),
                };

            return menus;
        }

        private void ShowForm(Form form, bool asChild = true, FormWindowState windowState = FormWindowState.Maximized)
        {
            form.WindowState = windowState;
            
            if (asChild)
            {
                form.MdiParent = _mainWindow;
                form.Show();
            }
            else
            {
                form.Show(_mainWindow);
            }
        }
    }
}