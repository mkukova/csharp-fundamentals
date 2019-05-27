## 1.More Exercise: C# Intro and Basic Syntax

1. 3.Gaming Store

Write a program, whichhelps you buy the games. The **valid games** are the following games in this table:

| **Name** | **Price** |
| --- | --- |
| OutFall 4 | $39.99 |
| CS: OG | $15.99 |
| Zplinter Zell | $19.99 |
| Honored 2 | $59.99 |
| RoverWatch | $29.99 |
| RoverWatch Origins Edition | $39.99 |

On the first line, you will receive your **current balance** – a **floating-point** number in the range **[0.00…5000.00]**.

Until you receive the command &quot; **Game Time**&quot;, you have to keep **buying games**. When a **game** is **bought** , the user&#39;s **balance** decreases by the **price** of the game.

Additionally, the program should obey the following conditions:

- If a game the user is trying to buy is **not present** in the table above, print &quot; **Not Found**&quot; and **read the next line**.
- If at any point, the user has **$0** left, print &quot; **Out of money!**&quot; and **end the program**.
- Alternatively, if the user is trying to buy a game which they **can&#39;t afford** , print &quot; **Too Expensive**&quot; and **read the next line**.
- If the game exists and the player has the money for it, print **&quot;Bought {nameOfGame}&quot;**

When you receive &quot; **Game Time**&quot;, **print** the user&#39;s **remaining money** and **total spent on games** , **rounded** to the **2**

# nd
 **decimal place**.
### Examples

| **Input** | **Output** |
| --- | --- |
| 120RoverWatchHonored 2Game Time | Bought RoverWatchBought Honored 2Total spent: $89.98. Remaining: $30.02 |
| 19.99Reimen originRoverWatchZplinter ZellGame Time | Not FoundToo ExpensiveBought Zplinter ZellOut of money! |
| 79.99OutFall 4RoverWatch Origins EditionGame Time | Bought OutFall 4Bought RoverWatch Origins EditionTotal spent: $79.98. Remaining: $0.01 |

