﻿using System.Windows;
using Caliburn.Micro;
using EmployeeMngApp.ViewModels;

namespace EmployeeMngApp
{
    public class Bootstrapper : BootstrapperBase
    {
        //public Bootstrapper(bool useApplication = true) : base(useApplication)
        //{
        //    Initialize();
        //}

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            //base.OnStartup(sender, e);
            DisplayRootViewForAsync<MainViewModel>();
        }
    }
}
