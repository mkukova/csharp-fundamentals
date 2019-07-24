## 1.Exercise: Regular Expressions

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1668/)

1. 1.Furniture

Write a program to calculate the total cost of different types of furniture. You will be given some lines of input until you receive the line &quot;Purchase&quot;. For the line to be valid it should be in the following format:

**&quot;\&gt;\&gt;{furniture name}\&lt;\&lt;{price}!{quantity}&quot;**

The price can be floating point number or whole number. Store the names of the furniture and the total price. At the end print the each bought furniture on separate line in the format:

**&quot;Bought furniture:**

**{1**

# st
 **name}**

**{2**

# nd
 **name}**

**…&quot;**

And on the last line print the following: **&quot;Total money spend: {spend money}&quot;** formatted to the second decimal point.

### Examples

| **Input** | **Output** | **Comment** |
| --- | --- | --- |
| \&gt;\&gt;Sofa\&lt;\&lt;312.23!3\&gt;\&gt;TV\&lt;\&lt;300!5\&gt;Invalid\&lt;\&lt;!5Purchase  | Bought furniture:SofaTVTotal money spend: 2436.69 | Only the Sofa and the TV are valid, for each of them we multiply the price by the quantity and print the result  |

