# BDD Tutorial

## General

<details>

### Definition

BDD or Behaivour Driven Development is an Agile sofware development methodology, which uses and mixes the modern technologies. The so called "behavior" is prior to functionality. The most important general goals:

- Describe behavior with examples
- Encourage continuous cooperation of the participants during development (especially two way communication)
- Continuous test reporting and automated tests and infrastructure


### BDD on the map

BDD is actually a mixture of different kinds of technologies: TDD, ATDD, DDD, development methodologies and practices e.g. OOP Design and Analysis, Requirement Engineering (RE), Business Analysis (BA), tooling etc.

**BDD has evolved from TDD:**
- Test first (not mandatory only recommendation)
- Realized fact: the successful tests of logical units do not guarantee the working of the system

**Takes over the main purpose of ATDD:**
- focus on system expected behavior and operation (acceptance and system level tests)
- Improvement: the testcases are defined and described with clear and understandable examples

**Takes over several DDD elements:**
- Common vocabulary and definitions
- Common language (meta/markup languages, programing languages, pseudo code etc.)
- Human-Readable description with real and exact example in focus (so not the Domain is the main focus as in DDD)

**Test Automation**

**Early feedback** (Agile)

**Short and quick iterations** (Agile)

**Tooling** (Cucumber, Robot etc.)

**Continuous reporting** (Agile)

**From participant point of view:**
- *Needs*: Customer/Stakeholder, BA, RE
- *Requirements*: RE, PO
- *Design and Plan*: RE, PO, Architect, Team, TestTeam
- *Implementation*: RE, Architect, Team, TestTeam
- *Test*: RE, Architect, Team, TestTeam

### Main Elements

The most important elements in BDD based refinement are:
- **Requirements and Narratives**: *"As a... - I want... - so that..."*
- **Examples, Specifications and Usecases**: *"Given... - When... - Then..."*
- But there are many other useful strategies (e.g. 5 whys, problem and solution space)

</details>

## Demonstration
### First iteration

<details>

**Requirement R1**

```
	As a game organizer
	I want a tool which creates pairs of players and civilizations
	So that all players have to get a civilization, in first iteration a console application enough.
```

**UseCase**: UC1 - Create pairs from given players and civilizations

```
	Given 3 players and 6 civs
	When start pairing
	Then
		3 pairs are created
		there is no empty item in pairs
		there is no missing or additional player
```

**UseCase**: UC2 - Parse the given inputfile into the model object of BusinessLogic

```
	Given
		a JSON file name as input
		and the file with the following content
        {
        "Players": [
            "Adam",
            "Bela",
            "Cecil"
            ],
        "Civs": [
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"
            ]
        }
	When the file is parsed
	Then all contents are loaded
```

</details>

### Second iteration

<details>

**Requirement R1_v2**

```
	As a game organizer
	I want a tool which creates pairs of players and civilizations and pairs are available in a human readable format.
	So that all players have to get a civilization, in the current iteration a console application is enough.
```

**UseCase**: UC3 - Read input and write pairs in output

```
	Given
		a JSON file name with path as input and a JSON file name with path as output
		and the file with the following content
        {
        "Players": [
            "Adam",
            "Bela",
            "Cecil"
            ],
        "Civs": [
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"
            ]
        }
	When the application is executed
	Then the pairs are written in a file with JSON format
```
</details>

### Third iteration

<details>

**Requirement R2**

```
	As a PO
	I want an improvement in the tool to develop its business logic to be able to serve a Web based application in the future
	So that I want the output well-formatted to Content of HTTP communication
```

**Requirement R3**

```
	As a Game Organizer
	I want to organize games where every player has unique civilization.
	So that the input has to contain an additional information whether civilizations are unique or not.
```

**Requirement R4**

```
	As a Game Organizer
	I want a reliable random generation in tool
	So that drawing each civilization has the same probability, and the average difference from expected value is less than 5%.
```

</details>

## References


<details>

	https://cucumber.io/docs/bdd/

	https://www.youtube.com/watch?v=hxmr68bDHYI

	https://dannorth.net/introducing-bdd/

	https://medium.com/javascript-scene/behavior-driven-development-bdd-and-functional-testing-62084ad7f1f2

	https://www.agilealliance.org/glossary/bdd/

	https://tesztelesagyakorlatban.hu/a-bdd-alapjai-a-tesztelesben/

	https://agility.im/frequent-agile-question/what-is-behaviour-driven-development/

	https://medium.com/codeops/what-is-bdd-and-why-936e80bce511

	https://en.wikipedia.org/wiki/Behavior-driven_development

</details>
