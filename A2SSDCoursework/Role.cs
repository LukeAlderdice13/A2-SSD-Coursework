using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SSDCoursework
{
    public class Role
    {
        public static List<Role> roles = new List<Role>();

        public static int ManagementID = 5;
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public int AccessLevel { get; set; }

        public Role()
        {

        }

        public Role(int roleID, string roleName, int accessLayer)
        {
            RoleID = roleID;
            RoleName = roleName;
            AccessLevel = accessLayer;
        }

        public static Role GetFromName(string name)
        {
            foreach (Role role in roles)
            {
                if(role.RoleName == name)
                {
                    return role;
                }
            }
            return null;
        }

        public static Role GetFromID(int ID)
        {
            foreach (Role role in roles)
            {
                if (role.RoleID == ID)
                {
                    return role;
                }
            }
            return null;
        }

        public static int NextID()
        {
            int maxID = 0;
            foreach(Role role in roles)
            {
                if(maxID <  role.RoleID)
                {
                    maxID = role.RoleID;
                }
            }
            return maxID + 1;
        }

        public static bool IsNameTaken(string name)
        {
            foreach(Role role in roles)
            {
                if (role.RoleName == name)
                {
                    return true;
                }
            }
            return false;
        }

        public static void EditRole(Role role)
        {
            foreach(Role r in roles)
            {
                if (role.RoleID == r.RoleID)
                {
                    r.RoleName = role.RoleName;
                    r.AccessLevel = role.AccessLevel;
                }
            }
        }

        public static void RemoveRole(int ID)
        {
            int i = 0;
            foreach(Role role in roles)
            {
                if (ID == role.RoleID)
                {
                    break;
                }
                else
                {
                    i++;
                }              
            }
            roles.RemoveAt(i);
        }
    }
}
