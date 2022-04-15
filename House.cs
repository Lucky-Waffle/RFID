using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID
{
    class House:Person
    {
        public string Adresse { get; set; }
        public int PostNr { get; set; }

        public House()
        {
            Adresse = "TestAdresse";
        }

        public House(string adresse, int postNr)
        {
            Adresse = adresse;
            PostNr = postNr;
        }
    }
}
