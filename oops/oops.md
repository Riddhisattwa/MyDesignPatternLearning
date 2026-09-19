# OOP Concepts Overview

This page covers the important object-oriented programming concepts demonstrated in this project, from the basics up to composition.

## 1. Introduction to OOP

### What is OOP?
- OOPS or Object Oriented Programming is a pardigm to write code in ways we can relate to common world. It packs the properties and behavior together.
- Helps us write code that understandable to human minds, solve complex problem by breaking them into smaller subparts, debug codebase easily and test them efficiently.

### Why this project is a good example
- The project uses a BankAccount to represent real business data.
- BankApplication coordinates business actions.
- Notification types handle messages without tightly coupling the banking logic.

---

## 2. Class and Object

### Class
- Define a class as a blueprint or template.
- Explain what a class contains:
  - fields
  - properties
  - methods
  - constructors

### Object
- Define an object as a real instance of a class.
- Explain how BankAccount is a class and each account is an object.

### Example from project
- BankAccount is a class that holds:
  - id
  - name
  - balance
- Methods such as AddToBankAccount and DeductBalance are behaviors of the object.

### What to explain
- Difference between a class and an object
- How state and behavior are grouped together
- Why objects make modeling easier

---

## 3. Encapsulation

### Definition
- Encapsulation means binding data and methods together.
- It also means restricting access to internal details.

### In this project
- The BankAccount fields are private.
- External code cannot directly change the balance.
- The class exposes controlled operations like:
  - AddToBankAccount
  - DeductBalance
  - GetBalance

### Why it matters
- Protects data integrity
- Prevents invalid state changes
- Keeps the internal logic inside the class

### What to explain
- Private fields vs public methods
- Why direct access to balance should be avoided
- How this reduces accidental bugs

---

## 4. Abstraction

### Definition
- Abstraction focuses on essential behavior and hides implementation details.
- A user should not need to know how a notification is sent internally.

### In this project
- INotification defines a common contract.
- MailNotification and SmsNotification implement the same behavior differently.
- The application only cares that a notification can be sent.

### Example to explain
- We do not need to know how MailNotification authenticates or sends data.
- We only care about calling SendNotification.

### What to explain
- Abstracting business logic from implementation details
- Why interfaces help reduce complexity

---

## 5. Inheritance

### Definition
- Inheritance allows one class to acquire properties and methods from another.
- It promotes code reuse.

### In this project
- This project shows inheritance through the notification hierarchy.
- A common base/contract may be used to share behavior among notification types.

### Important idea
- A specialized class extends a general behavior.
- For example, different notification channels share a common interface or base structure.

### What to explain
- Parent class vs child class
- Why inheritance is useful
- When inheritance is a good design choice
- When to avoid inheritance

---

## 6. Polymorphism

### Definition
- Polymorphism means one interface or method can take different forms.
- The same method call behaves differently depending on the concrete object.

### In this project
- INotification allows multiple implementations:
  - MailNotification
  - SmsNotification
- The method SendNotification is called in the same way for both, but each implementation performs its own logic.

### Example to explain
- A variable of type INotification can hold either a MailNotification or a SmsNotification object.
- Same method name, different behavior.

### What to explain
- Static vs dynamic polymorphism
- Interface-based polymorphism
- Why this improves flexibility

---

## 7. Interface and Dependency on Abstraction

### Definition
- An interface defines a contract.
- A class implementing the interface promises to provide the required behavior.

### In this project
- INotification contains methods such as:
  - SendNotification
  - UpdateMessage
- MailNotification and SmsNotification implement this contract.

### Why it matters
- The BankApplication depends on the interface, not a concrete notification class.
- This makes the code more flexible and easier to extend.

### What to explain
- Interface as a contract
- Dependency on behavior instead of implementation
- Why loose coupling is better than tight coupling

---

## 8. Loose Coupling

### Definition
- Loose coupling means classes depend on abstractions rather than concrete implementations.

### In this project
- BankApplication receives an INotification instead of directly creating a MailNotification or SmsNotification.
- This makes the system easier to change.

### Why it matters
- Easier to test
- Easier to replace implementations
- Reduced dependency and side effects

### What to explain
- Tight coupling example
- Loose coupling example in BankApplication
- Benefits in real software systems

---

## 9. Association

### Definition
- Association represents a relationship between two classes.
- One class knows about another.

### In this project
- BankApplication has a BankAccount object.
- It uses the account to deposit or withdraw money.

### What to explain
- One-to-one relationships
- Use of object references
- How behavior is delegated to another object

---

## 10. Aggregation

### Definition
- Aggregation is a weak whole-part relationship.
- One object contains another object, but the contained object can still exist independently.

### In this project
- A BankApplication may contain or use a BankAccount object.
- The account can exist separately and still be meaningful outside the application.

### What to explain
- Whole-part relationship without strong ownership
- The child object can survive on its own
- Real-life analogy: a department has employees, but employees exist independently

---

## 11. Composition

### Definition
- Composition is a strong whole-part relationship.
- The child object cannot meaningfully exist without the parent.

### In this project
- BankApplication owns the behavior of managing account operations and notifications.
- The notification object may be composed into the application as part of its workflow.

### Why composition is important
- More flexible than inheritance
- Promotes reusable and modular designs
- Allows behavior to be built from smaller objects

### What to explain
- Difference between aggregation and composition
- Strong ownership vs weak ownership
- How composition is used in real OOP design

---

## 12. Real-World Mapping of This Project

### BankAccount
- Represents the account state
- Protects balance through validation and encapsulation

### BankApplication
- Coordinates account actions and notifications
- Acts as the application layer

### INotification
- Defines the notification contract
- Decouples the banking feature from a specific message system

### MailNotification and SmsNotification
- Concrete implementations of the notification behavior
- Show abstraction and polymorphism in action

### Summary
- This project demonstrates the essential OOP principles together:
  - class and object
  - encapsulation
  - abstraction
  - polymorphism
  - interface-based design
  - loose coupling
  - association
  - composition

---

## 13. Comparison of Core OOP Concepts

### Encapsulation vs Abstraction
- Encapsulation hides data and controls access.
- Abstraction hides implementation details.

### Inheritance vs Composition
- Inheritance reuses behavior through a parent-child relationship.
- Composition builds behavior by combining objects.

### Interface vs Class
- Interface defines what to do.
- Class defines how it is done.

### What to explain
- Their purpose in design
- When one is better than the other
- Why modern OOP often prefers composition over inheritance

---

## 14. Final Understanding

Write your conclusion here:
- OOP helps us model real-world systems using objects.
- The Banking example shows how state, behavior, and interaction can be organized cleanly.
- Good OOP design makes code easier to maintain, extend, and test.

Use this final section to explain in your own words how your project demonstrates the concepts of OOP up to composition.
