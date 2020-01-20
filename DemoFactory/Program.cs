using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFactory
{//product interfact\e
    interface Ifactory
    {
        void manufacture(int cnt);
    }
    //creation of the product class
    class Bike : Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("Bike Manufacturing No: " + cnt);

        }
    }
    //creation of the product class
    class car : Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("Car Manufacturing No: " + cnt);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory obj = new ConcreateVehicleFactory();
            Ifactory myVehicle=obj.generateVehicles("Bike");
            myVehicle.manufacture(10);
            myVehicle = obj.generateVehicles("Car");
            myVehicle.manufacture(20);
            Console.ReadLine();
        }
    }
    //crete
    abstract class VehicleFactory
        {
        public abstract Ifactory generateVehicles(string type);
        }
    //actual creation cass
    class ConcreateVehicleFactory: VehicleFactory
    {
        public override Ifactory generateVehicles(string type)
        {
     
                if (type == "Bike")
                return new Bike();
                else
                return new car();
        }

        }
    }

