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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> lines = ReadLinesFromFile("yourfile.txt");

        }
        private List<string> ReadLinesFromFile(string filePath)
        {
            List<string> lines = new List<string>();


            try
            {
                // Read all lines from the file and add them to the list
                string[] fileLines = File.ReadAllLines(filePath);
                lines.AddRange(fileLines);
            }
            catch (IOException e)
            {
                MessageBox.Show($"Error reading file: {e.Message}", "File Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return lines;
        }
private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void answer3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void answer4_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
