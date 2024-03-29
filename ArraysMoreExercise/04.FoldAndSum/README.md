﻿# 1.More Exercises: Arrays

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1275)


1. 4.Fold and Sum

Read an array of **4\*k** integers, fold it like shown below, and print the sum of the upper and lower two rows (each holding 2 \* k integers):

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 5 **2 3** 6 | 7 9 | 5  6  +2  3  =7  9 |
| 1 2 **3 4 5 6** 7 8 | 5 5 13 13 | 2  1  8  7  +3  4  5  6  =5  5 13 13 |
| 4 3 -1 **2 5 0 1 9 8** 6 7 -2 | 1 8 4 -1 16 14 | -1  3  4 -2  7  6  + 2  5  0  1  9  8  = 1  8  4 -1 16 14 |

### Hints

- Create the **first row** after folding: the first **k** numbers reversed, followed by the last **k** numbers reversed.
- Create the **second row** after folding: the middle 2\ ***k** numbers.
- **Sum** the first and the second rows.
