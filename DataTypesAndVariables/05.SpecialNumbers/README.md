# 1.Lab: Data Types and Variables

1. 5.Special Numbers

A **number** is **special** when its **sum of digits is 5, 7 or 11**.

Write a program to read an integer **n** and for all numbers in the range **1…n** to print the number and if it is special or not ( **True** / **False** ).

### Examples

| **Input** | **Output** |
| --- | --- |
| 15 | 1 -\&gt; False2 -\&gt; False3 -\&gt; False4 -\&gt; False5 -\&gt; True6 -\&gt; False7 -\&gt; True8 -\&gt; False9 -\&gt; False10 -\&gt; False11 -\&gt; False12 -\&gt; False13 -\&gt; False14 -\&gt; True15 -\&gt; False |

### Hints

To calculate the sum of digits of given number **num** , you might repeat the following: sum the last digit ( **num**** % ****10** ) and remove it ( **sum**** = ****sum**** / ****10** ) until **num** reaches **0**.
