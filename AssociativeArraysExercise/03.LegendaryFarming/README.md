﻿# 1.Exercise: Associative Arrays

1. 3.Legendary Farming

You&#39;ve done all the work and the last thing left to accomplish is to own a **legendary item**. However, it&#39;s a tedious process and it requires quite a bit of farming. Anyway, you are not too pretentious - any legendary item will do. The possible **items** are:

- **Shadowmourne** - requires **250 Shards** ;
- **Valanyr** - requires **250 Fragments** ;
- **Dragonwrath** - requires **250 Motes** ;

**Shards, Fragments** and **Motes** are the **key materials** and everything else is **junk.** You will be given lines of input, in the format:

**2 motes 3 ores 15 stones**

Keep track of the **key materials** -the **first** one that reaches the **250 mark,**** wins **the** race **. At that point you have to print that the corresponding legendary item is obtained. Then, print the** remaining **shards, fragments, motes, ordered by** quantity **in** descending **order, then by** name **in** ascending **order, each on a new line. Finally, print the collected** junk **items in** alphabetical** order.

### Input

- Each line comes in the following format: **{quantity} {material} {quantity} {material} … {quantity} {material}**

### Output

- On the first line, print the obtained item in the format: **{Legendary item} obtained!**
- On the next three lines, print the remaining key materials in **descending order by quantity**
  - If **two** key materials have the same quantity, print them in **alphabetical**** order**
- On the final several lines, print the **junk** items **in alphabetical order**
  - All materials are printed in format **{material}: {quantity}**
  - The output should be **lowercase** , except for the first letter of the legendary

### Examples

| **Input** | **Output** |
| --- | --- |
| 3 Motes 5 stones 5 Shards6 leathers 255 fragments 7 Shards | Valanyr obtained!fragments: 5shards: 5motes: 3leathers: 6stones: 5 |
| 123 silver 6 shards 8 shards 5 motes9 fangs 75 motes 103 MOTES 8 Shards86 Motes 7 stones 19 silver | Dragonwrath obtained!shards: 22motes: 19fragments: 0fangs: 9silver: 123 |

