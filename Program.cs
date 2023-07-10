namespace BuilderDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder Desing Pattern");

            IVehicleBuilder heroVehicleBuilder = new HeroBuilder();
            heroVehicleBuilder.SetTransmission();
            heroVehicleBuilder.SetEngine();
            heroVehicleBuilder.SetAccessories();
            heroVehicleBuilder.SetBody();
            heroVehicleBuilder.SetModel();
            Vehicle herovehicle = heroVehicleBuilder.GetVehicle();
            herovehicle.ShowInfo();

            IVehicleBuilder hondaVehicleBuilder = new HondaBuilder();
            hondaVehicleBuilder.SetTransmission();
            hondaVehicleBuilder.SetEngine();
            hondaVehicleBuilder.SetAccessories();
            hondaVehicleBuilder.SetBody();
            hondaVehicleBuilder.SetModel();
            Vehicle hondavehicle = hondaVehicleBuilder.GetVehicle();
            hondavehicle.ShowInfo();

        }
    }
}