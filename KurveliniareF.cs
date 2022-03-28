using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurvendiskussion
{
    class KurveliniareF
    {
        //Eigenschaften
        public double Anstieg {get; set; }
        public double Verschiebung { get; set; }
        

      //Methoden
      //Konstruktor ist e ine Methode die genau so heisst wie die klasse
       public KurveliniareF(double anstieg, double verschiebung) // diese variable existern nur im Konstruktor
        {
            this.Anstieg = anstieg; // this bedeutet dass variable aus classe kommt == (anstieg = m)
            this.Verschiebung = verschiebung;
            
        }

        // Weitere Methode
        public double berechnenNullstelle ()
        {
            double nullstelle;
            nullstelle = -Verschiebung / Anstieg;
            return nullstelle;
        }
        public double berechnenFunktionswert (double Punkt)
        {
            double wert;
            wert = Anstieg * Punkt + Verschiebung;
            return wert;
        }

    }
}
