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

## Class with Multiple Constructor

**Overloading** allows most languages to create multiple constructor method. **It allows a class to have more than one method with the same name, but different sets of input parameters.**

Overloading multiple constructors gives us flexibility to pass in information when actually creating the object.

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

    // overload constructor
    public Spaceship(string name)
    {
        CallSign = name;
        ShieldStrength = 200;
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

### Destructor

**Destructor** or **Finalizer** languages that use garbage collection is a special method that gets called when the object is destroyed. It is a method that gets called when an object is no longer needed and is being disposed of.

Destructors are typically used if you have an object that's holding a resource. For example, when a document open on the file system or it's connected to a database, the object must release its connection to the resources before it's destroyed - Destructor takes care of this process.

---

## Static Attributes and Methods

### Static Attributes

Static Variables/Attributes are:

* Variable that is shared across all objects in a class
* Also called a shared variable or a class variable

Static variable != Global variable

It is global amongst the specific class but NOT the rest of the program - **it is shared within the class but still encapsulated**.

To create static variable at the class level, add the keyword `static` to a variable.

```c#
public class Spaceship()
{
    // instance variables
    public string callSign;
    private int shieldStrength;

    // class variables
    public static float toughness;

    // other codes omitted
}
```

To access static variable, we use the class name to access the static variable.

```c#
Spaceship myShip = new Spaceship();

// access CallSign variable from myShip object
var callSign = myShip.CallSign;

// access Toughness from Spaceship class
var toughness = Spaceship.Toughness;
```

### Static Methods

To create static methods at the class level, add the keyword `static` to a method declaration.

```c#
public class Spaceship()
{
    // instance variables omitted
 
    // class variables
    public static float Toughness;

    // public static method
    public static IncreaseDifficulty(float t)
    {
        Toughness += t;
    }

    // other codes omitted
}
```

Same as static variables, static methods exist at the class level. Therefore, static methods are called using the class name, not the name of an instance.

```c#
Spaceship.IncreaseDifficulty(0.2);
```

In UML diagrams, static method of a class are typically denoted with an underline.

```text
+----------------------------------+
|             Spaceship            |
|----------------------------------|
| + CallSign: String               |
| - ShieldStrength: Integer        |
| + Toughness                      |
| ''''''''''''                     |
|----------------------------------|
| + FireMissile(): String          |
| + ReducedShield(Integer)         |
| + IncreaseDifficulty(Float)      |
| '''''''''''''''''''''''''''      |
+----------------------------------+
```

---

## References

* [LinkedIn Learning - Programming Foundations: Object-Oriented Design](https://www.linkedin.com/learning/programming-foundations-object-oriented-design-3/object-oriented-thinking)
* [Microsoft - Naming Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)
* [C# Corner - C# Naming Conventions](https://www.c-sharpcorner.com/UploadFile/8a67c0/C-Sharp-coding-standards-and-naming-conventions/)
* [Microsoft - Classes (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes)
* [Guru 99 - C# Class & Object Tutorial with Examples](https://www.guru99.com/c-sharp-class-object.html)
