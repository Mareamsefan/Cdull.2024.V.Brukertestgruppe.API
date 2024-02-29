using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdull._2024.V.Brukertestgruppe.API
{
    internal class Flight
    {
        private string FlightNumber {  get; set; }
        private string AircraftType { get; set; }
        private DateTime DepartureTime { get; set; }
        private bool Recurring { get; set; }
        private List<Gate> GatesUsed { get; set; } = new List<Gate>();
        private List<Runway> RunwaysUsedBy { get; set; } = new List<Runway>();



       
        public Flight();

        public event EventHandler<FlightEvent> FlightLeftRunwayEventTriggered;

        public bool AssignGate(List<Gate>);
       
        public bool AssignRunway(List<Runway>);

        public bool AssignTaxiway(List<Taxiway>);

        public bool TakeOff();

        public override string ToString();

        public void OnFlightLeftRunway();


    }
}
