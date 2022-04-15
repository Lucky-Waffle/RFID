using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID
{
    class RFIDtag:Person
    {
        public string RFIDtagNr{ get; set; }

        public RFIDtag()
        {
            RFIDtagNr = "Test RFID Nr";
        }

        public RFIDtag(string rfidTag)
        {
            RFIDtagNr = rfidTag;
        }
    }
}
