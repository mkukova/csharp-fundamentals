## 1.Lab: Objects and Classes

1. 8.Vehicle Catalogue

Your task is to **create a Vehicle catalogue,** which contains only **Trucks**** and ****Cars**.

Define a class **Truck** with the following properties: **Brand, Model and Weight**.

Define a class **Car** with the following properties: **Brand, Model and Horse Power**.

Define a class **Catalog** with the following properties: **Collections of**** Trucks and Cars**.

You must read the input until you receive the &quot; **end**&quot; command. It will be in following format: **{type}/{brand}/{model}/{horse power / weight}**

In the end you have **to print all of the vehicles ordered alphabetical by brand,** in the following format:

**Cars:**

**{Brand}:**** {Model} **** - **** {Horse Power}hp**

**Trucks:**

**{Brand}**** : ****{Model}**  **-**  **{Weight}kg**

### Examples

| **Input** | **Output** |
| --- | --- |
| Car/Audi/A3/110Car/Maserati/Levante/350Truck/Mercedes/Actros/9019Car/Porsche/Panamera/375end | Cars:Audi: A3 - 110hpMaserati: Levante - 350hpPorsche: Panamera - 375hpTrucks:Mercedes: Actros - 9019kg |
| Car/Subaru/Impreza/152Car/Peugeot/307/109end | Cars:Peugeot: 307 - 109hpSubaru: Impreza - 152hp |

### Hints

This is how your class **Catalog** should look like.

Don&#39;t forget to **create instances**** for the two ****Lists**.

You can do it in the **constructor of CatalogueVehicle.**