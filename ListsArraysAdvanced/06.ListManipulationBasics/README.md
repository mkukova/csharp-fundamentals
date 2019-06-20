# 1.Lab: Lists

Problems for in-class lab for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1210)


1. 6.List Manipulation Basics

Write a program that reads a list of integers. Then until you receive **&quot;end&quot;** , you will receive different **commands:**

**Add {number}:** add a number to the end of the list.
**Remove {number}:** remove a number from the list.
**RemoveAt {index}:** remove a number at a given index.
**Insert {number} {index}:** insert a number at a given index.

**Note: All the indices will be valid!**

When you receive the **&quot;end&quot;** command, print the **final state** of the list ( **separated by spaces** ).

### Example

| **Input** | **Output** |
| --- | --- |
| 4 19 2 53 6 43Add 3Remove 2RemoveAt 1Insert 8 3end | 4 53 6 8 43 3 |

### Solution

First let us read the list from the console.

- We **split** the string we have received from the console, then we **loop through each of the elements** and parse them to **integers.**
- This returns **IEnumarable\&lt;int\&gt;** (a **collection** of integers) and we have to keep it in the form of a list.

Next, we go through the input using a while loop and a switch case statement for the different commands.

- We stop the cycle if the line is end, otherwise we **split** the input string into **tokens**.

Now, let us implement **each** of the **commands**.

- For each of the commands, **except &quot;Insert&quot;,**** tokens[1] **is the** number/index.**
- For the **&quot;Insert&quot;** command we receive a **number and an index** (**tokens[1], tokens[2]**).

Finally, we **print** the numbers, joined by **a single space.**

