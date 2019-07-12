# 1.Exercise: Associative Arrays


1. 4.Orders

Write a program that keeps information about **products** and their **prices**. Each product has a **name** , a **price** and a **quantity**. If the product **doesn&#39;t exist** yet, **add** it with its **starting quantity**.

If you receive a product, which **already exists,**** increase **its quantity by the input quantity and if its** price **is different,** replace** the price as well.

You will receive products&#39; **names** , **prices** and **quantities** on **new lines**.Until you receive the command &quot; **buy**&quot;, keep adding items. When you do receive the command &quot; **buy**&quot;, print the items with their **names** and **total price** of all the products with that name.

### **Input**

- Until you receive &quot; **buy**&quot;, the products will be coming in the format: &quot; **{name} {price} {quantity}**&quot;.
- The product data is **always** delimited by a **single space**.

### **Output**

- Print information about **each**** product** in the following format:
**&quot;{productName} -\&gt; {totalPrice}&quot;**
- **Format** the average grade to the **2**
# nd
 **digit after the decimal separator**.

### Examples

| **Input** | **Output** |
| --- | --- |
| Beer 2.20 100IceTea 1.50 50NukaCola 3.30 80Water 1.00 500buy | Beer -\&gt; 220.00IceTea -\&gt; 75.00NukaCola -\&gt; 264.00Water -\&gt; 500.00 |
| Beer 2.40 350Water 1.25 200IceTea 5.20 100Beer 1.20 200IceTea 0.50 120buy | Beer -\&gt; 660.00Water -\&gt; 250.00IceTea -\&gt; 110.00 |
| CesarSalad 10.20 25SuperEnergy 0.80 400Beer 1.35 350IceCream 1.50 25buy | CesarSalad -\&gt; 255.00SuperEnergy -\&gt; 320.00Beer -\&gt; 472.50IceCream -\&gt; 37.50 |

