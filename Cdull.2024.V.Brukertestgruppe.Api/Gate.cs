﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdull._2024.V.Brukertestgruppe.API
{
    internal class Gate
    {
        internal string GateNumber { get; set; }

        internal string AllowedAircraftType { get; set; }

        internal int DistanceToTaxiway { get; set; }


        private bool IsAircraftTypeAllowed(string aircraftType);


        private bool ReserveGate(Plane flight);



        public override string ToString();

    }
}
