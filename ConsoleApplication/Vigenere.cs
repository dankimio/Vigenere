using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
	// Contains encryption and decryption methods
	class Vigenere
	{
		// Index of coincidence
		private double ioc = 0.0667;

		// Frequency data for English language
		Dictionary<string, double> english = new Dictionary<string, double>();

		// Enciphers text using 'key' parameter
		public string Encipher(string text, string key)
		{
			List<char> cipherText = new List<char>();
			int position = 0;
			int keyLength = key.Length;

			for (int i = 0; i < text.Length; i++)
			{
				// Plain text letter
				char letter = text[i];

				// If character is not a letter then append it to result
				if (Char.IsLetter(letter))
				{
					if (Char.IsLower(letter))
					{
						char lowerKey = Char.ToLower(key[position % keyLength]);
						char cipher = (char)((letter + lowerKey - 2 * 'a') % 26 + 'a');
						cipherText.Add(cipher);
						position++;
					}
					else if (Char.IsUpper(letter))
					{
						char upperKey = Char.ToUpper(key[position % keyLength]);
						char cipher = (char)((letter + upperKey - 2 * 'A') % 26 + 'A');
						cipherText.Add(cipher);
						position++;
					}
				}
				else
				{
					cipherText.Add(letter);
				}
			}

			return String.Join("", cipherText.ToArray());
		}

		public string Decipher(string text, string key)
		{
			List<char> plainText = new List<char>();
			int position = 0;
			int keyLength = key.Length;

			for (int i = 0; i < text.Length; i++)
			{
				// Cipher text letter
				char letter = text[i];

				// If character is not a letter then append it to result
				if (Char.IsLetter(letter))
				{
					if (Char.IsLower(letter))
					{
						char lowerKey = Char.ToLower(key[position % keyLength]);
						char plain = (char)(Modulo((letter - lowerKey), 26) + 'a');
						plainText.Add(plain);
						position++;
					}
					else if (Char.IsUpper(letter))
					{
						char upperKey = Char.ToUpper(key[position % keyLength]);
						char plain = (char)(Modulo((letter - upperKey), 26) + 'A');
						plainText.Add(plain);
						position++;
					}
				}
				else
				{
					plainText.Add(letter);
				}
			}

			return String.Join("", plainText.ToArray());
		}

		public string CaesarEncipher(string text, int key)
		{
			List<char> cipherText = new List<char>();

			foreach (char letter in text)
			{
				if (char.IsLetter(letter))
				{
					if (char.IsLower(letter))
					{
						char cipher = (char) (Modulo(letter - 'a' + key, 26) + 'a');
						cipherText.Add(cipher);
					}
					else if (char.IsUpper(letter))
					{
						char cipher = (char) (Modulo(letter - 'A' + key, 26) + 'A');
						cipherText.Add(cipher);
					}
				}
				else
				{
					cipherText.Add(letter);
				}
			}

			return String.Join("", cipherText);
		}

		public Dictionary<char, int> CountLetterFrequency(string text)
		{
			Dictionary<char, int> frequency = new Dictionary<char, int>();

			for (char c = 'A'; c <= 'Z'; c++)
			{
				frequency.Add(c, 0);
			}

			text = text.ToUpper();

			foreach (char letter in text)
			{
				if (char.IsLetter(letter))
				{
					frequency[letter]++;
				}
			}

			return frequency;
		}

		// Find Caesar shift
		private int FindOptimalCaesarShift(string text)
		{
			int optimal = 0;
			int smallestSum = -1;

			for (int shift = 0; shift < 26; shift++)
			{
				string encipheredText = CaesarEncipher(text, shift);
				Dictionary<char, int> frequencies = CountLetterFrequency(encipheredText);
			}

			return 0;
		}

		private string GetEveryNthChar(string text, int start, int n)
		{
			List<char> accumulator = new List<char>();

			for (int i = 0; i < text.Length; i++)
			{
				if (i % n == start)
				{
					accumulator.Add(text[i]);
				}
			}

			return String.Join("", accumulator);
		}

		private string RotateRight(string text, int n)
		{
			// %
			int cuttingPoint = text.Length - (n % text.Length);
			// TODO Check
			return text.Substring(cuttingPoint) + text.Substring(0, cuttingPoint);
		}

		private int FindKeyLength(string text, int minLength, int maxLength)
		{
			int keyLength = minLength;

			// Indexes of coincidence
			List<double> iocs = new List<double>();

			// Get IOC value for each tested length
			for (int i = minLength; i <= maxLength; i++)
			{
				string temp = RotateRight(text, i);
				int coincidences = 0;

				for (int j = 0; j < text.Length; j++)
				{
					if (temp[j] == text[j])
					{
						coincidences++;
					}
				}

				iocs.Add((double)coincidences / text.Length);
			}

			// Find the closest IOC. If two IOCs are equal, then select shortest
			double smallestDiff = -1.0;

			for (int i = 0; i < (maxLength + 1) - minLength; i++)
			{
				double currentDiff = Math.Pow(ioc - iocs[i], 2);

				if (smallestDiff == -1.0)
				{
					smallestDiff = currentDiff;
				}

				if (currentDiff < smallestDiff)
				{
					keyLength = minLength + i;
					smallestDiff = currentDiff;
				}
			}

			return keyLength;
		}

		private string FindKey(string text, int minLength = 5, int maxLength = 15)
		{
			// A list without invalid letters
			List<char> accumulator = new List<char>();

			// Remove non-alpha letters
			foreach (char ch in text)
			{
				if (Char.IsLetter(ch))
				{
					accumulator.Add(ch);
				}
			}

			string lettersOnly = String.Join("", accumulator);
			int keyLength = FindKeyLength(lettersOnly, minLength, maxLength);

			// Find key
			List<string> key = new List<string>();

			for (int i = 0; i < keyLength; i++)
			{
				string temp = GetEveryNthChar(lettersOnly, i, keyLength);
				// Best Caesar shift
			}

			return "";
		}

		public string CrackKey(string text, int minLength = 5, int maxLength = 15)
		{
			return FindKey(text, minLength, maxLength);
		}

		// In C# '%' operator is remainder, however it differs from modulo operator, which is needed
		static int Modulo(int a, int b)
		{
			return (Math.Abs(a * b) + a) % b;
		}
	}
}
