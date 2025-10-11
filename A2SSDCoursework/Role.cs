using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SSDCoursework
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public Role()
        {

        }

        public Role(int roleID, string roleName)
        {
            RoleID = roleID;
            RoleName = roleName;
        }
    }
}
