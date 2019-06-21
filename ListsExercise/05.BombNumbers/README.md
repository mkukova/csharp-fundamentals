﻿# 1.Exercise: Lists

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions here: [Judge](https://judge.softuni.bg/Contests/1211)

1. 5.Bomb Numbers

Write a program that **reads a sequence of numbers** and a **special bomb number** with a certain **power**. Your task is to **detonate every occurrence of the special bomb number** and according to its power - **his neighbors from left and right**. Detonations are performed from **left to right** and all detonated numbers **disappear**. Finally print the **sum of the remaining elements** in the sequence.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 1 2 242 2 2 94 2 | 12 | Special number is **4** with power **2**. After detontaion we are left with the sequence [1, 2, 9] with sum 12. |
| 1 4 4 2 8919 3 | 5 | Special number is **9** with power **3.** After detontaion we are left with the sequence [1, 4] with sum 5. Since the 9 has only 1 neighbour from the right we remove just it (one number instead of 3). |
| 177 1 2 37 1 | 6 | Detonations are performed from left to right. We cannot detonate the second occurance of **7,** because its already destroyed by the first occurance. The numbers [1, 2, 3] survive. Their sum is 6. |
| 1 121 1 121 1 12 1 | 4 | The red and yellow numbers disappear in two sequential detonations. The result is the sequence [1, 1, 1, 1]. Sum = 4. |

