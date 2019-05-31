## 1.Exercise: Arrays

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1206)



1. 6.Equal Sums

Write a program that determines if there **exists an element in the array** such that the **sum of the elements on its left** is **equal** to the **sum of the elements on its right**. If there are **no elements to the left / right** , their **sum is considered to be 0**. Print the **index** that satisfies the required condition or **&quot;no&quot;** if there is no such index.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 1 233 | 2 | At a[2] -\&gt; left sum = 3, right sum = 3a[0] + a[1] = a[3] |
| 1 2 | no | At a[0] -\&gt; left sum = 0, right sum = 2At a[1] -\&gt; left sum = 1, right sum = 0No such index exists |
| 1 | 0 | At a[0] -\&gt; left sum = 0, right sum = 0 |
| 1 2 3 | no | No such index exists |
| 10 5 5993 4 2 5 1 1 4 | 3 | At a[3] -\&gt; left sum = 20, right sum = 20a[0] + a[1] + a[2] = a[4] + a[5] + a[6] + a[7] + a[8] + a[9] + a[10] |

