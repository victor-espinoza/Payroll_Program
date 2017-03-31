//Victor Espinoza
//CECS 475 - Application Programming using .NET
//Assignment #2 - Payroll Program
//Due: 2/4/16

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CECS_475_Lab2_Payroll {
   public class SalariedEmployee : Employee {
      private decimal weeklySalary;

      // four-parameter constructor
      public SalariedEmployee(string first, string last, string ssn, decimal salary)
         : base(first, last, ssn) {
         WeeklySalary = salary; // validate salary via property
      } // close SalariedEmployee(...) four-parameter constructor


      // property that gets and sets salaried employee's salary
      public decimal WeeklySalary {
         get {
            return weeklySalary;
         } // end get
         set {
            if (value >= 0) // validation
               weeklySalary = value;
            else
               throw new ArgumentOutOfRangeException("WeeklySalary",
                value, "WeeklySalary must be >= 0");
         } // end set
      } // close property WeeklySalary


      // calculate earnings; override abstract method Earnings in Employee
      public override decimal GetPaymentAmount() {
         return WeeklySalary;
      } // close GetPaymentAmount()      


      // return string representation of SalariedEmployee object
      public override string ToString() {
         return string.Format("salaried employee: {0}\n{1}: {2:C}",
          base.ToString(), "weekly salary", WeeklySalary);
      } // close ToString()

   } // close class SalariedEmployee
}//close namespace CECS_475_Lab2_Payroll
