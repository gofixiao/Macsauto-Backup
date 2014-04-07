using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Autofac;
using DevComponents.DotNetBar;
using Macsauto.Infrastructure.Crosscutting.AuthorizationRequired;
using Macsauto.Infrastructure.Service;
using Macsauto.Domain.UserManagementModule;
using Macsauto.Infrastructure.Helper.Extension;
using Macsauto.Presentation.WinForm.ConfigurationModule;
using Macsauto.Presentation.WinForm.PointOfSalesModule.Login;
using Menu = Macsauto.Presentation.WinForm.ConfigurationModule.Menu;

namespace Macsauto.Presentation.WinForm
{
    public partial class MainWindow : Form
    {
        private MenuFactory _menuFactory;
        private Menu[] _menus;
        private IContainer _autofacContainer;

        public MainWindow()
        {
            InitializeComponent();
        }

        public IContainer AutofacContainer
        {
            get { return _autofacContainer; }
            set
            {
                _autofacContainer = value;

                _menuFactory = new MenuFactory(_autofacContainer, this);
            }
        }

        private void InitializeMenu()
        {
            _menus = _menuFactory.GetMenus();

            foreach (ButtonX menuButton in _menus.Select(menu => new ButtonX
                {
                    AccessibleRole = AccessibleRole.PushButton,
                    Dock = DockStyle.Top,
                    Image = menu.ButtonImage,
                    ImageTextSpacing = 10,
                    Location = new Point(0, 0),
                    Name = @"btnMenu" + menu.Text,
                    Size = new Size(206, 40),
                    Style = eDotNetBarStyle.Office2003,
                    Text = menu.Text,
                    TextAlignment = eButtonTextAlignment.Left,
                    ThemeAware = false
                }))
            {
                menuButton.Click += MenuButtonClicked;

                menuSplitContainer.Panel2.Controls.Add(menuButton);
            }
        }

        private void MenuButtonClicked(object sender, EventArgs e)
        {
            var button = sender as ButtonX;

            treeMenu.Nodes.Clear();

            if (button != null)
            {
                Menu selectedMenu = IterateThrough(_menus, x => @"btnMenu" + x.Text == button.Name);

                TreeNode node = GetTreeNode(selectedMenu);

                treeMenu.Nodes.Add(node);
                treeMenu.Nodes[0].Expand();
            }
        }

        [AuthorizationRequired]
        private Menu IterateThrough(IEnumerable<Menu> menus, Expression<Func<Menu, bool>> expression)
        {
            Menu selectedMenu = null;

            foreach (Menu menu in menus)
            {
                if (expression.Compile()(menu))
                {
                    selectedMenu = menu;
                }
                else
                {
                    if (menu.HasChildren && selectedMenu == null)
                    {
                        selectedMenu = IterateThrough(menu.Children, expression);
                    }
                }
            }

            return selectedMenu;
        }

        private TreeNode GetTreeNode(Menu menu)
        {
            var treeNode = new TreeNode(menu.Text){Name = menu.Index};

            if (menu.HasChildren)
            {
                foreach (Menu child in menu.Children)
                {
                    treeNode.Nodes.Add(GetTreeNode(child));
                }
            }

            return treeNode;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Text = @"Macsauto - V." + System.Windows.Forms.Application.ProductVersion;

            var form = AutofacContainer.Resolve<LoginFrm>();

            if (LoginFrm.LoggedInUser.IsNull())
            {
                form.FormClosed += loginFrm_FormClosed;
                form.LoginSuccess += loginFrm_LoginSuccess;

                form.ShowDialog(this);
            }

            InitializeMenu();
        }

        private void loginFrm_LoginSuccess(object sender, EventArgs e)
        {
            tssLoggedInAs.Text = @"Logged as : " + LoginFrm.LoggedInUser.Employee.Name.Fullname;

            var container = new ContainerBuilder();
            container.RegisterInstance(LoginService.LoggedInUser.Employee)
                .Named<Employee>("loggedInEmployee");
        }

        private void loginFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (LoginFrm.LoggedInUser.IsNull())
            {
                Dispose();
            }
        }

        private void treeMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var treeView = sender as TreeView;

            if (treeView == null) return;

            var selectedMenu = IterateThrough(_menus, x => x.Index == treeView.SelectedNode.Name);

            if (selectedMenu.Action != null)
            {
                selectedMenu.Action.Invoke();
            }
        }

        [AuthorizationRequired]
        private void btnPOS_Click(object sender, EventArgs e)
        {
            var form = _autofacContainer.Resolve<PointOfSalesModule.Dashboard.Dashboard>();

            form.Show();
        }
    }
}