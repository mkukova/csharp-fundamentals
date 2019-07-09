﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Articles2._0
{
	class Article
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public string Author { get; set; }

		public Article(string title, string content, string author)
		{
			this.Title = title;
			this.Content = content;
			this.Author = author;
		}
		public void AtricleToString()
		{
			Console.WriteLine($"{this.Title} -{this.Content}:{this.Author}");
		}
	}
}

