// using statements allow me access to the classes in the stated namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.AdHoc_Demo; // collection class demos

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {

           // Run some of the demos

            //ArrayDemo Demo1 = new ArrayDemo();
            //Demo1.Run();

            ListDemo Demo1 = new ListDemo();
            Demo1.Run();

            // Card();


        }

        //static void Card()
        //{

          // / Card ThreeOfSpades = new Card(SPADES, Three);
           // /Card KingOfClubs= new Card(CLUBS, King);

                 

        }
    
    }

