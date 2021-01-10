# Review of Test-Driven Development

[<- Back to C# Test Driven Development](../README.md)

## Table of Contents

* [Add Tests to an Existing C# Project](#add-tests-to-an-existing-c-project)
* [Add a Failing Test](#add-a-failing-test)
* [Update Test to Pass](#refactor-test-to-pass)
* [Refactor Code](#refactor-code)
* [Use Moq to Test Data](#use-moq-to-test-data)
* [References](#references)

---

## Add Tests to an Existing C# Project

Starting code demos polymorphic - it is polymorphic at run time as the correct version of the calculate weekly salary method will be invoked depending on whether or not it's a contractor.

```c#
foreach (var e in employees)
{
      e.CalculateWeeklySalary(hours, wage);
}

public class Employee
{
      public virtual void CalculateWeeklySalary(int weeklyHours, int wage)
      {
      var salary = 40 * wage;
      Console.WriteLine("\nThis ANGRY EMPLOYEE worked {0} hrs. " + 
                        "Paid for 40 hrs at $ {1}" +
                        "/hr = ${2} \n", weeklyHours, wage, salary);
      Console.WriteLine("---------------------------------------------\n");
      }
}

public class Contractor : Employee
{
      public override void CalculateWeeklySalary(int weeklyHours, int wage)
      {
      var salary = weeklyHours * wage;
      Console.WriteLine("\nThis HAPPY CONTRACTOR worked {0} hrs. " + 
                        "Paid for {0} hrs at $ {1}" +
                        "/hr = ${2} ", weeklyHours, wage, salary);
      Console.WriteLine("---------------------------------------------\n");
      }
}
```

---

## Add a Failing Test

Another set of test that can be done would be to confirm some values are not equal and if that's the intent of the test, then it should pass when it's false.

---

## Update Test to Pass

---

## Refactor Code

---

## Use Moq to Test Data

---

## References

* [LinkedIn Learning - C# Test Driven Development](https://www.linkedin.com/learning/c-sharp-test-driven-development-2)
