# 1.Exercise: Lists

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions here: [Judge](https://judge.softuni.bg/Contests/1211)

1. 1.Train

You will receive a **list of wagons** (integers) on the first line. Every integer represents **the number of passengers that are currently in each of the wagons**. On the next line, you will get **the max capacity of each wagon** (a single integer). Until you receive &quot; **end**&quot;you will be given two types of input:

- **Add** { **passengers** } – add a wagon to the end with the given number of passengers.
- { **passengers** } - find an existing wagon to **fit every passenger** , starting from the first wagon.

At the end **print the final state** of the train (each of the wagons, separated by a space).

### Example

| **Input** | **Output** |
| --- | --- |
| 32 54 21 12 4 0 2375Add 10Add 0301075end | 72 54 21 12 4 75 23 10 0 |
| 0 0 0 10 2 410Add 1010101086end | 10 10 10 10 10 10 10 |

