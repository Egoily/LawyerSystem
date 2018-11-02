using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
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

namespace ee.LawyerSystem.Modules
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            areaSelector.Provinces = ls.ViewModel.ViewModels.GlobalVm.GetProvince();
            areaSelector.Province = "广东省";
            areaSelector.City = "广州市";
            areaSelector.County = "番禺区";
        }

        private void DialogHost_OnDialogClosing(object sender, DialogClosingEventArgs eventArgs)
        {

            if (!Equals(eventArgs.Parameter, true)) return;

            Console.Write("Do Delete.");

        }

    }
}
