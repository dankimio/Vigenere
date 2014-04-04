﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
			string text = cipherTextBox.Text;
			string key;

			try
			{
				key = Vigenere.CrackKey(text, Convert.ToInt32(minUpDown.Value), Convert.ToInt32(maxUpDown.Value));
				keyTextBox.Text = key;
				resultTextBox.Text = Vigenere.Decipher(text, key);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}

		private void minUpDown_ValueChanged(object sender, EventArgs e)
		{
			if (minUpDown.Value >= maxUpDown.Value)
			{
				MessageBox.Show("Error");
				minUpDown.Value = maxUpDown.Value - 1;
			}
		}

		private void maxUpDown_ValueChanged(object sender, EventArgs e)
		{
			if (maxUpDown.Value <= minUpDown.Value)
			{
				MessageBox.Show("Error");
				maxUpDown.Value = minUpDown.Value + 1;
			}
		}
	}
}