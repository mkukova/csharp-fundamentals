# 1.Lab: Intro and Basic Syntax

1. 13.Debug the Code: Holidays Between Two Dates

You are assigned to **find and fix the bugs** in an existing piece of code, using the Visual Studio **debugger**. You should trace the program execution to find the lines of code that produce incorrect or unexpected results.

You are given a program (existing **source code** ) that aims to **count the non-working days between two dates** given in format **day.month.year** (e.g. between **1.05.2015** and **15.05.2015** there are **5** non-working days – Saturday and Sunday).

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 1.05.201615.05.2016 | 5 | There are 5 non-working days (Saturday / Sunday) in this period:
1-May-2016, 7-May-2016, 8-May-2016, 14-May-2016, 15-May-2016 |
| 1.5.20162.5.2016 | 1 | Only 1 non-working day in the specified period: 1.05.2016 (Sunday) |
| 15.5.202010.5.2020 | 0 | The second date is before the first. No dates in the range. |
| 22.2.20201.3.2020 | 4 | TwoSaturdays and Sundays:
- 02.2020 and 23.02.2020
- 02.2020 and 1.03.2020
 |

You can **find the broken code** in the judge system: [Broken Code for Refactoring](http://softuni.bg/downloads/svn/soft-tech/Sep-2016/Programming-Fundamentals-Sep-2016/03.%20Programming-Fundamentals-Methods-Debugging-and-Troubleshooting-Code/03.Programming-Fundamentals-Methods-and-Debugging-Lab-Broken-Solutions.zip). It looks as follows:

| HolidaysBetweenTwoDates.cs |
| --- |
| using System;using System.Globalization;classHolidaysBetweenTwoDates{    staticvoid Main()    {        var startDate = DateTime.ParseExact(Console.ReadLine(),            &quot;dd.m.yyyy&quot;, CultureInfo.InvariantCulture);        var endDate = DateTime.ParseExact(Console.ReadLine(),            &quot;dd.m.yyyy&quot;, CultureInfo.InvariantCulture);        var holidaysCount = 0;        for (var date = startDate; date \&lt;= endDate; date.AddDays(1))            if (date.DayOfWeek == DayOfWeek.Saturday &amp;&amp;                date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;        Console.WriteLine(holidaysCount);    }} |

### Hints

There are **4**** mistakes **in the code. You&#39;ve got to** use the debugger **to find them and fix them. After you do that, submit your** fixed code in the judge contest**: [https://judge.softuni.bg/Contests/Practice/Index/304#8](https://judge.softuni.bg/Contests/Practice/Index/304#8).