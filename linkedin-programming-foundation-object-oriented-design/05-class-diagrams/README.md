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

---

## Instantiating Classes

---

## Static Attributes and Methods

---

## References

* [LinkedIn Learning - Programming Foundations: Object-Oriented Design](https://www.linkedin.com/learning/programming-foundations-object-oriented-design-3/object-oriented-thinking)
* [Microsoft - Naming Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)
* [C# Corner - C# Naming Conventions](https://www.c-sharpcorner.com/UploadFile/8a67c0/C-Sharp-coding-standards-and-naming-conventions/)