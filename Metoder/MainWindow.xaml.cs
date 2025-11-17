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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SumOfTwoNumbers();
            MessageBox.Show($"{_sum}");
        }

        // OLIKA METODER

        // VOID

        // Här använder jag en metod som är void. Den skickar inte tillbaka något värde
        // men har tillgång till fält-variablar. Jag kallar metoden på rad 24 så när jag
        // klickar på knappen "BUTTON" räknas summan ut av _a + _b och visas i messagebox.

        int _sum = 0;
        int _a = 10;
        int _b = 5;

        private void SumOfTwoNumbers()
        {
            _sum = _a + _b;
        }

        // RETURN METHODS
    }
}