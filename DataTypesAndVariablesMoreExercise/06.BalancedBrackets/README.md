# 1.More Exercise: Data Types and Variables

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1271/Data-Types-and-Variables-More-Exercises)


1. 6.Balanced Brackets

You will receive **n** lines. On **those**** lines **, you will receive** one** of the following:

- Opening bracket – &quot;**(**&quot;,
- Closing bracket – &quot;**)**&quot; or
- **Random string**

Your task is to find out if the **brackets** are **balanced**. That means after every **closing** bracket should follow an **opening** one. Nested parentheses are **not valid** , and if **two**** consecutive opening brackets **exist, the expression should be marked as** unbalanced**.

### Input

- On the **first line** , you will receive **n** – the number of lines, which will follow
- On the next **n** lines, you will receive &quot;**(**&quot;, &quot;**)**&quot; or **another** string

### Output

You have to print &quot; **BALANCED**&quot;, if the parentheses are balanced and &quot; **UNBALANCED**&quot; otherwise.

### Constraints

- **n** will be in the interval **[1…20]**
- The length of the stings will be between **[1…100]** characters

### Examples

| **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- |
| **8** (5 + 10)\* 2 +(5)-12 | BALANCED |   | **6** 12 \*)10 + 2 -(5 + 10)   | UNBALANCED |