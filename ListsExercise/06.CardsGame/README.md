# 1.Exercise: Lists

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions here: [Judge](https://judge.softuni.bg/Contests/1211)


1. 6.Cards Game

You will be given two hands of cards, which will be integer numbers. Assume that you have two players. You have to find out the winning deck and respectively the winner.

You start from the beginning of both hands. Compare the cards from the first deck to the cards from the second deck. The player, who has the bigger card, takes both cards and puts them at the **back** of his hand - **the second player&#39;s card is last, and the first person&#39;s card (the winning one) is before it (second to last)** and the player with the smaller card must **remove** the **card** from his deck. If both players&#39; cards have the same values - no one wins, and the two cards must be **removed**** from **the** decks **. The game is over, when one of the decks is left without any cards. You have to print the winner on the console and the sum of the left cards:**&quot;{First/Second} player **** wins! Sum: {sum}&quot;.**

### Examples

| **Input** | **Output** |
| --- | --- |
| 20 30 40 5010 20 30 40 | First player wins! Sum: 240 |
| 10 20 30 40 5050 40 30 30 10 | Second player wins! Sum: 50 |

