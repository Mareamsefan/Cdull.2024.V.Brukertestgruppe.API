using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdull._2024.V.Brukertestgruppe.API
{
    internal class Runway
    {


        private string RunwayName { get; set; }
        private bool IsAvailable { get; set; }
        private int Distance { get; set; }



        public bool IsRunwayAvailable();
        public override string ToString();
}
