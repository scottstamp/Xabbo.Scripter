﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

using Xabbo.Scripter.ViewModel;

namespace Xabbo.Scripter.View
{
    public partial class ScriptsView : UserControl
    {
        public ScriptsViewManager Manager => (ScriptsViewManager)DataContext;

        public ScriptsView()
        {
            InitializeComponent();
        }

        private void ScriptTab_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is not FrameworkElement element ||
                element.DataContext is not ScriptViewModel scriptViewModel)
            {
                return;
            }

            if (e.ChangedButton == MouseButton.Middle)
            {
                e.Handled = true;

                Manager.CloseScript(scriptViewModel);
            }
        }
    }
}