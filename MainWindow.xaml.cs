using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Connect4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            
            
        }

        //Switch um Buttons zu verstecken/enthüllen
        bool Switch =false;

        //resetSwitch um nochmal zu Spielen,wenn jemand gewonnen hat

        bool resetSwitch = false;
        //Farbe für den Spielerwechsel
        Brush Farbe = Brushes.Red;

        //Zweidimensionales Array um die Werte zu speichern
        Brush[,] SpielFeld = { { Brushes.White, Brushes.White, Brushes.White, Brushes.White, Brushes.White, Brushes.White, },
                               { Brushes.White, Brushes.White, Brushes.White, Brushes.White, Brushes.White, Brushes.White, },
                               { Brushes.White, Brushes.White, Brushes.White, Brushes.White, Brushes.White, Brushes.White, },
                               { Brushes.White, Brushes.White, Brushes.White, Brushes.White, Brushes.White, Brushes.White, },
                               { Brushes.White, Brushes.White, Brushes.White, Brushes.White, Brushes.White, Brushes.White, },
                               { Brushes.White, Brushes.White, Brushes.White, Brushes.White, Brushes.White, Brushes.White, },
                               { Brushes.White, Brushes.White, Brushes.White, Brushes.White, Brushes.White, Brushes.White, }
            };





        private void BeendenButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        //Wenn der StartButton geklickt wird
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (resetSwitch)
            {
                reset();
            }
            else
            {
                //Spielbuttons werden sichtbar
                if (!Switch)
                    SpielButton1.Opacity = 100;
                SpielButton2.Opacity = 100;
                SpielButton3.Opacity = 100;
                SpielButton4.Opacity = 100;
                SpielButton5.Opacity = 100;
                SpielButton6.Opacity = 100;
                SpielButton7.Opacity = 100;

                //Start/Ende Buttons werden unsichtbar
                StartButton.Opacity = 0;
                BeendenButton.Opacity = 0;

                //Text wird verändert

                Text.Text = "Spieler 1 ist dran";
                Text.Width = 175;
                Text.FontSize = 20;
                //Switch wird umgelegt
                Switch = true;
            }
        }

        #region Spielbuttons

        //Button für Spalte 1
        private void SpielButton1_Click(object sender, RoutedEventArgs e)
        {
            //Funktioniert nur, wenn der Switch umgelegt ist
            if (Switch)
            {
                if (SpielFeld[0, 5] == Brushes.White)
                {
                    SpielFeld[0, 5] = Farbe;
                    Ellipse06.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[0, 4] == Brushes.White)
                {
                    SpielFeld[0, 4] = Farbe;
                    Ellipse05.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[0, 3] == Brushes.White)
                {
                    SpielFeld[0, 3] = Farbe;
                    Ellipse04.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[0, 2] == Brushes.White)
                {
                    SpielFeld[0, 2] = Farbe;
                    Ellipse03.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[0, 1] == Brushes.White)
                {
                    SpielFeld[0, 1] = Farbe;
                    Ellipse02.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[0, 0] == Brushes.White)
                {
                    SpielFeld[0, 0] = Farbe;
                    Ellipse01.Fill = Farbe;
                    Spielerwechsel();
                }
                //Die Gewinnkondition wird überprüft
                Wincon();
            }
        }


        private void SpielButton2_Click(object sender, RoutedEventArgs e)
        {
            //Funktioniert nur, wenn der Switch umgelegt ist
            if (Switch)
            {
                if (SpielFeld[1, 5] == Brushes.White)
                {
                    SpielFeld[1, 5] = Farbe;
                    Ellipse12.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[1, 4] == Brushes.White)
                {
                    SpielFeld[1, 4] = Farbe;
                    Ellipse11.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[1, 3] == Brushes.White)
                {
                    SpielFeld[1, 3] = Farbe;
                    Ellipse10.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[1, 2] == Brushes.White)
                {
                    SpielFeld[1, 2] = Farbe;
                    Ellipse09.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[1, 1] == Brushes.White)
                {
                    SpielFeld[1, 1] = Farbe;
                    Ellipse08.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[1, 0] == Brushes.White)
                {
                    SpielFeld[1, 0] = Farbe;
                    Ellipse07.Fill = Farbe;
                    Spielerwechsel();
                }
                //Gewinnkondition wird überprüft
                Wincon();
            }
        }

        private void SpielButton3_Click(object sender, RoutedEventArgs e)
        {
            //Funktioniert nur, wenn der Switch umgelegt ist
            if (Switch)
            {
                if (SpielFeld[2, 5] == Brushes.White)
                {
                    SpielFeld[2, 5] = Farbe;
                    Ellipse18.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[2, 4] == Brushes.White)
                {
                    SpielFeld[2, 4] = Farbe;
                    Ellipse17.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[2, 3] == Brushes.White)
                {
                    SpielFeld[2, 3] = Farbe;
                    Ellipse16.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[2, 2] == Brushes.White)
                {
                    SpielFeld[2, 2] = Farbe;
                    Ellipse15.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[2, 1] == Brushes.White)
                {
                    SpielFeld[2, 1] = Farbe;
                    Ellipse14.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[2, 0] == Brushes.White)
                {
                    SpielFeld[2, 0] = Farbe;
                    Ellipse13.Fill = Farbe;
                    Spielerwechsel();
                }
                //Gewinnkondition wird überprüft
                Wincon();
            }
        }

        private void SpielButton4_Click(object sender, RoutedEventArgs e)
        {
            //Funktioniert nur, wenn der Switch umgelegt ist
            if (Switch)
            {
                if (SpielFeld[3, 5] == Brushes.White)
                {
                    SpielFeld[3, 5] = Farbe;
                    Ellipse24.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[3, 4] == Brushes.White)
                {
                    SpielFeld[3, 4] = Farbe;
                    Ellipse23.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[3, 3] == Brushes.White)
                {
                    SpielFeld[3, 3] = Farbe;
                    Ellipse22.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[3, 2] == Brushes.White)
                {
                    SpielFeld[3, 2] = Farbe;
                    Ellipse21.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[3, 1] == Brushes.White)
                {
                    SpielFeld[3, 1] = Farbe;
                    Ellipse20.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[3, 0] == Brushes.White)
                {
                    SpielFeld[3, 0] = Farbe;
                    Ellipse19.Fill = Farbe;
                    Spielerwechsel();
                }
                //Gewinnkondition wird überprüft
                Wincon();
            }
        }

        private void SpielButton5_Click(object sender, RoutedEventArgs e)
        {
            //Funktioniert nur, wenn der Switch umgelegt ist
            if (Switch)
            {
                if (SpielFeld[4, 5] == Brushes.White)
                {
                    SpielFeld[4, 5] = Farbe;
                    Ellipse30.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[4, 4] == Brushes.White)
                {
                    SpielFeld[4, 4] = Farbe;
                    Ellipse29.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[4, 3] == Brushes.White)
                {
                    SpielFeld[4, 3] = Farbe;
                    Ellipse28.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[4, 2] == Brushes.White)
                {
                    SpielFeld[4, 2] = Farbe;
                    Ellipse27.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[4, 1] == Brushes.White)
                {
                    SpielFeld[4, 1] = Farbe;
                    Ellipse26.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[4, 0] == Brushes.White)
                {
                    SpielFeld[4, 0] = Farbe;
                    Ellipse25.Fill = Farbe;
                    Spielerwechsel();
                }
                //Gewinnkondition wird überprüft
                Wincon();
            }
        }

        private void SpielButton6_Click(object sender, RoutedEventArgs e)
        {
            //Funktioniert nur, wenn der Switch umgelegt ist
            if (Switch)
            {
                if (SpielFeld[5, 5] == Brushes.White)
                {
                    SpielFeld[5, 5] = Farbe;
                    Ellipse36.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[5, 4] == Brushes.White)
                {
                    SpielFeld[5, 4] = Farbe;
                    Ellipse35.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[5, 3] == Brushes.White)
                {
                    SpielFeld[5, 3] = Farbe;
                    Ellipse34.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[5, 2] == Brushes.White)
                {
                    SpielFeld[5, 2] = Farbe;
                    Ellipse33.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[5, 1] == Brushes.White)
                {
                    SpielFeld[5, 1] = Farbe;
                    Ellipse32.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[5, 0] == Brushes.White)
                {
                    SpielFeld[5, 0] = Farbe;
                    Ellipse31.Fill = Farbe;
                    Spielerwechsel();
                }
                //Gewinnkondition wird überprüft
                Wincon();
            }
        }

        private void SpielButton7_Click(object sender, RoutedEventArgs e)
        {
            //Funktioniert nur, wenn der Switch umgelegt ist
            if (Switch)
            {
                if (SpielFeld[6, 5] == Brushes.White)
                {
                    SpielFeld[6, 5] = Farbe;
                    Ellipse42.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[6, 4] == Brushes.White)
                {
                    SpielFeld[6, 4] = Farbe;
                    Ellipse41.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[6, 3] == Brushes.White)
                {
                    SpielFeld[6, 3] = Farbe;
                    Ellipse40.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[6, 2] == Brushes.White)
                {
                    SpielFeld[6, 2] = Farbe;
                    Ellipse39.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[6, 1] == Brushes.White)
                {
                    SpielFeld[6, 1] = Farbe;
                    Ellipse38.Fill = Farbe;
                    Spielerwechsel();
                }
                else if (SpielFeld[6, 0] == Brushes.White)
                {
                    SpielFeld[6, 0] = Farbe;
                    Ellipse37.Fill = Farbe;
                    Spielerwechsel();
                }
                //Gewinnkondition wird überprüft
                Wincon();
            }
        }
        #endregion

        #region Methoden
        //Spielerwechsel
        void Spielerwechsel()
        {
            if (Farbe == Brushes.Red)
            {
                Farbe = Brushes.Yellow;
                Text.Text = "Spieler 2 ist dran";
            }
            else
            {
                Farbe = Brushes.Red;
                Text.Text = "Spieler 1 ist dran";
            }
        }

        //GewinnKonditionen überprüfen
        void Wincon()
        {   
            //Alle vertikalen Gewinnkonditionen werden überprüft
            for (int x = 0; x <= 6; x++)
            {
                for (int y = 0; y <= 2; y++)
                {
                    if (SpielFeld[x, y] == SpielFeld[x, y + 1] && SpielFeld[x, y] == SpielFeld[x, y + 2] && SpielFeld[x, y] == SpielFeld[x, y + 3]&&SpielFeld[x,y]!=Brushes.White)
                    {
                        Gewinnen();
                    }
                }
            }

            //Alle Horizontalen Gewinnkonditionen werden überprüft
            for (int y = 0; y <= 5; y++)
            {
                for (int x = 0; x <= 3; x++)
                {

                    if (SpielFeld[x, y] == SpielFeld[x + 1, y] && SpielFeld[x,y] == SpielFeld[x + 2, y] && SpielFeld[x, y] == SpielFeld[x + 3, y] && SpielFeld[x,y] != Brushes.White)
                    {
                        Gewinnen();
                    }
                }
            }

            //Diagonale Gewinnkonditionen werden überprüft

            //Diagonalen1
            for (int x = 0; x <= 3; x++)
            {
                for (int y = 0; y <= 2; y++)
                {
                    if (SpielFeld[x, y] == SpielFeld[x + 1, y + 1] && SpielFeld[x, y] == SpielFeld[x +2 , y + 2] && SpielFeld[x, y] == SpielFeld[x + 3, y + 3] && SpielFeld[x, y] != Brushes.White)
                    {
                        Gewinnen();
                    }
                }

            }

            //Diagonalen 2

            for(int x = 0; x <= 3; x++)
            {
                for (int y = 5; y >= 3; y--)
                {
                    if (SpielFeld[x, y] == SpielFeld[x + 1, y - 1] && SpielFeld[x, y] == SpielFeld[x + 2, y - 2] && SpielFeld[x, y] == SpielFeld[x + 3, y - 3] && SpielFeld[x, y] != Brushes.White)
                    {
                        Gewinnen();
                    }
                }

            }


        }

        void Gewinnen()
        {
            Switch = false;
            //Der Gewinner wird festgestellt und ausgegeben
            if (Farbe == Brushes.Yellow)
            {
                Text.Text = "Spieler 1 hat Gewonnen !";
            }
            else
            {
                Text.Text = "Spieler 2 hat Gewonnen !";
            }

            StartButton.Content = "Erneut Spielen";

            //Spielbuttons werden unsichtbar
            SpielButton1.Opacity = 0;
            SpielButton2.Opacity = 0;
            SpielButton3.Opacity = 0;
            SpielButton4.Opacity = 0;
            SpielButton5.Opacity = 0;
            SpielButton6.Opacity = 0;
            SpielButton7.Opacity = 0;

            //Start/Ende Buttons werden unsichtbar
            StartButton.Opacity = 100;
            BeendenButton.Opacity = 100;

            //Reset Switch wird umgelegt
            resetSwitch = true;

        }

        void reset()
        {
            //Spielerwechsel damit es richtig zurückgesetzt wird
            if (Farbe == Brushes.Yellow)
            {
                Spielerwechsel();
            }

            //Das Array wird zurückgesetzt
            SpielFeld[0, 0] = Brushes.White;
            SpielFeld[1, 0] = Brushes.White;
            SpielFeld[2, 0] = Brushes.White;
            SpielFeld[3, 0] = Brushes.White;
            SpielFeld[4, 0] = Brushes.White;
            SpielFeld[5, 0] = Brushes.White;
            SpielFeld[6, 0] = Brushes.White;
            SpielFeld[0, 1] = Brushes.White;
            SpielFeld[1, 1] = Brushes.White;
            SpielFeld[2, 1] = Brushes.White;
            SpielFeld[3, 1] = Brushes.White;
            SpielFeld[4, 1] = Brushes.White;
            SpielFeld[5, 1] = Brushes.White;
            SpielFeld[6, 1] = Brushes.White;
            SpielFeld[0, 2] = Brushes.White;
            SpielFeld[1, 2] = Brushes.White;
            SpielFeld[2, 2] = Brushes.White;
            SpielFeld[3, 2] = Brushes.White;
            SpielFeld[4, 2] = Brushes.White;
            SpielFeld[5, 2] = Brushes.White;
            SpielFeld[6, 2] = Brushes.White;
            SpielFeld[0, 3] = Brushes.White;
            SpielFeld[1, 3] = Brushes.White;
            SpielFeld[2, 3] = Brushes.White;
            SpielFeld[3, 3] = Brushes.White;
            SpielFeld[4, 3] = Brushes.White;
            SpielFeld[5, 3] = Brushes.White;
            SpielFeld[6, 3] = Brushes.White;
            SpielFeld[0, 4] = Brushes.White;
            SpielFeld[1, 4] = Brushes.White;
            SpielFeld[2, 4] = Brushes.White;
            SpielFeld[3, 4] = Brushes.White;
            SpielFeld[4, 4] = Brushes.White;
            SpielFeld[5, 4] = Brushes.White;
            SpielFeld[6, 4] = Brushes.White;
            SpielFeld[0, 5] = Brushes.White;
            SpielFeld[1, 5] = Brushes.White;
            SpielFeld[2, 5] = Brushes.White;
            SpielFeld[3, 5] = Brushes.White;
            SpielFeld[4, 5] = Brushes.White;
            SpielFeld[5, 5] = Brushes.White;
            SpielFeld[6, 5] = Brushes.White;

            //Das SpielFeld wird zurückgesetzt
            Ellipse01.Fill = Brushes.White;
            Ellipse02.Fill = Brushes.White;
            Ellipse03.Fill = Brushes.White;
            Ellipse04.Fill = Brushes.White;
            Ellipse05.Fill = Brushes.White;
            Ellipse06.Fill = Brushes.White;
            Ellipse07.Fill = Brushes.White;
            Ellipse08.Fill = Brushes.White;
            Ellipse09.Fill = Brushes.White;
            Ellipse10.Fill = Brushes.White;
            Ellipse11.Fill = Brushes.White;
            Ellipse12.Fill = Brushes.White;
            Ellipse13.Fill = Brushes.White;
            Ellipse14.Fill = Brushes.White;
            Ellipse15.Fill = Brushes.White;
            Ellipse16.Fill = Brushes.White;
            Ellipse17.Fill = Brushes.White;
            Ellipse18.Fill = Brushes.White;
            Ellipse19.Fill = Brushes.White;
            Ellipse20.Fill = Brushes.White;
            Ellipse21.Fill = Brushes.White;
            Ellipse22.Fill = Brushes.White;
            Ellipse23.Fill = Brushes.White;
            Ellipse24.Fill = Brushes.White;
            Ellipse25.Fill = Brushes.White;
            Ellipse26.Fill = Brushes.White;
            Ellipse27.Fill = Brushes.White;
            Ellipse28.Fill = Brushes.White;
            Ellipse29.Fill = Brushes.White;
            Ellipse30.Fill = Brushes.White;
            Ellipse31.Fill = Brushes.White;
            Ellipse32.Fill = Brushes.White;
            Ellipse33.Fill = Brushes.White;
            Ellipse34.Fill = Brushes.White;
            Ellipse35.Fill = Brushes.White;
            Ellipse36.Fill = Brushes.White;
            Ellipse37.Fill = Brushes.White;
            Ellipse38.Fill = Brushes.White;
            Ellipse39.Fill = Brushes.White;
            Ellipse40.Fill = Brushes.White;
            Ellipse41.Fill = Brushes.White;
            Ellipse42.Fill = Brushes.White;

            //Text wird verändert
            Text.Text = "Spieler 1 ist dran";
            
            //Funktion des StartButtons

            //Spielbuttons werden sichtbar
            if (!Switch)
                SpielButton1.Opacity = 100;
            SpielButton2.Opacity = 100;
            SpielButton3.Opacity = 100;
            SpielButton4.Opacity = 100;
            SpielButton5.Opacity = 100;
            SpielButton6.Opacity = 100;
            SpielButton7.Opacity = 100;

            //Start/Ende Buttons werden unsichtbar
            StartButton.Opacity = 0;
            BeendenButton.Opacity = 0;

            
            Text.Width = 175;
            Text.FontSize = 20;
            //Switch wird umgelegt
            Switch = true;
        }
        #endregion
    }
}
