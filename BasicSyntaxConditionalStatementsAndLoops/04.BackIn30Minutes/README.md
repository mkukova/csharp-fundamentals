﻿# 1.Lab: Intro and Basic Syntax


1. 4.Back in 30 Minutes

Every time Stamat tries to pay his bills he sees on the cash desk the sign: **&quot;**** I will be back in 30 minutes ****&quot;**. One day Stamat was sick of waiting and decided he needs a program, which **prints the time** after **30**** minutes**. That way he won&#39;t have to wait on the desk and come at the appropriate time. He gave the assignment to you, so you have to do it.

### Input

The **input** will be on two lines. On the **first**** line **, you will receive the** hours **and on the** second **you will receive the** minutes**.

### Output

Print on the console the time after **30** minutes. The result should be in format **hh:mm**. The **hours** have **one or two**** numbers **and the** minutes **have always** two numbers (with leading zero)**.

### Constraints

- **** The **hours** will be between **0 and 23**.
- **** The **minutes** will be between **0 and 59**.

### Examples

| **Input** | **Output** |   | **Input** | **Output** |   | **Input** | **Output** |   | **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| 146 | 2:16 |   | 001 | 0:31 | 2359 | 0:29 |   | 1108 | 11:38 |   | 1132 | 12:02 |

### Hints

- Add 30 minutes to the initial minutes, which you receive from the console. If the minutes are more than 59 – increase the hours with 1 and decrease the minutes with 60. The same way check if the hours are more than 23. When you print check for leading zero.

