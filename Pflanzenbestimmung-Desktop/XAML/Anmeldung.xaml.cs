﻿using System.Windows;
using System.Windows.Controls;

namespace Pflanzenbestimmung_Desktop
{
    /// <summary>
    /// Interaktionslogik für Anmeldung.xaml
    /// </summary>
    public partial class Anmeldung : UserControl
    {
        public Anmeldung()
        {
            InitializeComponent();


        }

        private void AnmeldungButton_Click(object sender, RoutedEventArgs e)
        {
            Main.LadenStart();
            string benutzername = AnmeldungBenutzernameTextBox.Text;
            string passwort = AnmeldungPasswordBox.Password;

            string hash = Main.GetHashWithSalt(passwort, benutzername);

            Main.benutzer = Main.api_anbindung.Login(benutzername, hash);

            Main.Laden();

            if (Main.benutzer.IstGueltig)
            {
                Main.LadeStatistiken();
                MainWindow.changeContent(new Hauptmenü());
            }
            else
            {
                MessageBox.Show("Der Benutzer konnte nicht gefunden werden. Mögliche Ursachen:\n" +
                    "   • Der Benutzername oder das Passwort ist falsch\n" +
                    "   • Es konnte keine Verbindung zur Datenbank hergestellt werden.");
            }
        }
    }
}
