using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Feil
{
    public class ClassFloor
    {
        private string Floor1, Floor2,Floor3,Floor4;
        public ClassFloor(string floor1,string floor2,string floor3,string floor4) 
        { 
            this.floor1 = floor1;
            this.floor2 = floor2;
            this.floor3 = floor3;
            this.floor4 = floor4;
        }
        public string floor1 { get; set; }
        public string floor2 { get; set; }
        public string floor3 { get; set; }
        public string floor4 { get; set; }

    }
}
