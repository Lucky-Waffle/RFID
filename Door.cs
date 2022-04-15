using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID
{
    class Door:House
    {
        public string DoorStatus { get; set; }

        public string DoorName { get; set; }

        public Door()
        {
            DoorName = "Test DoorName";
            DoorStatus = "Test Åpen";
        }

        public Door(string doorStatus, string doorName)
        {
            DoorStatus = doorStatus;
            DoorName = doorName;
        }
    }
}
