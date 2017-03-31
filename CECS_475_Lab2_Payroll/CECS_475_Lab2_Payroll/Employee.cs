//Victor Espinoza
//CECS 475 - Application Programming using .NET
//Assignment #2 - Payroll Program
//Due: 2/4/16

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CECS_475_Lab2_Payroll {
   public abstract class Employee : IPayable, IComparable {

      // read-only property that gets employee's first name
      public string FirstName { get; private set; }


      // read-only property that gets employee's last name
      public string LastName { get; private set; }


      // read-only property that gets employee's social security number
      public string SocialSecurityNumber { get; private set; }


      // three-parameter constructor
      public Employee(string first, string last, string ssn) {
         FirstName = first;
         LastName = last;
         SocialSecurityNumber = ssn;
      }// close Employee(...) three-parameter constructor


      //allow derived classes to overridde the implementation of GetPaymentAmount
      public virtual decimal GetPaymentAmount() {
         return 0.0m;
      }// close GetPaymentAmount()


      // return string representation of Employee object, using properties
      public override string ToString() {
         return string.Format("{0} {1}\nsocial security number: {2}",
            FirstName, LastName, SocialSecurityNumber);
      } // close ToString()


      //nested class to do descending sort on pay amount property.
      public class SortPayAmountDescendingHelper : IComparer {
         int IComparer.Compare(object a, object b) {
            Employee emp1 = (Employee)a;
            Employee emp2 = (Employee)b;

            return (emp1.GetPaymentAmount() < emp2.GetPaymentAmount())
             ? 1 : ((emp1.GetPaymentAmount() > emp2.GetPaymentAmount())
             ? -1 : 0);
         }//end IComparer.Compare(...)
      }//close sortPayAmountDescendingHelper()


      //Implement IComparable CompareTo to provide default sort order.
      int IComparable.CompareTo(object obj) {
         Employee emp = (Employee)obj;
         //compare the last name of both of the Employees
         int result = String.Compare(this.LastName, emp.LastName);
         if (result == 0)
            //Last Names are the same. Compare/Return the sort on the first name instead
            return String.Compare(this.FirstName, emp.FirstName);
         else
            //Last Names are not the same. Return comparison of last names.
            return result;
      }//close IComparable.CompareTo(...)


      //Method to return IComparer object for sort helper.
      public static IComparer SortPayAmountDescending() {
         return (IComparer)new SortPayAmountDescendingHelper();
      }//close SortPayAmountDescending()


      //Helps determine whether ssn is greater than the next item in array
      public static bool SSNIsGreaterThan(object lhs, object rhs) {
         Employee empLhs = (Employee)lhs;
         Employee empRhs = (Employee)rhs;
         return (empRhs.SocialSecurityNumber.CompareTo(empLhs.SocialSecurityNumber)
          > 0);
         //String.Compare(empRhs.SocialSecurityNumber, empLhs.SocialSecurityNumber)
      }//close SSNIsGreaterThan(...)

   } // close abstract class Employee
}//close namespace CECS_475_Lab2_Payroll
