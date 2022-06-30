using SofaProject.DataFiles;
using SofaProject.Director;
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

namespace SofaProject.Views
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
            CmbFIO.SelectedValuePath = "ID_Employee";
            CmbFIO.DisplayMemberPath = "Name";
            CmbFIO.ItemsSource = OdbConnectHelper.furObj.Employee.ToList();
        }
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageCreateNewProfile());
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void BtnGoIn_Click(object sender, RoutedEventArgs e)
        {
            if (PsbPassword.Password == "" && CmbFIO.SelectedItem == null)
            {
                MessageBox.Show("Заполните поля!",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                var EmployeeObj = OdbConnectHelper.furObj.Employee.FirstOrDefault(x => x.Name == CmbFIO.Text && x.Password == PsbPassword.Password);
                if (EmployeeObj == null)
                {
                    MessageBox.Show("Неверный пароль",
                        "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    
                    LoginData.PostID = EmployeeObj.ID_Post;
                    LoginData.Name = EmployeeObj.Name;
                    WindowOrder windowOrder = new WindowOrder();
                    windowOrder.Show();
                }
            }
        }
    }
}
