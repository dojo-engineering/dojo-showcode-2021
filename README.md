A Path to an easier life: TDD with Code Craftsmanship


- [**Glossary**](#glossary)
  - [General](#general)
  - [Code Craftsmanship](#code-craftsmanship)
  - [SOLID](#solid)

- [**Resources**](#resources)
  - [SOLID Resources](#solid-resources)
  - [TDD and Code Craftsmanship Resources](#tdd-and-code-craftsmanship-resources)
  - [BDD](#bdd)


Click [here](https://github.com/Dojo-Engineering/dojo-showcode-2021/raw/main/Dojo%20Handout.pdf) to download this handout.

Click [here](https://www.youtube.com/watch?v=UqcG5DnHbRY&feature=youtu.be) to watch the webinar.

# **Glossary**

## General

[Interface](https://en.wikipedia.org/wiki/Interface_(computing)): abstract type (i.e. no data/logic) that defines behaviour through method signatures

[Spaghetti Code](https://en.wikipedia.org/wiki/Spaghetti_code) - messy, hard to read and difficult to maintain code

[Extendable Code](https://en.wikipedia.org/wiki/Extensibility) - adding new features easily

[Strategy pattern](https://en.wikipedia.org/wiki/Strategy_pattern): Select algorithm at runtime

[Unit testing](https://en.wikipedia.org/wiki/Unit_testing) - Tests individual methods/sources of logic (i.e. only testing one piece of logic, not a journey)

[Behavior-driven development](https://en.wikipedia.org/wiki/Behavior-driven_development) - tests written in plain language- commonly using Gherkin syntax - Given/When/Then

[Legacy Codebase](https://en.wikipedia.org/wiki/Legacy_system) - outdated or code that is no longer updated - usually has old tech stack

[Mocking](https://en.wikipedia.org/wiki/Mock_object) - simulating the behaviour of objects

## Code Craftsmanship

[YAGNI](https://en.wikipedia.org/wiki/You_aren%27t_gonna_need_it) - You aren&#39;t gonna need it

[KISS principle](https://en.wikipedia.org/wiki/KISS_principle) - Keep it simple, stupid

[DRY](https://en.wikipedia.org/wiki/Don%27t_repeat_yourself) - Don&#39;t repeat yourself

[Boy Scout](https://martinfowler.com/bliki/OpportunisticRefactoring.html) - Leave things in a better state than you found it

## SOLID

[Single-responsibility principle](https://en.wikipedia.org/wiki/Single-responsibility_principle): Every class should have only **one** responsibility

[Open–closed](https://en.wikipedia.org/wiki/Open%E2%80%93closed_principle): software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification

[Liskov substitution](https://en.wikipedia.org/wiki/Liskov_substitution_principle): Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it.

[Interface segregation](https://en.wikipedia.org/wiki/Interface_segregation_principle): Many client-specific interfaces are better than one general-purpose interface.

[Dependency inversion](https://en.wikipedia.org/wiki/Dependency_inversion_principle): Depend upon abstractions (interfaces), not concrete classes.  

# 
# **Resources**

[Margaret Hamilton interview](https://www.theguardian.com/technology/2019/jul/13/margaret-hamilton-computer-scientist-interview-software-apollo-missions-1969-moon-landing-nasa-women) - interesting interview with Maraget Hamilton regarding her work on the Apollo code and being the first female software engineer and managing an all-male team. She also talks about managing being a mother and her career.

[Clean Code Summary](https://gist.github.com/wojteklu/73c6914cc446146b8b533c0988cf8d29) - Really good read/tips on clean code.

[A detailed example of the KISS principle in C#](https://www.davidomid.com/a-detailed-example-of-the-kiss-principle-in-csharp) - KISS Code Example from slides.

## SOLID Resources

Overview - [SOLID: The First 5 Principles of Object Oriented Design](https://www.digitalocean.com/community/conceptual_articles/s-o-l-i-d-the-first-five-principles-of-object-oriented-design)

Strategy Pattern - [Strategy Pattern C# Example](https://www.c-sharpcorner.com/UploadFile/shinuraj587/strategy-pattern-in-net/)

SOLID examples (both violations &amp; fixes) in Python - [SOLID Python Examples](https://gist.github.com/dmmeteo/f630fa04c7a79d3c132b9e9e5d037bfd)

SOLID examples (both violations &amp; fixes) in JavaScript - [SOLID Javascript Examples](https://dev.to/denisveleaev/5-solid-principles-with-javascript-how-to-make-your-code-solid-1kl5)

Single-Responsibility Principle C# Example - [Single Responsibility Examples](https://dzone.com/articles/solid-principles-by-examples-single-responsability)

Open-Closed Principle C# Example - [The Open/Closed Principle Examples](https://stackify.com/solid-design-open-closed-principle/)

Liskov Substitution Principle C# Example - [Liskov Substitution Principle Examples](https://dzone.com/articles/solid-principles-by-examples-liskov-substitution-p)

Interface Segregation Principle C# Example - [Interface Segregation Examples](https://dzone.com/articles/solid-principles-by-example-interface-segregation)

Dependency Inversion Principle C# Example - [Dependency Inversion Examples](https://dzone.com/articles/solid-principles-by-example-dependency-inversion)

## TDD and Code Craftsmanship Resources

TDD &amp; Code Craftsmanship - [Clean Code &amp; TDD](https://cleancoders.com/episode/clean-code-episode-6-p1)

The Benefits - [The Benefits of TDD, Unit Testing, and Code Quality](https://dzone.com/articles/the-benefits-of-tdd-unit-testing-and-code-quality)

Different testing layers - [Difference between Component and Unit Testing](https://www.geeksforgeeks.org/difference-between-component-and-unit-testing/)

Different layers of testing - [TestPyramid](https://martinfowler.com/bliki/TestPyramid.html)

Mocking - [What is Mocking?](https://stackoverflow.com/questions/2665812/what-is-mocking)

Mocking C# - [Mocking in C#](https://www.c-sharpcorner.com/UploadFile/dacca2/fundamental-of-unit-testing-understand-mock-object-in-unit/)

Mocking Python - [Mocking in Python](https://realpython.com/python-mock-library/)

Mocking JavaScript - [Mocking using Jest in JavaScript](https://jestjs.io/docs/mock-functions)

## BDD

Specflow - C# BDD testing framework - [https://docs.specflow.org/en/latest/Examples.html](https://docs.specflow.org/en/latest/Examples.html)

BDD language syntax - [Gherkin Syntax](https://cucumber.io/docs/gherkin/)
