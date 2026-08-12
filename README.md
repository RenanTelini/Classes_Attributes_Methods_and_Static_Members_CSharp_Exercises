# Classes, Attributes, Methods and Static Members - C# Exercises

#### These exercises are based on the <a href="https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/?couponCode=MT260714G2">"C# COMPLETO Programação Orientada a Objetos + Projetos"</a> course.

## Classes and Attributes

### <ins>Exercise 01</ins>

#### Write a program that reads data for two people and displays the name of the older person.

#### Example:

First person's details:<br>
Name: <strong>Maria</strong><br>
Age: <strong>17</strong><br>
Second person's details:<br>
Name: <strong>Joao</strong><br>
Age: <strong>16</strong><br>
Older person: <strong>Maria</strong>

### <ins>Exercise 02</ins>

#### Write a program that reads the names and salaries of two employees and then displays their average salary.

#### Example:

Details of the first employee:<br>
Name: <strong>Carlos Silva</strong><br>
Salary: <strong>6300.00</strong><br>
Details of the second employee:<br>
Name: <strong>Ana Marques</strong><br>
Salary: <strong>6700.00</strong><br>
Average salary = <strong>6500.00</strong>

## Classes and Methods

### <ins>Exercise 03</ins>

#### Write a program to read the width and height of a rectangle. Then, display its area, perimeter, and diagonal. Use a class based on the UML diagram shown alongside this exercise.

| Rectangle |
|:----|
|- Heght: double <br> - Width: double |
| + Area(): double <br> + Perimeter(): double <br> + Diagonal(): double |

#### Example:

Enter the height and width of a rectangle: <br>
<strong>3.00</strong><br>
<strong>4.00</strong><br>
Area = 12.00<br>
Perimeter = 14.00<br>
Diagonal = 5.00

### <ins>Exercise 04</ins>

#### Write a program to read an employee's data (name, gross salary, and tax). Then, display the employee's name and net salary. Next, increase the employee's salary by a given percentage. The percentage should be applied only to the gross salary. Finally, display the employee's name and updated net salary. Use the class designed below.

| Employee |
|:----|
| - Name: string <br> - GrossSalary: double <br> - Tax: double |
| + NetSalary(): double <br> + IncreaseSalary(percentage: double): void |

#### Example:

Name: <strong>Joao Silva</strong><br>
Gross salary: <strong>6000.00</strong><br>
Tax: <strong>1000.00</strong><br>

Employee: Joao Silva, $ 5000.00

Enter the percentage increase in salary: <strong>10.0</strong><br>

Updated data: Joao Silva, $ 5600.00

### <ins>Exercise 05</ins>

#### Write a program to read a student's names and the three grades obtained in the three terms of the year (the first term is worth 30 points, while the second and third terms are worth 35 points each).

#### At the end, display the student's final grade for the year. Also, indicate whether the student has PASSED or FAILED. If the student has FAILED, state how many points are needed to reach the minimum passing score of 60 points.

#### You must create a "Student" class to solve this problem.

#### Example 1:

Student name: <strong>Alex Green</strong><br>
Enter the student's three grades:<br>
<strong>27.00</strong><br>
<strong>31.00</strong><br>
<strong>32.00</strong><br>
Final grade = 90.00<br>
Approved

#### Example 2:

Student name: <strong>Alex Green</strong><br>
Enter the student's three grades:<br>
<strong>17.00</strong><br>
<strong>20.00</strong><br>
<strong>15.00</strong><br>
Final grade = 52.00<br>
Failed<br>
Fell short by 8.00 points

#### Class Student:

| Student |
|:-|
| - Name: string <br> - Grade1: double <br> - Grade2: double <br> - Grade3: double |
| + CalcGrade(): double <br> + CalcReprovedGrade(): double |

## Classes and Static Members

### <ins>Exercise 06</ins>

#### Write a program that reads the dollar exchange rate and the amount of dollars a person wants to purchase using Brazilian reais. Calculate and display the total amount to be paid in reais, including a 6% IOF tax applied to the dollar amount.

#### Create a "CurrencyConverter" class to handle the calculations.

#### Class CurrencyConverter:

| CurrencyConverter |
|:--|
| - Iof: double |
| + CalcConversion(double exchangeRate, <br>double qtyDollars): double |

#### Example:

What is the dollar exchange rate? <strong>3.10</strong><br>
How many dollars are you going to buy? <strong>200.00</strong><br>
Amount to be paid in Brazilian reais = 657.20