using System;
namespace Uppgift2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Frågar hur långt Elin hoppade
            Console.WriteLine("Hur långt hoppade Elin (i meter)?");
            float lengthElin = float.Parse(Console.ReadLine());


            //Frågar hur långt Alma hoppade
            Console.WriteLine("Hur långt hoppade Alma (i meter)?");
            float lengthAlma = float.Parse(Console.ReadLine());

            //if-satserna nedan jämför deras resultat och skriver olika saker beroende på vem som hoppade längst
            //Ifall Elin hoppade längst
            if(lengthElin > lengthAlma)
            {
                Console.WriteLine($"Elin hoppade {lengthElin - lengthAlma} meter längre än Alma!");
                Console.ReadKey();
            }

            //Alma hoppade längst
            else if (lengthAlma > lengthElin)
            {
                Console.WriteLine($"Alma hoppade {lengthAlma - lengthElin} meter längre än Elin!");
                Console.ReadKey();
            }

            //De hoppade lika långt
            else if (lengthAlma == lengthElin)
            {
                Console.WriteLine("De hoppade lika långt!");
                Console.ReadKey();
            }
        }
    }
}
