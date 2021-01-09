# A Simple Test-Driven C# Project

[<- Back to C# Test Driven Development](../README.md)

## Table of Contents

* [Different Approaches to Testing](#different-approaches-to-testing)
* [Red, Green, Refactor](#red-green-refactor)
* [Refactor: A Deeper Look](#refactor-a-deeper-look)
* [The Art of Testing](#the-art-of-testing)
* [References](#references)

---

## Create a simple test-driven C# Project

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

## Add A Failing Test

Unit test are set up using a three-step pattern referred to as Arrange, Act and Assert.

* Arrange by initializing objects and setting the values that are needed
* Act by invoking the methods on those objects
* Assert by verifying that the action of these methods heaved as expected

---

## References

* [LinkedIn Learning - C# Test Driven Development](https://www.linkedin.com/learning/c-sharp-test-driven-development-2)
