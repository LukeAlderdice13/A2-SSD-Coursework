using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SSDCoursework
{
    internal class ProjectDal
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementConnectionString"].ConnectionString;
    }
}
