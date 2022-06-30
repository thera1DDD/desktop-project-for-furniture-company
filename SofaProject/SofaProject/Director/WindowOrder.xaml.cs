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
    /// Логика взаимодействия для WindowOrder.xaml
    /// </summary>
    public partial class WindowOrder : Window
    {
        public WindowOrder()
        {
            InitializeComponent();
            GridOrderList.ItemsSource = OdbConnectHelper.furObj.Order.ToList();
            LabelCurrentUser.Text = LoginData.Name;
            UserRules();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            WindowPrice windowPrice = new WindowPrice();
            windowPrice.Show();
        }

        public void BtnViewDetails_Click(object sender, RoutedEventArgs e)
        {
            WIndowViewDetails wvd = new WIndowViewDetails();
            Order orderObj = GridOrderList.SelectedItem as Order;
            if (orderObj != null)
            {
                wvd.TxtIdOrder.Text = Convert.ToString(orderObj.ID_Order);
                wvd.TxtDiscountPrice.Text = Convert.ToString(orderObj.PriceDiscount);
                wvd.TxtClient.Text = Convert.ToString(orderObj.Client.Title);
                wvd.TxtOrderDate.Text = Convert.ToString(orderObj.DateStart);
                wvd.TxtOrderDateEnd.Text = Convert.ToString(orderObj.DateEnd);
                wvd.TxtOrderPrice.Text = Convert.ToString(orderObj.PriceFull);
                wvd.Show();
            }
            else
            {
                MessageBox.Show("Выберите заказ", "Уведомление"
                    , MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnEditOrder_Click(object sender, RoutedEventArgs e)
        {
            OdbConnectHelper.furObj.SaveChanges();
        }

        private void BtnNewOrder_Click(object sender, RoutedEventArgs e)
        {
            WindowNewOrder windowNewOrder = new WindowNewOrder();
            windowNewOrder.Show();
        }
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void MenuRekvizits_Click(object sender, RoutedEventArgs e)
        {
            SpravkaViews.RekvizitiView rekvizitiView = new SpravkaViews.RekvizitiView();
            rekvizitiView.Show();
        }

        private void MenuDoljnostiItems_Click(object sender, RoutedEventArgs e)
        {
            SpravkaViews.DoljnostiView doljnostiView = new SpravkaViews.DoljnostiView();
            doljnostiView.Show();
        }

       
        private void MenuClientItems_Click(object sender, RoutedEventArgs e)
        {
            SpravkaViews.ClientView clientView = new SpravkaViews.ClientView();
            clientView.Show();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Order orderObj = GridOrderList.SelectedItem as Order;
            GridOrderList.ItemsSource = OdbConnectHelper.furObj.Order.ToList();
            
            if (GridOrderList.SelectedItem!=null)
            {
                if (orderObj.DateEnd <= DateTime.Now)
                {
                    orderObj.Status = "Готов";
                }
                else
                {
                    orderObj.Status = "Не готов";
                }
            }
            else
            {
                GridOrderList.ItemsSource = OdbConnectHelper.furObj.Order.ToList();
            }
            OdbConnectHelper.furObj.SaveChanges();
        }
        private void UserRules()
        {
            var checkUser = OdbConnectHelper.furObj.Employee.Where(x => x.Name == LabelCurrentUser.Text).Select(x => x.Post.Title).FirstOrDefault();
            if(checkUser !="Менеджер" && checkUser !="Директор")
            {
                BtnEditOrder.IsEnabled = false;
                BtnUpdate.IsEnabled = false;
                BtnViewDetails.IsEnabled = false;
                BtnNewOrder.IsEnabled = false;
                MenuClientItems.IsEnabled = false;
                MenuDoljnostiItems.IsEnabled = false;
                MenuRekvizits.IsEnabled = false;
            }
        }

        private void MenuAboutItem_Click(object sender, RoutedEventArgs e)
        {
            WindowAbout windowAbout = new WindowAbout();
            windowAbout.Show();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Order orderObj = GridOrderList.SelectedItem as Order;
                if (orderObj!=null)
                {
                    OdbConnectHelper.furObj.Order.Remove(orderObj);
                    var orderDetObj = OdbConnectHelper.furObj.OrderDetails.Where(x => x.ID_Order == orderObj.ID_Order).FirstOrDefault();
                    OdbConnectHelper.furObj.OrderDetails.Remove(orderDetObj);
                    OdbConnectHelper.furObj.SaveChanges();
                    GridOrderList.ItemsSource = OdbConnectHelper.furObj.Order.ToList();
                }
                else
                {
                    MessageBox.Show("Выберите заказ для удаления!",
                        "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
    }
}
