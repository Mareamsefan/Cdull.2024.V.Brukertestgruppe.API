using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdull._2024.V.Brukertestgruppe.API
{
    internal class Plane
    {
        private string PlaneId {  get; set; }
        private DateTime DepartureTime { get; set; }
        private bool IsFlightRecurring { get; set; }
        private float Acceleration { get; set; }
        private List<string> UsedGates { get; set; } = new List<string>();
        private List<string> UsedRunways { get; set; } = new List<string>();




       
        public Plane();

        public event EventHandler<FlightEvent> FlightLeftRunwayEventTriggered;
        public void AssignGate();
        public void AssignRunway();
        
        public bool IsPlaneAssignedToGate(List<Gate>);
       
        public bool IsPlaneAssignedToRunway(List<Runway>);

        public bool IsPlaneAssignedToTaxiway(List<Taxiway>);

        public bool HasPlaneTakenOff();

        public override string ToString();

        public void TakeOff();

        public enum AircraftType
        {
            JumboJet,
            CargoAirplane,
            Widebody,
            Narrowbody,
            PrivateJet,
            HeavyJet,
            MidsizeJet,
            LightJet,
            VeryLightJet,
            PropellerPlane,
            AmhibiousPlane,
            AerobaticPlane,
            TurbopropPlane

        }


    }
}
