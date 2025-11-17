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
        private void VariablerOchDatatyperOchLoopar()
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

            // LOOPAR

            // Här loopar jag över nummerarrayn och fyller på med värden från
            // nummerarrayen på rad 33. Den kommer loopa så länge i är mindre än 
            // längden på arrayen.

            int[] treNummer = [1, 2, 3];
            int[] nummerArray = new int[3];

            // i ökar med ett steg varje varv.
            for (int i = 0; i < nummerArray.Length; i++)
            {
                nummerArray[i] = treNummer[i];
            }
        }

        // Varv 1 
        // i = 0;
        // nummerArray[0] = nioNummer[0] (dvs 1, det första värdet i arrayen)

        // Varv 2
        // i = 1
        // nummerarray[1] = nioNummer[1] (dvs 2, det andra värdet i arrayen)

        // Varv 3
        // i = 2
        // nummerarray[2] = nioNummer[2] (dvs 3, det tredje värdet i arrayen)

        // Varv 4
        // i = 3
        // Loopen stannar då i nu är större än nummerArryas längd som är 3.

        // DUBBLA LOOPAR

        // Man kan även ha en dubbel for-loop för att jämföra två arrayer t.ex
        // Här har jag lagt loopen i ett clcikevent som är kopplad till en knapp i gränssnittet
        // dvs det som användaren ser, den gröna stora knappen.

        // Med den dubbla for-loopen är det så fiffigt att i stannar på värdet 0
        // när programemt går vidare in i j-loopen. Då ökar bara j med 1 och i är hela
        // tiden 0. Då kan man t.ex jämföra arrayer som här

        // VARV 1
        // i = 0 (värde "Volvo")
        // j = 0 (värde "Opel")

        // Varv 2
        // i = 0 (värde "Vovlo")
        // j = 1 (värde "Saab"

        // Först när alla sex bilar i jonathansbilar gåtts igenom så ökar i till 1
        // och sen börjar det om igen fast med i=1, j=0, i=1, j=1, i=1, j=2. osv 

        private void ClickToCompareCars(object sender, RoutedEventArgs e)
        {
            //string[] eriksBilar = ["Volvo", "Bmv", "Fiat", "Opel"];
            //string[] jonathansBilar = ["Opel", "Saab", "Porsche", "Lada", "Mazda"];

            //for (int i = 0; i < eriksBilar.Length; i++)
            //{
            //    for (int j = 0; j < jonathansBilar.Length; j++)
            //    {
            //        if (eriksBilar[i] == jonathansBilar[j])
            //        {
            //            MessageBox.Show($"Jaså du har också en {jonathansBilar[j]}");
            //        }
            //    }
            //}
            //SayAName();
            //SayAName();
            //SayAName();
            //SayAName();
            //SayAName();
            //string greeting = WriteAName();
            //textBox.Text = greeting;
            test();
        }

        // Istället för att lägga all kod i clickeventet ovanför så kan du skriva en egeen kod och aktivera 
        // genom att kalla metoden. På rad 102 kallar jag på metoden SayAName(). Då körs koden som 
        // finns inom SayANames scope, markerat med vita linjer. (OKEJ LÅDAN!). Test kör programmet
        // och klicka på "KNAPP".

        private void SayAName()
        {
            MessageBox.Show("LOVE!");
        }

        // Du kan också retuerna variablar från metoder. Här skickar jag med strängen hello.
        // Som du ser på rad 103 och 104 så kan jag lagra det som metoden returnerar i en variabel
        // och sen visa upp den som här eller göra vad jag vill med den.
        // ska du returnera något måste du byta ut "void" före metodens namn mot datatypen du vill
        // skicka med se "private string" här nedanför.

        private string WriteAName()
        {
            string hello = "Love säger hallå";
            return hello;
        }

        //bool isValidNumber()
        //{
        //    int tru = 10;
        //    bool test = true;
        //    if (tru < 3)
        //    {
        //        test = false;
        //    }
        //    return tru;
        //}

        private void test()
        {
            int test2;
            int test3;
            bool res;
            int a;
            string myStr = "120";
            res = int.TryParse(myStr, out a);
            test2 = a;
            MessageBox.Show("String is a numeric representation: " + res);
        }

    }
}