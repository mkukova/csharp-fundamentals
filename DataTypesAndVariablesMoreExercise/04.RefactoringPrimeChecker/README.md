# 1.More Exercise: Data Types and Variables

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1271/Data-Types-and-Variables-More-Exercises)


1. 4.Refactoring: Prime Checker

You are given a program that checks if numbers in a given range [2...N] are prime. For each number is printed &quot;{number} -\&gt; {true or false}&quot;. The code however, is not very well written. Your job is to modify it in a way that is easy to read and understand.

### Code

| **Sample Code** |
| --- |
| int \_\_\_Do\_\_\_ = int.Parse(Console.ReadLine());for (int takoa = 2; takoa \&lt;= \_\_\_Do\_\_\_; takoa++){   bool takovalie = true;   for (int cepitel = 2; cepitel \&lt; takoa; cepitel++)   {       if (takoa % cepitel == 0)       {          takovalie = false;          break;       }   }Console.WriteLine(&quot;{0} -\&gt; {1}&quot;, takoa, takovalie);} |

### Examples

| **Input** | **Output** |
| --- | --- |
| 5 | 2 -\&gt; true3 -\&gt; true4 -\&gt; false5 -\&gt; true |

