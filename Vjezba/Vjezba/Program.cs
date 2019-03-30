using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba
{
    class Program
    {
        static void StartingApp()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"------------\n1.)Novi unos\n2.)Prepravi\n3.)Obriši\n4.)Drugo\n5.)Izlaz\n------------\n");
            Console.Write("Što želiš odabrati: ");
            var answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    InputNameSurname();
                    InputNumber();
                    break;
                case "2":
                    //funkcija za prepravljanje
                    break;
                case "3":
                    //funkcija za brisanje
                    break;
                case "4":
                    //funkcija za nešto drugo
                    Console.WriteLine("Zasad nema ništa :/");
                    break;
                case "5":
                    Console.WriteLine("Doviđenja :)\n");
                    break;
                default:
                    Console.WriteLine("Pogrešan unos!\n");
                    break;
            }
            Console.ResetColor();
        }

        static void InputNameSurname()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Unesi kontakt");
            Console.ResetColor();

            Console.Write("Unesi ime: ");
            var inputName = "";

            do
            {
                inputName = Console.ReadLine();
            } while (!IsText(inputName));

            Console.Write("Unesi prezime: ");
            var inputSurname = "";

            do
            {
                inputSurname = Console.ReadLine();
            } while (!IsText(inputSurname));
        }

        static void InputNumber()
        {
            Console.Write("Unesi broj mobitela: ");

            var inputNumber = "";

            do
            {
                inputNumber = Console.ReadLine();
            } while (!IsNumber(inputNumber));


            Console.Write("Za potvrdu unesite još jednom broj: ");
            var inputNumber2 = Console.ReadLine();
            while (inputNumber.CompareTo(inputNumber2) != 0)
            {
                Console.WriteLine("Krivi unos!\nUnesite ispravan broj: ");
                inputNumber2 = Console.ReadLine();
                if (inputNumber.CompareTo(inputNumber2) == 0)
                    break;
            }
        }

        static void Main(string[] args)
        {
            StartingApp();
            /*
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Unesi kontakt");
            Console.ResetColor();

            Console.Write("Ime: ");
            var inputName = Console.ReadLine();
            Console.Write("Unesi prezime: ");
            var inputSurname = Console.ReadLine();
            
            
        Console.WriteLine("Dobar dan {0} {1}, tvoj broj mobitela je {2}.", inputName,inputSurname,inputNumber);
        */

        }

        static bool IsNumber(string toCheck)
        {
            foreach (var character in toCheck)
            {
                if (character < '0' && character != ' ')
                    return false;
                if (character > '9' && character != ' ')
                    return false;
            }
            return true;
        }

        static bool IsText(string toCheck)
        {
            foreach(var character in toCheck)
            {
                if (character < '0' && character != ' ')
                    return true;
                if (character > '9' && character != ' ')
                    return true;
            }
            return false;
        }
    }
}
