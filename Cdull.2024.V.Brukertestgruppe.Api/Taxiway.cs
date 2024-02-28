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
        private List<string> ConnectedRunways { get; set; } = new List<string>();
        private List<string> ConnectedGates { get; set; } = new List<string>();

        public void AddConnectedRunway(string TaxiwayName);

        public void AddConnectedGate(string TaxiwayName);

        public override string ToString();
    }
}
