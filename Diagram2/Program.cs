using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram2
{
    public class Vehicle
    {
        protected string make;
        protected string model;
        protected int year;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Vehicle() { }

        public Vehicle(string make, string model) { Console.WriteLine("Overload Method Invoked"); }

        public void Accelerate() { }
        public void Decelerate() { }
        public void Drive() { }
        public void Start() { }
        public void Stop() { }

    }

    public class Car : Vehicle { }

    public class Sportscar : Car { }

    public class Van : Vehicle { }

    public class Minivan : Van
    {
        protected int cargo_Net;
        protected bool dual_Sliding;

        public bool HasCargoNet() { return true; }
        public bool HasDualSlidingDoors() { return dual_Sliding; }

        public Minivan() { }

        public Minivan(int cargo_Net, bool dual_Sliding) { }

        public void SetCargoNet(int cargo_Net)
        {
            this.cargo_Net = cargo_Net;
        }

        public void SetDualSliding(bool dual_Sliding)
        {
            this.dual_Sliding = dual_Sliding;
        }
    }

    public class ExcursionVan : Van { }

    public class TestVehicles
    {
        private static void Main(string[] args)
        {

        }
    }
}