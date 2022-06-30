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

namespace SofaProject.SpravkaViews
{
    /// <summary>
    /// Логика взаимодействия для RekvizitiView.xaml
    /// </summary>
    public partial class RekvizitiView : Window
    {
        public RekvizitiView()
        {
            InitializeComponent();
            FirmDetailsShow();
        }
        private void FirmDetailsShow()
        {
            var titleFirm = OdbConnectHelper.furObj.FirmDetails.Where(x => x.ID_Details == 1).Select(x => x.Title).FirstOrDefault();
            TxtFirmName.Text = titleFirm;
            var bankData = OdbConnectHelper.furObj.FirmDetails.Where(x => x.ID_Details == 1).Select(x => x.BankDetails).FirstOrDefault();
            TxtBankData.Text = bankData;
            var kppData = OdbConnectHelper.furObj.FirmDetails.Where(x => x.ID_Details == 1).Select(x => x.KPP).FirstOrDefault();
            TxtCodeKpp.Text = kppData;
            var innData = OdbConnectHelper.furObj.FirmDetails.Where(x => x.ID_Details == 1).Select(x => x.INN).FirstOrDefault();
            TxtCodeINN.Text = innData;
            var fioDirector = OdbConnectHelper.furObj.FirmDetails.Where(x => x.ID_Details == 1).Select(x => x.Director).FirstOrDefault();
            TxtFioDirector.Text = fioDirector;
            var phoneNumber = OdbConnectHelper.furObj.FirmDetails.Where(x => x.ID_Details == 1).Select(x => x.Phone).FirstOrDefault();
            TxtPhoneNumber.Text = phoneNumber;
            var addressData = OdbConnectHelper.furObj.FirmDetails.Where(x => x.ID_Details == 1).Select(x => x.Address).FirstOrDefault();
            TxtAddress.Text = addressData;
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
