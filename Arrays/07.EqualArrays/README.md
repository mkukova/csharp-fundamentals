# 1.Lab: Arrays

Problems for in-class lab for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1202)

1. 7.Equal Arrays

Read two arrays and print on the console whether they are identical or not. Arrays are identical if their elements are equal. If the arrays are identical find the sum of the first one and print on the console following message: &quot;Arrays are identical. Sum: {sum}&quot;, otherwise find the first index where the arrays differ and print on the console following message: &quot;Arrays are not identical. Found difference at {index} index&quot;.

### Examples

| **Input** | **Output** |
| --- | --- |
| 10 20 3010 20 30 | Arrays are identical. Sum: 60 |
| 1 2 3 4 51 2 4 3 5 | Arrays are not identical. Found difference at 2 index |
| 110 | Arrays are not identical. Found difference at 0 index |

### Hints

First, we need to read two arrays.

Iterate through arrays and compare element. If the elements are not equal print the required message and break the loop.

Think about how to solve the other part of the problem.

