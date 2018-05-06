using System;

namespace Properties
{
    class Vehicle
    {
        public int Id { get; set; }
        public string VehicleName { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Id = 1;
            vehicle.VehicleName = "Maruti";
            vehicle.Model = "2003";
            vehicle.Type = "Four Wheeler";
            Console.WriteLine("Vehicle Details are: " + vehicle.Id + ","+ vehicle.VehicleName + "," +vehicle.Model + "," + vehicle.Type);
        }
    }
}
