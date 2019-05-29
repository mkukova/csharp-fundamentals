# 1.More Exercise: Data Types and Variables

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1271/Data-Types-and-Variables-More-Exercises)



1. 3.Floating Equality

Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers **a** and **b** by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than some fixed constant eps.

You will receive two lines, each containing a floating-point number. Your task is to compare the values of the two numbers.

### Examples

| **Number a** | **Number b** | **Equal (with precision eps=0.000001)** | **Explanation** |
| --- | --- | --- | --- |
| 5.3 | 6.01 | False | The difference of 0.71 is too big (\&gt; eps) |
| 5.00000001 | 5.00000003 | True | The difference 0.00000002 \&lt; eps |
| 5.00000005 | 5.00000001 | True | The difference 0.00000004 \&lt; eps |
| -0.0000007 | 0.00000007 | True | The difference 0.00000077 \&lt; eps |
| -4.999999 | -4.999998 | False | Border case. The difference 0.0000001== eps. We consider the numbers are different. |
| 4.999999 | 4.999998 | False | Border case. The difference 0.0000001 == eps. We consider the numbers are different. |

