
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

namespace WpfAppGit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            //Das geht ohne Zweig?
            //Einen Zweig brauche ich für meine eigenen Änderungen
            //Eine Fork für Zusammenarbeit
            
            /*Das ist toll*/
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tata, der Durchbruch ist geschafft.");
        }
    }
}
