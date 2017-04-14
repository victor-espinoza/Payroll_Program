# Lab_2_Payroll_Program
Project Overview:    
Payroll program with C#.  
   
This project deals with  the polymorphic relationship between the abstract Employee class and the other Employee classes within this project (HourlyEmployee, CommissionEmployee, and SalariedEmployee). 
   
It also deals with the different sorting types of IComparable, IComparer, and using a delegate.

While using the program users are allowed to sort employee names in ascending order using IComparable, Sorting employees by pay amount in descending order using IComparer, Sorting employees by social security number in ascending order using a selection sort and delegate, and exiting the program.  
  
Dependencies:      
This project was created using Microsoft Visual Studio Community 2013 for Windows Desktop Version: 12.0.40629.00 Update 5.
     
Sample Output:     
Employees processed polymorphically: 

salaried employee: John Smith
social security number: 111-11-1111
weekly salary: $700.00
earned $700.00

salaried employee: Antonio Smith
social security number: 555-55-5555
weekly salary: $800.00
earned $800.00

salaried employee: Victor Smith
social security number: 444-44-4444
weekly salary: $600.00
earned $600.00

hourly employee: Karen Price
social security number: 222-22-2222
hourly wage: $16.75; hours worked: 40.00
earned $670.00

hourly employee: Ruben Zamora
social security number: 666-66-6666
hourly wage: $20.00; hours worked: 40.00
earned $800.00

commission employee: Sue Jones
social security number: 333-33-3333
gross sales: $10,000.00
commission rate: 0.06
earned $600.00

base-salaried commission employee: Bob Lewis
social security number: 777-77-7777
gross sales: $5,000.00
commission rate: 0.04; base salary: $300.00
new base salary with 10% increase is: $330.00
earned $530.00

base-salaried commission employee: Lee Duarte
social security number: 888-88-888
gross sales: $5,000.00
commission rate: 0.04; base salary: $300.00
new base salary with 10% increase is: $330.00
earned $530.00


User Menu:
 1. Sort last name in ascending order using IComparable.
 2. Sort pay amount in descending order using IComparer.
 3. Sort by social security number in ascending order using a
    selection sort and delegate.
 4. Exit program

Please enter the number of the command you wish to execute:
(1 <= command number =< 4):
1
You chose command #1: Sort by last name in ascending order
using IComparable.

Sorted Result:
   1. Lee        Duarte
   2. Sue        Jones
   3. Bob        Lewis
   4. Karen      Price
   5. Antonio    Smith
   6. John       Smith
   7. Victor     Smith
   8. Ruben      Zamora

User Menu:
 1. Sort last name in ascending order using IComparable.
 2. Sort pay amount in descending order using IComparer.
 3. Sort by social security number in ascending order using a
    selection sort and delegate.
 4. Exit program

Please enter the number of the command you wish to execute:
(1 <= command number =< 4):
2
You chose command #2: Sort by pay amount in descending order
using IComparer.

Sorted Result:
   1. Antonio    Smith      -     Payment Amount: $800.00
   2. Ruben      Zamora     -     Payment Amount: $800.00
   3. John       Smith      -     Payment Amount: $700.00
   4. Karen      Price      -     Payment Amount: $670.00
   5. Sue        Jones      -     Payment Amount: $600.00
   6. Victor     Smith      -     Payment Amount: $600.00
   7. Lee        Duarte     -     Payment Amount: $530.00
   8. Bob        Lewis      -     Payment Amount: $530.00

User Menu:
 1. Sort last name in ascending order using IComparable.
 2. Sort pay amount in descending order using IComparer.
 3. Sort by social security number in ascending order using a
    selection sort and delegate.
 4. Exit program

Please enter the number of the command you wish to execute:
(1 <= command number =< 4):
3
You chose command #3: Sort by social security number in
ascending order using a selection sort and delegate

Sorted Result:
   1. John       Smith      -    SSN: 111-11-1111
   2. Karen      Price      -    SSN: 222-22-2222
   3. Sue        Jones      -    SSN: 333-33-3333
   4. Victor     Smith      -    SSN: 444-44-4444
   5. Antonio    Smith      -    SSN: 555-55-5555
   6. Ruben      Zamora     -    SSN: 666-66-6666
   7. Bob        Lewis      -    SSN: 777-77-7777
   8. Lee        Duarte     -    SSN: 888-88-888

User Menu:
 1. Sort last name in ascending order using IComparable.
 2. Sort pay amount in descending order using IComparer.
 3. Sort by social security number in ascending order using a
    selection sort and delegate.
 4. Exit program

Please enter the number of the command you wish to execute:
(1 <= command number =< 4):
1234
The number provided was not within the appropriate range of permissible
values. Please enter an integer value between 1 and 4...

User Menu:
 1. Sort last name in ascending order using IComparable.
 2. Sort pay amount in descending order using IComparer.
 3. Sort by social security number in ascending order using a
    selection sort and delegate.
 4. Exit program

Please enter the number of the command you wish to execute:
(1 <= command number =< 4):
av
Invalid user input. Please enter an INTEGER value between 1 and 4...

User Menu:
 1. Sort last name in ascending order using IComparable.
 2. Sort pay amount in descending order using IComparer.
 3. Sort by social security number in ascending order using a
    selection sort and delegate.
 4. Exit program

Please enter the number of the command you wish to execute:
(1 <= command number =< 4):
4
You chose command #4:
You will now exit the program...
Your session has been terminated. Thank you for using this program.
Click any key to close this window..
