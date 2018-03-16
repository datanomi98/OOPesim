using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_ohjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("anna etunimesi: ");
            string u_etunimi = Console.ReadLine();
            Console.WriteLine("anna sukunimesi: ");
            string u_sukunimi = Console.ReadLine();
            //tässä otetaan class1 tiedostosta basic_class niminen classi
            basic_class basic = new basic_class();
            basic.Etunimi = u_etunimi; //aktivoidaan Etunimi setterin arvo
            basic.Sukunimi = u_sukunimi; //aktivoidaan Sukunimi setterin arvo
            Console.WriteLine(basic.Sukunimi);
            //aktivoidaan kaikki basic_classin sisällä olevat functiot
            basic.ekafunctio();
            basic.tokafunctio();
            basic.kolmasfunctio();
            //tässä otetaan class2 tiedostosta super_class niminen classi
            super_class super = new super_class();
            //ja tässä huomataan että voimme ajaa ekafunction joka on kirjoitettu basic_classissä super_classin kautta
            super.ekafunctio();
            super.neljasfunctio();
            //otetaan method tiedostosta method_esimerkki classin sisältö.
            method_esimerkki metodi = new method_esimerkki();
            string kokonimi = metodi.Kokonimi(basic.Etunimi, basic.Sukunimi);
            Console.WriteLine(kokonimi);
            Console.ReadLine();
        }
    }
}
