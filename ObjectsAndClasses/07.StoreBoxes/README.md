## 1.Lab: Objects and Classes

1. 7.Store Boxes

Define a class **Item,** which contains these properties: **Name and Price.**

Define a class **Box,** which contains these properties: **Serial Number, Item, Item Quantity** and **Price for a Box.**

Until you receive **&quot;end&quot;,** you will be receiving data in the following format: **{Serial Number} {Item Name} {Item Quantity} {itemPrice}**

The **Price of one box** has to be calculated: **itemQuantity \* itemPrice.**

Print all the boxes, ordered descending by price for a box, in the following format:

**{boxSerialNumber}**

**-- {boxItemName} – ${boxItemPrice}: {boxItemQuantity}**

**-- ${boxPrice}**

The price should be **formatted to the 2**

# nd
 **digit after the decimal separator**.
### Examples

| **Input** | **Output** |
| --- | --- |
| 19861519 Dove 15 2.5086757035 Butter 7 3.2039393891 Orbit 16 1.6037741865 Samsung 10 1000end | 37741865-- Samsung - $1000.00: 10-- $10000.0019861519-- Dove - $2.50: 15-- $37.5039393891-- Orbit - $1.60: 16-- $25.6086757035-- Butter - $3.20: 7-- $22.40 |
| 48760766 Alcatel 8 10097617240 Intel 2 50083840873 Milka 20 2.7535056501 SneakersXL 15 1.50end | 97617240-- Intel - $500.00: 2-- $1000.0048760766-- Alcatel - $100.00: 8-- $800.0083840873-- Milka - $2.75: 20-- $55.0035056501-- SneakersXL - $1.50: 15-- $22.50 |

### Hints

This is how your class Box should look like:

Create an **instance** of **Item** in such a way, that when you try to set a value to some of the properties, it will not throw you an exception.

There are two ways to do that:

First you can create a new instance of **Item** in the **Box constructor**.

Or every time you create a new Box, on the next line just access the Item property and create a new instance.

