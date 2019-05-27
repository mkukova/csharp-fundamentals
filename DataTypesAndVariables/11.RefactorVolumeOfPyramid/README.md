# 1.Lab: Data Types and Variables

1.
# III.Variables

1. 11.Refactor Volume of Pyramid

You are given a **working code** that finds the **volume of a pyramid**. However, you should consider that the variables exceed their optimum span and have improper naming. Also, search for variables that **have multiple purpose**.

### Hints

- **Reduce the span** of the variables by declaring them in the moment they receive a value, not before
- Rename your variables to **represent their** real **purpose** (example: &quot;dul&quot; should become length, etc.)
- Search for variables that have multiple purpose. If you find any, **introduce a new variable**.

| **Sample Code** |
| --- |
| double dul, sh, V = 0;Console.WriteLine(&quot;Length: &quot;);dul = double.Parse(Console.ReadLine());Console.WriteLine(&quot;Width: &quot;);sh = double.Parse(Console.ReadLine());Console.WriteLine(&quot;Heigth: &quot;);V = double.Parse(Console.ReadLine());V = (dul + sh + V) / 3;Console.WriteLine($&quot;Pyramid Volume: {V:f2}&quot;); |
