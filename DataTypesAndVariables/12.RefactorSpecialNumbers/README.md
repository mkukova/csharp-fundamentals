# 1.Lab: Data Types and Variables

1.
# III.Variables

1. 12.Refactor Special Numbers

You are given a **working code** that is a solution to **Problem 5**. **Special Numbers**. However, the variables are **improperly named, declared before** they are needed and some of them are used for multiple things. Without using your previous solution, **modify the code** so that it is **easy to read and understand**.

| **Sample Code** |
| --- |
|  int kolkko = int.Parse(Console.ReadLine()); int obshto = 0; int takova = 0; bool toe = false; for (int ch = 1; ch \&lt;= kolkko; ch++) {        takova = ch;         while (ch \&gt; 0)         {             obshto += ch % 10;             ch = ch / 10;         }     toe = (obshto == 5) || (obshto == 7) || (obshto == 11);     Console.WriteLine(&quot;{0} -\&gt; {1}&quot;, takova, toe);     obshto = 0;     ch = takova; } |

### Hints

- Reduce the span of the variables by declaring them in the moment they receive a value, not before
- Rename your variables to represent their real purpose (example: &quot;toe&quot; should become isSpecialNum, etc.)
- Search for variables that have multiple purpose. If you find any, introduce a new variable