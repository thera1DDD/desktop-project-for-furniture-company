using SofaProject.DataFiles;
using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace SofaProject.Director
{
    /// <summary>
    /// Логика взаимодействия для WindowPrice.xaml
    /// </summary>
    public partial class WindowPrice : Window
    {
        public WindowPrice()
        {
            InitializeComponent();
            GridPrice.ItemsSource = OdbConnectHelper.furObj.Price.ToList();
        }

        private void GridPrice_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            try
            {
                Price priceObj = GridPrice.SelectedItem as Price;
                txtDescription.Text = priceObj.Description;
                if (priceObj.Foto != null)
                {
                    BitmapImage image = new BitmapImage(new Uri(priceObj.Foto));
                    PictureBoxPrice.Source = image;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
        }
        private void TXtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            GridPrice.ItemsSource = OdbConnectHelper.furObj.Price.Where(x => x.Title.Contains(TXtSearch.Text)).ToList();
        }
    }
}
