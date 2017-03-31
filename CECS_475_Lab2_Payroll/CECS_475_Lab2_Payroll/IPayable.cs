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
   public interface IPayable {
      decimal GetPaymentAmount(); // calculate payment; no implementation
   } // close interface IPayable
}//close namespace CECS_475_Lab2_Payroll
