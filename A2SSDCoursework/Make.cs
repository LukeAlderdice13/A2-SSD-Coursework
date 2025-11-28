using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SSDCoursework
{
    public class Make
    {
        public static List<Make> makes = new List<Make>();
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

        public static bool CheckNameAvailability(string name)
        {
            foreach(Make make in makes)
            {
                if (make.Name == name)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
