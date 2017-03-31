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
   public class PayrollSystemTest {

      public static void Main(string[] args) {
         int userInput = -1; //used to keep track of user input
         int counter = 1;  //used to print out the designated order number in the array.

         IPayable[] payableObjects = new IPayable[8]; //declare array of IPayable objects

         //fill in array with data
         payableObjects[0] = new SalariedEmployee("John", "Smith", "111-11-1111", 700M);
         payableObjects[1] = new SalariedEmployee("Antonio", "Smith", "555-55-5555", 800M);
         payableObjects[2] = new SalariedEmployee("Victor", "Smith", "444-44-4444", 600M);
         payableObjects[3] = new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75M, 40M);
         payableObjects[4] = new HourlyEmployee("Ruben", "Zamora", "666-66-6666", 20.00M, 40M);
         payableObjects[5] = new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000M,
          .06M);
         payableObjects[6] = new BasePlusCommissionEmployee("Bob", "Lewis", "777-77-7777",
          5000M, .04M, 300M);
         payableObjects[7] = new BasePlusCommissionEmployee("Lee", "Duarte", "888-88-888",
          5000M, .04M, 300M);

         //Inform user that employees are going to be processed polymorphically
         Console.WriteLine("Employees processed polymorphically:\n");

         //Display each Employee's information
         foreach (Employee currentEmployee in payableObjects) {
            Console.WriteLine(currentEmployee); // invokes ToString
            // determine whether element is a BasePlusCommissionEmployee
            if (currentEmployee is BasePlusCommissionEmployee) {
               // downcast Employee reference to 
               // BasePlusCommissionEmployee reference
               BasePlusCommissionEmployee employee =
                (BasePlusCommissionEmployee)currentEmployee;
               employee.BaseSalary *= 1.10M; //increase their BaseSalary.
               Console.WriteLine("new base salary with 10% increase is: {0:C}",
                employee.BaseSalary); //inform user of increase.
            } // end if
            //Display pay amount
            Console.WriteLine("earned {0:C}\n", currentEmployee.GetPaymentAmount());
         } // end foreach

         while (userInput != 4) {
            try {
               //display commands and prompt user to enter a valid command
               Console.WriteLine("\nUser Menu: \n 1. Sort last name in ascending order "
                 + "using IComparable.\n 2. Sort pay amount in descending order using "
                 + "IComparer.\n 3. Sort by social security number in ascending order "
                 + "using a\n    selection sort and delegate.\n 4. Exit program ");
               Console.WriteLine("\nPlease enter the number of the command you wish to "
                + "execute:\n(1 <= command number =< 4): ");
               //attempt to convert the user input into an integer
               userInput = Convert.ToInt32(Console.ReadLine());
               //if the conversion was correct but the number is not within the valid
               //range of 1 <= input =< 4, then re-prompt the user to enter a valid value
               if (userInput > 4 || userInput < 1)
                  Console.WriteLine("The number provided was not within the appropriate"
                    + " range of permissible \nvalues. Please enter an integer value "
                    + "between 1 and 4...");
               else {
                  switch (userInput) {
                     case 1:
                        Console.WriteLine("You chose command #1: Sort by last name "
                        + "in ascending order\nusing IComparable.\n\nSorted Result:");
                        //Demo IComparable by sorting array with "default" sort ordr.
                        Array.Sort(payableObjects);

                        //display the names of the employees
                        counter = 1;
                        foreach (Employee emp in payableObjects)
                           Console.WriteLine("   {0}. {1, -10} {2, -10}", counter++,
                            emp.FirstName, emp.LastName);
                        break;
                     case 2:
                        Console.WriteLine("You chose command #2: Sort by pay amount "
                         + "in descending order\nusing IComparer.\n\nSorted Result:");
                        //sort data using IComparer
                        Array.Sort(payableObjects, Employee.SortPayAmountDescending());

                        //display the names of the employees and payment amont
                        counter = 1;
                        foreach (Employee emp in payableObjects)
                           Console.WriteLine("   {0}. {1, -10} {2, -10} -     "
                            + "Payment Amount: {3:C}", counter++, emp.FirstName,
                            emp.LastName, emp.GetPaymentAmount());
                        break;
                     case 3:
                        Console.WriteLine("You chose command #3: Sort by social "
                         + "security number in\nascending order using a selection "
                         + "sort and delegate\n\nSorted Result:");
                        SelectionSort(payableObjects, Employee.SSNIsGreaterThan);

                        //display the names of the employees and payment amont
                        counter = 1;
                        foreach (Employee emp in payableObjects)
                           Console.WriteLine("   {0}. {1, -10} {2, -10} -    "
                            + "SSN: {3}", counter++, emp.FirstName, emp.LastName,
                            emp.SocialSecurityNumber);
                        break;
                     case 4:
                        Console.WriteLine("You chose command #4:\n"
                        + "You will now exit the program...");
                        break;
                     default:
                        Console.WriteLine("You have reached the default case...");
                        break;

                  }//end switch
               }//end else
            }//end try
            catch (FormatException) {
               //inform the user that they did not enter an integer value and re-prompt
               //the command value input.
               Console.WriteLine("Invalid user input. Please enter an INTEGER value "
                + "between 1 and 4...");
            }//end catch
         }//end while loop
         Console.WriteLine("Your session has been terminated. Thank you for using this "
          + "program.\nClick any key to close this window..");
         Console.ReadKey();
      } // close Main(...)


      // Declare a delegate that will refer to a function having two object parameters and 
      //will return boolean value
      public delegate bool CompareDelegate(object lhs, object rhs);

      public static void BubbleSort(object[] sortArray, CompareDelegate comparisonMethod) {

         if (sortArray == null)
            return;
         if (comparisonMethod == null)
            throw new ArgumentNullException("comparisonMethod");
         for (int i = 0; i < sortArray.Length; i++) {
            for (int j = i + 1; j < sortArray.Length; j++) {
               if (comparisonMethod(sortArray[j], sortArray[i])) {
                  object temp = sortArray[i];
                  sortArray[i] = sortArray[j];
                  sortArray[j] = temp;
               }//end if
            }//end inner for loop
         }//end outer for loop

      }//close class BubbleSort()


      public static void SelectionSort(object[] sortArray, CompareDelegate comparisonMethod) {
         int min_pos;
         object temp;
         if (sortArray == null)
            return;
         if (comparisonMethod == null)
            throw new ArgumentNullException("comparisonMethod");
         for (int i = 0; i < sortArray.Length - 1; i++) {
            min_pos = i;
            for (int j = i + 1; j < sortArray.Length; j++) {
               if (comparisonMethod(sortArray[j], sortArray[min_pos])) {
                  min_pos = j;
               }//end if
            }//end inner for loop
            //if pos_min no longer equals i than a smaller value must have been found, 
            //so a swap must occur
            if (min_pos != i) {
               temp = sortArray[i];
               sortArray[i] = sortArray[min_pos];
               sortArray[min_pos] = temp;
            }//end if
         }//end outer for loop  

      }//close class SelectionSort()

   } // close class PayrollSystemTest
}//close namespace CECS_475_Lab2_Payroll
