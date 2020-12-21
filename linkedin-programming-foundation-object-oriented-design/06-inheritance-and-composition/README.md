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
                                    ^         ^
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
                                        ^        ^        ^
                             .----------'        |        '----------.       "overriding"
+-----------------------------+   +-----------------------------+   +-----------------------------+
|         StarFighter         |   |         CargoShuttle        |   |         WarpCruiser         |
|-----------------------------|   |-----------------------------|   |-----------------------------|
| [Everything from Spaceship] |   | [Everything from Spaceship] |   | [Everything from Spaceship] |
| fireMissile()               |   | cargo                       |   | move()                      |
+-----------------------------+   | dropCargo()                 |   +-----------------------------+
                                  +-----------------------------+

* WarpCruiser is overriding move method as subclass replaces the implementation of an inherited method

^ == open arrow
```

Inheritance can extend multiple levels deep. However, don't go looking for inheritance - Inheritance usually announces itself.

---

## Using Inheritance

---

## Abstract and Concrete Class

---

## Interfaces

---

## Aggregation

---

## Composition

---

## References

* [LinkedIn Learning - Programming Foundations: Object-Oriented Design](https://www.linkedin.com/learning/programming-foundations-object-oriented-design-3/object-oriented-thinking)
