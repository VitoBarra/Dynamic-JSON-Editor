using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;
using System.Windows;
using Mxv_Dynamic_JSON_Editor;
using Mxv_Dynamic_JSON_Editor.Core.ViewModels;

namespace Dynamic_JSON_Editor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : MvxApplication
    {

        protected override void RegisterSetup()
        {
            this.RegisterSetupType<MvxWpfSetup<Mxv_Dynamic_JSON_Editor.Core.App>>();

            //MainWindow = new MainWindow(new MainViewModel());
            //MainWindow.Show();
        }
    }
}