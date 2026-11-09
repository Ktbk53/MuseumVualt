# MuseumVualt
Class Project
Team Contract 3

Within the first week of the assignment, each team will submit a brief plan (1 page or less) to divide the workload for this project among team members.

This plan should include:

Division of specific tasks related to all project deliverables
Names of specific team members who commit to delivering those pieces
This contract does not have to be long / verbose, but it should speciify who will be responsible for what throughout the project.

NOTES:

As needed, people can and should help teammates who are having trouble or falling behind.
If it makes sense to do so, responsibilities can be rearranged  / reassigned after the contract is submitted. Simply mention these changes in your presentation.
Collaborative Project 3
In addition to the team contract described above, our second collaborative project will have two team deliverables:

A C# console application to keep track of animals in a wildlife perserve. Do NOT use top-level code.

A 10-15 minute presentation (slideshow) delivered in-class along with a live demo of your program

C# console application

Your team will build a console application that helps a museum curator store and track different kinds of museum artifacts. Examples of artifacts include paintings, fossils, ancient coins, etc. These artifacts are to be implemented as classes that allow instances to describe themselves and report their estimated age. The curator wants one unified vault that can hold any type of artifact, retrieve items by position, and display a summary of everything stored inside.

Required Files
1. IArtifact.cs (custom interface)

Members

Name: read-only string property, the name of this specific artifact, e.g. "The Klopman Diamond"

EstimatedAgeYears: read-only int property, storing how old the artifact is in years

Describe(): a method that returns a string ... a human-readable sentence describing the artifact, e.g. "This gem is one of the largest in the world, but is rumored to carry a terrible curse."

2. Vault.cs (generic class)

Member data

items: a private array of type T[]

Count: a read-only property returning an int indicating the current number of stored artifacts/items

Methods

A constructor that accepts a capacity parameter of type int

The constructor will use capacity to instantiate the items array to the specified size

Store(T item): adds item to vault if there is available space; report success if so, report that vault is full if not

Retrieve(int index): returns a reference to the specified artifact if index is valid; prints error and return null if not

DisplayAll(): loops through all stored artifacts, doing the following for each:

Print the Name and EstimatedAgeYears

Call artifact's Describe() method

HINT:

Class will be designated as Vault<T>

Add the class constraint that T must be a type that implements IArtifact

3. Three concrete artifact classes that implement IArtifact:

For all, as required by IArtifact:

Member data: Name and EstimatedAgeYears

Method: Describe()

Specific classes, with unique data and requirements for each:

Painting.cs

Specific member data: Artist (public string property)

Describe() should mention the Artist by name

Fossil.cs

Specific member data: Species (public string property)

Describe() should mention the Species by name

Coin.cs

Specific member data: CountryOfOrigin (public string property)

Describe() should mention the CountryOfOrigin by name

OPTIONAL: add a fourth class of artifact, with relevant member data and description

4. Program.cs ... the usual "kickoff" class for a console app, launching via the static void Main method

Create a Vault<IArtifact> with a capacity of 5

Construct at least one instance of each concrete class (Painting, Fossil, Coin)

Set both the IArtifact field values, as well as the class-specific value

Store all three (or more) artifacts in the vault using Store()

Call DisplayAll() to print the full vault contents

Use Retrieve() to retrieve one item by index and print its Name individually

Attempt to retrieve an invalid index (e.g., index 10) to verify the error message prints

Print the vault's Count property before and after adding items

NOTE:

For this project, It is not necessary to offer these choices through a menu

Therefore, it isn't necessary to prompt for a new artifact's type + its corresponding unique data

This can be done as an optional goal, but again, interactivity is not required for this project.

In-class demo and presentation

A slideshow presentation (PowerPoint, Google Slides, etc.) named CIT165_Collab3_Presentation_TeamX ... where X is the number of your team

(1 slide) Title slide, including names of your group members

(1 slide) Division of responsibilities

(1-2 slides each) Summaries — not code— of each class you wrote, including what you do in Program's Main method. Describe input, output, and steps performed

(1 slide) AI use: Did you use AI tools? If so, which ones and how? If not, why not?

(1 slide) Coordination: Did you meet outside of class? How did you bring everyone's work together?

(1 slide) Challenges: Technical or organizational

(1 slide) What could be done better in future collaborations?

(1-2 slides) List of sources you consulted: textbook, web sites, AI tools, other people, etc.

Grading:

 / 5 — .zip file submitted containing code that builds and runs without error

 / 8 — IArtifact interface ... set up interface as directed

 / 12 — Vault generic class ... implemented successfully, with type constraint applied

 / 12 — 3+ concrete classes that implement IArtifact (Painting, Fossil, Coin, ???)

 / 12 — Program ... performs the steps and invokes the required output

 / 8 — Slideshow: All topics covered

 / 8 — In-class presentation & demo: Content, clarity, and duration (under 15 minutes) ... will be conducted in class a week after project is due.

 / 35 — INDIVIDUAL COMPONENT ... Based on attendance at team work sessions, contributions to project, and presence during in-class presentation

Possible ways to divide responsibilities

Note that these are only suggestions. It is up to your team to divide tasks fairly, and to hold each other accountable! If you have only 3 team members, replan accordingly.

TEAMMATE 1: Code IArtifact interface and Vault class
TEAMMATE 2: Code the 3+ concrete artifact classes
TEAMMATE 3: Code Program
TEAMMATE 4: Oversee code integration and version management, perform testing
All: Prepare in-class slideshow presentation
All: Deliver in-class presentation on the due date
NOTE: Teams with three members might divide the share responsibility for code integration, version management, and testing.

The slideshow and presentation duties are purely up to your team. If one person wishes to take on either or both, that's OK. If you choose to break up the slideshow presentation or in-class talk/demo, that's fine too. Just be sure to note WHO you anticipate will do WHAT in your team contracts! (This can change, but make tentative plans early.)

Related but separate assignments:

GROUP: Team Contract 3 — Briefly record how you will divide responsibilities: who will be responsible for which requirements
INDIVIDUAL: Retrospective 3 — A short summary of your own individual contributions, challenges and lessons learned, and a peer review of teammates
