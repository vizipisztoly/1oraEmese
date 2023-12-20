using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace oraEmese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alapInt = 2147483647;               //Egész szám, alapból 2^32-1 db számot tud eltárolni
            Int16 bit16Int = 32767;                 //Egész szám, alapból 2^16-1 db számot tud eltárolni
            Int64 bit64Int = 9223372036854775807;   //Egész szám, alapból 2^64-1 db számot tud eltárolni
            double nemEgesz = 0.111111111;          //Nem egész szám, elég pontosan tudja eltárolni a számokat,
                                                    //kb 15-16 tizedesjegyig, 64-bit-es 

            string alapString = "Ez egy szöveg változó!"; //Szöveg változó,
                                                          //kb bármit el tud tárolni,
                                                          //de mindent szövegként kezel

            bool logikaiValtozo = false; //Logikai változó, lehet true vagy false az értéke,
                                         //int-be konvertálva a false 0 és a true meg 1,
                                         //ez visszafele is működik annyi különbséggel,
                                         //hogyha az int nem 0 akkor true-t ad vissza, ha 0 akkor meg false-t

            char egyBetu = 'a';     //El tud tárolni EGY betűt


            //Ha a változók elé odaírjuk hogy "const",
            //akkor az a változó egy "állandó" változó lesz,
            //azaz nem lehet az értékét változtatni a programban
            //pl:
            const double pi = 3.14159265359;
            const string koszonto = "Üdvözlez!";

            //Kiiratás
            Console.WriteLine("");  //A zárójelen belűre szinte bármi kerülhet,
                                    //legyen az egy string, egy int, egy double,
                                    //egy char, egy bool, egy matematikai egyenelt vagy
                                    //ezek valamely kombinációja
                                    //Miután kiiratta amit megadtunk neki, mindig ír ki egy új sort is
            Console.Write("");      //Ugyan ez, csak nem ír ki új sort a végén,
                                    //közvetlenül lehet folytatni a kiíratást utánna
                                    // "\n" --> Új sor
                                    // "\t" --> tabulátor
                                    // Ha " jelet szeretnénk kiíratni a parannccsal,
                                    // akkor rakjunk elé egy \ jelet, helyes használata:
            Console.WriteLine("\", ez egy idézőjel");


            //Padding
            //Csakis stringeknél lehet használni
            //PadLeft(hossz, kitöltő), a "kitöltő" opcionális,
            //ha nem adsz meg semmit akkor szóköz lesz az alap értéke
            //Ha a string nincs olyan hosszú mint a "hossz", akkor BALRÓL kitölti a "kitöltő"-vel
            //A hosszba beleszámít minden karakter, még a szóköz is
            Console.WriteLine("Hello world!".PadLeft(20, '-'));
            //Kimenet: --------Hello World!

            //A PadRight(hossz, kitöltő), a "kitöltő" opcionális,
            //ha nem adsz meg semmit akkor szóköz lesz az alap értéke
            //Ha a string nincs olyan hosszú mint a "hossz", akkor JOBBRÓL kitölti a "kitöltő"-vel
            //A hosszba beleszámít minden karakter, még a szóköz is
            Console.WriteLine("Hello world!".PadRight(20, '-'));
            //Kimenet: Hello World!--------


            //Egyedi numerikus formázás
            double number1 = 1234567890;
            string value1 = number1.ToString("(###) ###-####"); //A "#"-ek a számok helytartója,
            Console.WriteLine(value1);                          //azok helyére kerülhet szám
            //Output:
            //(123) 456-7890

            int number2 = 42;
            string value2 = number2.ToString("My Number = #");
            Console.WriteLine(value2);
            //Output:
            //42

            Console.ReadKey();
        }
    }
}
