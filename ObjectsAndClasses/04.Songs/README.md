## 1.Lab: Objects and Classes

1.
## II.Defining Simple Classes

1. 4.Songs

Define a class **Song** , which holds the following information about songs: **Type List** , **Name** and **Time**.

On the first line you will receive the **number of songs**** - ****N**.

On the **next N-lines** you will be receiving data in the following format: **&quot;{typeList}\_{name}\_{time}&quot;****.**

On the last line you will receive **Type List** / **&quot;all&quot;.** Print only the **Names of the songs,** which are from that **Type List** / **All songs**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 3favourite\_DownTown\_3:14favourite\_Kiss\_4:16favourite\_Smooth Criminal\_4:01favourite | DownTownKissSmooth Criminal |
| 4favourite\_DownTown\_3:14listenLater\_Andalouse\_3:24favourite\_In To The Night\_3:58favourite\_Live It Up\_3:48listenLater | Andalouse |
| 2like\_Replay\_3:15ban\_Photoshop\_3:48all | ReplayPhotoshop |

### Solution

Define a class Song with properties: **Type List** , **Name** and **Time**.

Read the input lines, make a collection and store the data.

Finally read your last line – **Type List** and **print** the result.

You can use LINQ to filter the collection.

