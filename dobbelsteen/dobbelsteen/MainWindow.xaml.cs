using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dobbelsteen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();

        int diceResult;
        int currentThrow;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            while (diceResult != 6)
            {
                diceResult = rnd.Next(1, 7);
                currentThrow += 1;

                resultTextBox.Text = (resultTextBox.Text + $"Worp {currentThrow} geeft {diceResult}\n");
            }
        }

        private void againButton_Click(object sender, RoutedEventArgs e)
        {
            diceResult = 0;
            currentThrow = 0;

            resultTextBox.Clear();
            startButton.Focus();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}