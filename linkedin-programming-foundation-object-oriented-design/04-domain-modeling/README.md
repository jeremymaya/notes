# Domain Modeling

---

## Identifying the Objects

After completing analysis and use cases, the next is to create a **conceptual model**.

**Conceptual Model** represents important objects and the relationship between them.

### Steps to Identifying the Objects

```text
"Dodge" Use Case Scenario:

System spawns enemy spaceship on play area. Spaceship flies towards player astroid and fires missile at it. Player steers astroid in direction to avoid missile path. Missile flies past player astroid and disappear offscreen.
```

1. To identify objects, go through all of the use cases, user stories and any other written requirements to pick out all of the **nouns**.
2. Remove any duplicates or non-object nouns.
    * ~~System~~
    * Spaceship
    * Area
    * Astroid
    * Missile
    * ~~It~~
        * Refers to the Astroid
    * Player
    * Direction
        * When it doubt, keep it - attribute of Astroid vs. class of Direction
    * Path
    * ~~Offscreen~~
        * Concept of area

---

## Identifying Class Relationships

The benefit of detailing class relationships makes it easier to identify which objects interact with each other - meaning which objects have **behaviors** that affect other objects.

### Steps to Identifying Class Relationships

```text
+--------+    Steers    +---------+              +-----------+
| Player |--------------| Astroid |--------------| Direction |
+--------+              +---------+              +-----------+
                         /                            |
                        /                             |
                       /                              |
                  +------+       Contains       +-----------+
                  | Area |----------------------| Spaceship |
                  +------+ 1               1..* +-----------+
                      \ Contains         Fires  /
                       '--------.     .--------'
                                |     |
                              +---------+    Follows   +------+
                              | Missile |--------------| Path |
                              +---------+              +------+
```

1. Draw a line between each object that has a relationship/interaction
    * A player steers the astroid
    * The area contains the astroid, spaceship, and missile
    * The missile follows a path
    * The spaceship fires a missile
    * The spaceship and astroid travel in a direction
2. Draw a optional symbols - Is it interesting or important enough to need to be put on the diagram?
    * The game area can contain multiple spaceships

---

## Identifying Class Responsibilities

Ask the question of from which class should a behavior live, or whose responsibility it is.It should not be showing who initiates the actions but where the responsibility lies in performing them. **An object should be responsible for itself**.

### Steps to Identifying Class Responsibilities

```text
+--------+      +---------+      +-----------+
| Player |------| Astroid |------| Direction |
+--------+      +---------+      +-----------+
                    move
               detect collision
                     |
                  +------+       +-----------+
                  | Area |-------| Spaceship |
                  +------+       +-----------+
                                     spawn
                                      move
                                       |
                                  +---------+      +------+
                                  | Missile |------| Path |
                                  +---------+      +------+
                                     spawn
                                      move
                               detect out-of-bounds
```

1. To identify responsibilities, create a list of potential objects by looking for verbs and verb phrases from the use cases and user stories.
    * spawn enemy spaceship
    * files toward player
    * steers asteroid
    * avoid missile path
    * flies past player
    * disappear offscreen
2. Distribute the list of verb phrases amongst the conceptual objects

### God Object

In object oriented design when an object that knows too much or does too much, it is called a **god object**. Responsibilities should be distributed between different objects and not stored in one master object. An object should be responsible for itself, as much as possible for maintainability and future updates.

---

## CRC Cards

---

## References

* [LinkedIn Learning - Programming Foundations: Object-Oriented Design](https://www.linkedin.com/learning/programming-foundations-object-oriented-design-3/object-oriented-thinking)
