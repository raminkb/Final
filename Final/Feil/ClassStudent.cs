using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Final.Feil
{
    internal class ClassStudent : ClassInfor
    {
        public ClassStudent(string name, string lastname, int id, string floor, string room, string bed) : base(name, lastname, id, floor, room, bed)
        { }
          
    }
}
