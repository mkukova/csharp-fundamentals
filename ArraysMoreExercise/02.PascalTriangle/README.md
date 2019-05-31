﻿# 1.More Exercises: Arrays

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1275)


1. 2.Pascal Triangle

The triangle may be constructed in the following manner: In row 0 (the topmost row), there is a unique nonzero entry 1. Each entry of each subsequent row is constructed by adding the number above and to the left with the number above and to the right, treating blank entries as 0. For example, the initial number in the first (or any other) row is 1 (the sum of 0 and 1), whereas the numbers 1 and 3 in the third row are added to produce the number 4 in the fourth row.

If you want more info about it: [https://en.wikipedia.org/wiki/Pascal&#39;s\_triangle](https://en.wikipedia.org/wiki/Pascal&#39;s_triangle)

Print each row elements separated with whitespace.

### Examples

| **Input** | **Output** |
| --- | --- |
| 4 | 1 1 1 1 2 1 1 3 3 1 |
| 13 | 1 1 1 1 2 1 1 3 3 1 1 4 6 4 1 1 5 10 10 5 1 1 6 15 20 15 6 1 1 7 21 35 35 21 7 1 1 8 28 56 70 56 28 8 1 1 9 36 84 126 126 84 36 9 1 1 10 45 120 210 252 210 120 45 10 1 1 11 55 165 330 462 462 330 165 55 11 1 1 12 66 220 495 792 924 792 495 220 66 12 1 |

### Hints

- The input number **n** will be **1 \&lt;= n \&lt;= 60**
- Think about proper **type** for elements in array
- Don&#39;t be scary to use **more and more arrays**

