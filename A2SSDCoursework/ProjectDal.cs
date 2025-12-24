using A2_SSD_Coursework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2SSDCoursework
{
    internal class ProjectDal
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["ProjectManagementConnectionString"].ConnectionString;

        public static void GetEmployees()
        {
            Debug.WriteLine("GetEmployee");
            Employee.employees.Clear();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                Debug.WriteLine("Connection String: " + connection.ConnectionString);
                Debug.WriteLine("Database File: " + connection.Database);

                SqlCommand getEmployeesCommand = new SqlCommand();
                getEmployeesCommand.Connection = connection;

                getEmployeesCommand.CommandType = System.Data.CommandType.StoredProcedure;

                getEmployeesCommand.CommandText = "GetEmployees";

                SqlDataReader sqlDataReader = getEmployeesCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    int employeeID = Convert.ToInt32(sqlDataReader["EmployeeID"]);
                    
                    try
                    {
                        object roleIdValue = sqlDataReader["RoleID"];
                        object roleNameValue = sqlDataReader["RoleName"];

                        Role role = null;
                        if (roleIdValue != DBNull.Value)
                        {
                            role = new Role(Convert.ToInt32(roleIdValue), Convert.ToString(roleNameValue));
                        }

                        if (Employee.CheckIfExists(employeeID))
                        {
                            Status status = new Status(Convert.ToInt32(sqlDataReader["StatusID"]), Convert.ToString(sqlDataReader["StatusDescription"]));
                            Employee employee = new Employee(Convert.ToInt32(sqlDataReader["EmployeeID"]), Convert.ToString(sqlDataReader["FirstName"]), Convert.ToString(sqlDataReader["Surname"]), Convert.ToString(sqlDataReader["Gender"]), Convert.ToString(sqlDataReader["Address"]), Convert.ToDateTime(sqlDataReader["DateOfBirth"]), Convert.ToString(sqlDataReader["Email"]), Convert.ToString(sqlDataReader["TelephoneNo"]), Convert.ToString(sqlDataReader["Username"]), Convert.ToString(sqlDataReader["Password"]), Convert.ToDateTime(sqlDataReader["DateHired"]), Convert.ToDecimal(sqlDataReader["Salary"]), status);
                            Employee.employees.Add(employee);
                        }

                        if (role != null)
                        {
                            Employee.AddRole(employeeID, role);
                        }
                    }
                    catch
                    {
                        if (Employee.CheckIfExists(employeeID))
                        {
                            Status status = new Status(Convert.ToInt32(sqlDataReader["StatusID"]), Convert.ToString(sqlDataReader["StatusDescription"]));
                            Employee employee = new Employee(Convert.ToInt32(sqlDataReader["EmployeeID"]), Convert.ToString(sqlDataReader["FirstName"]), Convert.ToString(sqlDataReader["Surname"]), Convert.ToString(sqlDataReader["Gender"]), Convert.ToString(sqlDataReader["Address"]), Convert.ToDateTime(sqlDataReader["DateOfBirth"]), Convert.ToString(sqlDataReader["Email"]), Convert.ToString(sqlDataReader["TelephoneNo"]), Convert.ToString(sqlDataReader["Username"]), Convert.ToString(sqlDataReader["Password"]), Convert.ToDateTime(sqlDataReader["DateHired"]), Convert.ToDecimal(sqlDataReader["Salary"]), status);
                            Employee.employees.Add(employee);
                        }
                    }
                }

                connection.Close();
            }
            Debug.WriteLine("GetEmployee");
        }

        public static int AddEmployee(Employee employee)
        {
            Debug.WriteLine("AddEmployee");
            int ID = GetNewEmployeeID();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand addEmployeeCommand = new SqlCommand();
                addEmployeeCommand.Connection = connection;
                addEmployeeCommand.CommandType = System.Data.CommandType.StoredProcedure;
                addEmployeeCommand.CommandText = "AddEmployee";
                addEmployeeCommand.Parameters.Add(new SqlParameter("@EmployeeID", ID));
                addEmployeeCommand.Parameters.Add(new SqlParameter("@FirstName", employee.FirstName));
                addEmployeeCommand.Parameters.Add(new SqlParameter("@Surname", employee.Surname));
                addEmployeeCommand.Parameters.Add(new SqlParameter("@Gender", employee.Gender));
                addEmployeeCommand.Parameters.Add(new SqlParameter("@Address", employee.Address));
                addEmployeeCommand.Parameters.Add(new SqlParameter("@DateOfBirth", employee.DateOfBirth.Date));
                addEmployeeCommand.Parameters.Add(new SqlParameter("@Email", employee.Email));
                addEmployeeCommand.Parameters.Add(new SqlParameter("@TelephoneNo", employee.TelephoneNo));
                addEmployeeCommand.Parameters.Add(new SqlParameter("@Username", employee.Username));
                addEmployeeCommand.Parameters.Add(new SqlParameter("@Password", employee.Password));
                addEmployeeCommand.Parameters.Add(new SqlParameter("@DateHired", employee.DateHired.Date));
                addEmployeeCommand.Parameters.Add(new SqlParameter("@Salary", employee.Salary));
                addEmployeeCommand.Parameters.Add(new SqlParameter("@StatusID", employee.status.StatusId));

                int rowsAffected = addEmployeeCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    employee.EmployeeID = ID;
                    Employee.employees.Add(employee);
                }

                connection.Close();

                return rowsAffected;
            }
        }

        public static int GetNewEmployeeID()
        {
            Debug.WriteLine("GetNewEmployeeID");
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand getIDCommand = new SqlCommand();
                getIDCommand.Connection = connection;
                getIDCommand.CommandType = System.Data.CommandType.StoredProcedure;
                getIDCommand.CommandText = "GetMaxEmployeeID";

                SqlDataReader sqlDataReader = getIDCommand.ExecuteReader();

                int ID = 0;

                while (sqlDataReader.Read())
                {
                    ID = (int)sqlDataReader["ID"];
                }

                connection.Close();

                return ID + 1;
            }
        }

        public static void GetRoles()
        {
            Debug.WriteLine("GetRoles");
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand getRolesCommand = new SqlCommand();
                getRolesCommand.Connection = connection;
                getRolesCommand.CommandType = System.Data.CommandType.StoredProcedure;
                getRolesCommand.CommandText = "GetRoles";

                SqlDataReader sqlDataReader = getRolesCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Role role = new Role((int)sqlDataReader["RoleID"], (string)sqlDataReader["RoleName"]);
                    Role.roles.Add(role);
                }

                connection.Close();
            }
        }

        public static void UpdateEmployeeInfo(Employee employee)
        {
            Debug.WriteLine("UpdateEmployeeInfo");
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand updateEmployeeInfoCommand = new SqlCommand();
                updateEmployeeInfoCommand.Connection = connection;
                updateEmployeeInfoCommand.CommandType = System.Data.CommandType.StoredProcedure;
                updateEmployeeInfoCommand.CommandText = "UpdateEmployeeInfo";
                updateEmployeeInfoCommand.Parameters.Add(new SqlParameter("@EmployeeID", employee.EmployeeID));
                updateEmployeeInfoCommand.Parameters.Add(new SqlParameter("@FirstName", employee.FirstName));
                updateEmployeeInfoCommand.Parameters.Add(new SqlParameter("@Surname", employee.Surname));
                updateEmployeeInfoCommand.Parameters.Add(new SqlParameter("@Gender", employee.Gender));
                updateEmployeeInfoCommand.Parameters.Add(new SqlParameter("@Address", employee.Address));
                updateEmployeeInfoCommand.Parameters.Add(new SqlParameter("@DateOfBirth", employee.DateOfBirth.Date));
                updateEmployeeInfoCommand.Parameters.Add(new SqlParameter("@Email", employee.Email));
                updateEmployeeInfoCommand.Parameters.Add(new SqlParameter("@TelephoneNo", employee.TelephoneNo));
                updateEmployeeInfoCommand.Parameters.Add(new SqlParameter("@Username", employee.Username));
                updateEmployeeInfoCommand.Parameters.Add(new SqlParameter("@Password", employee.Password));
                updateEmployeeInfoCommand.Parameters.Add(new SqlParameter("@DateHired", employee.DateHired.Date));
                updateEmployeeInfoCommand.Parameters.Add(new SqlParameter("@Salary", employee.Salary));
                updateEmployeeInfoCommand.Parameters.Add(new SqlParameter("@StatusID", employee.status.StatusId));

                updateEmployeeInfoCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void AddNewEmployeeRoles(int ID, List<int> roleIDs, List<int> removedRoleIDs)
        {
            Debug.WriteLine("AddNewEmployeeRoles");
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                foreach (int roleID in roleIDs)
                {
                    SqlCommand addEmployeeRoleCommand = new SqlCommand();
                    addEmployeeRoleCommand.Connection = connection;
                    addEmployeeRoleCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    addEmployeeRoleCommand.CommandText = "AddNewEmployeeRole";
                    addEmployeeRoleCommand.Parameters.Add(new SqlParameter("@EmployeeID", ID));
                    addEmployeeRoleCommand.Parameters.Add(new SqlParameter("@RoleID", roleID));
                    addEmployeeRoleCommand.ExecuteNonQuery();
                }

                foreach (int roleID in removedRoleIDs)
                {
                    SqlCommand removeEmployeeRoleCommand = new SqlCommand();
                    removeEmployeeRoleCommand.Connection = connection;
                    removeEmployeeRoleCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    removeEmployeeRoleCommand.CommandText = "DeleteRemovedRoles";
                    removeEmployeeRoleCommand.Parameters.Add(new SqlParameter("@EmployeeID", ID));
                    removeEmployeeRoleCommand.Parameters.Add(new SqlParameter("@RoleID", roleID));
                    removeEmployeeRoleCommand.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public static void GetEmploymentStatuses()
        {
            Debug.WriteLine("GetEmploymentStatuses");
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand getEmploymentStatusesCommand = new SqlCommand();
                getEmploymentStatusesCommand.Connection = connection;
                getEmploymentStatusesCommand.CommandType = System.Data.CommandType.StoredProcedure;
                getEmploymentStatusesCommand.CommandText = "GetStatuses";

                SqlDataReader sqlDataReader = getEmploymentStatusesCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Status status = new Status((int)sqlDataReader["StatusID"], (string)sqlDataReader["StatusDescription"]);
                    Status.statuses.Add(status);
                }

                connection.Close();
            }
        }

        public static void DeleteMake(int MakeID)
        {
            Make.RemoveMake(MakeID);
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand deleteMakeCommand = new SqlCommand();
                deleteMakeCommand.Connection = connection;
                deleteMakeCommand.CommandType = System.Data.CommandType.StoredProcedure;
                deleteMakeCommand.CommandText = "DeleteMake";

                deleteMakeCommand.Parameters.Add(new SqlParameter("@MakeID", MakeID));

                deleteMakeCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void GetMakes()
        {
            Make.makes.Clear();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand getMakesCommand = new SqlCommand();
                getMakesCommand.Connection = connection;
                getMakesCommand.CommandType = System.Data.CommandType.StoredProcedure;
                getMakesCommand.CommandText = "GetMakes";

                SqlDataReader sqlDataReader = getMakesCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Make make = new Make(Convert.ToInt32(sqlDataReader["MakeID"]), Convert.ToString(sqlDataReader["MakeName"]));
                    Make.makes.Add(make);
                }

                connection.Close();
            }
        }

        public static void GetVehicles()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand getVehiclesCommand = new SqlCommand();
                getVehiclesCommand.Connection = connection;
                getVehiclesCommand.CommandType = System.Data.CommandType.StoredProcedure;
                getVehiclesCommand.CommandText = "GetVehicles";

                SqlDataReader vehicleDataReader = getVehiclesCommand.ExecuteReader();

                while (vehicleDataReader.Read())
                {
                    int VehicleID = Convert.ToInt32(vehicleDataReader["VehicleID"]);

                    //Sold Vehicles
                    object DateSold = vehicleDataReader["DateSold"];
                    object SellPrice = vehicleDataReader["SellPrice"];
                    object SellerID = vehicleDataReader["EmployeeID"];
                    object BuyerID = vehicleDataReader["CustomerID"];
                    //

                    //Vehicle Servicing
                    Service service = null;

                    object serviceID = vehicleDataReader["ServiceID"];
                    object serviceDate = vehicleDataReader["ServiceDate"];
                    object serviceEmployeeID = vehicleDataReader["ServiceEmployeeID"];
                    object serviceType = vehicleDataReader["Type"];
                    object serviceCost = vehicleDataReader["Cost"];

                    if (Vehicle.CheckIfExists(VehicleID))
                    {
                        Make make = Make.MakeFromID(Convert.ToInt32(vehicleDataReader["MakeID"]));

                        Vehicle vehicle = new Vehicle(Convert.ToInt32(vehicleDataReader["VehicleID"]), Convert.ToString(vehicleDataReader["Model"]), make, Convert.ToString(vehicleDataReader["YearMade"]), Convert.ToString(vehicleDataReader["Colour"]), Convert.ToDecimal(vehicleDataReader["EngineSize"]), Convert.ToString(vehicleDataReader["RegistrationPlate"]), Convert.ToString(vehicleDataReader["VIN"]), Convert.ToString(vehicleDataReader["FuelType"]), Convert.ToInt32(vehicleDataReader["Price"]), Convert.ToDateTime(vehicleDataReader["DatePurchased"]));

                        if (BuyerID != DBNull.Value)
                        {
                            vehicle.Sold = true;
                            vehicle.SoldPrice = Convert.ToDecimal(SellPrice);
                            vehicle.DateSold = Convert.ToDateTime(DateSold);
                            vehicle.CustomerID = Convert.ToInt32(BuyerID);
                            vehicle.EmployeeID = Convert.ToInt32(SellerID);
                        }


                        Vehicle.vehicles.Add(vehicle);
                    }

                    if (serviceID != DBNull.Value)
                    {
                        service = new Service(Convert.ToInt32(serviceID), Vehicle.GetVehicleFromID(VehicleID), Convert.ToDateTime(serviceDate), Employee.GetEmployeeFromID(Convert.ToInt32(serviceEmployeeID)), serviceType.ToString().Trim(), Convert.ToDecimal(serviceCost));
                    }

                    if (service != null)
                    {
                        Vehicle.AddService(VehicleID, service);
                    }
                }

                connection.Close();
            }
        }

        public static void GetCustomers()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand getCustomersCommand = new SqlCommand();
                getCustomersCommand.Connection = connection;
                getCustomersCommand.CommandType = System.Data.CommandType.StoredProcedure;
                getCustomersCommand.CommandText = "GetCustomers";

                SqlDataReader sqlDataReader = getCustomersCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    if (Customer.CheckIfExists(Convert.ToInt32(sqlDataReader["CustomerID"])))
                    {
                        object vehicleID = sqlDataReader["VehicleID"];
                        Customer customer;
                        if (vehicleID != DBNull.Value)
                        {
                            customer = new Customer(Convert.ToInt32(sqlDataReader["CustomerID"]), Convert.ToString(sqlDataReader["FirstName"]), Convert.ToString(sqlDataReader["Surname"]), Convert.ToString(sqlDataReader["Address"]), Convert.ToString(sqlDataReader["Email"]), Convert.ToString(sqlDataReader["TelephoneNo"]), Convert.ToInt32(sqlDataReader["VehicleID"]));
                        } else
                        {
                            customer = new Customer(Convert.ToInt32(sqlDataReader["CustomerID"]), Convert.ToString(sqlDataReader["FirstName"]), Convert.ToString(sqlDataReader["Surname"]), Convert.ToString(sqlDataReader["Address"]), Convert.ToString(sqlDataReader["Email"]), Convert.ToString(sqlDataReader["TelephoneNo"]));
                        }

                        Customer.customers.Add(customer);
                            
                    } else
                    {
                        Customer.addBoughtVehicle(Convert.ToInt32(sqlDataReader["CustomerID"]), Convert.ToInt32(sqlDataReader["VehicleID"]));
                    }
                }
            }
        }

        public static void UpdateMakeName(Make make, string NewName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand updateMakeCommand = new SqlCommand();
                updateMakeCommand.Connection = connection;
                updateMakeCommand.CommandType = System.Data.CommandType.StoredProcedure;
                updateMakeCommand.CommandText = "UpdateMakeName";

                updateMakeCommand.Parameters.Add(new SqlParameter("@oldName", make.Name));
                updateMakeCommand.Parameters.Add(new SqlParameter("@newName", NewName));

                updateMakeCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void AddMake(String MakeName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand insertMakeCommand = new SqlCommand();
                insertMakeCommand.Connection = connection;
                insertMakeCommand.CommandType = System.Data.CommandType.StoredProcedure;
                insertMakeCommand.CommandText = "AddMake";

                insertMakeCommand.Parameters.Add(new SqlParameter("@MakeName", MakeName));

                insertMakeCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void UpdateCustomerInfo(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand UpdateCustomerCommand = new SqlCommand();
                UpdateCustomerCommand.Connection = connection;
                UpdateCustomerCommand.CommandType = System.Data.CommandType.StoredProcedure;
                UpdateCustomerCommand.CommandText = "UpdateCustomerInfo";

                UpdateCustomerCommand.Parameters.Add(new SqlParameter("@CustomerID", customer.CustomerID));
                UpdateCustomerCommand.Parameters.Add(new SqlParameter("@FirstName", customer.FirstName));
                UpdateCustomerCommand.Parameters.Add(new SqlParameter("@Surname", customer.Surname));
                UpdateCustomerCommand.Parameters.Add(new SqlParameter("@Address", customer.Address));
                UpdateCustomerCommand.Parameters.Add(new SqlParameter("@Email", customer.Email));
                UpdateCustomerCommand.Parameters.Add(new SqlParameter("@TelephoneNo", customer.TelephoneNo));

                UpdateCustomerCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void DeleteService(int serviceID, int vehicleID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand DeleteServiceCommand = new SqlCommand();
                DeleteServiceCommand.Connection = connection;
                DeleteServiceCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DeleteServiceCommand.CommandText = "DeleteService";

                DeleteServiceCommand.Parameters.Add(new SqlParameter("@serviceID", serviceID));
                DeleteServiceCommand.Parameters.Add(new SqlParameter("@VehicleID", vehicleID));

                DeleteServiceCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void UpdateService(Service service)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand UpdateServiceCommand = new SqlCommand();
                UpdateServiceCommand.Connection = connection;
                UpdateServiceCommand.CommandType = System.Data.CommandType.StoredProcedure;
                UpdateServiceCommand.CommandText = "UpdateService";

                UpdateServiceCommand.Parameters.Add(new SqlParameter("@ServiceID", service.ServiceID));
                UpdateServiceCommand.Parameters.Add(new SqlParameter("@VehicleID", service.vehicle.Id));
                UpdateServiceCommand.Parameters.Add(new SqlParameter("@EmployeeID", service.employee.EmployeeID));
                UpdateServiceCommand.Parameters.Add(new SqlParameter("@Type", service.ServiceType));
                UpdateServiceCommand.Parameters.Add(new SqlParameter("@Cost", service.Cost));

                UpdateServiceCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void AddService(Service service)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand AddServiceCommand = new SqlCommand();
                AddServiceCommand.Connection = connection;
                AddServiceCommand.CommandType = System.Data.CommandType.StoredProcedure;
                AddServiceCommand.CommandText = "AddService";

                AddServiceCommand.Parameters.Add(new SqlParameter("@VehicleID", service.vehicle.Id));
                AddServiceCommand.Parameters.Add(new SqlParameter("@Date", service.ServiceDate));
                AddServiceCommand.Parameters.Add(new SqlParameter("@EmployeeID", service.employee.EmployeeID));
                AddServiceCommand.Parameters.Add(new SqlParameter("@Type", service.ServiceType));
                AddServiceCommand.Parameters.Add(new SqlParameter("@Cost", service.Cost));

                AddServiceCommand.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
