# 1.More Exercises: Arrays

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1275)



1. 3.Recursive Fibonacci

The Fibonacci sequence is quite a famous sequence of numbers. Each member of the sequence is calculated from the sum of the two previous elements. The **first two** elements are 1, 1. Therefore the sequence goes as 1, 1, 2, 3, 5, 8, 13, 21, 34…
The following sequence can be generated with an array, but that&#39;s easy, so your task is to implement recursively.

So if the function **GetFibonacci(n)** returns the n&#39;th Fibonacci number we can express it using **GetFibonacci(n) = GetFibonacci(n-1) + GetFibonacci(n-2).**

However, this will never end and in a few seconds a StackOverflow Exception is thrown. In order for the recursion to stop it has to have a &quot; **bottom**&quot;. The bottom of the recursion is **GetFibonacci(2)** should return 1 and **GetFibonacci(1)** should return 1.

### Input Format:

- On the only line in the input the user should enter the wanted Fibonacci number.

### Output Format:

- The output should be the n&#39;th Fibonacci number counting from 1.

### Constraints:

- 1 ≤ N ≤ 50

### Examples

| **Input** | **Output** |
| --- | --- |
| 5 | 5 |
| 10 | 55 |
| 21 | 10946 |

For the Nth Fibonacci number, we calculate the N-1th and the N-2th number, but for the calculation of N-1th number we calculate the N-1-1th(N-2th) and the N-1-2th number, so we have a lot of repeated calculations.

If you want to figure out how to skip those unnecessary calculations, you can search for a technique called [memoization](https://en.wikipedia.org/wiki/Memoization).

