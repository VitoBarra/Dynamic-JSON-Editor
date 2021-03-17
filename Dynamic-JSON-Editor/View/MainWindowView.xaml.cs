using Dynamic_JSON_Editor.ViewModel;
using System.Windows;

namespace Dynamic_JSON_Editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        private MainViewMode vm;

        public MainWindowView(MainViewMode _vm)
        {
            InitializeComponent();
            vm = _vm;
        }
    }
}