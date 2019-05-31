# 1.Lab: Arrays

Problems for in-class lab for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1202)

1. 6.Even and Odd Subtraction

Write a program that calculates the difference between the sum of the even and the sum of the odd numbers in an array.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 1 2 3 4 5 6 | 3 | Even: 2 + 4 + 6 = 12Odd: 1 + 3 + 5 = 9Result: 12 – 9 = 3 |
| 3 5 7 9 | -24 | Even: 0Odd: 3 + 5 + 7 + 9 = 24Result: 0 – 24 = -24 |
| 2 4 6 8 10 | 30 | Even: 2 + 4 + 6 + 8 + 10 = 30Odd: 0Result: 30 – 0 = 30 |

### Hints

First, we need to read the array.

We will need two variables – even and odd sum.

Iterate through all elements in the array with for loop.

Check the current number – if it is even add it to the even sum, otherwise add It to the odd sum.

Print the difference.



