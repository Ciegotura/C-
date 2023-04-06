using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikcjakonsoli1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ZMIENNE CALKOWITE
            var zmienna = 1; //zmienna zwykla, tu var za int
            int zmienna_int = 1;
            int zmienna_max = int.MaxValue;//przypisuje maksymalna wartosc inta
            uint xdddd = 1; //tylko dodatnie
            var zmienna2 = "napis"; //C# sam okresla jaka to smienna ze to string, var to zakrycie takie
            byte t = 4; // bardzo maly typ, tylko 255 liczb przechowuje, nieujemne
            sbyte xd = 8; // bardzo mala wartosc, tez minusowe
            short schort = 8; // 32k wartosc max, next int
            ushort jooo = 1000; // przechowuje tylko dodatnie (przez co wiencej pamienci i wienkszy zakres)
            long llong = 6;
            ulong fffff = 8; //tylko dodatnie

            //ZMIENNE NIE CALKOWITE
            float jcco =  1.7f;//musi byc f na koncu bo domyslnie jest double
            double jjpjpjp = 1.7;
            decimal jjj = 1.6M; // potezny rozmiary przechowuje

            //ZMIENNE TEKSTOWE
            string tomasz = "tomasz";
            char jedenznak = 'T'; //only jeden znak
            var ii = 'a'; 

            //ZMIENNA LOGICZNA
            bool lol = false; //lub true moze byc
            bool olo = 5 > 2; //operacja logiczna
            Console.ForegroundColor = ConsoleColor.Blue;         //<----------------- Zmienia kolor liter
            Console.WriteLine(olo); //wypisze true lol 
            if (olo == false)
            {
                Console.WriteLine("prowda");
            }
            else Console.WriteLine("Nicht");

            Console.BackgroundColor = ConsoleColor.Green;    //<------------ Zmienia kolor tła 
            Console.WriteLine(zmienna);//metoda wypisująca "napis" lub cyfre, zmienne

            Console.ResetColor();    // <---- resetuje kolory
            Console.WriteLine("Zmienna 1 {0}, zmienna 2 {1}, zmienna 3", jcco, jjpjpjp, t);       //<----- inny sposób wypisywania

            double cc = Math.Pow(2, 3);   //<--- funkcja pow nasza fajna

            Console.WriteLine("2^3 = {0}", cc);

            Console.WriteLine("Jakie mosz imie");

            string imie = Console.ReadLine();                           //<------- wpisywanie danych 

            Console.WriteLine("Hello {0}, zagrajma",imie);
            while (true)
            {
                //  POBIERANIE DANEJ TYPU INT Z KLAWIATURY
                int danaZKlawiatury = 0; //zgadnij = 7;
                                         //Randomowy numer do zgadywania
                Random allmidallrandom = new Random();
                int zgadnij = allmidallrandom.Next(1, 11);         //<--------------------randomowy numer od 0 do 10


                while (danaZKlawiatury != zgadnij)
                {
                    string dawaj = Console.ReadLine();
                    //UPEWNIANIE SIE ZE JEST TO INT
                    if (!int.TryParse(dawaj, out danaZKlawiatury))
                    {
                        Console.WriteLine("To nie numer dawaj dalej");

                        continue;
                    }

                    danaZKlawiatury = Int32.Parse(dawaj); //Jest!
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Pobrana liczba {0}", danaZKlawiatury);
                    if (danaZKlawiatury == zgadnij)
                    {
                        Console.WriteLine("Gratulacjum, zgadles to byla liczba 7");
                      Console.WriteLine("Chcesz grac dalej Y/N");
                    string answer = Console.ReadLine().ToUpper();    //<--- bedzie odpowiedz toupperowana
                    if(answer == "Y")
                    {
                        continue;
                    }else
                    {Console.ReadKey();//metoda ktora przytrzymuje konsole az nacisniemy dowolny klawisz
                        return;
                    }
                    }
                    else
                    {
                        Console.WriteLine("Zgaduj dalej");


                    }
                    
                }
            }
            
        }
    }
}
