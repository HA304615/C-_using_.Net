using System;

namespace Inheritance
{
    public class Vehicle
    {
        public void VehicleInfo()
        {
            Console.WriteLine("Vehicle Details are:");
        }
    }
    class TwoWheeler : Vehicle
    {   
        public void Bajaj()
        {
            Console.WriteLine("This is a Bajaj two wheeler!");
        }
    }
    class FourWheeler : Vehicle
    {
        public void Car()
        {
            Console.WriteLine("This a four wheeler i.e a car");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TwoWheeler twoWheeler = new TwoWheeler();
            twoWheeler.VehicleInfo();
            twoWheeler.Bajaj();
            FourWheeler fourWheeler = new FourWheeler();
            fourWheeler.VehicleInfo();
            fourWheeler.Car();
        }
    }
}
