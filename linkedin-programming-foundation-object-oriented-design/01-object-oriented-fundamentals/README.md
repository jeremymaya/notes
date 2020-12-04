# Object-Oriented Fundamentals

---

## Object-Oriented Thinking

There are different programming paradigms:

* Procedural Programming Languages
  * C
* Object Oriented Programming Languages
  * C#, C++, Go, Java, JavaScript, Perl, PHP, Python, R, Ruby, Swift, VB.NET and etc.
* Logic Programming Languages
  * Prolog
* Functional Programming Languages
  * Haskell

The object orientated programming is NOT a language itself, instead, object orientation is referred to as a **programming paradigm**.

### Procedural Programming Languages

* A program is written as a long series of operations to execute
* Can be organized into named functions or sub-routines to make the code modular and maintainable

Advantage of the procedural approach includes quick and easier way ot completing a tasks. However, it is not great for scalability and changes in the future.

### Object Oriented Programming Languages

* Code is split apart into several contained object instead of a single large program
* Each object contains its own data and logic to describe how it behaves and interacts with other objects

Although writing code in object oriented approach may feel bloated and way beyond the scope of a  project, advantage of includes **code reusability** where the real value of object orientation will appear as your projects grow in scale and require changes.

---

## Objects

The idea behind object-oriented computing is that it makes thinking about and discussing programming similar to thinking about the real world.

All objects have:

* Identity - self-contained so it has its own identity separate from other objects
* Attributes - describe its current state
* Behaviors - the things it can do

The idea of an object extends further to describe __non-tangible__ things too. Like a date, a timer, or a bank account.

Objects == Noun (can you put "the" in front of it?)

* Things
* People
* Places
* Ideas
* Concepts

Whereas,

Behaviors == Verbs

---

## Classes

A class is the detailed description, the definition, the template of what an object will be.

### Class vs Object

3 components of a class in object-oriented programming:

* Name (type)
* Attributes (properties)
* Behaviors (operations)

Class != Object

We use class to **instantiate** objects (every object is an instant of a class). Each of the instances, each object has its own data, its own identity, independent from other objects.

### Method vs Function

| Method | Function |
|:-|:-|
| A program procedure that can return a value | A program procedure that can return a value |
|| Defined as part of a class |
|| Can only access data known to its object|

### Frameworks and Libraries

Frameworks and Libraries are a collection of predefined classes for a language.

* Java Class Library for Java
* .NET Framework for C# and Visual Basic .NET
* C++ Standard Library for C++
* The Standard Library for Ruby and Python

---

## Abstraction

The four fundamental ideas in object-oriented programming when creating classes: `APIE`

* Abstraction
* Polymorphism
* Inheritance
* Encapsulation

Abstraction

* Focus on the essential qualities of something rather than one specific example
* Discard what's unimportant or irrelevant

It should be what should a person class look like for __this application__? Instead of what does a person class look like?

---

## Encapsulation

Encapsulation is about containing the elements of an object

* Keep the elements of an object together and protect them
* Restricts access to some of the object's components

One of the principles of encapsulation is called `black boxing` which an object should not make anything about itself available except what is absolutely necessary for other parts of the application to work.

One of the main benefits with object orientation is that it allows us to more safely change the way the object works without changing the rest of the application. __It's about reducing dependencies__ between different parts of the application. The change in one place won't cause a domino effect and require multiple changes elsewhere.

The general rule is to encapsulate as much as possible.

---

## Inheritance

Inheritance

* Base a new object or class on an existing one
* Inherit the existing attributes and methods
* Great for of code reuse

```text
                                      +-----------------+
                                      |     Person      |                     Superclass
                                      |-----------------|                     (Parent class)
                                      | name            |                     (Base class)
                                      | phone           |
                                      | address         |
                                      |-----------------|
                                      | updateContact() |
                                      +-----------------+
                                          ^         ^
                                          |         |
"Customer inherits from Person"           |         |
                                          |         |
                                          |         |
                    +------------------------+  +------------------------+
                    |        Customer        |  |        Employee        |    Subclass
                    |------------------------|  |------------------------|    (Child class)
                    | (Everything in Person) |  | (Everything in Person) |    (Derived class)
                    | customerID             |  | employeeID()           |
                    | purchase()             |  | promote()              |
                    +------------------------+  | retire()               |
                                                +------------------------+
```

* `Customer` class automatically gets everything in the `Person` class.
* Any additional attributes, and methods unique to `Customer` and `Employee` classes can be added
* A change in a super class will automatically filter down and effect all of the subclasses

### Multiple Inheritance vs Single Inheritance

**Multiple inheritance** inherits from more then one super class (Python, C++).

However, it's much more common to see **single inheritance** where a subclass only inherits from one parent or superclass (Java, C#, Swift, and Ruby).

---

## Polymorphism

Multiple Forms of Polymorphism

* Dynamic (Run-Time) Polymorphism
* Static (Compile-Time) Polymorphism

Polymorphism can be implemented using

* Inheritance
* Abstract classes
* Interfaces

### Dynamic Polymorphism

Uses **method overriding** which uses the same interface for methods on different types of objects.

Overriding occurs when two methods have the same method name and parameters. One of the methods is in the parent class, and the other is in the child class. Overriding allows a child class to provide the specific implementation of a method that is already present in its parent class.​

```text
                                            +------------------+
                                            | BasicCoffeeMaker |
                                            |------------------|
                                            | size             |
                                            |------------------|
                                            | brew()           |
                                            | pour()           |
                                            +------------------+
                                                      ^
                                                      |
                                      +----------------------------------+
                                      |            FrenchPress           |
                                      |----------------------------------|
                                      | (Everything in BasicCoffeeMaker) |
                          Overriding  | brew()                           |
                                      +----------------------------------+
```

The benefit of dynamic polymorphism here is that it enables any form of coffee maker to be used as long as it has a brew method that takes coffee grounds and water as inputs and returns a cup of coffee.

### Static Polymorphism

Uses **method overloading** which implements multiple methods with the same name, but different parameters.

Overloading occurs when two or more methods in one class have the same method name but different parameters.

```text
brew(coffee, water)       --> cupOfCoffee
brew(tea, water)          --> cupOfTea
brew(coffee, tea, water)  --> cupOfSomething
```

---

## Analysis, Design, and Programming

---

## Unified Modeling Language (UML)

---

## References

* [LinkedIn Learning - Programming Foundations: Object-Oriented Design](https://www.linkedin.com/learning/programming-foundations-object-oriented-design-3/object-oriented-thinking)
* [edpresso - Overloading vs. Overriding](https://www.educative.io/edpresso/overloading-vs-overriding)

