using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
	// Contains encryption and decryption methods
	class Vigenere
	{
		// Index of coincidence
		private double ioc = 0.0667;

		// Frequency data for English language
		Dictionary<string, double> english = new Dictionary<string, double>()
		{
			{"A", 8.167}, {"B", 1.492},	{"C", 2.782}, {"D", 4.253},
			{"E", 12.702}, {"F", 2.228}, {"G", 2.015}, {"H", 6.094},
			{"I", 6.996}, {"J", 0.153},	{"K", 0.772}, {"L", 4.025},
			{"M", 2.406}, {"N", 6.749}, {"O", 7.507}, {"P", 1.929},
			{"Q", 0.095}, {"R", 5.987},	{"S", 6.327}, {"T", 9.056},
			{"U", 2.758}, {"V", 0.978}, {"W", 2.360}, {"X", 0.150},
			{"Y", 1.974}, {"Z", 0.074},	{"maxValue", 12.702}, {"ioc", 0.0667}
		};

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
						char cipher = (char)(Modulo(letter - 'a' + key, 26) + 'a');
						cipherText.Add(cipher);
					}
					else if (char.IsUpper(letter))
					{
						char cipher = (char)(Modulo(letter - 'A' + key, 26) + 'A');
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

		public Dictionary<string, double> CountLetterFrequency(string text)
		{
			Dictionary<string, double> frequency = new Dictionary<string, double>();

			for (char c = 'A'; c <= 'Z'; c++)
			{
				frequency.Add(c.ToString(), 0);
			}

			text = text.ToUpper();

			foreach (char letter in text)
			{
				if (char.IsLetter(letter))
				{
					frequency[letter.ToString()]++;
				}
			}

			return frequency;
		}

		// Change dictionary to compare with frequency data
		public Dictionary<string, double> UpdateDictionary(Dictionary<string, double> dictionary)
		{
			double[] values = new double[dictionary.Count];
			values = dictionary.Values.ToArray();
			Array.Sort(values);
			double maxValue = values[values.Length - 1];
			double ratio = english["maxValue"] / maxValue;

			Dictionary<string, double> newDictionary = new Dictionary<string, double>();

			foreach (KeyValuePair<string, double> item in dictionary)
			{
				newDictionary[item.Key] = item.Value * ratio;
			}

			return newDictionary;
		}

		// Difference between letter's frequency in the text and data, squared to prevent negative values
		double SquaredDifference(Dictionary<string, double> dictionary)
		{
			double sum = 0;

			foreach (var item in dictionary)
			{
				sum += Math.Pow(item.Value - english[item.Key], 2);
			}

			return sum;
		}

		// Find Caesar shift
		private int FindOptimalCaesarShift(string text)
		{
			int optimal = 0;
			double smallestSum = -1;

			for (int shift = 0; shift < 26; shift++)
			{
				// TODO
				string encipheredText = CaesarEncipher(text, shift);
				Dictionary<string, double> letterFrequencies = english;
				Dictionary<string, double> frequencies = CountLetterFrequency(encipheredText);
				Dictionary<string, double> updatedDictionary = UpdateDictionary(frequencies);
				double sum = SquaredDifference(updatedDictionary);

				if (smallestSum == -1)
				{
					smallestSum = sum;
				}

				if (sum < smallestSum)
				{
					optimal = shift;
					smallestSum = sum;
				}
			}

			return optimal;
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
				int shift = FindOptimalCaesarShift(temp);

				if (shift == 0)
				{
					key.Add("A");
				}
				else
				{
					char letter = (char)('A' + 26 - shift);
					key.Add(letter.ToString());
				}
			}

			string result = String.Join("", key);
			return result;
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
