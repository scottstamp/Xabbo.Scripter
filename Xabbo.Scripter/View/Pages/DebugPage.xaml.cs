﻿using System;
using System.Collections.Generic;
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

namespace Xabbo.Scripter.View.Pages
{
    /// <summary>
    /// Interaction logic for TestPage.xaml
    /// </summary>
    public partial class DebugPage : Page
    {
        private readonly Random _rng = new();

        public DebugPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["ApplicationBackgroundColor"] = Color.FromRgb(
                (byte)_rng.Next(0, 256),
                (byte)_rng.Next(0, 256),
                (byte)_rng.Next(0, 256)
            );
        }

        private void ButtonAttachDebugger_Click(object sender, RoutedEventArgs e)
        {
            if (!Debugger.IsAttached)
            {
                Debugger.Launch();
            }
        }
    }
}
