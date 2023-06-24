using System;

namespace lab1ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
Folosind instructiunea “switch”, scrieti un program care citind de la tastatura un numar intreg va verifica urmatoarele
“unu” daca numarul citit este 1
 “doi” daca numarul citit este 2
 “trei” daca numarul citit este 3
 “cinci” daca numarul citit este 5
 “opt” daca numarul citit este 8
 “neidentificat” pentru orice alt caz
            */

            string numarInLitere = "neidentificat";

            Console.WriteLine("introduceti un numar");
            int numar = int.Parse(Console.ReadLine());

            {
                switch (numar)
                {
                    case 1:
                        numarInLitere = "unu";
                        break;
                    case 2:
                        numarInLitere = "doi";
                        break;
                    case 3:
                        numarInLitere = "trei";
                        break;
                    case 5:
                        numarInLitere = "cinci";
                        break;
                    case 8:
                        numarInLitere = "opt";
                        break;
                    default:
                        numarInLitere = "neidentificat";
                        break;
                }

            }

            Console.WriteLine("numarul introdus este: " + numarInLitere);
        }
    }
}
