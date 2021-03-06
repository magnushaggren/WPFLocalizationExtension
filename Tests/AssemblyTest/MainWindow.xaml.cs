﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using WPFLocalizeExtension.Engine;
using WPFLocalizeExtension.Providers;

namespace AssemblyTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.DataContext = new MyViewModel();
            InitializeComponent();
        }

        private void ButtonAssembly_Click(object sender, RoutedEventArgs e)
        {
            this.SetValue(ResxLocalizationProvider.DefaultAssemblyProperty, "AssemblyTest");
        }
    }
}
