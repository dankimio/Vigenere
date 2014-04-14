using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary;

namespace WindowsFormsApplication
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void analyzeButton_Click(object sender, EventArgs e)
		{
			try
			{
				string text = cipherTextBox.Text;
				string key;

				try
				{
					// Выбор направления (шифрование / дешифрование)
					if (decryptionRadioButton.Checked)
					{
						// Выбор действия:(если ключа нет, то выполнить анализ, при наличии ключа, дешифровать текст с данным ключом
						if (keyTextBox.Text == String.Empty)
						{

							// Выбран метод Касиски
							if (kasiskiBox.Checked)
							{
								int kMin = Kasiski.FindKeyLength(cipherTextBox.Text)[0];
								int kMax = Kasiski.FindKeyLength(cipherTextBox.Text)[1];

								minUpDown.Value = kMin;
								maxUpDown.Value = kMax;
								key = Vigenere.CrackKey(text, kMin, kMax);
							}
							else
							{
								key = Vigenere.CrackKey(text, Convert.ToInt32(minUpDown.Value), Convert.ToInt32(maxUpDown.Value));
							}

							keyTextBox.Text = key;
							resultTextBox.Text = Vigenere.Decipher(text, key);
						}
						else
						{
							string result = Vigenere.Decipher(cipherTextBox.Text, keyTextBox.Text);
							resultTextBox.Text = result;
						}
					}
					else
					{
						string result = Vigenere.Encipher(cipherTextBox.Text, keyTextBox.Text);
						resultTextBox.Text = result;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void minUpDown_ValueChanged(object sender, EventArgs e)
		{
			if (minUpDown.Value > maxUpDown.Value)
			{
				MessageBox.Show("Error");
				minUpDown.Value = maxUpDown.Value - 1;
			}
		}

		private void maxUpDown_ValueChanged(object sender, EventArgs e)
		{
			if (maxUpDown.Value < minUpDown.Value)
			{
				MessageBox.Show("Error");
				maxUpDown.Value = minUpDown.Value + 1;
			}
		}

		private void kasiskiBox_CheckedChanged(object sender, EventArgs e)
		{
			minUpDown.Enabled = !minUpDown.Enabled;
			maxUpDown.Enabled = !maxUpDown.Enabled;
			keyTextBox.Text = String.Empty;
		}

		private void decryptionRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			cipherLabel.Text = "Шифротекст";
			analyzeButton.Text = "Дешифровать";
		}

		private void encryptionRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			cipherLabel.Text = "Открытый текст";
			analyzeButton.Text = "Зашифровать";
		}

		private void cleanButton_Click(object sender, EventArgs e)
		{
			Clean();
		}

		private void enToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Vigenere.SetLanguage("en");
			UncheckAll();
			enToolStripMenuItem.Checked = true;
		}

		private void esToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Vigenere.SetLanguage("es");
			UncheckAll();
			esToolStripMenuItem.Checked = true;
		}

		private void deToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Vigenere.SetLanguage("de");
			UncheckAll();
			deToolStripMenuItem.Checked = true;
		}

		private void frToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Vigenere.SetLanguage("fr");
			UncheckAll();
			frToolStripMenuItem.Checked = true;
		}

		private void ptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Vigenere.SetLanguage("pt");
			UncheckAll();
			ptToolStripMenuItem.Checked = true;
		}

		private void UncheckAll()
		{
			foreach (var item in languageToolStripMenuItem.DropDownItems)
			{
				ToolStripMenuItem button = (ToolStripMenuItem)item;
				button.Checked = false;
			}
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clean();
		}

		private void Clean()
		{
			cipherTextBox.Text = String.Empty;
			resultTextBox.Text = String.Empty;
			keyTextBox.Text = String.Empty;
			minUpDown.Value = 5;
			maxUpDown.Value = 15;
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFileDialog.Filter = "Text documents|*.txt";
			saveFileDialog.FilterIndex = 2;
			saveFileDialog.RestoreDirectory = true;

			// В каталог исполняемого файла
			saveFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string path = saveFileDialog.FileName;
				File.WriteAllText(path, resultTextBox.Text);
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				var fileDialog = new OpenFileDialog
				{
					Filter = "Text documents|*.txt",
					Title = "Select a TXT File",
					InitialDirectory = AppDomain.CurrentDomain.BaseDirectory
				};

				if (fileDialog.ShowDialog() == DialogResult.OK)
				{
					FileInfo f = new FileInfo(fileDialog.FileName);
					if (f.Length > 1024 * 1024)
					{
						MessageBox.Show("Слишком большой файл. Могут возникнуть неполадки");
					}
					Clean();
					string path = fileDialog.FileName;
					cipherTextBox.Text = File.ReadAllText(path);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Дешифратор лозунгового ручного шифра\nна основе результатов подсчета частот\nбукв, биграмм и триграмм", "Дешифратор");
		}
	}
}
