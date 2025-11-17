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

namespace Metoder
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int _sum = 0;
        int _a = 10;
        int _b = 8;

        int fem = 5;
        int sex = 6;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SumOfTwoNumbers();
            MessageBox.Show($"{_sum}");

            // man kan visa upp resultat såhär också utan att spara i en variabel.
            // På rad 41 sparas istället värdet som returneras till en variabel.
            MessageBox.Show(SumOfTwoNumbersWithReturn(fem, sex).ToString());

            int showNumber;
            // man kan skicka in valfria ints här dvs heltal eftersom metoden
            // har int a, int b som parametrar se rad 59.
            showNumber = SumOfTwoNumbersWithReturn(17, 28);
            MessageBox.Show($"{showNumber}");

            // Testa att köra programmet! 
        }

        // OLIKA METODER

        // VOID

        // Här använder jag en metod som är void. Den skickar inte tillbaka något värde
        // men har tillgång till fält-variablar. Jag kallar metoden på rad 24 så när jag
        // klickar på knappen "BUTTON" räknas summan ut av _a + _b och visas i messagebox.

        private void SumOfTwoNumbers()
        {
            _sum = _a + _b;
        }

        // RETURN METHODS

        // Här har jag en metod som måste returnera en int(heltal).
        // Jag har tagit bort "private" här för att tydligöra att var
        // man anger vad metoden ska returnera eller skicka tillbaka.
        
        // Metoden tar in två parametrar a och b. Du kan själv välja dessa namn.
        // Namnen behöver inte vara samma som det du skickar in(se rad 36).
        // a och b är namnen de värden du skickar in kommer ha i själva metoden. (metodens låda)

        int SumOfTwoNumbersWithReturn(int a, int b)
        {
            int sum = 0;
            sum = a + b;
            return sum;
        }
    }
}