using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SSDCoursework
{
    public class ReportData : DataSet
    {
        public VehicleSalesDataTable VehicleSales;
        public EmployeeSalesDataTable EmployeeSales;
        public ServiceSalesDataTable ServiceSales;
        public IndividualSalesDataTable IndividualSales;

        public ReportData()
        {
            VehicleSales = new VehicleSalesDataTable();
            EmployeeSales = new EmployeeSalesDataTable();
            ServiceSales = new ServiceSalesDataTable();
            IndividualSales = new IndividualSalesDataTable();
            Tables.Add(VehicleSales);
            Tables.Add(EmployeeSales);
            Tables.Add(ServiceSales);
            Tables.Add(IndividualSales);
        }
    }

    public class VehicleSalesDataTable : DataTable
    {
        public DataColumn MakeColumn;
        public DataColumn ModelColumn;
        public DataColumn DateSoldColumn;
        public DataColumn OriginalPriceColumn;
        public DataColumn SellPriceColumn;
        public DataColumn CustomerColumn;
        public DataColumn EmployeeColumn;
        public DataColumn SelectedVehicle;
        public DataColumn SelectedMake;

        public VehicleSalesDataTable()
        {
            TableName = "VehicleSalesData";

            MakeColumn = new DataColumn("Make", typeof(string));
            ModelColumn = new DataColumn("Model", typeof(string));
            DateSoldColumn = new DataColumn("SoldDate", typeof(DateTime));
            OriginalPriceColumn = new DataColumn("OriginalPrice", typeof(decimal));
            SellPriceColumn = new DataColumn("SellPrice", typeof(decimal));
            CustomerColumn = new DataColumn("Customer", typeof(string));
            EmployeeColumn = new DataColumn("Employee", typeof(string));
            SelectedVehicle = new DataColumn("SelectedVehicle", typeof(string));
            SelectedMake = new DataColumn("SelectedMake", typeof(string));

            Columns.Add(MakeColumn);
            Columns.Add(ModelColumn);
            Columns.Add(DateSoldColumn);
            Columns.Add(OriginalPriceColumn);
            Columns.Add(SellPriceColumn);
            Columns.Add(CustomerColumn);
            Columns.Add(EmployeeColumn);
            Columns.Add(SelectedVehicle);
            Columns.Add(SelectedMake);
        }

        public DataRow NewDataRow()
        {
            return NewRow();
        }
    }

    public class EmployeeSalesDataTable : DataTable
    {
        public DataColumn NameColumn;
        public DataColumn StatusColumn;
        public DataColumn SalaryColumn;
        public DataColumn SalesColumn;
        public DataColumn ServicesColumn;
        public DataColumn TotalColumn;
        public DataColumn SelectedEmployee;
        public DataColumn SelectedStatus;

        public EmployeeSalesDataTable()
        {
            TableName = "EmployeeSalesData";

            NameColumn = new DataColumn("Name", typeof(string));
            StatusColumn = new DataColumn("Status", typeof(string));
            SalaryColumn = new DataColumn("Salary", typeof(decimal));
            SalesColumn = new DataColumn("Sales", typeof(decimal));
            ServicesColumn = new DataColumn("Services", typeof(decimal));
            TotalColumn = new DataColumn("Total", typeof(decimal));
            SelectedEmployee = new DataColumn("SelectedEmployee", typeof(string));
            SelectedStatus = new DataColumn("SelectedStatus", typeof(string));

            Columns.Add(NameColumn);
            Columns.Add(StatusColumn);
            Columns.Add(SalaryColumn);
            Columns.Add(SalesColumn);
            Columns.Add(ServicesColumn);
            Columns.Add(TotalColumn);
            Columns.Add(SelectedEmployee);
            Columns.Add(SelectedStatus);
        }

        public DataRow NewDataRow()
        {
            return NewRow();
        }
    }

    public class ServiceSalesDataTable : DataTable
    {
        public DataColumn MakeColumn;
        public DataColumn ModelColumn;
        public DataColumn ServiceTypeColumn;
        public DataColumn EmployeeColumn;
        public DataColumn DateColumn;
        public DataColumn PriceColumn;
        public DataColumn InternalServiceColumn;
        public DataColumn SelectedVehicle;
        public DataColumn SelectedMake;
        public DataColumn SelectedEmployee;

        public ServiceSalesDataTable()
        {
            TableName = "ServiceSalesDataTable";

            MakeColumn = new DataColumn("Make", typeof(string));
            ModelColumn = new DataColumn("Model", typeof(string));
            ServiceTypeColumn = new DataColumn("Type", typeof(string));
            EmployeeColumn = new DataColumn("Employee", typeof(string));
            DateColumn = new DataColumn("Date", typeof(DateTime));
            PriceColumn = new DataColumn("Price", typeof(decimal));
            InternalServiceColumn = new DataColumn("Internal", typeof(string));
            SelectedVehicle = new DataColumn("SelectedVehicle", typeof(string));
            SelectedMake = new DataColumn("SelectedMake", typeof(string));
            SelectedEmployee = new DataColumn("SelectedEmployee", typeof(string));

            Columns.Add(MakeColumn);
            Columns.Add(ModelColumn);
            Columns.Add(ServiceTypeColumn);
            Columns.Add(EmployeeColumn);
            Columns.Add(DateColumn);
            Columns.Add(PriceColumn);
            Columns.Add(InternalServiceColumn);
            Columns.Add(SelectedVehicle);
            Columns.Add(SelectedMake);
            Columns.Add(SelectedEmployee);
        }

        public DataRow NewDataRow()
        {
            return NewRow();
        }
    }

    public class IndividualSalesDataTable : DataTable
    {
        public DataColumn NameColumn;
        public DataColumn StatusColumn;
        public DataColumn TypeColumn;
        public DataColumn PriceColumn;
        public DataColumn DateColumn;

        public IndividualSalesDataTable()
        {
            TableName = "IndividualSalesData";

            NameColumn = new DataColumn("Name", typeof(string));
            StatusColumn = new DataColumn("Status", typeof(string));
            TypeColumn = new DataColumn("Type", typeof(string));
            PriceColumn = new DataColumn("Price", typeof(decimal));
            DateColumn = new DataColumn("Date", typeof(DateTime));

            Columns.Add(NameColumn);
            Columns.Add(StatusColumn);
            Columns.Add(TypeColumn);
            Columns.Add(PriceColumn);
            Columns.Add(DateColumn);
        }

        public DataRow NewDataRow()
        {
            return NewRow();
        }
    }
}