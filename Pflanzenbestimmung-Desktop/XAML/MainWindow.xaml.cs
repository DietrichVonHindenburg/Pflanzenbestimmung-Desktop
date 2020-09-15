﻿using System;
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

namespace Pflanzenbestimmung_Desktop
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow dieses;

        public MainWindow()
        {
            InitializeComponent();
            dieses = this;
            changeContent(new Anmeldung());
        }

        public static void changeContent(object o)
        {
            dieses.ContentHolder.Content = o;

            switch (o.GetType().Name)
            {
                case "Administration":
                    dieses.Title = "Administration";
                    break;
                case "Anmeldung":
                    dieses.Title = "Anmeldung";
                    break;
                case "Hauptmenü":
                    dieses.Title = "Pflanzenbestimmung";
                    if (!Main.benutzer.istAdmin)
                        ((Hauptmenü)o).AdministrativesButton.Visibility = Visibility.Collapsed;
                    break;
                case "Registrierung":
                    dieses.Title = "Registrierung";
                    break;
                default:
                    dieses.Title = "Pflanzenbestimmung";
                    break;
            }
        }
    }
}
