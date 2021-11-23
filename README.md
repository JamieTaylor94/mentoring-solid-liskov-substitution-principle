# Liskov Substitution Principle

## What is the Liskov Substitution Principle ?

[What is it?](https://medium.com/@a.vathanaka/benefits-of-the-liskov-substitution-principle-9621dcc20aad)

Don't worry about understanding the code this guy gives really good explanations and that is what is important here.

## Practical 

The Liskov substitution principle is following a pattern where higher order classes (otherwise known as base classes/a class you are inheriting from, a super class or a parent class) can be substituted for a derived (otherwise known as child) class without changing the behaviour.
         
The failing test in this solution shows that when defining a variable of type SumCalculator when instantiating the EvenSumCalculator class the result from the Calculate method uses the calculation in the SumCalculator class meaning the result is giving 40 (all added together) rather than the sum of all even numbers (18). This is because the SumCalculator which is being used as a base class takes order of precedence over the EvenSumCalculator class.

To fix this we need to correctly implement the Liskov substitution principle.

- Find the failing test and implement the Liskov Substitution Principle so that the test passes.

Hint: You will have to create a new parent class.

## Evidence for the matrix

Create a file liskov-substitution-principle.md

Answer the following questions:

What is the liskov substitution principle?
Why do we use it?   

Insert a link that goes to that file in the repo in your GitHub account.

We will use this as evidence for the L of the SOLID principles.

