# 1.Exercise: Lists

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions here: [Judge](https://judge.softuni.bg/Contests/1211)

1. 3.House Party

Write a program that keeps track of guests, that are going to a house party. On the first line of input, you are going to receive the **number of commands** you are going to receive. On the next lines you are going to receive one of the following **messages** :

- **--****&quot;{name} is going!&quot;**
- **--****&quot;{name} is not going!&quot;**

If you receive the **first** message, you have to **add** the person if he/she **is not** in the list and if he/she is in the list print on the console: &quot; **{name} is already in the list!&quot;**. If you receive the second message, you have to **remove** the person if he/she **is** in the list and if not print: &quot; **{name} is not in the list!**&quot;. At the end print all the guests.

### Examples

| **Input** | **Output** |
| --- | --- |
| 4Allie is going!George is going!John is not going!George is not going! | John is not in the list!Allie |
| 5Tom is going!Annie is going!Tom is going!Garry is going!Jerry is going! | Tom is already in the list!TomAnnieGarryJerry |

