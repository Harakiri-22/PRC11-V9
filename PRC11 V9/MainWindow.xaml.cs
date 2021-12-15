using System;
using System.Collections.Generic;
using System.Linq;
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

namespace PRC11_V9
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

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Мишин Д.А. ИСП-34", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            listBoxNumbers.Items.Clear();
        }

        private void FindingTheFirstLine_Click(object sender, RoutedEventArgs e)
        {
            listBoxNumbers.Items.Clear();
            string lineNumberOne = firstLine.Text;

            Regex regex = new Regex(@"\b2\+*\+3\b"); //строку 2+3, не захватив остальные
            MatchCollection match = regex.Matches(lineNumberOne);

            object[] array = new object[match.Count];
            match.CopyTo(array, 0);

            for (int i = 0; i < match.Count; i++)
            {
                listBoxNumbers.Items.Add(match[i]);
            }
        }

        private void FindingTheSecondLine_Click(object sender, RoutedEventArgs e)
        {
            listBoxNumbers.Items.Clear();
            string lineNumberTwo = secondLine.Text;

            Regex regex = new Regex(@"a(b{2,4})a"); //строки abba, abbba, abbbba и только их
            MatchCollection match = regex.Matches(lineNumberTwo);

            object[] array = new object[match.Count];
            match.CopyTo(array, 0);

            for (int i = 0; i < match.Count; i++)
            {
                listBoxNumbers.Items.Add(match[i]);
            }
        }
    }
}
