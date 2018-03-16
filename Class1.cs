using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_ohjelmointi
{
   //tehdään class jonka sisään tulee perus funktioita.
    class basic_class
    {
       
        private string etunimi;
        private string sukunimi;
        //tässä asetetaan private stringin public classi, jonka avulla private stringeihin voidaan lisätä dataa.
        //get tarkoittaa että privaatti muuttujan arvo voidaan lueta classin ulkopuolelta.
        // set toiminnan avulla voidaan tallentaa private luokan kenttään arvo
        public string Etunimi
        {
            set
                {
                etunimi = value;
                }
            get
             {
                return etunimi;
             }

        }
        public string Sukunimi
        {
            set
            {
                sukunimi = value;
            }
            get
            {
                return sukunimi;
            }

        }
        public basic_class() //oletuskonstruktori
        {
            etunimi = "";
            sukunimi = "";
        }
        public void Nimi()
        {
            Console.WriteLine("nimeni on: {0} {1}", etunimi, sukunimi);
        }
        public void ekafunctio()
        {
            
            Console.WriteLine("eka functio");
        }
        public void tokafunctio()
        {
            Console.WriteLine("toka functio");
        }
        public void kolmasfunctio()
        {
            Console.WriteLine("kolmas functio");
        }
    }
}
