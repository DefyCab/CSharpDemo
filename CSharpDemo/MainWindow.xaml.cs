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

namespace CSharpDemo
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //I variabler kan man lagra värden.
        private void VariablerOchDatatyper()
        {
            int heltal = 10;
            double decimaltal = 10.3;
            string text = "Jag är en sträng med text";
            bool sant_eller_falskt = true;

            // ARRAY
            // Om du vill lagra fler än en variabel använder du en array.
            int[] nummer = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            double[] decimalnummer = [1.1, 2.2, 3.4, 5.4];
            string[] personer = ["Love", "Tom", "Sven", "Kurt", "Bilal", "Natahlie"];
            bool[] check = [true, false, true, false];

            // om du vill ha en tom array med 10 platser så skriver du
            int[] emptyNumbersArray = new int[10];
            string[] emptyStringArray = new string[10];

        }

    }
}