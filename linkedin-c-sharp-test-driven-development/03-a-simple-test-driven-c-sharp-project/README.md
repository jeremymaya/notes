# A Simple Test-Driven C# Project

[<- Back to C# Test Driven Development](../README.md)

## Table of Contents

* [Create a Simple Test-Driven C# Project](#create-a-simple-test-driven-c-project)
* [Add a Failing Test](#add-a-failing-test)
* [Update Test to Pass](#update-test-to-pass)
* [Refactor the Code](#refactor-the-code)
* [Create Another Test](#create-another-test)
* [References](#references)

---

## Create a Simple Test-Driven C# Project

### Description

Create a simple annual salary and hourly wage calculator.

The application will have two functions:

* A function to determine your hourly wage by dividing the annual salary by 2080
* A function to determine our annal salary by multiplying the hourly wage by 2080

```text
To get hourly, divide annual salary by 2080
$100,006.40 / 2080 = $48.08 hr

To get annual, multiply hourly by 2080
$48.08 * 2080 = $100,1006.40
```

Create the unite test first then draw the design of the program.

---

## Add a Failing Test

Unit test are set up using a three-step pattern referred to as Arrange, Act and Assert.

* Arrange by initializing objects and setting the values that are needed
* Act by invoking the methods on those objects
* Assert by verifying that the action of these methods heaved as expected

## Update Test to Pass

* Add a new project under the same solution
* Add a reference from the test to the newly created class library
* Import a namespace to be tested
* Run the test

---

## Refactor the Code

```c#
const int HoursInYear = 2080;
```

Above code moved to outside of `GetAnnualSalary` method so `GetHourlyWage` method can also access it later.

---

## Create Another Test

* Individual test case can be debugged by placing a breakpoint and selecting `Debug Test`

Methods can be refactored further by converting them into expression body function

```c#
public decimal GetAnnualSalary(decimal hourlyWage)
{
    decimal annualSalary = hourlyWage * HoursInYear;
    return annualSalary;
}

// expression-bodied method
public decimal GetAnnualSalary(decimal hourlyWage) => hourlyWage * HoursInYear;
```

---

## References

* [LinkedIn Learning - C# Test Driven Development](https://www.linkedin.com/learning/c-sharp-test-driven-development-2)
* [Microsoft - Expression-bodied members (C# programming guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members)
