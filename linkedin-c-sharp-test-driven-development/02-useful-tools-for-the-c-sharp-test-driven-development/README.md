# Useful Tools for the C# Test-Driven Development

[<- Back to C# Test Driven Development](../README.md)

## Table of Contents

* [Testing Tools](#testing-tools)
* [Mocking Frameworks](#mocking-frameworks)
* [References](#references)

---

## Testing Tools

Different kinds of testing tools include:

* MSTest - official unit tester by Microsoft
  * Much better for integration based testing
* NUnit - open-source unit testing framework inspired by Java's JUnit
  * Really fast and works either in 32-bit mode or 64-bit mode
* xUnit - open-source unit tester developed for .NET
  * Has a feature which allows setting up tests in one area and then apply them to multiple tests across a project

---

## Mocking Frameworks

Mocking frameworks ensure all codes written is functioning correctly through unit test, and any input data that is needed is  simulated or mocked up.

Different kinds of mocking frameworks include:

* FakeItEasy - mocking framework where objects are considered fakes but usage determines whether they are mocks or stubs
* NSubstitute - mocking framework syntax that is more succinct and concise
* Moq - mocking library developed from scratch to take full advantage of .NET

---

## References

* [LinkedIn Learning - C# Test Driven Development](https://www.linkedin.com/learning/c-sharp-test-driven-development-2)
