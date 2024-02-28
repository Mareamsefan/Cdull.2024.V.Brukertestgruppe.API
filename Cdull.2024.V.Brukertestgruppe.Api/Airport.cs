using System.Runtime.Intrinsics.X86;

namespace Cdull._2024.V.Brukertestgruppe.Api
{
    public class Airport
    {

        private List<Gate> Gates { get; set; } = new List<Gate>();  

        private List<Runway> Runaways { get; set; } = new List<Runway>();

        private List<Taxiway> Taxiways { get; set; } = new  List<Taxiway>();

        public void ConfigurateAirPort(List<Gate> gates, List<Runway> runways, List<Taxiway> taxiways);

        public override string ToString()
        {
            return null;
        }







    }

    
}
