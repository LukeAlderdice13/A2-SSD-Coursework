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

        public static int NewID()
        {
            int ID = 0;
            foreach (Make make in makes)
            {
                ID++;
            }
            return ID + 1;
        }

        public static Make MakeFromID(int ID)
        {
            foreach (Make make in makes)
            {
                if (make.MakeID == ID)
                {
                    return make;
                }
            }

            return null;
        }

        public static void RemoveMake(int ID)
        {
            Make deletedMake = new Make();
            foreach(Make make in makes)
            {
                if (make.MakeID == ID)
                {
                    deletedMake = make;
                }
            }

            makes.Remove(deletedMake);
        }
    }
}
