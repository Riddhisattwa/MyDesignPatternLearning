# My Design Pattern Learning

## Description

This repository is a personal collection of software design patterns learned through study and practice. Each design pattern is documented in its own README and includes a sample code implementation to show how the pattern works in practice.

The goal is to make the patterns easy to understand, compare, and revisit while building a stronger foundation in object-oriented design and maintainable software development.

## Contents

- [My Design Pattern Learning](#my-design-pattern-learning)
  - [Description](#description)
  - [Contents](#contents)
  - [OOP Basics](#oop-basics)
    - [Core OOP Concepts](#core-oop-concepts)
  - [SOLID Principles](#solid-principles)
  - [Design Patterns](#design-patterns)
    - [Creational Patterns](#creational-patterns)
    - [Structural Patterns](#structural-patterns)
    - [Behavioral Patterns](#behavioral-patterns)
  - [Repository Structure](#repository-structure)
  - [How to Use This Repository](#how-to-use-this-repository)

## OOP Basics

This section covers the fundamentals of object-oriented programming that provide the foundation for understanding design patterns.

### Core OOP Concepts

- **Classes and objects:** Classes define the structure and behavior of objects, while objects are instances of those classes.
- **Encapsulation:** Bundling data and the operations that work on it while controlling access to the internal state.
- **Abstraction:** Exposing the essential behavior of an object while hiding unnecessary implementation details.
- **Inheritance:** Creating a new class from an existing class to reuse or extend its behavior.
- **Polymorphism:** Allowing objects of different types to be treated through a common interface while providing type-specific behavior.
- **Composition:** Building complex objects by combining simpler objects and delegating responsibilities to them.

## SOLID Principles

SOLID is a set of five principles for creating software that is easier to understand, extend, test, and maintain.

- **Single Responsibility Principle (SRP):** A class should have one reason to change.
- **Open/Closed Principle (OCP):** Software entities should be open for extension but closed for modification.
- **Liskov Substitution Principle (LSP):** Subtypes should be replaceable for their base types without breaking expected behavior.
- **Interface Segregation Principle (ISP):** Clients should not be forced to depend on interfaces they do not use.
- **Dependency Inversion Principle (DIP):** High-level modules should depend on abstractions rather than low-level implementation details.

## Design Patterns

Patterns will be added here as they are documented. Each entry will link to the pattern's README and sample implementation.

### Creational Patterns

Patterns that provide ways to create objects while keeping creation logic flexible and independent from the rest of the application.

### Structural Patterns

Patterns that explain how to compose classes and objects into larger, flexible structures.

### Behavioral Patterns

Patterns that focus on communication, responsibilities, and the interaction between objects.

## Repository Structure

Each design pattern follows a structure similar to this:

```text
PatternName/
├── README.md          # Pattern overview, purpose, and explanation
└── src/               # Sample code implementation
```

The pattern README explains the problem, the pattern's intent, its key participants, and when it is useful. The sample code demonstrates the implementation and expected usage.

## How to Use This Repository

1. Choose a design pattern from the relevant category.
2. Read the pattern-specific README to understand the problem and the proposed solution.
3. Review and run the sample implementation.
4. Adapt the example to a small project or exercise to reinforce the idea.
