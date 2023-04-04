using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Feil
{
   public class ClassInfor
    {
     public string Name { get; set; }
        public string Lastname { get; set; }
        public int Id { get; set; }
        public string Floor { get; set; }
        public string Room { get; set; }
        public string Bed { get; set; }
        public ClassInfor(string name, string lastname, int id, string floor, string room, string bed)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Id = id;
            this.Floor = floor;
            this.Room = room;
            this.Bed = bed;

        }
        
    }
}
