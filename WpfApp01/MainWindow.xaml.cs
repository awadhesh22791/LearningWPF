using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp01.Constant;
using WpfApp01.Service;
using WpfApp01.Service.Impl;
namespace WpfApp01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IAuthenticationService authenticationService;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            this.authenticationService = new AuthenticationService();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.authenticationService.ValidateUser(txtUserName.Text, txtPassword.Password);
        }

        private void Reset_Button_Click(object sender, RoutedEventArgs e)
        {
            txtPassword.Clear();
            txtUserName.Clear();
        }
    }
}
