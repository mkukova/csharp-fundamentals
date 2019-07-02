## 1.Lab: Objects and Classes

1.
## I.Using the Built-in .NET Classes

1. 1.Day of Week

You are given a **date** in format **day-month-year**. Calculate and print the **day of week** in **English**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 18-04-2016 | Monday |
| 27-11-1996 | Wednesday |

### Hints

- **Read the date as string** from the Console.
- Use the method [**DateTime.ParseExact(string date,**](https://msdn.microsoft.com/en-us/library/w2sa9yss(v=vs.110).aspx)[**format,**](https://msdn.microsoft.com/en-us/library/w2sa9yss(v=vs.110).aspx)[**provider)**](https://msdn.microsoft.com/en-us/library/w2sa9yss(v=vs.110).aspx) to convert the input string to object of type **DateTime**. Use format **&quot;**** d-M-yyyy ****&quot;** and **InvariantCulture**.
  - Alternatively split the input by &quot; **-**&quot; and you will get the day, month and year as numbers. Now you can create **new DateTime(year, month, day)**.
- The newly created **DateTime** object has a [**DayOfWeek**](https://msdn.microsoft.com/en-us/library/system.datetime.dayofweek(v=vs.110).aspx)

