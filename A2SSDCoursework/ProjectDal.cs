using A2_SSD_Coursework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                        object roleAccessLevel = sqlDataReader["AccessLevel"];

                        Role role = null;
                        if (roleIdValue != DBNull.Value)
                        {
                            role = new Role(Convert.ToInt32(roleIdValue), Convert.ToString(roleNameValue), Convert.ToInt32(roleAccessLevel));
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

        public static void AddEmployee(Employee employee)
        {
            Debug.WriteLine("AddEmployee");
            int ID = GetNewEmployeeID();
            employee.EmployeeID = ID;
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
            }
            if (employee.Roles.Count > 0)
            {
                List<int> RoleIDs = new List<int>();
                foreach (Role role in employee.Roles)
                {
                    RoleIDs.Add(role.RoleID);
                }
                AddNewEmployeeRoles(employee.EmployeeID, RoleIDs, new List<int>());
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
                    Role role = new Role((int)sqlDataReader["RoleID"], (string)sqlDataReader["RoleName"], (int)sqlDataReader["AccessLevel"]);
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
            Debug.WriteLine("GetMakes");
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
            Debug.WriteLine("GetVehicles");
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

                        Vehicle vehicle = new Vehicle(Convert.ToInt32(vehicleDataReader["VehicleID"]), Convert.ToString(vehicleDataReader["Model"]), make, Convert.ToString(vehicleDataReader["YearMade"]), Convert.ToString(vehicleDataReader["Colour"]), Convert.ToDecimal(vehicleDataReader["EngineSize"]), Convert.ToString(vehicleDataReader["RegistrationPlate"]), Convert.ToString(vehicleDataReader["VIN"]), Convert.ToString(vehicleDataReader["FuelType"]), Convert.ToDecimal(vehicleDataReader["Price"]), Convert.ToDateTime(vehicleDataReader["DatePurchased"]));

                        if (BuyerID != DBNull.Value)
                        {
                            vehicle.Sold = true;
                            vehicle.SoldPrice = Convert.ToDecimal(SellPrice);
                            vehicle.DateSold = Convert.ToDateTime(DateSold);
                            vehicle.CustomerID = Convert.ToInt32(BuyerID);
                            vehicle.EmployeeID = Convert.ToInt32(SellerID);
                            Employee.AddSoldVehicle(vehicle.EmployeeID, vehicle);
                        }


                        Vehicle.vehicles.Add(vehicle);
                    }

                    if (serviceID != DBNull.Value && serviceEmployeeID != DBNull.Value)
                    {
                        service = new Service(Convert.ToInt32(serviceID), Vehicle.GetVehicleFromID(VehicleID), Convert.ToDateTime(serviceDate), Employee.GetEmployeeFromID(Convert.ToInt32(serviceEmployeeID)), serviceType.ToString().Trim(), Convert.ToDecimal(serviceCost));
                    }
                    else if (serviceID != DBNull.Value)
                    {
                        service = new Service(Convert.ToInt32(serviceID), Vehicle.GetVehicleFromID(VehicleID), Convert.ToDateTime(serviceDate), serviceType.ToString().Trim(), Convert.ToDecimal(serviceCost));
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

        public static void UpdateMakeName(Make make)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand updateMakeCommand = new SqlCommand();
                updateMakeCommand.Connection = connection;
                updateMakeCommand.CommandType = System.Data.CommandType.StoredProcedure;
                updateMakeCommand.CommandText = "UpdateMakeName";

                updateMakeCommand.Parameters.Add(new SqlParameter("@MakeID", make.MakeID));
                updateMakeCommand.Parameters.Add(new SqlParameter("@MakeName", make.Name));

                updateMakeCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void AddMake(Make make)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand insertMakeCommand = new SqlCommand();
                insertMakeCommand.Connection = connection;
                insertMakeCommand.CommandType = System.Data.CommandType.StoredProcedure;
                insertMakeCommand.CommandText = "AddMake";

                insertMakeCommand.Parameters.Add(new SqlParameter("@MakeID", make.MakeID));
                insertMakeCommand.Parameters.Add(new SqlParameter("@MakeName", make.Name));

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

                AddServiceCommand.Parameters.Add(new SqlParameter("@ServiceID", service.ServiceID.ToString()));
                AddServiceCommand.Parameters.Add(new SqlParameter("@VehicleID", service.vehicle.Id));
                AddServiceCommand.Parameters.Add(new SqlParameter("@Date", service.ServiceDate));
                AddServiceCommand.Parameters.Add(new SqlParameter("@EmployeeID", service.employee.EmployeeID));
                AddServiceCommand.Parameters.Add(new SqlParameter("@Type", service.ServiceType));
                AddServiceCommand.Parameters.Add(new SqlParameter("@Cost", service.Cost));

                AddServiceCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void SellVehicle(Vehicle vehicle)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand SellVehicleCommand = new SqlCommand();
                SellVehicleCommand.Connection = connection;
                SellVehicleCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SellVehicleCommand.CommandText = "SellVehicle";

                SellVehicleCommand.Parameters.Add(new SqlParameter("@VehicleID", vehicle.Id));
                SellVehicleCommand.Parameters.Add(new SqlParameter("@DateSold", vehicle.DateSold));
                SellVehicleCommand.Parameters.Add(new SqlParameter("@SellPrice", vehicle.SoldPrice));
                SellVehicleCommand.Parameters.Add(new SqlParameter("@EmployeeID", vehicle.EmployeeID));
                SellVehicleCommand.Parameters.Add(new SqlParameter("@CustomerID", vehicle.CustomerID));

                SellVehicleCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void AddCustomer(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand AddCustomerCommand = new SqlCommand();
                AddCustomerCommand.Connection = connection;
                AddCustomerCommand.CommandType = System.Data.CommandType.StoredProcedure;
                AddCustomerCommand.CommandText = "AddCustomer";
                AddCustomerCommand.Parameters.Add(new SqlParameter("@FirstName", customer.FirstName));
                AddCustomerCommand.Parameters.Add(new SqlParameter("@Surname", customer.Surname));
                AddCustomerCommand.Parameters.Add(new SqlParameter("@Address", customer.Address));
                AddCustomerCommand.Parameters.Add(new SqlParameter("@Email", customer.Email));
                AddCustomerCommand.Parameters.Add(new SqlParameter("@TelephoneNo", customer.TelephoneNo));

                AddCustomerCommand.ExecuteNonQuery();

                connection.Close();
            }
            customer.CustomerID = Customer.NewID();
            Customer.customers.Add(customer);
        }

        public static void AddRole(Role role)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand AddRoleCommand = new SqlCommand();
                AddRoleCommand.Connection = connection;
                AddRoleCommand.CommandType = System.Data.CommandType.StoredProcedure;
                AddRoleCommand.CommandText = "AddRole";
                AddRoleCommand.Parameters.Add(new SqlParameter("@RoleID", role.RoleID));
                AddRoleCommand.Parameters.Add(new SqlParameter("@RoleName", role.RoleName));
                AddRoleCommand.Parameters.Add(new SqlParameter("@AccessLevel", role.AccessLevel));

                AddRoleCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void EditRole(Role role)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand EditRoleCommand = new SqlCommand();
                EditRoleCommand.Connection = connection;
                EditRoleCommand.CommandType = System.Data.CommandType.StoredProcedure;
                EditRoleCommand.CommandText = "EditRole";
                EditRoleCommand.Parameters.Add(new SqlParameter("@RoleID", role.RoleID));
                EditRoleCommand.Parameters.Add(new SqlParameter("@RoleName", role.RoleName));
                EditRoleCommand.Parameters.Add(new SqlParameter("@AccessLevel", role.AccessLevel));

                EditRoleCommand.ExecuteNonQuery();

                connection.Close();

            }
        }

        public static void DeleteRole(int ID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand DeleteRoleCommand = new SqlCommand();
                DeleteRoleCommand.Connection = connection;
                DeleteRoleCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DeleteRoleCommand.CommandText = "DeleteRole";
                DeleteRoleCommand.Parameters.Add(new SqlParameter("@RoleID", ID));

                DeleteRoleCommand.ExecuteNonQuery();

                connection.Close();

            }
        }

        public static void AddVehicle(Vehicle vehicle)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand AddVehicleCommand = new SqlCommand();
                AddVehicleCommand.Connection = connection;
                AddVehicleCommand.CommandType = CommandType.StoredProcedure;
                AddVehicleCommand.CommandText = "AddVehicle";
                AddVehicleCommand.Parameters.Add(new SqlParameter("@VehicleID", vehicle.Id));
                AddVehicleCommand.Parameters.Add(new SqlParameter("@Model", vehicle.Model));
                AddVehicleCommand.Parameters.Add(new SqlParameter("@MakeID", vehicle.make.MakeID));
                AddVehicleCommand.Parameters.Add(new SqlParameter("@YearMade", Convert.ToInt32(vehicle.YearMade)));
                AddVehicleCommand.Parameters.Add(new SqlParameter("@Colour", vehicle.Colour));
                AddVehicleCommand.Parameters.Add(new SqlParameter("@EngineSize", vehicle.EngineSize));
                AddVehicleCommand.Parameters.Add(new SqlParameter("@RegistrationPlate", vehicle.RegistrationPlate));
                AddVehicleCommand.Parameters.Add(new SqlParameter("@Vin", vehicle.VIN));
                AddVehicleCommand.Parameters.Add(new SqlParameter("@FuelType", vehicle.FuelType));
                AddVehicleCommand.Parameters.Add(new SqlParameter("@Price", vehicle.Price));
                AddVehicleCommand.Parameters.Add(new SqlParameter("@DatePurchased", vehicle.DatePurchased));

                AddVehicleCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void DeleteVehicle(int ID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand DeleteVehicleCommand = new SqlCommand();
                DeleteVehicleCommand.Connection = connection;
                DeleteVehicleCommand.CommandType = CommandType.StoredProcedure;
                DeleteVehicleCommand.CommandText = "DeleteVehicle";
                DeleteVehicleCommand.Parameters.Add(new SqlParameter("@VehicleID", ID));

                DeleteVehicleCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void DeleteEmployee(int ID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand DeleteEmployeeCommand = new SqlCommand();
                DeleteEmployeeCommand.Connection = connection;
                DeleteEmployeeCommand.CommandType = CommandType.StoredProcedure;
                DeleteEmployeeCommand.CommandText = "DeleteEmployee";
                DeleteEmployeeCommand.Parameters.Add(new SqlParameter("@EmployeeID", ID));

                DeleteEmployeeCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void DeleteCustomer(int ID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand DeleteCustomerCommand = new SqlCommand();
                DeleteCustomerCommand.Connection = connection;
                DeleteCustomerCommand.CommandType = CommandType.StoredProcedure;
                DeleteCustomerCommand.CommandText = "DeleteCustomer";
                DeleteCustomerCommand.Parameters.Add(new SqlParameter("@CustomerID", ID));

                DeleteCustomerCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void AddStatus(Status status)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand AddStatusCommand = new SqlCommand();
                AddStatusCommand.Connection = connection;
                AddStatusCommand.CommandType = CommandType.StoredProcedure;
                AddStatusCommand.CommandText = "AddStatus";
                AddStatusCommand.Parameters.Add(new SqlParameter("@StatusID", status.StatusId));
                AddStatusCommand.Parameters.Add(new SqlParameter("@StatusName", status.StatusName));

                AddStatusCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void DeleteStatus(int ID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand DeleteStatusCommand = new SqlCommand();
                DeleteStatusCommand.Connection = connection;
                DeleteStatusCommand.CommandType = CommandType.StoredProcedure;
                DeleteStatusCommand.CommandText = "DeleteStatus";
                DeleteStatusCommand.Parameters.Add(new SqlParameter("@StatusID", ID));

                DeleteStatusCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void EditStatus(Status status)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand EditStatusCommand = new SqlCommand();
                EditStatusCommand.Connection = connection;
                EditStatusCommand.CommandType = CommandType.StoredProcedure;
                EditStatusCommand.CommandText = "EditStatus";
                EditStatusCommand.Parameters.Add(new SqlParameter("@StatusID", status.StatusId));
                EditStatusCommand.Parameters.Add(new SqlParameter("@StatusName", status.StatusName));

                EditStatusCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void EditVehicle(Vehicle vehicle)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand EditVehicleCommand = new SqlCommand();
                EditVehicleCommand.Connection = connection;
                EditVehicleCommand.CommandType = CommandType.StoredProcedure;
                EditVehicleCommand.CommandText = "EditVehicle";
                EditVehicleCommand.Parameters.Add(new SqlParameter("@VehicleID", vehicle.Id));
                EditVehicleCommand.Parameters.Add(new SqlParameter("@Model", vehicle.Model));
                EditVehicleCommand.Parameters.Add(new SqlParameter("@MakeID", vehicle.make.MakeID));
                EditVehicleCommand.Parameters.Add(new SqlParameter("@YearMade", Convert.ToInt32(vehicle.YearMade)));
                EditVehicleCommand.Parameters.Add(new SqlParameter("@Colour", vehicle.Colour));
                EditVehicleCommand.Parameters.Add(new SqlParameter("@EngineSize", vehicle.EngineSize));
                EditVehicleCommand.Parameters.Add(new SqlParameter("@RegistrationPlate", vehicle.RegistrationPlate));
                EditVehicleCommand.Parameters.Add(new SqlParameter("@Vin", vehicle.VIN));
                EditVehicleCommand.Parameters.Add(new SqlParameter("@FuelType", vehicle.FuelType));
                EditVehicleCommand.Parameters.Add(new SqlParameter("@Price", vehicle.Price));
                EditVehicleCommand.Parameters.Add(new SqlParameter("@DatePurchased", vehicle.DatePurchased));

                EditVehicleCommand.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
