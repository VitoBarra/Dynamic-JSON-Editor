﻿using Dynamic_JSON_Editor.ViewModel;
using System.Windows;

namespace Dynamic_JSON_Editor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow = new MainWindowView(new MainViewMode());
            MainWindow.Show();
        }
    }
}