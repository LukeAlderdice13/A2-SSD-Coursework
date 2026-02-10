using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SSDCoursework
{
    public class Status
    {
        public static List<Status> statuses = new List<Status>();
        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public Status()
        {

        }

        public Status(int statusId, string statusName)
        {
            StatusId = statusId;
            StatusName = statusName;
        }   

        public static Status GetFromName(string name)
        {
            foreach(Status s in statuses)
            {
                return s;
            }
            return null;
        }

        public static Status GetFromID(int ID)
        {
            foreach(Status s in statuses)
            {
                if (s.StatusId == ID)
                {
                    return s;
                }
            }
            return null;
        }

        public static bool IsNameTaken(string Name)
        {
            foreach(Status status in statuses)
            {
                if (status.StatusName == Name)
                {
                    return false;
                }
            }
            return true;
        }

        public static int GetNextID()
        {
            int i = 0;
            foreach(Status s in statuses)
            {
                if (i < s.StatusId)
                {
                    i = s.StatusId;
                }
            }
            return i + 1;
        }

        public static void EditStatus(Status status)
        {
            foreach(Status s in statuses)
            {
                if (s.StatusId == status.StatusId)
                {
                    s.StatusName = status.StatusName;
                    break;
                }
            }
        }

        public static void RemoveStatus(int ID)
        {
            Status status = new Status();

            foreach(Status s in statuses)
            {
                if (s.StatusId == ID)
                {
                    status = s;
                    break;
                }
            }
            statuses.Remove(status);
        }
    }
}
