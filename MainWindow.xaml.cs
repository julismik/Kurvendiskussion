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

namespace Kurvendiskussion
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double anstieg = Convert.ToDouble(A.Text);
            double verschiebung = Convert.ToDouble(B.Text);
            KurveliniareF f = new KurveliniareF(anstieg, verschiebung);
            
            string Ausgabe;
            Ausgabe = "Die Nullstelle ist x_n = " + f.berechnenNullstelle() + "\n";
            Ausgabe += " Der Schnittpunkt mi der xAchse liegt bei: (" + f.berechnenNullstelle() + "/0" ;
            Ergebnis.Text = Ausgabe;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double anstieg = Convert.ToDouble(A.Text);
            double verschiebung = Convert.ToDouble(B.Text);
            double punkt = Convert.ToDouble(Punkt.Text);
            KurveliniareF f = new KurveliniareF(anstieg, verschiebung);
           
           
            Wert.Text = Convert.ToString(f.berechnenFunktionswert(Convert.ToDouble(Punkt.Text)));
        }
    }
}
