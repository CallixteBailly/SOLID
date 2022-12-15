## What is SOLID ?
    
**SOLID** is the mnemonic acronym introduced by Michael Feathers for the first five principles named by Robert Martin, which meant five basic principles of object-oriented programming and design.
    
### Table of Contents
- [What is SOLID ?](#what-is-solid-)
  - [Table of Contents](#table-of-contents)
- [Single Responsibility Principle (SRP)](#single-responsibility-principle-srp)
- [Open/Closed Principle (OCP)](#openclosed-principle-ocp)
- [Liskov Substitution Principle (LSP)](#liskov-substitution-principle-lsp)
- [Interface Segregation Principle (ISP)](#interface-segregation-principle-isp)
- [Dependency Inversion Principle (DIP)](#dependency-inversion-principle-dip)
  
## Single Responsibility Principle (SRP)
    
As stated in Clean Code, “There should never be more than one reason for a class to change”. It’s tempting to jam-pack a class with a lot of functionality, like when you can only take one suitcase on your flight. The issue with this is that your class won’t be conceptually cohesive and it will give it many reasons to change. Minimizing the amount of times you need to change a class is important.

It’s important because if too much functionality is in one class and you modify a piece of it, it can be difficult to understand how that will affect other dependent modules in your codebase.

## Open/Closed Principle (OCP)
    
As stated by Bertrand Meyer, “software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.” What does that mean though? This principle basically states that you should allow users to add new functionalities without changing existing code.
    
## Liskov Substitution Principle (LSP)
    
This is a scary term for a very simple concept. It’s formally defined as “If S is a subtype of T, then objects of type T may be replaced with objects of type S (i.e., objects of type S may substitute objects of type T) without altering any of the desirable properties of that program (correctness, task performed, etc.).” That’s an even scarier definition.

The best explanation for this is if you have a parent class and a child class, then the base class and child class can be used interchangeably without getting incorrect results. This might still be confusing, so let’s take a look at the classic Square-Rectangle example. Mathematically, a square is a rectangle, but if you model it using the “is-a” relationship via inheritance, you quickly get into trouble.
    
## Interface Segregation Principle (ISP)
    
ISP states that “Clients should not be forced to depend upon interfaces that they do not use.”

A good example to look at that demonstrates this principle is for classes that require large settings objects. Not requiring clients to setup huge amounts of options is beneficial, because most of the time they won’t need all of the settings. Making them optional helps prevent having a “fat interface”.

## Dependency Inversion Principle (DIP)

This principle states two essential things:

1. High-level modules should not depend on low-level modules. Both should depend on abstractions.
2. Abstractions should not depend upon details. Details should depend on abstractions.

This can be hard to understand at first, but if you’ve worked with .NET/.NET Core framework, you’ve seen an implementation of this principle in the form of [Dependency Injection](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection) (DI). While they are not identical concepts, DIP keeps high-level modules from knowing the details of its low-level modules and setting them up. It can accomplish this through DI. A huge benefit of this is that it reduces the coupling between modules. Coupling is a very bad development pattern because it makes your code hard to refactor.