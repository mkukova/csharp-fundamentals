## 1.Exercise: Arrays

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1206)

1. 10.\*LadyBugs

You are **given a field size** and the **indexes of ladybugs** inside the field. After that on every new line **until the &quot;end&quot; command** is given, a **ladybug changes its position** either to its **left or to its right**** by a given fly length**.

A **command to a ladybug** looks like this: &quot; **0 right 1**&quot;. This means that the little insect placed on index 0 should fly one index to its right. If the ladybug **lands on a fellow ladybug** , it **continues to fly** in the same direction **by the same fly length**. If the ladybug **flies out of the field, it is gone**.

For example, imagine you are given a field with size 3 and ladybugs on indexes 0 and 1. If the ladybug on index 0 needs to fly to its right by the length of 1 (0 right 1) it will attempt to land on index 1 but as there is another ladybug there it will continue further to the right by additional length of 1, landing on index 2. After that, if the same ladybug needs to fly to its right by the length of 1 (2 right 1), it will land somewhere outside of the field, so it flies away:

If you are given ladybug index that does not have ladybug there, nothing happens. If you are given ladybug index that is outside the field, nothing happens.

Your job is to create the program, simulating the ladybugs flying around doing nothing. At the end, **print all cells in the field separated by blank spaces**. For each cell that has a ladybug on it print &#39; **1**&#39; and for each empty cells print &#39; **0**&#39;. For the example above, the output should be **&#39;0 1 0&#39;**.

### Input

- On the first line you will receive an integer - the size of the field
- On the second line you will receive the initial **indexes** of all ladybugs separated by a blank space. **The given indexes** may or may not be inside the field range
- On the next lines, until you get the &quot;end&quot; command you will receive commands in the format: &quot; **{ladybug index} {direction} {fly length}**&quot;

### Output

- Print the **all cells within the field in format: &quot;{cell} {cell} … {cell}&quot;**
  - If a cell has ladybug in it, print **&#39;1&#39;**
  - If a cell is empty, print **&#39;0&#39;**

### Constrains

- The size of the field will be in the range [0 … 1000]
- The ladybug indexes will be in the range [-2,147,483,647
#
… 2,147,483,647]
- The number of commands will be in the range [0 … 100]
- The fly length will be in the range [-2,147,483,647
#
… 2,147,483,647]

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 30 10 right 12 right 1end | 0 1 0 | 1 1 0 - Initial field0 1 1 - field after &quot;0 right 1&quot;0 1 0 - field after &quot;2 right 1&quot; |

| **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- |
| 30 1 20 right 11 right 12 right 1end | 0 0 0 |   | 533 left 21 left -2end | 0 0 0 1 0 |