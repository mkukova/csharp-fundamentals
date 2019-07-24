## 1.Exercise: Regular Expressions

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1668/)

1. 6.\*Extract Emails

Write a program to **extract all email addresses from a given text**. The text comes at the only input line. Print the emails on the console, each at a separate line. Emails are considered to be in format **\&lt;user\&gt;@\&lt;host\&gt;** , where:

- **\&lt;user\&gt;** is a sequence of **letters** and **digits** , where &#39; **.**&#39;, &#39; **-**&#39; and &#39; **\_**&#39; can appear between them.
  - Examples of valid users: &quot; **stephan**&quot;, &quot; **mike03**&quot;, &quot; **s.johnson**&quot;, &quot; **st\_steward**&quot;, &quot; **softuni-bulgaria**&quot;, &quot; **12345**&quot;.
  - Examples of invalid users: &#39;&#39; **--123**&quot;, &quot; **.....**&quot;, &quot; **nakov\_-**&quot;, &quot; **\_steve**&quot;, &quot; **.info**&quot;.
- **\&lt;host\&gt;** is a sequence of at least two words, separated by dots &#39; **.**&#39;. Each word is sequence of letters and can have hyphens &#39; **-**&#39; between the letters.
  - Examples of hosts: &quot; **softuni.bg**&quot;, &quot; **software-university.com**&quot;, &quot; **intoprogramming.info**&quot;, &quot; **mail.softuni.org**&quot;.
  - Examples of invalid hosts: &quot; **helloworld**&quot;, &quot; **.unknown.soft.**&quot;, &quot; **invalid-host-**&quot;, &quot; **invalid-**&quot;.
- Examples of **valid emails** : **info@softuni-bulgaria.org** , **kiki@hotmail.co.uk** , **no-reply@github.com** , **s.peterson@mail.uu.net** , **info-bg@software-university.software.academy**.
- Examples of **invalid emails** : **--123@gmail.com** , **…@mail.bg** , **.info@info.info** , **\_steve@yahoo.cn** , **mike@helloworld** , **mike@.unknown.soft****. **,** s.johnson@invalid-**.

### Examples

| **Input** | **Output** |
| --- | --- |
| Please contact us at: support@github.com. | support@github.com |
| Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information. | s.miller@mit.eduj.hopking@york.ac.uk |
| Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. –- steve.parker@softuni.de. | steve.parker@softuni.de |