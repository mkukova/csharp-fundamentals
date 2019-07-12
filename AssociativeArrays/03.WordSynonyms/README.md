# 1.Lab: Dictionaries, Lambda and LINQ

1.
# I.Associative Arrays

1. 3.Word Synonyms

Write a program, which keeps a dictionary with synonyms. The **key** of the dictionary will be the **word**. The **value** will be a **list of all the synonyms of that word**. You will be given a number **n**  **– the count of the words**. After each word, you will be given a synonym, so the count of lines you have to read from the console is **2 \* n****. **** You will be receiving **a** word **and a** synonym** each on a separate line like this:

- { **word** }
- { **synonym** }

If you get the same word twice, just add the new synonym to the list.

Print the words in the following format:

**{word} - {synonym1, synonym2… synonymN}**

### Examples

| **Input** | **Output** |
| --- | --- |
| 3cuteadorablecutecharmingsmartclever | cute - adorable, charmingsmart - clever |
| 2taskproblemtaskassignment | task – problem, assignment |

### Hints

- Use a **dictionary (string -\&gt; List\&lt;string\&gt;)** to keep all of the synonyms.
- **Read n \* 2 lines**
- **Add the word in the dictionary if it is not present**

- **Add the synonym as a value to the given word**
- **Print each word with the synonyms in the required format**

