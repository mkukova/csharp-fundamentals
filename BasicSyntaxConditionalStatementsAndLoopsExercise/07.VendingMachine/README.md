﻿# 1.7.Vending Machine

You task is to calculate the total price of a purchase from a vending machine. Until you receive &quot; **Start**&quot; you will be given different coins that are being inserted in the machine. You have to sum them in order to have the total money inserted. There is a problem though. Your vending machine only works with **0.1** , **0.2** , **0.5, 1, and 2** coins. If someone tries to insert some other coins you have to display &quot; **Cannot accept {money}**&quot; and **not** add it to the total money. On the next few lines until you receive &quot; **End**&quot; you will be given products to purchase. Your machine has however only &quot; **Nuts**&quot;, &quot; **Water**&quot;, &quot; **Crisps**&quot;, &quot; **Soda**&quot;, &quot; **Coke**&quot;. The prices are: **2.0** , **0.7** , **1.5** , **0.8** , **1.0** respectively. If the person tries to purchase a not existing product print &quot; **Invalid product**&quot;. Be careful that the person may try to purchase a product they don&#39;t have the money for. In that case print &quot; **Sorry, not enough money**&quot;. If the person purchases a product successfully print &quot; **Purchased {product name}**&quot;. After the &quot;End&quot; command print the money that are left formatted to the second decimal point in the format &quot; **Change: {money left}**&quot;.

### Examples

| **Input** | **Output** |
| --- | --- |
| 110.50.6StartCokeSodaCrispsEnd | Cannot accept 0.6Purchased cokePurchased sodaSorry, not enough moneyChange: 0.70 |