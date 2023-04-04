using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Feil
{
    public class Classroom
    {
        private string Room1,Room2,Room3,Room4,Room5,Room6;
        public Classroom(string room1,string room2,string room3, string room4,string room5,string room6 ) 
        {
            this.Room1 = room1;
            this.Room2 = room2;
            this.Room3 = room3;
            this.Room4 = room4;
            this.Room5 = room5;
            this.Room6 = room6;
        }
        public string room1 { get; set; }
        public string room2 { get; set; }
        public string room3 { get; set; }
        public string room4 { get; set; }
        public string room5 { get; set; }
        public string room6 { get; set; }
    }
}
