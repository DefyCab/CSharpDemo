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

        //I variabler kan man lagra värden. Variabel har ett namn, en datatyp och ett värde.
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

            // Om du vill ha en tom array med specificerat antal platser så skriver du
            int[] emptyNumbersArray = new int[10]; // en tom array med tio lagringsplatser.
            string[] emptyStringArray = new string[5];

            // Arrays är indexerade. Det första värdet har index 0.
            // Vill du komma åt 1:an i arrayen nummer så kan du skriva nummer[0]

            // lagra ett nummer från en array i ny variabel

            int ny = nummer[0]; // ny får värdet 1 (index 0 motsvarar första värdet i arrayen)
            int ny2 = nummer[2]; // nu får värdet 3 (index 2 motsvarar tredje värdet i arrayen)


        }

    }
}