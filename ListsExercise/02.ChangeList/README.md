# 1.Exercise: Lists

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions here: [Judge](https://judge.softuni.bg/Contests/1211)

1. 2.Change List

Write a program, which reads a **list** of **integers** from the **console** and receives **commands** , which **manipulate** the list. Your program may receive the following commands:

- **Delete {element}** – delete all elements in the array, which are equal to the given element.
- **Insert {element} {position}** – insert an element and the given position.

You should stop the program when you receive the command **&quot;end&quot;**. Print the numbers in the array separated by a **single** whitespace.

### Examples

| **Input** | **Output** |
| --- | --- |
| 1 2 3 4 5 5 5 6Delete 5Insert 10 1Delete 5end | 1 10 2 3 4 6 |
| 20 12 4 319 21 31234 2 41 23 4Insert 50 2Insert 50 5Delete 4end | 20 12 50 319 50 21 31234 2 41 23 |

