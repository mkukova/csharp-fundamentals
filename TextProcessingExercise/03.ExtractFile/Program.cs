using System;

namespace _03.ExtractFile
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split("\\");
			string file = input[input.Length - 1];
			string fileName = file.Substring(0, file.LastIndexOf('.'));
			string fileExtension = file.Substring(file.LastIndexOf('.') + 1);

			Console.WriteLine($"File name: {fileName}");
			Console.WriteLine($"File extension: {fileExtension}");
		}
	}
}
