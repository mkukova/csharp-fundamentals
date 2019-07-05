## 1.Exercise: Objects and Classes


1. 2.Articles

Create a **class**** Article**with the following properties:

- **Title** – a string
- **Content** – a string
- **Author** – a string

The class should have a constructor and the following methods:

- **Edit (new content**)– change the old content with the new one
- **ChangeAuthor (new author)** – change the author
- **Rename (new title)**– change the title of the article
- Override the **ToString** method – print the article in the following format:

**&quot;{title} - {content}: {autor}&quot;**

Write a program that reads an article in the following format **&quot;{title}, {content}, {author}&quot;**. On the next line, you will receive a number **n,** representing the number of commands, which will follow after it. On the next **n lines,** you will be receiving the following commands: **&quot;Edit: {new content}&quot;** ; **&quot;ChangeAuthor: {new author}&quot;** ; **&quot;Rename: {new title}&quot;**. At the end, print the final state of the article.

### Example

| **Input** | **Output** |
| --- | --- |
| some title, some content, some author3Edit: better contentChangeAuthor:  better authorRename: better title | better title - better content: better author |

