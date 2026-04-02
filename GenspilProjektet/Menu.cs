using System;
namespace GenspilProjektet
{
    public class Menu
    {
        public void Start()
        {
            bool running = true;

            while (running)
            {
                
                PrintHeader();

                Console.WriteLine("1. Spiloversigt");
                Console.WriteLine("2. Reservationer");
                Console.WriteLine("3. Forespørgsler");
                Console.WriteLine("4. Forespørgsels Liste");
                Console.WriteLine("5. Afslut");

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        ShowSpil();
                        break;

                    case ConsoleKey.D2:
                        ShowReservationer();
                        break;

                    case ConsoleKey.D3:
                        ShowForespørgsler();
                        break;

                    case ConsoleKey.D4:
                        ShowLager();
                        break;

                    case ConsoleKey.D5:
                        running = false;
                        break;

                    default:
                        ErrorMessage();
                        break;
                }
            }
        }
        void PrintHeader()
        {
            Console.WriteLine("====================");
            Console.WriteLine("  GENSPIL SYSTEM  ");
            Console.WriteLine("====================");
        }

        void ShowSpil()
        {
            Console.Clear();
            Console.WriteLine(" [Spiloversigt]");
            Pause();

        }

        void ShowReservationer()
        {
            Console.Clear();
            Console.WriteLine("[Reservationer]");
            Pause();
        }

        void ShowForespørgsler()
        {
            Console.Clear();
            Console.WriteLine("[Forespørgsler]");
            Pause();
        }

        void ShowLager()
        {
            Console.Clear();
            Console.WriteLine("[Forespørgsels Liste]");
            Pause();
        }

        void ErrorMessage()
        {
            
            Console.WriteLine("Ugyldigt input");
            Pause();
        }

        void Pause()
        {
            
            Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
    
 

    