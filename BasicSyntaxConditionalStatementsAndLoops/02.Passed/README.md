﻿# 1.Lab: Intro and Basic Syntax


1. 2.Passed

Write a program, which takes as an input a **grade** and prints &quot; **Passed!**&quot; if the grade is **equal or more than 3.00**.

### Input

The **input** comes as a single floating-point number.

### Output

The **output** is either &quot; **Passed!**&quot; if the grade is **equal or more than 3.00** , otherwise you should print nothing.

### Examples

| **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- |
| 5.32 | Passed! |   | 2.34 | _(no output)_ |

### Solution

We need to take as an input a floating-point number from the console. We will use **double.Parse()** to convert **string** to **double** , which we receive from **Console.ReadLine()**. After that we compare the grade with **3.00** and prints the result **only**** if **the condition returns** true**.

