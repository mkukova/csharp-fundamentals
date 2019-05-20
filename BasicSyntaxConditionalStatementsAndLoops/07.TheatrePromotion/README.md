# 1.Lab: Intro and Basic Syntax


1. 7.Theatre Promotions

A theatre **is doing a ticket sale** , but they need a program **to** calculate the price of a single ticket. If the given age does not fit one of the categories **,** you should print &quot;Error!&quot;.  You can see the prices i **n** the table below:

| **Day / Age** | **0 \&lt;= age \&lt;= 18** | **18 \&lt; age \&lt;= 64** | **64 \&lt; age \&lt;= 122** |
| --- | --- | --- | --- |
| **Weekday** | 12$ | 18$ | 12$ |
| **Weekend** | 15$ | 20$ | 15$ |
| **Holiday** | 5$ | 12$ | 10$ |

### Input

The input comes in **two lines**. On the **first** line, you will receive the **type of day**. On the **second** – the **age** of the person.

### Output

Print the price of the ticket according to the table, or &quot; **Error!**&quot; if the age is not in the table.

### Constraints

- **** The age will be in the interval **[-1000…1000]**.
- **** The type of day will **always be**** valid**.

### Examples

| **Input** | **Output** |   | **Input** | **Output** |   | **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| Weekday42 | 18$ |   | Holiday-12 | Error! | Holiday15 | 5$ |   | Weekend122 | 15$ |

### Solution

#### Step 1. Read the Input

We need to read **two** lines. **First** one will be the **type of day**. We will convert it to **lower case** letters with the method &quot;**ToLower()**&quot;. After that, we will read the **age** of the person and declare a **variable** – **price** , which we will use to set the price of the ticket.

#### Step 2. Add if-else Statements for the Different Types of Day

For every **type of day** , we will need to add **different cases** to check the **age** of the person and **set the price**. Some of the **age groups** have **equal**** prices **for the** same type **of day. This means we can use** logical operators **to** merge some of the conditions**.

Think **where** and **how** you can use **logical operators** for the **other cases**.

#### Step 3. Print the result

We can check if the **price**  **has a value** different, than the **initial** one. If It it does, that means we got a **valid combination of day and age** and the price of the ticket is saved in the **price** variable. If the **price** has a **value of 0** , then none of the cases got hit, therefore we have to **print the error message**.


