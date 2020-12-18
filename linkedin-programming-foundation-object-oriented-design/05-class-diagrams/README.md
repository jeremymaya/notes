# Domain Modeling

---

## Creating Class Diagram: Attributes

UML Class Diagram

```text
+----------------------------------+
|             ClassName            |
|----------------------------------|
|                                  |
|            Attributes            |
|                                  |
|----------------------------------|
|                                  |
|             Behaviors            |
|                                  |
+----------------------------------+
```

### Spaceship Class Example

```text
+----------------------------------+
|             Spaceship            |
|----------------------------------|
| CallSign: String = "Excelsior"   |
| ShieldActive: Boolean            |
| ShieldStrength: Integer          |
| Position: Coordinate             |
|----------------------------------|
|                                  |
|             Behaviors            |
|                                  |
+----------------------------------+
```

* Class name should be in the singular form and starts with an uppercase first letter
* List attributes - use the naming convention appropriate for the programming language
  * C# uses pascal casing
* Suggest a data type using a colon
* Describe a default value using an equal sign after the data type

---

## Creating Class Diagram: Behaviors

```text
+----------------------------------+
|             Spaceship            |
|----------------------------------|
| - CallSign: String = "Excelsior" |
| - ShieldActive: Boolean          |
| - ShieldStrength: Integer        |
| - Position: Coordinate           |
|----------------------------------|
| + GetShieldStrength(): Integer   |
| + ReducedShield(Integer)         |
| + GetPosition(): Coordinate      |
| + Move(Direction)                |
| - SetPosition(Coordinate)        |
+----------------------------------+
```

### Adding Class Behaviors

It's common practice to name methods that modify and retrieve attributes as get instant operations rather than things like change or retrieve.

* Add parenthesis and parameters
* Add an expected return type by putting a colon after the parenthesis

### Controlling Visibility

Focus of the UML diagram is public visibility which is in line with the principle of **encapsulation** - To hide as much of the implementation as possible and only share what is absolutely necessary to expose to other classes.

```text
+ attributes            - attributes
+ behaviors             - behaviors
```

* Minus indicates that a member should be private to the class - not directly accessible by the other objects
* Plus indicates the member should be public
* Try to leave as many attributes and methods private as possible

Do NOT focus on the data initially.

**Focus on what object do** rather than just viewing them as data structures.

---

## Converting Class Diagram Into Code

```text
+----------------------------------+
|             Spaceship            |
|----------------------------------|
| + CallSign: String               |
| - ShieldStrength: Integer        |
|                ...               |
|----------------------------------|
| + FireMissile(): String          |
| + ReducedShield(Integer)         |
|                ...               |
+----------------------------------+
```

Above UML diagram is in C# syntax would be:

```c#
public class Spaceship()
{
    // instance variable
    public string CallSign;
    private int ShieldStrength;

    // method
    public string FireMissile()
    {
        return "Pew";
    }

    public void ReduceShield(int amount)
    {
        ShieldStrength -= amount;
    }
}
```

---

## Instantiating Classes

### Class == Blueprint

A class as itself is NOT a usable object but it is used to create an object - Class is used to **instantiate** one of more instances of an object.

To instantiate an object in C#,

```c#
Spaceship myShip = new Spaceship();
```

When an object is instantiated, the computer allocates a section of memory to hold the new object, including space for each of the variables in the object.

BUT what is the internal state of an object immediately after it is instantiated?

For myShip object created above, it will be:

```text
+----------------------------------+
| CallSign: Null                   |
| ShieldActive: 0                  |
+----------------------------------+
```

Be mindful of the these default values. The initial values can be set after the object has been instantiated but **can we create an object in a meaningful state to begin with?**

```c#
Spaceship myShip = new Spaceship();

myShip.CallSign = "Excelsior";
myShip.SetShieldStrength(100);
```

### Constructor

**Constructor** is a special method that gets called to create an object. Use the constructor method to make sure that any variables belonging to the object are set to the values we want when the object is created.

```c#
public class Spaceship()
{
    // instance variable
    public string CallSign;
    private int ShieldStrength;

    // constructor
    public Spaceship()
    {
        name = "The nameless ship";
        ShieldStrength = 100;
    }

    // method
    public string FireMissile()
    {
        return "Pew";
    }

    public void ReduceShield(int amount)
    {
        ShieldStrength -= amount;
    }
}
```

For myShip object created above, it will be:

```text
+----------------------------------+
| CallSign: "The nameless ship"    |
| ShieldActive: 100                |
+----------------------------------+
```

Constructor does NOT have a `return` type because it is called when `new` keyword is used to instantiate a new object.

A basic constructor method is represented as a method with the same name as the class in UML diagram.

```text
+----------------------------------+
|             Spaceship            |
|----------------------------------|
| + CallSign: String               |
| - ShieldStrength: Integer        |
|                ...               |
|----------------------------------|
| + Spaceship()                    |
| + FireMissile(): String          |
| + ReducedShield(Integer)         |
|                ...               |
+----------------------------------+
```

---

## Static Attributes and Methods

---

## References

* [LinkedIn Learning - Programming Foundations: Object-Oriented Design](https://www.linkedin.com/learning/programming-foundations-object-oriented-design-3/object-oriented-thinking)
* [Microsoft - Naming Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)
* [C# Corner - C# Naming Conventions](https://www.c-sharpcorner.com/UploadFile/8a67c0/C-Sharp-coding-standards-and-naming-conventions/)
* [Microsoft - Classes (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes)
* [Guru 99 - C# Class & Object Tutorial with Examples](https://www.guru99.com/c-sharp-class-object.html)
