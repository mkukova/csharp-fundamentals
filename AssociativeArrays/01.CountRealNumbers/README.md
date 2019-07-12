# 1.Lab: Dictionaries, Lambda and LINQ

1.
# I.Associative Arrays

1. 1.Count Real Numbers

Read a **list of**  **integers** and **print them in ascending order**** , **along with their** number of occurrence ****s**.

### Examples

| **Input** | **Output** |   | **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | --- | --- |
| 8 2 2 8 2 | 2 -\&gt; 38 -\&gt; 2 | 1 5 1 3 | 1 -\&gt; 23 -\&gt; 15 -\&gt; 1 | -2 0 0 2 | -2 -\&gt; 10 -\&gt; 22 -\&gt; 1 |

### Hints

Read an array of doubles:

Use **SortedDictionary\&lt;double,**** int\&gt; **named** counts**.

Pass through each of the numbers and increase their count - **counts[num]****, **if** num **exists in the dictionary, or assign** counts[num] **=** 1 ****,**** if the number does not exist in the dictionary. We are assigning it that value, beacause it is its first occurance. The count represents the occurances.**

Pass through all of the numbers in the dictionary  and print the number **num** and its count of occurrences.

