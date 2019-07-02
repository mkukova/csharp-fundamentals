## 1.Lab: Objects and Classes

1.
## I.Using the Built-in .NET Classes


1. 2.Randomize Words

You are given a **list of words in one line**. **Randomize their order** and print each word at a separate line.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| Welcome to SoftUni and have fun learning programming | learningWelcomeSoftUniandfunprogramminghaveto | The order of the words in the output will be different after each program execution. |

### Hints

- **Split** the input string by (space) and create an **array of words**.
- Create a random number generator – an object **rnd** of type **Random**.
- In a **for-loop exchange each number** at positions 0, 1, … **Length-1** by a number at **random position**. To generate a random number in rangeuse **rnd.** [**Next(minValue, maxValue)**](https://msdn.microsoft.com/en-us/library/2dx6wyd4(v=vs.110).aspx). Note that by definition **minValue** is **inclusive** , but **maxValue** is **exclusive**.
- Print each word in the array on new line.

