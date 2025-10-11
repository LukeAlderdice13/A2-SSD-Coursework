using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SSDCoursework
{
    public class Status
    {
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
    }
}
