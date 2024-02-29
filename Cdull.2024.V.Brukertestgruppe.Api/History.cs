using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdull._2024.V.Brukertestgruppe.API
{
    internal class History
    {
        private string FlightNumber { get; set; }
        private List<string> UsedGates { get; set; } = new List<string>();
        private List<string> UsedRunways { get; set; } = new List<string>();
        private DateTime Timestamps { get; set; }

        private List<History> allFlightHistories;
        public History(string FlightNumber, List<string> UsedGates, List<string> UsedRunways, DateTime TimeStamps);

        public void CreateFlightHistory(string FlightNumber, List<string> UsedGates, List<string> UsedRunways, DateTime TimeStamps); 

        public List<string> GetFlightHistory(string FlightNumber);

        public string ToString();
    }
}
