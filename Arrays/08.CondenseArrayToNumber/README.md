﻿# 1.Lab: Arrays

Problems for in-class lab for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1202)

1. 8.Condense Array to Number

Write a program to read **an array of integers** and **condense** them by **summing** adjacent couples of elements until a **single integer** is obtained. For example, if we have 3 elements {2, 10, 3}, we sum the first two and the second two elements and obtain {2+10, 10+3} = {12, 13}, then we sum again all adjacent elements and obtain {12+13} = {25}.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 2 10 3 | 25 | 2 10 3  2+10 10+3  12 13  12 + 13  25 |
| 5 0 4 1 2 | 35 | 5 0 4 1 2  5+0 0+4 4+1 1+2  5 4 5 3  5+4 4+5 5+3  9 9 8  9+9 9+8  18 17  18+17  35 |
| 1 | 1 | 1 is already condensed to number |

### Hints

While we have more than one element in the array **nums[]**, repeat the following:

- Allocate a new array **condensed[]** of size **nums.Length-1**.
- Sum the numbers from **nums[]** to **condensed[]**:
  - condensed[i] = nums[i] + nums[i+1]
- nums[] = condensed[]

The process is illustrated below: