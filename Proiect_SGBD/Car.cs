using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_SGBD
{
    public class Car
    {
        public int id { get; set; }
        public string TagNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string CarYear { get; set; }
        public string Category { get; set; }
        public bool Mp3player { get; set; }
        public bool DVDPlayer { get; set; }
        public bool AirConditioner { get; set; }
        public bool ABS { get; set; }
        public bool ASR { get; set; }
        public bool Navigation { get; set; }
        public bool Available { get; set; }
    }
}
