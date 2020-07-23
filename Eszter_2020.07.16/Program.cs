using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._07._16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Készítsünk programot, mely a következő feladatokat végzi el:
            //- Feltölt egy N elemű tömböt egy és száz közé eső véletlen számokkal. 
            // A tömb méretét a felhasználó határozza meg!
            //1.lépés: Létrehozzuk az üres tömbböt!
            int[] egesz_szamok = new int[15];
            //2.lépés: Véletlenszám objektum létrehozása
            Random veletlen = new Random();
            //3.lépés: Tömb feltöltése véletlen számokkal
            for (int i = 0;i<egesz_szamok.Length;i++)
            {
                egesz_szamok[i] = veletlen.Next(1, 101);
            }

            //- Feltöltés után a tömb elemeit a program írja ki a képernyőre!
            for (int i = 0; i < egesz_szamok.Length; i++)
            {
                Console.Write($"{egesz_szamok[i]} ");
            }

            //-Másolja át a program egy másik tömbbe a páros számokat!(kiválogatás tétele)
            //1.lépés: Létrehozzuk az új üres tömmböt!
            int[] paros_szamok = new int[15];
            //2.lépés: Végig kell menni a feltöltött tömbön, hogy kiválogassuk a páros számokat!
            int k = 0;
            for (int i = 0; i < egesz_szamok.Length; i++)
            {
                if (egesz_szamok[i] % 2 ==0)
                {
                    paros_szamok[k] = egesz_szamok[i];
                    k++;
                }
            }

            // - Számolja meg a program, hogy hány páros számot tartalmazott a tömb! 
            // (megszámlálás tétele)
            int m = 0;
            for (int i = 0; i < egesz_szamok.Length; i++)
            {
                if (egesz_szamok[i] % 2 == 0)
                {
                    paros_szamok[m] = egesz_szamok[i];
                    m++;
                }
            }
            Console.WriteLine();

            //- Írja ki a program a páros elemeket, de a 0-át ne tartalmazza! (házi feladat)
            for (int i = 0; i < paros_szamok.Length; i++)
            {
                if (paros_szamok[i] != 0)
                {
                    Console.Write($"{paros_szamok[i]} ");
                }               
            }
            Console.WriteLine($"A tömbben lévő páros számok darabszáma: {m}");

            
            Console.ReadKey();
        }
    }
}
