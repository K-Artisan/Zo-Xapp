﻿using MahApps.Metro.Controls;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Zo.Xapp.Demos;

namespace Zo.Xapp.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly IUserService _userService;
        private readonly IDemoAppService _demoAppService;

        public MainWindow(
            IUserService userService,
            IDemoAppService demoAppService
            )
        {
            _userService = userService;
            _demoAppService = demoAppService;

            InitializeComponent();
        }

        //public MainWindow( )
        //{
        //    InitializeComponent();
        //}

        private void LaunchGitHubSite(object sender, RoutedEventArgs e)
        {
            // Launch the GitHub site...
            this.Title = _demoAppService?.GetInfos();
            //this.Title = _userService?.GetName();
        }
    }
}
