using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatalogiAssignment1
{
    internal class Menu
    {
        private int menuChoice;
        private int nrOfChoice;
        private string errormsg;
        private List<int> listOfPrimes;

        //Initi
        internal Menu()
        {
            listOfPrimes = new List<int>();
            nrOfChoice = 4;
            MainMenu();
        }

        private void MainMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Välkommen!");
                Console.WriteLine("Ni har följande val:");
                Console.WriteLine("1. Kolla om ett heltal är primtal.");
                Console.WriteLine("2. Lista alla sparade primtal.");
                Console.WriteLine("3. Lägg till ett primtal efter det högsta talet i listan.");
                Console.WriteLine("4. Avsluta.");
                Console.Write("Ditt val: ");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        keepRunning = false;
                        Console.Clear();
                        Console.WriteLine("Tack och hej!");
                        break;
                }

            }
        }
    }
}
