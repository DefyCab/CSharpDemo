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

namespace LogiskaSatser
{
    public partial class MainWindow : Window
    {
        #region Logiska Operatorer
        /* Logik är en stor del av hur programmet vet vad som ska hända
         * Vi har därför tillgång till ett antal olika Logiska Satser
         * och Operatorer.
         * 
         * Logiska satser och operatorer ger programmet svar som antingen
         * är true (ja), eller false (nej). Beroende på vilket svar som ges
         * så kan programmet gå olika vägar.
         * 
         * De logiska operatorerna är:
         * 
         *  == : EQUALITY. Kollar om båda sidorna är lika.
         *          10 == 5 ger false.
         *          
         *          int x = 5, y = 5;
         *          x == y ger true.
         *          
         *  > : Kollar om det vänstra värdet är större än det högra.
         *          10 > 5 ger true.
         *          
         *          int x = 5, y = 5;
         *          x > y ger false.
         *  
         *  >= : Kollar om det vänstra värdet är större eller lika med än det högra.
         *          10 >= 5 ger false.
         *          
         *          int x = 5, y = 5;
         *          x > y ger true.
         *  
         *  < : Kollar om det vänstra värdet är mindre än det högra.
         *          10 < 5 ger false.
         *          
         *          int x = 3, y = 5;
         *          x < y ger true.
         *          
         *  <= : Kollar om det vänstra värdet är mindre eller lika med än det högra.
         *          5 <= 10 ger true.
         *          
         *          int x = 5, y = 5;
         *          x < y ger true.
         *          
         *  && : Betyder AND och används för att kolla två (eller fler) olika logiska
         *          satser sammtidigt. Ger true bara om alla delar är true.
         *          
         *          int x = 5, y = 5;
         *          x >= y && x < y ger false.
         *           true  && false ger false.
         *           
         *          x >= y && x <= y ger true.
         *           true  &&  true ger true.
         *           
         *  || : Betyder OR och används för att kolla två (eller fler) olika logiska
         *          satser sammtidigt. Ger true om minst en av alla delar är true.
         *          
         *          int x = 5, y = 5;
         *          x >= y || x < y ger true.
         *           true  && false ger true.
         *           
         *           int x = 5, y = 5;
         *          x > y && x < y ger false.
         *          false && false ger false.
         *  
         *  ! : Betyder NOT och används för att kolla det negativa av en sats.
         *      Man kan tänka att den ger tillbaka det motsatta.
         *       
         *          !true ger false.
         *          !false ger true.
         *          
         *          int x = 5, y = 10;
         *          !(x > y) ger true. Den kollar om NOT(x större än y).
         *  
         *  != : INEQUALITY. Kollar om vänster sida INTE är samma som höger.
         *          
         *          int x = 5, y = 5;
         *          x != y ger false.
         *          
         *          int x = 4, y = 5;
         *          x != y ger true.
         */
        #endregion Logiska Operatorer

        #region Logiska Satser
        /* För att se exempel så behöver vi känna till Logiska Satser med:
         * 
         * 1. if-else if-else
         * 2. switch-case (COMING SOON)
         */

        #region if-else if-else
        /* 1.       if säger till programmet att den ska utvärdera en logisk sats.
        *          om satsen värderas till true så kan koden i if-satsen läsas.
        *          om satsen värderas till false så går programmet vidare till
        *            slutet av if-satsen utan att gå in.
        *                
        *                if(logisk sats)       
        *                {
        *                    Kod att utföra
        *                }
        *          
        *          Den logiska satsen kan vara enkel eller komplex (vi tar komplexa längre ner).
        *                
        *                int x = 7, y = 13;
        *                    if(x > y)     här blir resultatet false, så programmet
        *                                      går inte in.
        *                    if(y > x)     här blir resultatet true, så programmet
        *                                      går in och läser av koden.
        *                                
        *          if-satser kan kolla om ett obegränsat antal logiska satser är
        *           true eller false. else if kan användas för att utvärdera en
        *           till sats.
        *                
        *                if(logisk sats)                | Om denna är false..
        *                {                              |
        *                    Kod att utföra             | så skippas denna kod, och..
        *                }                              |
        *                else if(en annan logisk sats)  | Denna sats utvärderas.
        *                {                              
        *                    Kod om denna sats är true  
        *                }
        *           
        *           else if-satser värderas bara om if-satsen är false och om det finns
        *           fler else if-satser så går programmet igenom dem i ordning. Det kan 
        *           därför vara viktigt att välja ordningen man skriver dem i.
        *           
        *                if( 1 < 2)          | Denna är true så..
        *                else if ( 2 > 1)    | ..denna syns aldrig.
        *                
        *                if ( 1 > 2)         |
        *                else if ( 2 < 3)    | Nu är den första else if true..
        *                else if ( 1 < 2)    | ..så den andra syns aldrig.
        *                
        *            Om man vill fånga in ett fall där if-satsen inte är true, men
        *            man inte bryr sig om detaljerna så kan man i slutet ha en 
        *            else-sats utan något logiskt uttryck.
        *            
        *            if (x > y)
        *            {
        *                true kod
        *            }
        *            else
        *            {
        *                kod här händer alltid om if-satsen är false!
        *            }
        *            
        *            Man kan ha hur många else if-satser som man vill mellan
        *            if och else.
        */
        #endregion if-else if-else

        #endregion Logiska Satser

        public MainWindow()
        {
            InitializeComponent();

            // EXEMPEL 1 | enkel if-sats som kollar en boolean

            bool isItRaining = true;

            if (isItRaining) // här kollar programmet om isItRaining är true eller false
            {
                MessageBox.Show("Ta med ett paraply!"); // eftersom att det är true, händer detta
            }
            else // och else-satsen kolla aldrig!
            {
                MessageBox.Show("Sun's out, guns out!"); // denna messagebox visas bara om if(false)!
            }

            // EXEMPEL 2 | if - else if - else

            // kolla igenom koden under, vad tror du kommer hända?

            int score = 69;

            if(score >= 90)
            {
                MessageBox.Show("Wow!");
            }
            else if (score >= 70)
            {
                MessageBox.Show("bra jobbat!");
            }
            else
            {
                MessageBox.Show("Nja, kanske plugga lite mer!");
            }

            // eftersom att score är mindre än både 90 och 70 så visar de false och
            // programmet går in i else, som alltid händer om programmet når den.

            // EXEMPEL 3 | Mer komplext villkår med && eller ||

            // vad kommer programmet att göra?

            int temperatureOutside = 22;
            isItRaining = false;

            if (temperatureOutside < 20 || isItRaining == true)
            {
                MessageBox.Show("kanske stannar hemma..");
            }
            else if (temperatureOutside > 20 && isItRaining == false)
            {
                MessageBox.Show("Köpa glass?");
            }

            /* Nu är temperaturen 22 graden, och det regnar inte.
             *   den försa satsen koller om: temperatur mindre än 20
             *    ELLER det regnar.
             *   Det krävs bara att en av de två är true för att programmet
             *   ska gå in..
             *   Men eftersom att båda blir false i det här fallet så går programmet
             *   vidare till else if-satsen.
             *   Här måste båda villkåren vara true för att koden ska läsas.. och 
             *   som tur så är det så!
             */

            // EXEMPEL 4 | Nästade if:s!

            // det kanske ser läskigt ut, men läs igenom och försök att förstå vad som kommer
            //  att hända.

            string userRole = "Admin";
            bool hasSuperAccess = false;

            if (userRole == "Admin")
            {
                MessageBox.Show("Välkommen, administratör!");

                if (hasSuperAccess) // eftersom en boolean variabel redan är true eller false
                {                   //   så behöver man inte skriva ut == true/false!
                    MessageBox.Show("Du har full behörighet!");
                }
                else
                {
                    MessageBox.Show("Du har begränsad behörighet.");
                }
            }
            else
            {
                MessageBox.Show("Välkommen, standardanvändare.");
            }

            /* när man har en if inuti en annan if kallas "nästade if:s". Det används vanligtvis
             * för att kolla relaterade men mer specifika villkår ju djupare man går.
             * 
             * I vårat fall så kollar den första om man har "Admin" som roll och visar ett Admin
             * medelande om det är sannt. Annars får användaren ett vanligt medelande.
             * 
             * i exemplet så är användaren Admin, så programmet går in!
             * 
             * Inuti finns en till if-sats, som kollar om en Admin också har SuperAccess. Den checken
             * kan bara hända om man redan är Admin!
             * 
             * Om man har SuperAccess så får man full kontrol, annars har man begränsad behörighet.
             * 
             * Vår användare har Admin men inte SuperAccess, så hen kommer inte in i den nästade
             * if-satsen.
             */
        }
    }
}