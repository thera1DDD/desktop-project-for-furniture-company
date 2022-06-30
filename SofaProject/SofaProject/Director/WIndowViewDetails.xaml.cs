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
using System.Windows.Shapes;

namespace SofaProject.Director
{
    /// <summary>
    /// Логика взаимодействия для WIndowViewDetails.xaml
    /// </summary>
    public partial class WIndowViewDetails : Window
    {
        public WIndowViewDetails()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GridOrderDetails.ItemsSource = OdbConnectHelper.furObj.OrderDetails.Where(x => x.ID_Order.ToString() == TxtIdOrder.Text).ToList();
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
        }
    }
}
