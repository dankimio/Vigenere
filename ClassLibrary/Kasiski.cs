using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class Kasiski
	{
		public static int[] FindKeyLength(string source)
		{
			string text = ClearFormatting(source);
			return GetLengthInterval(CountFactors(text));
		}

		/// <summary>
		/// Метод удаляет все ненужные символы из текста (пробелы, символы) и приводит к прописным буквам
		/// </summary>
		/// <param name="s">Исходный текст</param>
		/// <returns>Подготовленный текст</returns>
		static string ClearFormatting(string s)
		{
			string result = "";
			foreach (char c in s) {
				if (Char.IsLetter(c)) {
					result += c;
				}
			}
			return result.ToUpper();
		}

		/// <summary>
		/// Метод находит все n-граммы, подсчитывает расстояние между ними и находит все делители расстояния
		/// </summary>
		/// <param name="aText">Текст</param>
		static Dictionary<int, int> CountFactors(string aText)
		{
			Dictionary<int, int> factors = new Dictionary<int, int>();

			for (int ngramLength = 3; ngramLength <= 4; ngramLength++) {
				for (int i = 0; i < aText.Length - ngramLength; i++) {
					string sub = aText.Substring(i, ngramLength);
					for (int j = i + 1; j <aText.Length - ngramLength; j++) {
						string subSub = aText.Substring(j, ngramLength);
						if (subSub.Equals(sub)) {
							var test = Factors(j - i);
							foreach (int f in test) {
								if (factors.ContainsKey(f))
									factors[f]++;
								else
									factors.Add(f, 1);
							}
						}
					}
				}
			}
			return factors;
		}

		static int[] GetLengthInterval(Dictionary<int, int> d)
		{
			var sorted = (from entry in d orderby entry.Value descending select entry).ToDictionary(entry => entry.Key, entry => entry.Value);

			// Исключаем 1 и 2 по причине высокого числа случайных совпадений
			sorted.Remove(1);
			sorted.Remove(2);

			int[] interval = new int[2];

			int i = 0;
			foreach(var pair in sorted) {
				if (i == 2)
					break;
				interval[i] = pair.Key;
				i++;
			}

			Array.Sort(interval);
			return interval;
		}

		/// <summary>
		/// Метод, находящий все делители числа
		/// </summary>
		/// <param name="number">Число</param>
		/// <returns>Список всех делителей</returns>
		static List<int> Factors(int number)
		{
			List<int> factors = new List<int>();
			for (int i = 2; i <= number; i++) {
				if (number % i == 0) {
					factors.Add(i);
				}
			}
			return factors;
		}
	}
}
