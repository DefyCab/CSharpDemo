/* Högst upp specifieras vilka andra resurser din kod
 * använder. Dessa ger oss tillgång till färdiga lösningar
 * till vanliga problem!
 */
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

/* Namespace
 * Organiserar relaterade klasser på ett ställe,
 * Namespace har samma namn som projektet, alla filer
 * ligger i samma "folder" = Namespace.
 * Olika program kan identifieras genom olika Namespace
 * om de har samma namn.
 * All kod du skriver kommer att falla inom Namespace "ramen"
 * som visas med { }.
 * { visar var det startar.
 * } visar vart det slutar.
 */
namespace BasicStructure
{
    /* MainWindow - Class
     * En klass är en mall för ett objekt.
     * Den beskriver vad objektet är och
     * vad det kan göra.
     * 
     * En klass har egenskaper (variabler) och
     * beteenden (metoder) för objektet som klassen
     * beskriver.
     * 
     * All kod för objektet måste ligga innom
     * klassens {} ram.
     * 
     * Du ska inte skriva kod utanför!
     */
    public partial class MainWindow : Window
    {
        /* MainWindow - Method
         * en metod som skapas automatiskt och hanterar
         * det som behövs för att koppla det grafiska
         * fönstret till koden bakom.
         * 
         * InitializeComponent() är det som kopplar ihop
         * allt mellan de två sidorna. Vilka knappar eller
         * textrutor som ska visas och hur de kommer åt koden.
         * 
         * Detta ska alltid vara den första raden i MainWindow.
         * 
         * Annan kod som ska hända en gång direkt när programmet
         * startar kan komma här i MainWindow efter InitializeComponent().
         */

        // variabler som deklareras här syns av alla metoder!
        // dessa är instansvariabler

        public MainWindow()
        {
            InitializeComponent(); // <--- Rör aldrig!!


            // om du deklarerar variabler här, syns de bara inom
            //  MainWindow metoden! De är lokala till denna metod.
        }

        /* Egna metoder kan läggas till här, inom MainWindow klassen.
         * Det kan vara för knappar, eller metoder som gör andra saker.
         * En miniräknare kanske har en metod för varje matematiska operation.
         */

        // 1      2       3      4
        private void MinEgnaMetod()// Det här är en egen metod, alla metoder man gör
        {                          // måste ha vissa komponenter.
                                   // 1. tillgänglighet.
                                   // 2. vad metoden ger tillbaka.
                                   // 3. Ett unikt namn.
        }                          // 4. inputs, en metod kan ta in data

        /* 1.
         * Precis som med variabler så har metoder olika tillgänglighetsnivåer
         * Det finns ett antal, men de tre vanligaste är:
         * Private: Kan bara kallas av kod i samma klass eller subklasser av den klassen.
         * Internal: All kod i samma Assembly kan kalla på den.
         * Public: All kod oberoende av Assembly kan kalla på den.
         * 
         * 2.
         * Metoder kan skicka data tillbaka till den som kallade på den, eller så
         * kan den helt enkelt utföra en viss uppgift. Det finns här två val:
         * void: signalerar att ingen data skickas tillbaka, metoden utför bara sin kod.
         * en datatyp: den typ av data som kommer att skickas tillbaka.
         *          exempelvis: private int SkickarEttNummerTillbaka()
         *          
         * 3.
         * Namnet måste vara unikt för att identifiera de olika metoderna och variablerna.
         * Namnet ska beskriva det som metoden ska göra, det ska inte vara oklart.
         * 
         * 4.
         * Vissa metoder kan ta in data som behövs för att de ska utföra sin uppgift, det kan
         * specifieras inom paranteserna.
         *          exempelvis: private void RäknaBokstäverIEttNamn(string namn)
         *          Den metoden ska räkna bokstäver i ett visst namn, vi specifierar då
         *          att metoden tar in en variabel av typ string med namn "namn".
         */

    }
}