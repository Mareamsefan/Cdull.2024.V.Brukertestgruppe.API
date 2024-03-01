using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdull._2024.V.Brukertestgruppe.API
{
    internal class Taxiway
    {
        private string TaxiwayName { get; set; }
        private int Distance { get; set; }


        
        public void AddToRunway(string TaxiwayName);

        public void AddToGate(string TaxiwayName);

        public string ToString();
    }
}
