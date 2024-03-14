using System;


namespace Ncit_Nishan
{
    class Vehicle { 
    public void StartEngine()
        {
            Console.WriteLine("Vehicle engine Started.");
        }
    
    }
    class Bus : Vehicle
    {
        public void StartCar()
        {
            Console.WriteLine("Bus engine Started.");
            base.StartEngine();
        }
    }


    internal class Basecall
    {
        static void Main(string[] args)
        {
            Bus myBus = new Bus();
            myBus.StartCar();
            myBus.StartEngine();
            Console.WriteLine("\nNishan Bhattarai");
            Console.WriteLine("\nRollno::26453");
        }
       
    }
  
}
