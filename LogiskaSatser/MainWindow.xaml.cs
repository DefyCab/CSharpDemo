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
         * 2. switch-case
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
        *          Den logiska satsen kan vara enkel eller komplex.
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
        }
    }
}