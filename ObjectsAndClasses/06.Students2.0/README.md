## 1.Lab: Objects and Classes

1. 6.Students 2.0

Use the class from the previous problem. If you receive a student, which already exists ( **first name** and **last name** should be **unique** ) overwrite the information.

| **Input** | **Output** |
| --- | --- |
| John Smith 15 SofiaPeter Ivanov 14 PlovdivPeter Ivanov 25 PlovdivLinda Bridge 16 SofiaLinda Bridge 27 SofiaSimon Stone 12 VarnaendSofia | John Smith is 15 years old.Linda Bridge is 27 years old. |
| Anthony Taylor 15 ChicagoDavid Anderson 16 WashingtonJack Lewis 14 ChicagoDavid Lee 14 ChicagoJack Lewis 26 ChicagoDavid Lee 18 ChicagoendChicago | Anthony Taylor is 15 years old.Jack Lewis is 26 years old.David Lee is 18 years old. |

### Hints

Check if the given student already exists.

Overwrite the student information.

First, we have to find the existing student.

Finally, we have to overwrite the information.

We can use LINQ as well.

**FirstOrDefault** returns the first occurrence or the default value (null in this case).

