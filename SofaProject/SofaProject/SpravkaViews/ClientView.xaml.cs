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
    /// Логика взаимодействия для ClientView.xaml
    /// </summary>
    public partial class ClientView : Window
    {
        public ClientView()
        {
            InitializeComponent();
            GridClients.ItemsSource = OdbConnectHelper.furObj.Client.ToList();
        }

        private void GridClients_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            Client clientObj = GridClients.SelectedItem as Client;
            TxtPhone.Text = clientObj.Phone;
            TxtDiscount.Text = clientObj.Discount.ToString();
            TxtContactPerson.Text = clientObj.ContactPerson;
            TxtCodeKPP.Text = clientObj.KPP;
            TxtZametki.Text = clientObj.Information;
            TxtCodeINN.Text = clientObj.INN;
            TxtAddress.Text = clientObj.Address;
            TxtTitleOrg.Text = clientObj.Title;
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Client clientObj = GridClients.SelectedItem as Client;
                if (clientObj!=null)
                {
                    OdbConnectHelper.furObj.Client.Remove(clientObj);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Выберите клиента для удаления!",
                        "Уведомление",MessageBoxButton.OK,MessageBoxImage.Warning);
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(TxtTitleOrg.Text !=null)
                {
                    Client clientObj = new Client()
                    {
                        Phone = TxtPhone.Text,
                        KPP = TxtCodeKPP.Text,
                        Information = TxtZametki.Text,
                        Address = TxtAddress.Text,
                        ContactPerson = TxtContactPerson.Text,
                        Discount = Convert.ToDecimal(TxtDiscount.Text),
                        Title = TxtTitleOrg.Text,
                        INN = TxtCodeINN.Text
                    };
                    OdbConnectHelper.furObj.Client.Add(clientObj);
                    MessageBox.Show("Успешно добавленно", "Уведомение",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Заполните поля!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            OdbConnectHelper.furObj.SaveChanges();
            GridClients.ItemsSource = OdbConnectHelper.furObj.Client.ToList();
        }
        private void ClearFields()
        {
            TxtAddress.Text = null;
            TxtCodeINN.Text = null;
            TxtCodeKPP.Text = null;
            TxtContactPerson.Text = null;
            TxtDiscount.Text = null;
            TxtPhone.Text = null;
            TxtTitleOrg.Text = null;
            TxtZametki.Text = null;
        }

        private void TxtSearchClients_TextChanged(object sender, TextChangedEventArgs e)
        {
            GridClients.ItemsSource = OdbConnectHelper.furObj.Client.Where(x => x.Title.Contains(TxtSearchClients.Text)).ToList();
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
