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

namespace autok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Auto
        {
            public string Rendszám { get; set; }
            public string Márka { get; set; }
            public string Üzemanyag { get; set; }
        
            public Auto(string rendszam, string marka, string uzemanyag)
            {
                Rendszám = rendszam;
                Márka = marka;
                Üzemanyag = uzemanyag;
            }
        }
        List<Auto> autok = new List<Auto>();

        public MainWindow()
        {
            InitializeComponent();
            autok.Add(new Auto("PFL-453", "Toyota", "Benzin"));
            datagrid.ItemsSource = autok;
        }

        private void torles(object sender, RoutedEventArgs e)
        {
            if(datagrid.SelectedItem != null && datagrid.SelectedItem is Auto)
            {
                autok.Remove((Auto)datagrid.SelectedItem);
                datagrid.Items.Refresh();
            }
        }

        private void kilepes(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void hozzaadas(object sender, RoutedEventArgs e)
        {
            autok.Add(new Auto(rendszam.Text, marka.Text, uzemanyag.Text));
            datagrid.Items.Refresh();
        }
    }
}