# 1.Lab: Regular Expressions C#

1. 1.Match Full Name

Write a C# Program to **match full names** from a list of names and **print** them on the console.

### Writing the Regular Expression

First, write a regular expression to match a valid full name, according to these conditions:

- A valid full name has the following characteristics:
  - It consists of **two words**.
  - Each word **starts** with a **capital letter**.
  - After the first letter, it **only contains lowercase letters afterwards**.
  - **Each** of the **two words** should be **at least two letters long**.
  - The **two words** are **separated** by a **single space**.

To help you out, we&#39;ve outlined several steps:

1. Use an online regex tester like [https://regex101.com/](https://regex101.com/)
2. Check out how to use **character sets** (denoted with square brackets - &quot;**[]**&quot;)
3. Specify that you want **two words** with a space between them (the **space character &#39;****&#39; **, and** not** any whitespace symbol)
4. For each word, specify that it should begin with an uppercase letter using a **character set**. The desired characters are in a range – **from**&#39; **A**&#39; **to**&#39; **Z**&#39;.
5. For each word, specify that what follows the first letter are only **lowercase letters** , one or more – use another character set and the correct **quantifier**.
6. To prevent capturing of letters across new lines, put &quot; **\b**&quot; at the beginning and at the end of your regex. This will ensure that what precedes and what follows the match is a word boundary (like a new line).

In order to check your RegEx, use these values for reference (paste all of them in the **Test String** field):

| **Match ALL of these** | **Match NONE of these** |
| --- | --- |
| Ivan Ivanov | ivan ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Ivan IvAnov, Ivan Ivanov |

By the end, the matches should look something like this:

After you&#39;ve constructed your regular expression, it&#39;s time to write the solution in C#.

### Implementing the Solution in C#

Create a new C# project and copy your **regular expression** into a **string** variable:

Note: It&#39;s usually a good idea to use a **verbatim string** (@in front of the string literal) to store **regular expressions** , since characters like the backslash &quot; **\**&quot; can clash with **string escaping**.

Now, it&#39;s time to **read the input** and **extract all the matches** from it. For this, we can use the **MatchCollection** class:

After we extract all the matches, we need to **iterate** over the **MatchCollection** and **print** every match that we found:

### Examples

| **Input** |
| --- |
| Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan Ivanov |
| **Output** |
| Ivan Ivanov Test Testov |
