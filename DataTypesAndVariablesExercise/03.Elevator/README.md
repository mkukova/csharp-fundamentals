﻿# 1.Exercise: Data Types and Variables

# 3.Elevator

Calculate how many courses will be needed to **elevate n persons** by using an elevator of **capacity of p persons**. The input holds two lines:the **number of people n** and the **capacity p** of the elevator.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 173 | 6 | 5 courses \* 3 people
+ 1 course \* 2 persons |
| 45 | 1 | All the persons fit inside in the elevator.Only one course is needed. |
| 105 | 2 | 2 courses \* 5 people |

### Hints

- You should **divide**  **n**  **by**  **p**. This gives you the number of full courses (e.g. 17 / 3 = 5).
- If **n** does not divide **p** without a remainder, you will need one additional partially full course (e.g. 17 % 3 = 2).
- Another approach is to round up **n**** / ****p** to the nearest integer (ceiling), e.g. 17/3 = 5.67 rounds up to 6.
- Sample code for the round-up calculation:

