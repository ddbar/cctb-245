using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // DemoInheritance();
            // DemoPolymorphism(); // this is a "method call" - it tells the method to run
            DemoOperatorOverloading();
        }

        static void DemoOperatorOverloading()
        {
            Cylinder barrel = new Cylinder(5, 20);
            Console.WriteLine("The volume is " + barrel.Volume);
            Cylinder doubleBarrel = barrel + barrel;
            Console.WriteLine("The Volume is " + doubleBarrel.Volume);
                   
        }
        // This is a "method declaration" - it states what the instructions are
        static void DemoPolymorphism()

        {
            Store otherStore = new Store(2, "Future Buy");
            Product myProduct = otherStore.GetProducts(5);
            myProduct.Purchase(); // Call the method 

            laptopcomputer myMac = new laptopcomputer();
            myMac.Name = "Macbook Pro";
            myMac.Purchase();
        }

        static void DemoInheritance()

        {
            // use my store and look up a product
            Store myStore = new Store(1, "Best Store");
            Product myProduct = myStore.GetProducts(5);

            Console.WriteLine("Store is {0}, Product is {1}", myStore.Name, myProduct.Name);

            // Explore the computer class

            // Instantiatie (create) an object of data type Computer
            Computer oldMachine = new Computer();
            oldMachine.CPU = "x86";
            oldMachine.OperatingSystem = "windows xp";
            oldMachine.Name = "HP 1234 - x";
            oldMachine.Id = 25;

            //Instantiate a LaptopComputer with an Initializer List
            laptopcomputer newMacine = new laptopcomputer()
            {
                Id = 77,
                Name = "HP 532 - Y",
                CPU = "Athalon Tiger",
                MonitorSize = 27.5,
            };
        }
            // newMachine
        }
    
}
