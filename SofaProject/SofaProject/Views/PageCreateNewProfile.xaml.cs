using SofaProject.DataFiles;
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
    /// Логика взаимодействия для PageCreateNewProfile.xaml
    /// </summary>
    public partial class PageCreateNewProfile : Page
    {
        public PageCreateNewProfile()
        {
            InitializeComponent();
            CmbDoljnost.SelectedValuePath = "ID_Post";
            CmbDoljnost.DisplayMemberPath = "Title";
            CmbDoljnost.ItemsSource = OdbConnectHelper.furObj.Post.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Employee employeeObj = new Employee()
            {
                Name = TxtSotrydnik.Text,
                Post = CmbDoljnost.SelectedItem as Post,
                Password = PsbPassword.Password
            };
            OdbConnectHelper.furObj.Employee.Add(employeeObj);
            OdbConnectHelper.furObj.SaveChanges();
            ClearFields();
            MessageBox.Show("Пользователь успешно добавлен!","Уведомление",MessageBoxButton.OK,MessageBoxImage.Information);
        }
        private void ClearFields()
        {
            TxtSotrydnik.Text = null;
            CmbDoljnost.SelectedItem = null;
            PsbPassword.Password = null;
        }
    }
}
