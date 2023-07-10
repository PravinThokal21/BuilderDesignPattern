using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal class HeroBuilder : IVehicleBuilder
    {
        Vehicle vehicle = null;

        public HeroBuilder()
        {
            vehicle = new Vehicle();
        }

        public Vehicle GetVehicle()
        {
            return vehicle;
        }

        public void SetAccessories()
        {
            vehicle.Accessories = new List<string>();
            vehicle.Accessories.Add("Seat Cover");
            vehicle.Accessories.Add("Helmet");
        }

        public void SetModel()
        {
            vehicle.Model = "Hero";
        }

        public void SetEngine()
        {
            vehicle.Engine = "5 Stroke";
        }

        public void SetTransmission()
        {
            vehicle.Transmission = "120 Km/hr";
        }

        public void SetBody()
        {
            vehicle.Body = "Plastic";
        }
    }
}
