using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_ohjelmointi
{
        //näin voit käyttää toisen classin sisältämiä functiota ilman että niitä tarvitsee kirjoittaa uudestaan
        class super_class : basic_class
        {
            public void neljasfunctio()
            {
                Console.WriteLine("neljas functio");
            }
        }
    }
