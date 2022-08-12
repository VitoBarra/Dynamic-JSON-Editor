using MvvmCross.Platforms.Wpf.Views;
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
using Dynamic_JSON_Editor.JSONInterpreter;
using Microsoft.Win32;
using IO.JsonFile;

namespace Dynamic_JSON_Editor.View
{
    /// <summary>
    /// Logica di interazione per BaseView.xaml
    /// </summary>
    public partial class MainView : MvxWpfView
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new();
            if (fileDialog.ShowDialog() == true)
               JsonInterpreter.WriteInterOnFile(UtilityFileReader.ReadJsonFromFile<dynamic>(fileDialog.FileName),
                   @"C:\Users\tovi2\Source\Repos\VitoBarra\Dynamic-JSON-Editor\Dynamic-JSON-Editor\TestRes\Out\out.json"
                   );
        }
    }
}
