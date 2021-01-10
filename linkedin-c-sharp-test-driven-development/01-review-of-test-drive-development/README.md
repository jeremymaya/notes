# Review of Test-Driven Development

[<- Back to C# Test Driven Development](../README.md)

## Table of Contents

* [Different Approaches to Testing](#different-approaches-to-testing)
* [Red, Green, Refactor](#red-green-refactor)
* [Refactor: A Deeper Look](#refactor-a-deeper-look)
* [The Art of Testing](#the-art-of-testing)
* [References](#references)

---

## Different Approaches to Testing

Most companies do not apply all of the above testing. One of the popular testing approach is __unit testing__.

* Acceptance testing
* Black box testing
* Compatibility testing
* Conformance testing
* FUnctional testing
* Integration testing
* Load testing
* Regression testing
* Smoke testing
* System testing
* Unit Testing
* White box testing

### Unit Testing

Tiny testable parts of a program independently tested for expected functionality.

### Test Driven Development

Process that uses unit tests to drive the design of software

Advantages Include:

* Clear intentions - knowing what you want and then creating it
* Encourages decoupling
* Easier to catch bugs early on
* Forces writing test cases early and lessens chance o missing test cases later
* Helps achieve YAGNI, or "you ain't gonna need it"
  * Prevents from writing excess code

---

## Red, Green, Refactor

1. Red - creating a test that will fail
2. Green - updating a test to pass
3. Refactor - updating your code to meet coding standards and minimize duplication

---

## Refactor: A Deeper Look

At a surface level, refactoring involves removing duplicate code and cleaning code for legibility.

At a deeper level, refactoring comes from following **SOLID** principles, made by Robert Martin.

* **S**ingle Responsibility Principle (SRP)
* **O**pen/Closed Principe (OCP)
* **L**iskov Substitution Principle (LSP)
* **I**nterface Segregation Principle (ISP)
* **D**ependency Inversion Principle (DIP)

**The SOLID principle based refactoring is about preventing code from being coupled.**

### Single Responsibility Principle

SRP - a class/method should have one, and only one, reason to change

```text
A class should have one, and only one, role. I should not handle any unrelated role to its core purpose. There should be another class for that.
```

### Open/Closed Principe

OCP - you should be able to extend a classes behavior, without modifying it

```text
Changes to the base classes is not permitted. Extra functionality should be added by extending the base class not modifying it.
```

### Liskov Substitution Principle

LSP - derived classes must be substitutable for their base classes

```text
"Objects in a program should be replaceable with instances of their subtypes, without altering the correctness of that program."
```

### Interface Segregation Principle

ISP - Make fine-grained interfaces that are client specific

```text
"You are better off with having several interfaces with unique roles, rather than one big interface with different roles."
```

### Dependency Inversion Principle

DIP - depends on abstractions, not on concretions

**Interfaces** are abstractions (no functioning methods; just signatures).

```text
"If you needed to inherit either from an abstraction or concretion, it is better to implement an interface, rather than inheriting a class that has implementation, so that you have a flexibility to create your own implementation."
```

```c#
// Abstraction
public interface ICustomer
{
    string GetName();
}

// Concretion
public class Customer : ICustomer
{
    string ICustomer.GetName()
    {
        string customerName = "Elvis";
        return customerName;
    }
}
```

---

## The Art of Testing

Be able to defend why you've chosen your approach when it comes to testing.

---

## References

* [LinkedIn Learning - C# Test Driven Development](https://www.linkedin.com/learning/c-sharp-test-driven-development-2)
* [medium - SOLID 법칙 中 LID](https://medium.com/humanscape-tech/solid-법칙-中-lid-fb9b89e383ef)
