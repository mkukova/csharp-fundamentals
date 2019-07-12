# 1.Exercise: Associative Arrays

1. 8.Company Users

Write a program that keeps information about companies and their employees.

You will be receiving a **company**** name **and an** employee&#39;s id, **until you receive the command &quot;** End**&quot; command. Add each employee to the given company. Keep in mind that a company cannot have two employees with the same id.

When you finish reading the data, **order the companies by the name in ascending order**.

Print the company name and each employee&#39;s id in the following format:

**{companyName}**

**-- {id1}**

**-- {id2}**

**-- {idN}**

### **Input / Constraints**

- Until you receive the &quot; **End**&quot; command, you will be receiving input in the format: &quot; **{companyName} -\&gt; {employeeId}**&quot;.
- The input always will be valid.

### Examples

| **Input** | **Output** |
| --- | --- |
| SoftUni -\&gt; AA12345SoftUni -\&gt; BB12345Microsoft -\&gt; CC12345HP -\&gt; BB12345End | HP-- BB12345Microsoft-- CC12345SoftUni-- AA12345-- BB12345 |
| SoftUni -\&gt; AA12345SoftUni -\&gt; CC12344Lenovo -\&gt; XX23456SoftUni -\&gt; AA12345Movement -\&gt; DD11111End | Lenovo-- XX23456Movement-- DD11111SoftUni-- AA12345-- CC12344 |

