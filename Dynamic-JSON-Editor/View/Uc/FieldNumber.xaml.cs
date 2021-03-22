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
    public partial class FieldNumber : UserControl
    {
        Regex regex = new Regex(@"^(-|\+)?\d+(,\d*)?$");
       // Regex regexWhitComa = new Regex(@"^(-|\+)?(\d{1,3}){1}(\.\d{3})*(,\d+)?$");
       // pe rquando vorremo usare le virgole per le migliaia
        public FieldNumber()
        {
            InitializeComponent();
        }

        private void Button_Click_Up(object sender, RoutedEventArgs e)
        {
            if(regex.IsMatch(DeltaValue.Text))
            NumberField.Text = (decimal.Parse(NumberField.Text) + decimal.Parse(DeltaValue.Text)).ToString();
        }

        private void Button_Click_Down(object sender, RoutedEventArgs e)
        {
            if(regex.IsMatch(DeltaValue.Text))
            NumberField.Text = (decimal.Parse(NumberField.Text) - decimal.Parse(DeltaValue.Text)).ToString();
        }

        private void NumberField_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string s = ((TextBox)sender).Text + e.Text;
            if (e.Text == ",")
                s += "0";

            bool a = regex.IsMatch(s);
            e.Handled = !a;
        }
    }
}
