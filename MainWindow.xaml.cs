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

namespace _184784ForstringExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            String myWord = "Hello";
            String output = "";

            for(int i = 0; i < myWord.Length; i++)
            {
                output += myWord[i].ToString()
                    + Environment.NewLine;
            }
            lblOutput.Content = output +
                Environment.NewLine + myWord;
        }
    }
}
