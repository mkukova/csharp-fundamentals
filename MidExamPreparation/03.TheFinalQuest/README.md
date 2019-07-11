## 1.The Final Quest

_After walking through fire, the group has reached the final step of the quest. They have received a list with instructions that will help them resolve the last riddle that will lead them to the truth about the Hunting Games._

Create a program that **follows** given **instructions**. You will receive a **collection of words on a single line** , split by a **single space**. They are not what they are supposed to be, so you have to **follow the instructions** in order to find the **real message**. You will be receiving commands. Here are the possible ones:

- -- **Delete {index}** – removes the word **after** the given index **if it is valid**.
- -- **Swap {word1} {word2}** – find the given words in the collections **if they exist** and **swap** their places.
- -- **Put {word} {index}** – **add** a word at the **previous place {index} before** the
given one, **if it is valid**. Note: putting at the last index simply appends the word to the end of the list.
- -- **Sort** – you must **sort** the words in descending order.
- -- **Replace {word1} {word2}** – find the **second word**** {word2}**in the collection (**if it exists**) and**replace **it with the** first word – {word1}**.

Follow them until you receive the &quot; **Stop**&quot; command. After you have successfully **followed the instructions** , you must print the words on a single line, split by a space.

# 2.Input / Constraints

- **On the 1**
# st
 **line** , you are going to receive the collection of words, split by a single space – **strings**
- **On the next lines** , you are going to receive **commands** , until you receive the &quot; **Stop**&quot; command

# 3.Output

- Print the words you have gathered on a single line, split by a single space

# 4.Examples

| **Input** | **Output** |
| --- | --- |
| Congratulations! You last also through the have challenge!Swap have lastReplace made haveDelete 2Put it 4Stop | Congratulations! You made it through the last challenge! |
| **Comments** |
| First, we receive the command **&quot;Swap&quot;,** so we change the positions of the words **have** and **last**. The text at this point should look like this: **Congratulations! You have also through the last challenge!** After that, we receive **&quot;Replace&quot;** and we have to replace the **second word** – &quot;have&quot; **with the first** – &quot;made&quot;. Afterwards we have to **delete** the **word** , which is **after the second index**. And finally, we have to put a word on the **previous** position **before**** 4**. |

| **Input** | **Output** |
| --- | --- |
| This the my quest! finalPut is 2Swap final quest!Delete 2Stop | This is the final quest! |