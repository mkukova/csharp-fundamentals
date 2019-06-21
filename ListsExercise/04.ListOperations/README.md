# 1.Exercise: Lists

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions here: [Judge](https://judge.softuni.bg/Contests/1211)


1. 4.List Operations

You will be given a **list** of **integer** numbers on the first line of input. You will be receiving operations you have to apply on the list until you receive the **&quot;End&quot;** command. The possible **commands** are:

- **Add {number}**  **–**  **add number at the end.**
- **Insert {number} {index}**  **–**  **insert number at given index.**
- **Remove {index}**  **–**  **remove at index.**
- **Shift left {count}**  **–**  **first number becomes last &#39;count&#39; times.**
- **Shift right {count}**  **–**  **last number becomes first &#39;count&#39; times.**

**Note: there is a possibility that the given index is outside of the bounds of the array. In that case print &quot;Invalid index&quot;**

### Examples

| **Input** | **Output** |
| --- | --- |
| 1 23 29 18 43 21 20Add 5Remove 5Shift left 3Shift left 1End | 43 20 5 1 23 29 18 |
| 5 12 42 95 32 1Insert 3 0Remove 10Insert 8 6Shift right 1Shift left 2End | Invalid index5 12 42 95 32 8 1 3 |

