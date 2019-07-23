## Problem 1.Exercise: Strings and Text Processing

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019)
You can check your solutions here: [Judge](https://judge.softuni.bg/Contests/1217)

1. 1. Valid Usernames

Write a program that **reads user** names on a **single** line (joined by **&quot;, &quot;** ) and **prints** all **valid usernames**.

A valid username is:

- Has **length** between 3 and 16 characters
- **Contains** only letters, numbers, hyphens and underscores
- Has **no redundant symbols** before, after or in between

### Examples

| **Input** | **Output** |
| --- | --- |
| sh, too\_long\_username, !lleg@l ch@rs, jeffbutt | jeffbutt |
| Jeff, john45, ab, cd, peter-ivanov, @smith | JeffJohn45peter-ivanov |
