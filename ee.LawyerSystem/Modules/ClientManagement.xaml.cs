﻿using ee.LawyerSystem.ViewModels;
using ee.ls.ViewModel.Models;
using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;

namespace ee.LawyerSystem.Modules
{
    /// <summary>
    /// Interaction logic for ClientManagement.xaml
    /// </summary>
    public partial class ClientManagement : UserControl
    {
        private ClientViewModel viewModel;

        public ClientManagement()
        {
            InitializeComponent();
            viewModel = new ClientViewModel();
            DataContext = viewModel;
        }

        private void DialogHost_OnDialogClosing_DeleteItem(object sender, DialogClosingEventArgs eventArgs)
        {
            viewModel.DeleteItem(sender, eventArgs);
        }
    }
}
