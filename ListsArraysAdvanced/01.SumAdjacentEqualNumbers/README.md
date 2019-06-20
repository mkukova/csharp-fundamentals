# 1.Lab: Lists

Problems for in-class lab for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1210)

1. 1.Sum Adjacent Equal Numbers

Write a program to **sum all adjacent equal numbers** in a list of decimal numbers, starting from **left to right**.

- After two numbers are summed, the obtained result could be equal to some of its neighbors and should be summed as well (see the examples below).
- Always sum the **leftmost** two equal neighbors (if several couples of equal neighbors are available).

### Examples

| **Input** | **Output** | **Explanation** |
| --- | --- | --- |
| 3 3 6 1 | 12 1 | **3 3** 6 1  **6 6** 1  12 1 |
| 8 2 2 4 8 16 | 16 8 16 | 8 **2 2** 4 8 16  8 **4 4** 8 16  **8 8** 8 16  16 8 16 |
| 5 4 2 1 1 4 | 5 8 4 | 5 4 2 **1 1** 4  5 4 **2 2** 4  5 **4 4** 4  5 8 4 |

### Solution

Read a list of numbers.

Iterate through the elements. Check if the number at the **current**** index **is** equal **to the** next **number. If it is,** aggregate ****the numbers** and **reset** the loop, otherwise **don&#39;t do anything**.

Finally, you have to print the numbers joined by a single space.

