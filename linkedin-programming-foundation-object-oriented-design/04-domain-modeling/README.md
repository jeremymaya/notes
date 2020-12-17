# Domain Modeling

---

## Identifying the Objects

After completing analysis and use cases, the next is to create a **conceptual model**.

**Conceptual Model** represents important objects and the relationship between them.

### Steps to Identify the Objects

```text
"Dodge" Use Case Scenario:

System spawns enemy spaceship on play area. Spaceship flies towards player asteroid and fires missile at it. Player steers asteroid in direction to avoid missile path. Missile flies past player asteroid and disappear offscreen.
```

1. To identify objects, go through all of the use cases, user stories and any other written requirements to pick out all of the **nouns**.
2. Remove any duplicates or non-object nouns.
    * ~~System~~
    * Spaceship
    * Area
    * Asteroid
    * Missile
    * ~~It~~
        * Refers to the asteroid
    * Player
    * Direction
        * When it doubt, keep it - attribute of Asteroid vs. class of Direction
    * Path
    * ~~Offscreen~~
        * Concept of area

---

## Identifying Class Relationships

---

## Identifying Class Responsibilities

---

## CRC Cards

---

## References

* [LinkedIn Learning - Programming Foundations: Object-Oriented Design](https://www.linkedin.com/learning/programming-foundations-object-oriented-design-3/object-oriented-thinking)
