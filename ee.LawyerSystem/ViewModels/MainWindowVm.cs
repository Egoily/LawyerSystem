using MaterialDesignThemes.Wpf;
using System;
using ee.LawyerSystem.Modules;
using ee.ls.ViewModel.Models;

namespace ee.LawyerSystem.ViewModels
{
    public class MainWindowVm
    {
        public MainWindowVm(ISnackbarMessageQueue snackbarMessageQueue)
        {
            if (snackbarMessageQueue == null) throw new ArgumentNullException(nameof(snackbarMessageQueue));

            ModuleItems = new[]
            {
                new ModuleItem("Home", new Home()),
                new ModuleItem("法院管理", new CourtManagement { } ),
                new ModuleItem("法官管理", new JudgeManagement { } ),
                new ModuleItem("客户管理", new ClientManagement { } ),
            };
        }

        public ModuleItem[] ModuleItems { get; }
    }
}