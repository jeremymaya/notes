# Software Development

[<- Back to Programming Foundations: Object-Oriented Design](../README.md)

## Table of Contents

* [OOP Support in Different Languages](#oop-support-in-different-languages)
* [General Development Principles](#general-development-principles)
* [Software Testing](#software-testing)
* [Design Patterns](#design-patterns)
* [References](#references)

---

## OOP Support in Different Languages

| Language | Inheritance | Call to Super | Typing | Interfaces | Abstract Classes |
|:-:|:-:|:-:|:-:|:-:|:-:|
| Java | single | super | static | Yes | Yes |
| C# | single | base| static | Yes | Yes |
| Python | multiple| super | dynamic | Abstract Class | Yes |
| Swift | single | super | static | Protocols | No |
| C++ | multiple | name of class::| static | Abstract Class| Yes |
| Ruby | mixins | super | dynamic | N/A | N/A |
| JavaScript| prototypes | N/A | dynamic | N/A | N/A |

---

## General Development PrinciplesS

### SOLID Principle

SOLID Principle - five separate but interrelated principles that apply to any object oriented design and are intended to make the software more understandable, flexible, and maintainable.

* **S**ingle Responsibility principle
  * A class should have only a single responsibility - avoid God objects
* **O**pen/Closed Principle
* **L**iskov Substitution Principle
* **I**nterface Segregation Principle
* **D**ependency Inversion Principle

### DRY

**D**on't **R**epeat **Y**ourself - avoid copying and pasting large sections of code without any changes.

### YAGNI

You Ain't Gonna Need It - make your scope appropriate and don't waste time on the features/principles that aren't useful

### Code Smell

Any characteristics in a program's code that possibility indicates a deeper problem.

---

## Software Testing

Software should be easy and intuitive to use.

If there is an optional field, input or tool, there will always be a user that tries to use in a way that was not intended to.

Also,

* Have proper error messages and prompts
* Create automated unit tests and system tests

---

## Design Patterns

Design Patterns are common, re-usable form of a solution to a design problem when creating software programs.

### Creational Patterns

* Abstract Factory
* Builder
* Factory Method
* Prototype
* Singleton

### Structural Patterns

* Adapter
* Bridge
* Composite
* Decorator
* Facade
* Flyweight
* Proxy

### Behavioral Patterns

* Chain of Responsibility
* Command
* Interpreter
* Iterator
* Mediator
* Memento
* Observer
* State
* Strategy
* Template Method
* Visitor

Refer to *Gang of Four Book* or *Head First Design Patterns* to learn the design pattern topic.

---

## References

* [LinkedIn Learning - Programming Foundations: Object-Oriented Design](https://www.linkedin.com/learning/programming-foundations-object-oriented-design-3/object-oriented-thinking)
