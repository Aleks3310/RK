using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _21._101_Mysin_Variant2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Start_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				string sentence = tb1.Text;
				string word = "";
				string[] words = sentence.Split(' ');
				int count = 0;
				string vowels = "aeiouyAEIOUY";
				foreach (char ch in sentence)
				{
					for (int i = 0; i < vowels.Length; i++)
					{
						if (ch == vowels[i])
						{
							count++;
						}
					}
				}
				l_num.Content = count;
				foreach (string w in words)
				{
					if (w.Length > word.Length)
					{
						word = w;
					}
				}
				l_word.Content = word;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Произошла ошибка!" + "\n" + ex.Message);
			}
		}
	}
}
