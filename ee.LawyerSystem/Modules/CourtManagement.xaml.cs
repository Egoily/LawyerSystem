using ee.LawyerSystem.ViewModels;
using ee.ls.ViewModel.Models;
using MaterialDesignThemes.Wpf;
using System;
using System.Windows;
using System.Windows.Controls;

namespace ee.LawyerSystem.Modules
{
    /// <summary>
    /// Interaction logic for CourtManagement.xaml
    /// </summary>
    public partial class CourtManagement : UserControl
    {
        private CourtViewModel viewModel;

        public CourtManagement()
        {
            InitializeComponent();
            viewModel = new CourtViewModel();
            DataContext = viewModel;
        }

        private void DialogHost_OnDialogClosing_DeleteItem(object sender, DialogClosingEventArgs eventArgs)
        {
            viewModel.DeleteItem(sender, eventArgs);
        }
    }
}
