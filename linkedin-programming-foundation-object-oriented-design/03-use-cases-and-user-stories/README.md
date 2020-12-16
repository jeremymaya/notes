# Use Cases and User Stories

---

## Use Cases

Essential Use Cases Components:

* Title - What is the goal?
* Primary Actors - Who desires/interact with it?
* Success Scenario - How is it accomplished?

### Title

Keep the title short and simple - the title for a use case should be a __short phrase__ with an __active verb__ that describes a goal

### Actor

Actor vs. User - need to identify exactly who is having this interaction

An actor could be __any external entity__ that acts on the system including other computer systems.

### Success Scenario

Keep the success scenarios short and succinct, using everyday, non-technical language.

#### Use Case: Scenario as Paragraph

```text
Title: Heat Metal
Primary Actor: Astronaut
Success Scenario: Astronaut inserts meal package. System identifies type of meal. System heats package for length of time required for meal type. System notifies astronaut that meal is ready via space pager. Astronaut removes package from system. 
```

#### Use Case: Scenario as Steps with Extensions

```text
Success Scenario:

1. Astronaut inserts meal package
2. System identifies type of meal
3. System heats package for length time required for meal type
4. System notifies astronaut that meal is ready via space pager
5. Astronaut removes package from system

Extensions:

2a Describe steps for unidentified package
4a Describe steps for space-pager system error
```

Add extensions or steps for alternative flows, for what happens when things go wrong depending on the situation.

#### Use Case: Additional Details

```text
Title: Heat Meal
Primary Actor: Astronaut
Success Scenario: ...
Extensions: ...
Preconditions: Customer has selected meal to prepare
```

#### Fully Dressed Use Case

```text
Use Case: Additional Details

Title: Heat Meal
Primary Actor: Astronaut
Success Scenario: ...
Extensions: ...
Preconditions: ... 
Secondary Actors: ...
Stakeholders: ...
Scope: ...
Owner: ...
```

DO NOT KILL PROGRESS BY FOCUSING TOO MUCH ON FORMALITY.

---

## Identifying the Actors

Identify possible **actors** before writing use cases!

Actors are __anything that lives outside of the application but interacts with it to accomplish some goal.__ - There can be one or multiple actors. Also, external systems are considered actors too.

Use cases always have __a single primary actor__ and possibly one or more __secondary actors__, if required.

The **primary actors** are NOT necessarily the most important actor in the scenario. The primary actors are just __the one who initiated it__.

```text
          +--       O        --+
          |        /|\         |
          |        / \         |
          |      Commander     |
          |         O          |
  Cook  --+---     /|\       --+--+
          |        / \         |  |
          |       Pilot        |  |
          |         O          |  |  
          |        /|\         |  |  
          |        / \         |  |  +------+    +-------------+
          +- Flight Engineer --+  |  | Heat |    | Space-Pager |
                                  +--| Meal |----|   System    |  
                                  |  +------+    +-------------+   
                                  |
          +--       O        --+  |
          |        /|\         |  |
          |        / \         |  |
Monitor --+  Mission Control   +--+
          |         O          |
          |        /|\         |
          |        / \         |
          +--  Nutritionist  --+

* Microwave interfaces with Space Pager System
* Update the collection of actors and use cases as a project progresses!
```

* Primary actor: Cook
* Secondary actor: Monitor

---

## Identifying the Scenarios

Describe **User-Focused Goals** when writing use case scenarios.

User focused goals are:

* Goal that an actor can accomplish in a single encounter
* Goal that an actor can stay focused on the user's intention and what they want to accomplish

Examples of the User-Focused Goals from the Space Microwave includes:

* Cook meal
* Generate reports
* Change settings
* Order supplies

Each with several steps that can be accomplished.

### How to Write a Case Scenario

Use **active voice** when writing use case scenarios and omit needless words. Also avoid describing user interface in a case scenario.

A good example of using active voice is:

```text
"Astronaut inserts meal package."

"System sends pager message."
```

A bad example would be:

```text
"The system connects to the external pager system over HTTPS and uses JSON to format the text message to be transmitted, then waits for a delegated callback response."

"User pressed the start button ..."
```

### Followup Questions to Ask

Questions that may prompt a new goal or actor are:

* Who performs system adminstration tasks?
* What manges users and security?
* What happens if they system fails?
* Is anyone looking at performance metrics or logs?

---

## Diagramming Use Cases

**Use Case Diagram** is another diagram that comes from UML. It is a diagram of several use cases and multiple actors at the same time which shows the relationship between the actors and the different use cases in which they are involved.

It's meant to be a simple overview of the relationships between multiple use cases and multiple actors at the same time, without the details of each particular written use case.

### Drawing a Use Case Diagram

```text
       O                                           +-----------+ 
      /|\   --.         +---------------------+    | <<ACTOR>> |
      / \      \        |     .---------.     |   /|   SPACE   |
   ASTRONAUT    \-------+----( Heat Meal )----+--' |   PAGER   |                        
                 \      |     `---------'     |    |   SYSTEM  |
                  \     |                     |    +-----------+
                   \    |  .---------------.  |
                    |---+-( GENERATE REPORT ) |
                   .    |  `---------------'  |
       O          /     |                     |
      /|\    ----'\     |   .--------------.  |
      / \          '----+--( CHANGE SETTING ) |
  NUTRITIONIST          |   `--------------'  |
                        +---------------------+
```

Drawing the first use case diagram:

1. Start by listing out the use cases
    * Heat meal
    * Generate reports
    * Change settings
2. Represent actors as sticker figures
3. Draw an ellipse around the use case titles to signify that they are self contained
4. Draw a box around all the use cases to represent the boundaries of the system
    * Anything within of the box: part of the application
    * Anything outside of the box: not part of the application
5. Draw a line between any of the actors and the use cases they will interact
6. Draw a box to represent an nonhuman actor, external system, then draw a line to represent it interaction on the right side

---

## User Stories

**User stories** are another written format for describing parts of an application but they are __shorter and simpler than a use case.__

A user story describes a single small scenario from a user's perspective, focusing on their goal, what they want to do and why rather than focusing on the system - It focuses on one specific goal of one specific user for a particular reason.

```text
As a (type of user) I want (goal) so that (reason)*

* optional - it provides context on how this application will be used
```

Use stories examples:

```text
As an astronaut, I want to heat up my food so that, I can eat a warm meal.

As a nutritionist, I want to see what astronauts eat, so that I can monitor their diet. 
```


### What to Avoid When Writing User Stories

Usee stories should NOT include

* Descriptions of the user interface
* Detail alternate paths or exceptions
* Any technical information

```text
BAD: As an astronaut, I want to press a button to delay when my food gets cooked, so that it will be ready later.

                                        vs.

GOOD: As an astronaut, I want to schedule when I heat my food, so it will be ready later. 
```

### User Stories vs Use Cases

Use cases and user stories are different things - they have different format and servers different purpose.

| User Stories | Use Cases |
|:-|:-|
|Short (one index card) | Long (a document) |
| One goal, no details | Multiple goals and details |
| Informal | Casual to (very formal) |
| "Placeholder for conversation" | "Record of conversation"|

---

## References

* [LinkedIn Learning - Programming Foundations: Object-Oriented Design](https://www.linkedin.com/learning/programming-foundations-object-oriented-design-3/object-oriented-thinking)
