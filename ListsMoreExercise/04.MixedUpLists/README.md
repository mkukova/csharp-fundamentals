# 1.More Exercises: Lists

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions here: [Ju](https://judge.softuni.bg/Contests/1300)[dge](https://judge.softuni.bg/Contests/1300)


1. 4.\*Mixed up Lists

Write a program that **mixes up**** two lists **by some rules. You will receive** two lines of input **, each one being a** list of numbers **. The** rules** for mixing are:

- Start from the **beginning of the first** list and from the **ending of the second.**
- **Add** element **from the first** and element **from the second.**
- At the end there will always be a list, in which there are **2 elements remaining.**
- These elements will be the **range of the elements you need to print.**
- **Loop through the result list** and take **only the elements that fulfill the condition.**
- Print the elements **ordered in ascending** order and **separated by a space.**

### Example

| **Input** | **Output** |
| --- | --- |
| 1 5 23 64 2 3 34 54 1243 23 12 31 54 51 92 | 23 23 31 34 43 51 |
| **Comment** |
| After looping through the two of the arrays we get: 192551235464312123233443The constrains are 54 and 12 (so we take only the numbers between them): 51 23 31 23 34 43We print the result sorted |

