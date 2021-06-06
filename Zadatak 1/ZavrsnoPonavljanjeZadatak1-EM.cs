using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string upis;
            upis = Console.ReadLine();

            Console.Write("Upisi nesto: ");


            string sVelika = upis.ToUpper();

            Console.WriteLine(sVelika);

            string sMala = upis.ToLower();

            Console.WriteLine(sMala);

            string sPrvaTri = upis.Substring(0, 3);

            Console.WriteLine(sPrvaTri);

            string sZadnjihPet = upis.Substring(upis.Length - 5);

            Console.WriteLine(sZadnjihPet);

            string s8_11 = upis.Substring(7, 4);
            Console.WriteLine(s8_11);

            Console.ReadKey();


        }
    }
}
