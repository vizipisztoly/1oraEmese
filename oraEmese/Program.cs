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

            //A változók típusának közötti való váltás
            //"Automatikus" váltás
            int a = 10;
            double b = a;       //Ez a két sor az int a-t átalakítja egy double-é és azt a b-ben tárolja el
            //Manuális átváltás
            string c = "15";
            int d = int.Parse(c);   //Ebben a két sorban egy string alapú számot alakít át int-té,
            int e = 20;             //ha a string tartalmaz nem szám karaktert, akkor a program hibát fog dobni
            string f = e.ToString();
            Console.WriteLine(e.GetType()); 



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

            //A kiíratásban való elemek összefűzése a + jellel
            Console.WriteLine("Hello" + " " + "world! " + 10 + " " + true);
            //Viszont ezzel vigyázni kell ha változókat használunk
            string szam1 = "4";
            string szam2 = "5";
            Console.WriteLine(szam1+szam2);
            //Először azt várhatnánk el, hogy 4+5= 9-et ad majd vissza a program,
            //de mivel stringekkel dolgozunk, ezért "4"+"5" --> "45", összefűzi a stringeket
            int szam3 = 4;
            int szam4 = 5;
            Console.WriteLine(szam3+szam4);
            //Ez viszont tényleg 4+5= 9-et ad vissza



            //if használata     Ha a ()-en belül lévő változó "igaz"-at ad vissza,a "ha" része fut le az "if"-nek
            //                  Ezen kívül még lehet írni egy else {} részt (ez csak opcionális) is az "if"-nek, ez akkor fut le,
            //                  ha a feltétel nem teljesült a ()-ben             
            if (szam3 > 5)       
            {
                //"ha" része az "if"-nek
            }
            else
            {
                //"különben" része az "if"-nek, csak akkor fut le, ha a feltétel nem teljesült
            }

            int aa;
            aa = int.Parse(Console.ReadLine());
            
            switch (aa)
                {
                case 0:
                    Console.WriteLine(0);
                    break;
                case 2 | 3:     //| --> AltGR + W   | == vagy
                    Console.WriteLine("Prímek");
                    break;
                case 4:
                case 6:
                    Console.WriteLine("Nem prímek");
                    break;
                default:
                    Console.WriteLine("valami");
                    break;
            }

            if (aa == 0)
            {
                Console.WriteLine();
            }
            else if (aa == 1)
            {

            }
            else if(aa == 2)
            {

            }


            if (true)
            {

            }

            if (true)
            {

            }
            string aaa = Console.ReadLine();



            //Írd ki a számokat 45-től 66-ig


            //Kezd el a számokat 1-től haladva összeszorozni,
            //addig amíg a szorzatuk kisebb mint 300,
            //a számokat és azorzatukat is írd ki
            // a*a=a^2
            // 2*2=4
            //Írd ki a legnagyobb számot, aminek szorzata még pont nem 300
            //Írd ki a legkisebb számot, aminek szorzata pont meghaladja a 300-at,
            //és ez a szám mennyivel nagyobb mint 300
            int szorzat = 1;
            while (szorzat*szorzat<300)
            {
                Console.WriteLine(szorzat +"*"+szorzat+"="+ szorzat * szorzat);
                szorzat++;
            }
            Console.WriteLine(szorzat-1);
            Console.WriteLine(szorzat);

            //Ciklusok  for && while (&& do {}while)

            //Ha valamit VALAHÁNYSZOR kell lefuttatnunk akkor "for" ciklust szoktunk használni
            //for (változó létrehozása, meddig változassa a változót, változó változtatása (pl.:növelés, csökkentés, stb))
            //{}-ben lévő rész addig fut le, annyiszor fut le, amíg teljesül a változóra megadott feltétel
            //ez a "length" lehet egy szám, (egy lista hossza,) egy tömb(array) hossza, egy string hossza, stb.
            //break; parancs viszont meg tudja állítani a futását bármikor
            int length = 10;
            for (int i = 0; i < length; i++)        //i++ = i+1     i-- = i-1
            {

            }

            //Ha valamit VALAMEDDIG kell futtatni, akkor "while" cilklust használunk
            //while (feltétel)
            //{}-ben lévő rész egészen addig fut, amíg a "feltétel" igaz
            //break; parancs viszont meg tudja állítani a futását bármikor
            while (true)    //Ebben az esetben a végtelenségig fog futni, vagy addig amíg nem rakunk bele valahol egy break;-et
            {
                break;
            }


            //Speckó műveletek
            //  % --> a maradékot adja vissza --> 1%3 = 1
            //  ^ --> hatványozás --> 3^2 = 9
            //  Math.Sqrt() --> gyökvonás --> Math.Sqrt(25) = 5

            //1-től 100-ig kiírja az összes 7-el osztahtó egész számot
            for (int i = 1; i < 101; i++)
            {
                if (i % 7 == 0) { Console.WriteLine(i); }
            }


            //Tömbök(array-ek)
            //Egydimenziós tömb létrehozása, amiben 5 számot lehet eltárolni
            int[] tomb1 = new int[5];

            tomb1[0] = 1;       //A tömbök indexelése/számozása 0-tól indul MINDIG
            tomb1[1] = 2;       //Itt most a tömböt 1-től 5-ig töltöttem fel számokkal
            tomb1[2] = 3;       //Ezt egy "for" ciklussal könnyebben is meglehetett volna tenni
            tomb1[3] = 4;       //for (let i = 1; i <= 5; i++) {tomb1[i-1] = i}
            tomb1[4] = 5;

            Console.WriteLine(tomb1[3]);

            int hossz = tomb1.Length;// --> Visszaadja a tömb hosszát


            //Egy tömböt tölts fel számokkal 1000-től 10000-ig
            //Mennyi 7-el osztható szám van benne

            int[] tomb2 = new int[10000];
            int hettelOszthato = 0;
            for (int i = 1000; i < 10000; i++)
            {
                tomb2[i-1000] = i;
                if (i % 7 == 0) {  hettelOszthato++; }
            }
            Console.WriteLine(hettelOszthato);

            //Az összes 6-al osztható számot emeljük a négyzetre

            for (int i = 0; i < tomb2.Length; i++)
            {
                if (tomb2[i] % 6 == 0)
                {
                    tomb2[i] = tomb2[i] * tomb2[i];
                    
                }
            }

            foreach (int i in tomb2)    //foreach (int i in "tömb") {} i, egyessével kiszedi az elemeket
            {
                Console.WriteLine(i);
            }

            //Adott egy lista, amiben van 30 véletlenszerű szám 0 és 500 között
            //Írd ki hogy mennyi elem van benne, hány 3-al osztható van benne
            //, hány 5-el osztható van benne és hány 3-al és 5-el is
            //osztható szám van benne

            int[] megadottTomb = new int[30];
            var rnd = new Random();
            for (int i = 0; i < 30; i++)
            {
                megadottTomb[i] = rnd.Next(0,500);
            }
            foreach (int i in megadottTomb) { Console.WriteLine(i); }
            int tombHossza = megadottTomb.Length;
            int harommal = 0;
            int ottel = 0;
            int harommalEsOttel = 0;

            foreach (int i in megadottTomb)
            {
                if (i % 3 == 0)
                {
                    harommal++;
                }

                if (i % 5 == 1)
                {
                    ottel++;
                }

                if (i % 3 == 1)
                {
                    if (i%5 == 0)
                    {
                        harommalEsOttel++;
                    }
                }

                Console.WriteLine("Hárommal:");
                Console.WriteLine(harommal);
                Console.WriteLine("Öttel:");
                Console.WriteLine(ottel);
                Console.WriteLine("Hárommal és öttel:");
                Console.WriteLine(harommalEsOttel);

            //A kiíratásban való elemek összefűzése az "órai" módszerrel
            string today = "great";
            Console.WriteLine("Hello world! Today is a {0} day", today);
            Console.WriteLine("A stringek összeadása: \"{0}\"+\"{1}\"=\"{2}\"", szam1, szam2, szam1+szam2);
            Console.WriteLine("Az intek összeadása: {0}+{1}={2}", szam3, szam4, szam3 + szam4);
            //A {} közé írjuk, hogy hanyadik elemet akarjuk kiíratni, MINDIG 0-val indulunk
            //("{0}, {1}", 0ikElem, 1ikElem), a formázásokról később lesz még említés

            //String interpolation
            //Hasonló az előző módszerhez, anny különbséggel hogy a string elé egy "$" jelet teszünk,
            //majd utánna a stringen belül a {} zárójelekbe nem az indexeket, hanem közvetlenül a változókat, műveleteket, stb.-t írjuk
            Console.WriteLine($"4+5={4+5}");
            Console.WriteLine($"Hello world! Today is a {today} day");
            //A {}zárójelen belül ugyanúgy lehet formázni a változókat, stringeket




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




            //Append
            // valami.Append(x)
            //az x elemet beleteszi a listába [1,2,3,4] -->
            //Append(1) --> [1,2,3,4,1]


            Console.ReadKey();
        }
    }
}
