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
    /// Логика взаимодействия для WindowNewOrder.xaml
    /// </summary>
    public partial class WindowNewOrder : Window
    {
        public WindowNewOrder()
        {
            InitializeComponent();
            Korzina();
            CmbClients.SelectedValuePath = "ID_Client";
            CmbClients.DisplayMemberPath = "Title";
            CmbClients.ItemsSource = OdbConnectHelper.furObj.Client.ToList();

            CmbMebelGroup.SelectedValuePath = "ID_GroupProd";
            CmbMebelGroup.DisplayMemberPath = "Title";
            CmbMebelGroup.ItemsSource = OdbConnectHelper.furObj.GroupProduct.ToList();

            CmbMaster.SelectedValuePath = "ID_Employee";
            CmbMaster.DisplayMemberPath = "Name";
            CmbMaster.ItemsSource = OdbConnectHelper.furObj.Employee.ToList();

            CmbPrinimal.SelectedValuePath = "ID_Employee";
            CmbPrinimal.DisplayMemberPath = "Name";
            CmbPrinimal.ItemsSource = OdbConnectHelper.furObj.Employee.ToList();

            CmbMebelTitle.DisplayMemberPath = "Title";
            CmbMebelTitle.SelectedValuePath = "ID_Price";
            CmbMebelTitle.ItemsSource = OdbConnectHelper.furObj.Price.ToList();
        }

        private void BtnEnterOrder_Click(object sender, RoutedEventArgs e)
        {
            //передача в итоговый заказ наименования товара
            string titleTovar = CmbMebelTitle.Text.ToString();
            TxtNameIzdelie.Text = titleTovar;
            //дата начала
            TxtDateStartOrderItog.Text = DateTime.Now.ToString();
            var izdeliePrice = OdbConnectHelper.furObj.Price.Where(x => x.Title == CmbMebelTitle.Text).Select(x => x.Price1).FirstOrDefault();
            var izdeliePriceInt = Convert.ToInt32(izdeliePrice);
            var izdelieCount =Convert.ToInt32(TxtCoutMebel.Text);
            var summa = izdelieCount * izdeliePriceInt;
            //сумма итог
            TxtSummaItog.Text = summa.ToString();
            //количество итог
            TxtCountItog.Text = TxtCoutMebel.Text;
            //дата окончания заказа
            var timeCraft = OdbConnectHelper.furObj.Price.Where(x => x.Title == CmbMebelTitle.Text).Select(x => x.TimeCraft).FirstOrDefault();
            var dateEnd = izdelieCount * timeCraft ;
            TxtDataEndItog.Text = DateTime.Now.AddDays(dateEnd).ToString();
            //нахождение скидки по Id клиента
            int clientID = Convert.ToInt32(CmbClients.SelectedValue);
            var discountObj = OdbConnectHelper.furObj.Client.Where(x => x.ID_Client == clientID).Select(x => x.Discount).FirstOrDefault();
            int discount = (summa * Convert.ToInt32(discountObj)) /100;
            int discountPrice = summa - discount;
            //стоимость со скидкой
            TxtDiscountPriceItog.Text = discountPrice.ToString();
            
        }

        public void CmbClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int clientID = Convert.ToInt32(CmbClients.SelectedValue);
            var discountObj = OdbConnectHelper.furObj.Client.Where(x => x.ID_Client == clientID).Select(x => x.Discount).FirstOrDefault();
            TxtDiscount.Text = discountObj.ToString() + "%";
        }

        private void CmbMebelGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int mebelGrpupId = Convert.ToInt32(CmbMebelGroup.SelectedValue);
            CmbMebelTitle.DisplayMemberPath = "Title";
            CmbMebelTitle.SelectedValuePath = "ID_Price";
            ////CmbMebelTitle.ItemsSource = OdbConnectHelper.furObj.Price.Where(x => x.ID_Group == mebelGrpupId).Select(x => x.Title).ToList();

        }
        private void CmbMebelTitle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
       
        /// <summary>
        /// Логика добавления заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddOrder_Click(object sender, RoutedEventArgs e)
        {
           
            //нахождение готовности заказа
            var izdelieCount = Convert.ToInt32(TxtCoutMebel.Text);
            var timeCraft = OdbConnectHelper.furObj.Price.Where(x => x.Title == CmbMebelTitle.Text).Select(x => x.TimeCraft).FirstOrDefault();
            var dateEnd = izdelieCount * timeCraft;
            string orderReady;

            if (Convert.ToDateTime(TxtDataEndItog.Text) >= DateTime.Now.AddDays(dateEnd))
            {
                orderReady = "Готов";
            }
            else
            {
                orderReady = "Не готов";
            }
            //добавление заказа
            Order orderObj = new Order()
            {
                DateStart = Convert.ToDateTime(TxtDateStartOrderItog.Text),
                Client = CmbClients.SelectedItem as Client,
                DateEnd = Convert.ToDateTime(TxtDataEndItog.Text),
                PriceDiscount = Convert.ToDecimal(TxtDiscountPriceItog.Text),
                PriceFull = Convert.ToDecimal(TxtSummaItog.Text),
                Employee = CmbPrinimal.SelectedItem as Employee,
                Status = orderReady
            };
            OdbConnectHelper.furObj.Order.Add(orderObj);
            OdbConnectHelper.furObj.SaveChanges();

            OrderDetails orderDetails = new OrderDetails()
            {
                Count = Convert.ToInt32(TxtCountItog.Text),
                PositionDateEnd = Convert.ToDateTime(TxtDataEndItog.Text),
                Employee = CmbMaster.SelectedItem as Employee,
                Price = CmbMebelTitle.SelectedItem as Price,
                Order = orderObj,
                
            };
            OdbConnectHelper.furObj.OrderDetails.Add(orderDetails);
            OdbConnectHelper.furObj.SaveChanges();
            MessageBox.Show("Заказ успешно добавлен", 
               "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if(printDialog.ShowDialog()==true)
            {
                printDialog.PrintVisual(DataContextPrint, "");
                MessageBox.Show("Чек успешно оформлен!", "Увед" +
                    "омление!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Пользователь прервал печать",
                    "Уведомление", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
        }
        private void Korzina()
        {
            TxtCoutMebel.Text = "5";
            TemporaryOrderDetails.Count = Convert.ToInt32(TxtCoutMebel.Text);

        }
    }
}
