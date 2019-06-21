# 1.Exercise: Lists

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions here: [Judge](https://judge.softuni.bg/Contests/1211)

1. 9.\*Pokemon Don&#39;t Go

_Ely likes to play Pokemon Go a lot. But Pokemon Go bankrupted … So the developers made Pokemon Don&#39;t Go out of depression. And so Ely now plays Pokemon Don&#39;t Go. In Pokemon Don&#39;t Go, when you walk to a certain pokemon, those closer to you, naturally get further, and those further from you, get closer._

You will receive a **sequence** of **integers** , separated by **spaces** – the distances to the pokemons. Then you will begin **receiving integers** , which will **correspond** to **indexes** in **that**** sequence**.

When you **receive** an **index** , you must **remove** the **element** at **that index** from the **sequence** (as if you&#39;ve captured the pokemon).

- You must **increase** the **value** of **all elements** in the sequence, which are **less** or **equal** to the **removed element** , with the **value** of the **removed element**.
- You must **decrease** the **value** of **all elements** in the sequence, which are **greater** than the **removed element** , with the **value** of the **removed element**.

If the **given index** is **less** than **0** , **remove** the **first element** of the **sequence** , and **copy** the **last element** to its place.

If the **given index** is **greater** than the **last index** of the **sequence** , **remove** the **last element** from the sequence, and **copy** the **first element** to its place.

The **increasing** and **decreasing** of elements should be done in these cases, **also**. The **element** , whose value you should use is the **removed** element.

The program **ends** when the **sequence** has **no elements** (there are no pokemons left for Ely to catch).

### Input

- On the **first line** of input you will receive a **sequence** of **integers** , **separated** by **spaces**.
- On the **next several** lines you will receive **integers** – the **indexes**.

### Output

- When the program ends, you must print the **summed**** value **of** all removed elements**.

### Constrains

- The input data will consist **only** of **valid integers** in the **range [-2.147.483.648, 2.147.483.647]**.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 4 5 3110 | 14 | The **array** is **{4, 5, 3}**. The index is **1**.We **remove**** 5 **, and we** increase all ****the**** lower **ones and** decrease all higher **ones.In this case there are** no higher **than** 5 **.The result is** {9, 8} **.The** index **is** 1 **. So we remove** 8 **, and** decrease all the higher **ones. The result is** {1} **. The** index **is** 0 **. So we remove** 1 **. There are** no elements ****left** , so we print the **sum** of **all removed elements**. **5 + 8 + 1 = 14**. |
| 5 10 6 3 52411300 | 51 | **Step 1** : **{11, 4, 9, 11}**** Step 2 **:** {22, 15, 20, 22} ****Step 3** : **{7, 5, 7}**** Step 4 **:** {2, 2} ****Step 5** : **{4, 4}**** Step 6 **:** {8} ****Step 7** : **{}**** (empty). ****Result** = **6 + 11 + 15 + 5 + 2 + 4 + 8 = 51**. |

