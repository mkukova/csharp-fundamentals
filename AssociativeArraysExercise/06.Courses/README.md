# 1.Exercise: Associative Arrays

1. 6.Courses

Write a program that keeps information about **courses**. Each course has a name and registered students.

You will be receiving a **course**** name **and a** student ****name,** until you receive the command &quot; **end**&quot;. **Check if such course already exists, and if not, add the course.** Register the user into the course. When you receive the command &quot; **end**&quot;, print the courses with their **names** and **total registered users** , ordered by the count of registered users in descending order. For each contest print the registered users **ordered by name**** in ascending order**.

### **Input**

- Until the &quot; **end**&quot; command is received, you will be receiving input in the format: &quot; **{courseName} : {studentName}**&quot;.
- The product data is **always** delimited by **&quot; : &quot;****.**

### **Output**

- Print the information about **each**** course** in the following the format:
**&quot;{courseName}: {registeredStudents}&quot;**
- Print the information about each student, in the following the format:
**&quot;-- {studentName}&quot;**

### Examples

| **Input** | **Output** |
| --- | --- |
| Programming Fundamentals : John SmithProgramming Fundamentals : Linda JohnsonJS Core : Will WilsonJava Advanced : Harrison Whiteend | Programming Fundamentals: 2-- John Smith-- Linda JohnsonJS Core: 1-- Will WilsonJava Advanced: 1-- Harrison White |
| Algorithms : Jay MooreProgramming Basics : Martin TaylorPython Fundamentals : John AndersonPython Fundamentals : Andrew RobinsonAlgorithms : Bob JacksonPython Fundamentals : Clark Lewisend | Python Fundamentals: 3-- Andrew Robinson-- Clark Lewis-- John AndersonAlgorithms: 2-- Bob Jackson-- Jay MooreProgramming Basics: 1-- Martin Taylor |

