using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    public class Persoon
    {
        //default constructor
        public Persoon()
        {
        
        }


        private string _voornaam ="";
        //Taak 5: voeg een prive variable toe voor de achternaam begin prive variable met _

        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        //Taak 6: voeg een publieke variable toe voor Achternaam
        //        deze bewerkt in de get en set de nieuwe prive variabele voor achternaam
        //        deze prive variabele heeft de naar Achternaam en werkt zoals Voornaam

        //Taak 7: Ga terug naar Program.cs

    }
}
