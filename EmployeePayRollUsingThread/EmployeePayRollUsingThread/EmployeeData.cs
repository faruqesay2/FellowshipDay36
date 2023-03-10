using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayRollUsingThread
{
    public class EmpData
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public char Gender { get; set; }
        public double BasicPay { get; set; }
        public double Deductions { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public EmpData(int EmployeeID, string EmployeeName, string PhoneNumber, string Address, string Department, char Gender, double BasicPay, double Deductions, double TaxablePay, double Tax, double NetPay, string City, string Country)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeName = EmployeeName;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Department = Department;
            this.Gender = Gender;
            this.BasicPay = BasicPay;
            this.Deductions = Deductions;
            this.TaxablePay = TaxablePay;
            this.Tax = Tax;
            this.NetPay = NetPay;
            this.City = City;
            this.Country = Country;

        }

    }
    //UC-4 & 5
    public class PayrollDetails
    {
        public int EmployeeID { get; set; }
        public double BasicPay { get; set; }
        public double Deductions { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }

        public PayrollDetails(int EmployeeID, double BasicPay, double Deductions, double TaxablePay, double Tax, double NetPay)
        {
            this.EmployeeID = EmployeeID;
            this.BasicPay = BasicPay;
            this.Deductions = Deductions;
            this.TaxablePay = TaxablePay;
            this.Tax = Tax;
            this.NetPay = NetPay;

        }
    }
}
