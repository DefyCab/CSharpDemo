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


        public MainWindow()
        {
            InitializeComponent();
        }
    }
}