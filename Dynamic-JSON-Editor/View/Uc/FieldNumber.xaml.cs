using MvvmCross.Platforms.Wpf.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Dynamic_JSON_Editor.View.Uc
{
    /// <summary>
    /// Logica di interazione per FieldNumber.xaml
    /// </summary>
    public partial class FieldNumber : MvxWpfView
    {
        Regex acceptedChar= new Regex(@"[0-9\-\,\+\.]+");
        //Regex regex = new Regex(@"^(-|\+)?\d+(,\d*)?$");
       // Regex regexWhitComa = new Regex(@" ^ (-|\+)?(\d{1,3}){1}(\.\d{3})*(,\d+)?$");
       // pe rquando vorremo usare le virgole per le migliaia
        public FieldNumber()
        {
            InitializeComponent();
        }
        private void NumberField_PreviewTextInput(object sender, TextCompositionEventArgs e) 
            => e.Handled = !acceptedChar.IsMatch(e.Text);

   

    }
}
