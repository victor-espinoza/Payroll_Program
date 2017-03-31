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
   public class CommissionEmployee : Employee {
      private decimal grossSales; // gross weekly sales
      private decimal commissionRate; // commission percentage

      // five-parameter constructor
      public CommissionEmployee(string first, string last, string ssn, decimal sales,
       decimal rate)
         : base(first, last, ssn) {
         GrossSales = sales; // validate gross sales via property
         CommissionRate = rate; // validate commission rate via property
      } // close CommissionEmployee(...) five-parameter constructor


      // property that gets and sets commission employee's gross sales
      public decimal GrossSales {
         get {
            return grossSales;
         } // end get
         set {
            if (value >= 0)
               grossSales = value;
            else
               throw new ArgumentOutOfRangeException(
                "GrossSales", value, "GrossSales must be >= 0");
         } // end set
      } // close property GrossSales


      // property that gets and sets commission employee's commission rate
      public decimal CommissionRate {
         get {
            return commissionRate;
         } // end get
         set {
            if (value > 0 && value < 1)
               commissionRate = value;
            else
               throw new ArgumentOutOfRangeException("CommissionRate",
                value, "CommissionRate must be > 0 and < 1");
         } // end set
      } // close property CommissionRate


      // calculate earnings; override abstract method Earnings in Employee
      public override decimal GetPaymentAmount() {
         return CommissionRate * GrossSales;
      } // close GetPaymentAmount()           


      // return string representation of CommissionEmployee object
      public override string ToString() {
         return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}",
          "commission employee", base.ToString(),
          "gross sales", GrossSales, "commission rate", CommissionRate);
      } // close ToString() 
   }//close class CommissionEmployee
}//close namespace CECS_475_Lab2_Payroll
