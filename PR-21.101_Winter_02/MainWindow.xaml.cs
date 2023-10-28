using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
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

namespace PR_21._101_Winter_02
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
          
        }

        private void BUT1_Click(object sender, RoutedEventArgs e)
        {
            //Проверка что введено предложение на английском языке
            string input = TB1.Text;    
            string pattern = @"^[A-Za-z0-9\s.,;!?]+$";
            bool isEnglish = Regex.IsMatch(input, pattern);

            if (isEnglish)
            {
                //Подсчёт количества глассных букв
                string sentence = TB1.Text.ToLower();
                int vowelCount = 0;

                foreach (char c in sentence)
                {
                    if ("aeiou".Contains(c))
                    {
                        vowelCount++;
                    }
                }

                lab1.Content = $" {vowelCount}";

                //Нахождение самого длинного слова
                string pred = TB1.Text;
                string[] words = pred.Split(' ');
                string longestWord = "";

                foreach (string word in words)
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }

                lab2.Content = $" {longestWord}";
            }
            else
            {
                MessageBox.Show("Введите предложение на английском языке!");
            }
        }
    }
}
