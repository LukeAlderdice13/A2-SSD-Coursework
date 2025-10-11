using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SSDCoursework
{
    public class Make
    {
        public int MakeID { get; set; }
        public string Name { get; set; }

        public Make()
        {

        }

        public Make(int makeID, string name)
        {
            MakeID = makeID;
            Name = name;
        }
    }
}
