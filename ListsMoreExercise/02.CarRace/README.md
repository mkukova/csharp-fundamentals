# 1.More Exercises: Lists

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions here: [Ju](https://judge.softuni.bg/Contests/1300)[dge](https://judge.softuni.bg/Contests/1300)

1. 2.Car Race

Write a program to calculate the **winner of a car race**. You will receive an **array of numbers**. Each element of the array represents the **time needed to pass through that step** (the index). There are going to be **two cars**. **One** of them **starts** from the **left side** and the **other one starts from the right**** side **.** The middle index of the array is the finish line **. The** number of elements **in the array** will always be odd **. Calculate** the total time for each racer to reach the finish **, which is the** middle of the array **, and** print the winner with his total time**(the**racer with less time**). If you have a**zero in the array **, you have to** reduce the time of the racer that reached it by 20%**(**from his current time**).

Print the result in the following format **&quot;The winner is {left/right} with total time: {total time}&quot;.**

### Example

| **Input** | **Output** |
| --- | --- |
| 29 13 9 0 13 0 21 0 14 82 12 | The winner is left with total time: 53.8 |
| **Comment** |
| The time of the left racer is (29 + 13 + 9) \* 0.8 (because of the zero) + 13 = 53.8The time of the right racer is (82 + 12 + 14) \* 0.8 + 21 = 107.4The winner is the left racer, so we print it |

