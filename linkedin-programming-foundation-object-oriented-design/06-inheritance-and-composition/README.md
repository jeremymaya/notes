# Inheritance and Composition

---

## Identifying Inheritance Situation

**Inheritance**:

* One of four key concepts of object orientation
* Allows one or more classes to inherit the attributes an methods of another class, reffered to as the **parent** or **superclass**.
* The inheriting subclasses or child classes automatically have all of the attributes and methods of their parent class
* Allows **code reuse** and makes **code maintenance easy**

```text
                                +-----------------+
                                |     ClassA      |    Superclass
                                |-----------------|    (Parent class)
                                | attribute1      |    (Base class)
                                | attribute2      |
                                |-----------------|
                                | method1()       |
                                | method2()       |
                                +-----------------+
                                    △        △
                                    |         |
"ClassB inherits from ClassA"       |         |
                                    |         |
                                    |         |
              +------------------------+  +------------------------+
              |         ClassB         |  |         ClassC         |    Subclass
              |------------------------|  |------------------------|    (Child class)
              | (Everything in ClassA) |  | (Everything in ClassA) |    (Derived class)
              | attribute3             |  | method4()              |
              +------------------------+  +------------------------+
```

**Inheritance describes an "is a" relationship between objects.**

```text
TRUE:
A StartFighter is a Spaceship.
A CargoShuttle is a a Spaceship.

NOT TRUE:
A CargoShuttle is a StartFighter.
```

```text
                   +--------------------------+    +--------------------------+
                   |       StarFighter        |    |       CargoShuttle       |
                   |--------------------------|    |--------------------------|
                   | shieldActive             |    | shieldActive             |
                   | shieldStrength           |    | shieldStrength           |
                   | position                 |    | position                 |
                   |--------------------------|    | cargo                    |
                   | setShield()              |    |--------------------------|
                   | move()                   |    | setShield()              |
                   | fireMissile()            |    | move()                   |
                   +--------------------------+    | dropCargo()              |
                                                    +--------------------------+

* StarFighter and CargoShuttle has common elements that can be inherited from a superclass, Spaceship


                                   +--------------------------+
                                   |         Spaceship        |
                                   |--------------------------|
                                   | shieldActive             |
                                   | shieldStrength           |
                                   | position                 |
                                   |--------------------------|
                                   | setShield()              |
                                   | move()                   |
                                   +--------------------------+
                                        △       △       △
                             .----------'        |        '----------.       "overriding"
+-----------------------------+   +-----------------------------+   +-----------------------------+
|         StarFighter         |   |         CargoShuttle        |   |         WarpCruiser         |
|-----------------------------|   |-----------------------------|   |-----------------------------|
| [Everything from Spaceship] |   | [Everything from Spaceship] |   | [Everything from Spaceship] |
| fireMissile()               |   | cargo                       |   | move()                      |
+-----------------------------+   | dropCargo()                 |   +-----------------------------+
                                  +-----------------------------+

* WarpCruiser is overriding move method as the subclass replaces the implementation of an inherited method
```

Inheritance can extend multiple levels deep. However, don't go looking for inheritance - Inheritance usually announces itself.

---

## Using Inheritance

```text
+--------------+
|   Spaceship  |
+--------------+
       △
       |
+--------------+
| CargoShuttle |
+--------------+
```

C# implements above inheritance as the following:

```c#
public class CargoShuttle : Spaceship
{
    ...
}
```

### Overriding

**Overriding** allows subclass to replace the implementation of a method from the superclass.

Implementation of overriding is very language dependent - Refer to the language documentation.

### Calling a Method in the Super/Parent/Base Class

```text
+--------------+
|   Spaceship  |
+--------------+
| setShield()  |
+--------------+
       △
       |
+--------------+
| CargoShuttle |
+--------------+
```

Below is how C# calls a method that was originally defined in the superclass from the subclass:

```c#
base.setShield();
```

---

## Abstract and Concrete Class

### Abstract Class

Abstract class:

* Exists for other classes to inherit
* Cannot be instantiated
* Contains at least one abstract method
* Can have a mix of abstract methods and method with an implementation

### Abstract Method

Abstract method is a method that is declared with a method signature but not actually implemented in the abstract class.
The implementation of an abstract method is deferred to any subclasses.

```text
                                   +--------------------------+
                                   |         Spaceship*       |
                                   |--------------------------|
                                   | setShield()              |
                                   | move()                   |
                                   +--------------------------+
                                        △       △       △
                             .----------'        |        '----------.
+-----------------------------+   +-----------------------------+   +-----------------------------+
|         StarFighter         |   |         CargoShuttle        |   |         WarpCruiser         |
|-----------------------------|   |-----------------------------|   |-----------------------------|
| move()                      |   | move()                      |   | move()                      |
| fireMissile()               |   | dropCargo()                 |   |                             |
+-----------------------------+   +-----------------------------+   +-----------------------------+

* Italicized to represent that it is an abstract class

* setShield() implemented once in the Spaceship class since it behaves same for all of its subclasses
* move() implemented as an abstract method as each subclasses moves differently
```

Below is C# implementation of the above UML diagram:

```c#
public abstract class Spaceship
{
    void setShield()
    {
        ...
    }
    public abstract void move();
}

class StartFighter : Spaceship
{
    public override void Eat()
    {
        ...
    }

    public void DropCargo()
    {
        ...
    }
}

class CargoShuttle : Spaceship
{
    public override void Eat()
    {
        ...
    }
}

class WarpCruiser : Spaceship
{
    public override void Eat()
    {
        ...
    }
}
```

The `abstract` keyword can be omitted. However, including the keyword allows for more clear way to communicate intentions for a class.

---

## Interfaces

Interface is a list of methods for a class to implement. It does not contain any actual behaviors.

Interface is like a signing a contract, promising that the new class we are defining will implement all of the methods in the interface. But we are free to implement the inner workings of those methods however we want as long as the method names, inputs, and outputs match the interface.

```c#
interface IMove()
{
    // method signatures
    void move(int x, int y);
}

class Asteroid : IMove
{
    public void move(int x, int y)
    {
        ...
    }

    // additional class functionality
}
```

### Interface vs Abstract Class

Interface and abstract class serve different purposes:

* Interfaces represents a **capability** that a class implements.
* Abstract classes represent a **type** that another class can inherit from.

Also while a subclass can inherit from a single superclass, multiple interface can be implemented to a single class.

**Program to an interface, not to an implementation.**

```text
+-------------------+       +-------------------+
|   <<interface>>   |       |   <<interface>>   |
|       IMove       |       |       IDraw       |
+-------------------+       +-------------------+
| move()            |       | draw()            |
+-------------------+       +-------------------+
          △         △     △         △
          '           '   '           '
          '          .  '  .          '
+-------------------+       +-------------------+
|     Spaceship     |       |      Asteroid     |
+-------------------+       +-------------------+
| setShield()       |       | move()            |
| move()            |       | detectCollision() |
| draw()            |       | draw()            |
+-------------------+       +-------------------+
         △
         |
+-------------------+
|   CargoShuttle    |       
+-------------------+       
| move()            |       
| dropCargo()       |       
+-------------------+       


* A CargoShuttle is a Spaceship.
* Asteroid dose NOT inherit from Spaceship nor is a type of Spaceship
* IMove is a capability that both Spaceship and Asteroid share
```

---

## Aggregation

Inheritance is just one type of relationship that can exist between objects.

The concept of **aggregation** is another type of object relationship in which **one object is built of other objects**.

**Aggregation describes an "has a" relationship between objects.**

or better description would be:

**Aggregation describes an "uses a"/"uses many" relationship between objects.**

```text
TRUE:
A Fleet has a Spaceship. -> A Fleet uses a Spaceship.
A Fleet has many Spaceships. -> A Fleet uses many Spaceship.

NOT TRUE:
A Fleet is a Spaceship.
```

```text
+-------------------+
|       Fleet       |
+-------------------+
|        ...        |
+-------------------+
          ♢ 1
          |
          | 0..*
+-------------------+
|     Spaceship     |
+-------------------+
|                   |
|        ...        |
|                   |
+-------------------+

* Unfilled diamond represents aggregation relationship
* Asterisk in the diagram represents multiplicity - a fleet object contains a collection of spaceship objects

IMPORTANT: The object lifetimes of Spaceships are not tied to each other or the existence of the fleet
* The spaceships each exists independently of the fleet
```

---

## Composition

Composition of is a more specific form of aggregation. **Composition implies ownership.**

Unlike aggregation, when the owning object is destroyed, the contained objects are destroyed too.

```text
Aggregation: A Fleet has a Spaceship.

Composition: A Spaceship owns a(n) Engine.
```

```text
+-------------------------------------------------------------------+
|                              Spaceship                            |
+-------------------------------------------------------------------+
|                                                                   |
|                                ...                                |
|                                                                   |
+-------------------------------------------------------------------+
          ♦ 1                     ♦                       ♦ 1
          |                       |                       |
          | 0..*                  |                       | 0..*
+-------------------+   +-------------------+   +-------------------+
|       Engine      |   |       Shield      |   |       Weapon      |
+-------------------+   +-------------------+   +-------------------+
|                   |   |                   |   |                   |
|        ...        |   |        ...        |   |        ...        |
|                   |   |                   |   |                   |
+-------------------+   +-------------------+   +-------------------+

* Filled diamond represents has aggregation relationship
* Asterisk in the diagram represents multiplicity

IMPORTANT: The object lifetimes of each parts are dependent on Spaceship objects lifetime
```

---

## References

* [LinkedIn Learning - Programming Foundations: Object-Oriented Design](https://www.linkedin.com/learning/programming-foundations-object-oriented-design-3/object-oriented-thinking)
