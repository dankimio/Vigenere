using System;

namespace ConsoleApplication
{
	class Program
	{
		static void Main()
		{
			string key = "key";
			string plainText = "Hello, World!";
			Vigenere myVigenere = new Vigenere();

			Console.WriteLine(plainText);
			string cipherText = myVigenere.Encipher(plainText, key);
			Console.WriteLine(cipherText);
			string result = myVigenere.Decipher(cipherText, key);
			Console.WriteLine(result);

			Console.WriteLine(myVigenere.CaesarEncipher("ABCabc", 1));

			foreach (var mem in myVigenere.UpdateDictionary(myVigenere.CountLetterFrequency("Lorem ipsum dolor sit amet.")))
			{
				Console.WriteLine("Letter {0} is {1} %", mem.Key, mem.Value);
			}
		}
	}
}
