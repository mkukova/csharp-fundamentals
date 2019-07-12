# 1.Lab: Dictionaries, Lambda and LINQ

1.
# I.Associative Arrays


1. 2.Odd Occurrences

Write a program that extracts all elements from a given sequence of words that are present in it an **odd number of times** (case-insensitive).

- Words are given n a single line, space separated.
- Print the result elements in lowercase, in their order of appearance.

### Examples

| **Input** | **Output** |
| --- | --- |
| Java C# PHP PHP JAVA C java | java c# c |
| 3 5 5 hi pi HO Hi 5 ho 3 hi pi | 5 hi |
| a a A SQL xx a xx a A a XX c | a sql xx c |

### Hints

Read a line from the console and split it by a space

Use a **dictionary** ( **string**  **int** ) to count **the occurrences of each word**

Pass through each of the elements in the array and count each word.

Pass through the dictionary and print words that occures odd times.
