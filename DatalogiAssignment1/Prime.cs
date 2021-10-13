using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatalogiAssignment1
{
    public class Prime
    {
        List<int> primeList = new List<int>();//Datastruktur för att lagra primtal.
        
        //
        public void Start()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Välkommen!");
                Console.WriteLine("Ni har följande val:");
                Console.WriteLine("[1.] Kolla om ett heltal är primtal.");
                Console.WriteLine("[2.] Lista alla sparade primtal.");
                Console.WriteLine("[3.] Lägg till ett primtal efter det högsta talet i listan.");
                Console.WriteLine("[4.] Avsluta.");
                Console.Write("Ditt val: ");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        CheckNumbers();
                        break;
                    case "2":
                        ShowPrimeList();
                        break;
                    case "3":
                        AddNextPrimeToList();
                        break;
                    case "4":
                        keepRunning = false;
                        Console.Clear();
                        Console.WriteLine("Tack och hej!");
                        break;
                }
            }
        }

        //Kolla om talet är ett primtal.
        //Om det är ett primtal, sparas talet i en lista.
        public void CheckNumbers()
        {
            Console.Clear();
            try
            {
                Console.Write("Ange ett heltal: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (CheckPrime(number))
                {
                    Console.WriteLine("Detta tal är primtal.");
                    AddPrimeToList(number);
                }
                else
                {
                    Console.WriteLine("Detta tal är inte primtal.");
                }
                    
            }
            catch (Exception)
            {
                Console.WriteLine("Fel typ av inmatning, det ska vara ett postivt heltal.\n Var god och försök igen!");

            }
            
        }

        //Metoden för att lägga ett primtal i en lista.
        private void AddPrimeToList(int number)
        {
            if (!primeList.Contains(number))
            {
                primeList.Add(number);
                primeList.Sort();
            }
        }

        //Metoden för att lägga till nästa primtal efter det högsta primtalet i listan.
        private void AddNextPrimeToList()
        {
            Console.Clear();
            if (primeList != null)
            {
                int highest = primeList.Last<int>();
                int nextPrime = GetNextPrime(highest);
                Console.WriteLine($"Nästa primtal är {nextPrime}.");
                primeList.Add(nextPrime);

            }
            
        }

        //Kontroll för primtal.
        private bool CheckPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            var max = Math.Round(Math.Sqrt(number));
            for (long i = 2; i <= max; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

       //Metoden för att nästa primtal.
        private int GetNextPrime(int number)
        {
            bool found = false;
            while (!found)
            {
                number++;
                if (CheckPrime(number))
                {
                    found = true;
                }
            }
            return number;
        }

        //Metoden för att lista alla sparade primtal.
        private void ShowPrimeList()
        {
            Console.Clear();
            if (primeList.Count > 0)
            {
                foreach (var number in primeList)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Listan är tom.");
            }
        }
    }
}
