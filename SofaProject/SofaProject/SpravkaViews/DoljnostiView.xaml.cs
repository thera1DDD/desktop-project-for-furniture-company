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
using System.Windows.Shapes;
using SofaProject.DataFiles;

namespace SofaProject.SpravkaViews
{
    /// <summary>
    /// Логика взаимодействия для DoljnostiView.xaml
    /// </summary>
    public partial class DoljnostiView : Window
    {
        public DoljnostiView()
        {
            InitializeComponent();
            GridDoljnosti.ItemsSource = OdbConnectHelper.furObj.Employee.ToList();

            CmbDoljnost.SelectedValuePath = "ID_Post";
            CmbDoljnost.DisplayMemberPath = "Title";
            CmbDoljnost.ItemsSource = OdbConnectHelper.furObj.Post.ToList();
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            Employee employeeObj = GridDoljnosti.SelectedItem as Employee;
            OdbConnectHelper.furObj.Employee.Remove(employeeObj);
            var orderEmployee = OdbConnectHelper.furObj.Order.Where(x => x.ID_Employee == employeeObj.ID_Employee).FirstOrDefault();
            orderEmployee.ID_Employee = 0;
            OdbConnectHelper.furObj.SaveChanges();
            GridDoljnosti.ItemsSource = OdbConnectHelper.furObj.Employee.ToList();
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employee employeeObj = new Employee()
                {
                    Name = TxtSotrydnik.Text,
                    Password = PsbSotrydnik.Password,
                    Post = CmbDoljnost.SelectedItem as Post

                };
                OdbConnectHelper.furObj.Employee.Add(employeeObj);
                OdbConnectHelper.furObj.SaveChanges();
                GridDoljnosti.ItemsSource = OdbConnectHelper.furObj.Employee.ToList();
                MessageBox.Show("Сотрудник успешно добавлен!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            OdbConnectHelper.furObj.SaveChanges();
            Employee employeeObj = GridDoljnosti.SelectedItem as Employee;
            GridDoljnosti.ItemsSource = OdbConnectHelper.furObj.Employee.ToList();
        }
    }
}
