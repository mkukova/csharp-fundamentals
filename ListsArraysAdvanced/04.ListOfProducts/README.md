# 1.Lab: Lists

Problems for in-class lab for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1210)

1. 4.List of Products

Read a number **n** and **n lines of products**. Print a **numbered list** of all the products **ordered by name**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 4PotatoesTomatoesOnionsApples |  1.Apples2.Onions3.Potatoes4.Tomatoes |

### Solution

First, we need to read the number **n** from the console.

Then we need to create our **list of strings** , because the **products are strings.**

Then we need to iterate **n times** and **read our current product**.

The next step is to **add** the current product to the list.

After we finish reading the products, we **sort our list alphabetically.**

- The **sort method** sorts the list in ascending order.

Finally, we have to **print our sorted** list. To do that we **loop through the list**.

- We use **i + 1** , because we want to **start counting from 1** , we put the **&#39;.&#39;** , and **finally** we put **the actual product.**

