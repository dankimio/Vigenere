using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	/// <summary>
	/// Класс, содержащий методы для дешифровки
	/// </summary>
    public class Vigenere
    {
		// Index of coincidence
		static double ioc = 0.0667;

		// Данные частотного анализа
		static Dictionary<string, double> english = new Dictionary<string, double>()
		{
			{"A", 8.167}, {"B", 1.492},	{"C", 2.782}, {"D", 4.253},
			{"E", 12.702}, {"F", 2.228}, {"G", 2.015}, {"H", 6.094},
			{"I", 6.996}, {"J", 0.153},	{"K", 0.772}, {"L", 4.025},
			{"M", 2.406}, {"N", 6.749}, {"O", 7.507}, {"P", 1.929},
			{"Q", 0.095}, {"R", 5.987},	{"S", 6.327}, {"T", 9.056},
			{"U", 2.758}, {"V", 0.978}, {"W", 2.360}, {"X", 0.150},
			{"Y", 1.974}, {"Z", 0.074},	{"maxValue", 12.702}, {"ioc", 0.0667}
		};

		/// <summary>
		/// Шифрование текста с использованием ключа
		/// </summary>
		/// <param name="text">Открытый текст</param>
		/// <param name="key">Ключ</param>
		/// <returns>Шифротекст</returns>
		public static string Encipher(string text, string key)
		{
			List<char> cipherText = new List<char>();
			int position = 0;
			int keyLength = key.Length;

			for (int i = 0; i < text.Length; i++)
			{
				// Буква открытого текста
				char letter = text[i];

				// Если символ не буква, то присоединить к результату без изменений
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

		/// <summary>
		/// Дешифровка с использованием ключа
		/// </summary>
		/// <param name="text">Шифротекст</param>
		/// <param name="key">Ключ</param>
		/// <returns>Открытый текст</returns>
		public static string Decipher(string text, string key)
		{
			List<char> plainText = new List<char>();
			int position = 0;
			int keyLength = key.Length;

			for (int i = 0; i < text.Length; i++)
			{
				// Символ шифротекста
				char letter = text[i];

				// Если символ не буква, то присоединить к результату без изменений
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

		/// <summary>
		/// Шифрование текста с использованием шифра Цезаря
		/// </summary>
		/// <param name="text">Открытый текст</param>
		/// <param name="key">Ключ</param>
		/// <returns>Шифротекст</returns>
		static string CaesarEncipher(string text, int key)
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

		/// <summary>
		/// Частотный анализ текста
		/// </summary>
		/// <param name="text">Текст</param>
		/// <returns>Словарь (ключ - буква, значение - количество попаданий)</returns>
		static Dictionary<string, double> CountLetterFrequency(string text)
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
		/// <summary>
		/// Добавление индекса совпадений вместо количества попаданий в качестве значения словаря
		/// </summary>
		/// <param name="dictionary">Словарь с частотным анализом</param>
		/// <returns>Словарь с индексом совпадений</returns>
		static Dictionary<string, double> UpdateDictionary(Dictionary<string, double> dictionary)
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

		/// <summary>
		/// Отклонение от статистического значения частотности букв в квадрате (чтобы избежать отрицательных значений)
		/// </summary>
		/// <param name="dictionary">Словарь с индексом совпадений</param>
		/// <returns></returns>
		static double SquaredDifference(Dictionary<string, double> dictionary)
		{
			double sum = 0;

			foreach (var item in dictionary)
			{
				sum += Math.Pow(item.Value - english[item.Key], 2);
			}

			return sum;
		}

		/// <summary>
		/// Поиск сдвига для шифра Цезаря с использованием частотного анализа
		/// </summary>
		/// <param name="text">Открытый текст</param>
		/// <returns>Ключ (сдвиг)</returns>
		static int FindOptimalCaesarShift(string text)
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

		/// <summary>
		/// Получение каждого n-ного символа текста
		/// </summary>
		/// <param name="text">Текст</param>
		/// <param name="start">Начальная позиция</param>
		/// <param name="n">n</param>
		/// <returns>Строка, содержащая каждый n-ный символ текста</returns>
		static string GetEveryNthChar(string text, int start, int n)
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

		/// <summary>
		/// Сдвиг текста на n позиций вправо, символы с конца идут в начало текста
		/// </summary>
		/// <param name="text">Текст</param>
		/// <param name="n">n</param>
		/// <returns>Текст со сдвигом n</returns>
		static string RotateRight(string text, int n)
		{
			// %
			int cuttingPoint = text.Length - (n % text.Length);
			// TODO Check
			return text.Substring(cuttingPoint) + text.Substring(0, cuttingPoint);
		}

		/// <summary>
		/// Нахождение длины ключа
		/// </summary>
		/// <param name="text">Шифротекст</param>
		/// <param name="minLength">Минимальная длина ключа</param>
		/// <param name="maxLength">Максимальная длина ключа</param>
		/// <returns>Длина ключа</returns>
		static int FindKeyLength(string text, int minLength, int maxLength)
		{
			int keyLength = minLength;

			// Индекс совпадений (Index of coincidence, IOC)
			List<double> iocs = new List<double>();

			// Получение индекса совпадений для каждой длины ключа
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

			// Нахождение ближайшего индекса совпадений. Если два индекса совпадают, то выбрать индекс с наименьшим ключом.
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

		/// <summary>
		/// Нахождение ключа
		/// </summary>
		/// <param name="text">Шифротекст</param>
		/// <param name="minLength">Минимальная длина ключа</param>
		/// <param name="maxLength">Максимальная длина ключа</param>
		/// <returns>Ключ</returns>
		public static string FindKey(string text, int minLength, int maxLength)
		{
			// Текст, содержащий только буквы
			List<char> accumulator = new List<char>();

			// Удаление небуквенных символов из текста
			foreach (char ch in text)
			{
				if (Char.IsLetter(ch))
				{
					accumulator.Add(ch);
				}
			}

			string lettersOnly = String.Join("", accumulator);
			int keyLength = FindKeyLength(lettersOnly, minLength, maxLength);

			List<string> key = new List<string>();

			for (int i = 0; i < keyLength; i++)
			{
				string temp = GetEveryNthChar(lettersOnly, i, keyLength);
				// Оптимальный сдвиг для шифра Цезаря
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

		/// <summary>
		/// Взлом шифра с указанной длиной
		/// </summary>
		/// <param name="text">Шифротекст</param>
		/// <param name="minLength">Минимальная длина ключа</param>
		/// <param name="maxLength">Максимальная длина ключа</param>
		/// <returns>Ключ</returns>
		public static string CrackKey(string text, int minLength = 5, int maxLength = 15)
		{
			if (minLength < 1)
				throw new System.ArgumentException("Минимальная длина ключа должна быть больше нуля");
			if (maxLength < 1)
				throw new System.ArgumentException("Максимальная длина ключа должна быть больше нуля");
			if (minLength > maxLength)
				throw new System.ArgumentException("Минимальная длина ключа должна быть меньше максимальной");
			if (maxLength < minLength)
				throw new System.ArgumentException("Максимальная длина ключа должна быть больше минимальной");
			if (text.Length == 0)
				throw new System.ArgumentException("Пустой текст");
			if (text.Length < maxLength)
				throw new System.ArgumentException("Слишком короткий текст");
			
			bool hasLetters = false;

			foreach (char ch in text)
			{
				if (Char.IsLetter(ch))
					hasLetters = true;
			}

			if (!hasLetters)
				throw new System.ArgumentException("В тексте отсутствуют буквы");

			return FindKey(text, minLength, maxLength);
		}

		/// <summary>
		/// Деление по модулю. В C# оператор '%' используется для нахождения остатка, однако в данном случае необходим оператор деления по модулю
		/// </summary>
		/// <param name="a">Операнд 1</param>
		/// <param name="b">Операнд 2</param>
		/// <returns></returns>
		static int Modulo(int a, int b)
		{
			return (Math.Abs(a * b) + a) % b;
		}
    }
}
