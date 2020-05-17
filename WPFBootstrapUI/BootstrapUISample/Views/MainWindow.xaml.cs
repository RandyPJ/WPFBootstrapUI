using System.Collections.Generic;
using System.Windows;
using WPFBootstrapUI.Controls;

namespace BootstrapUISample
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //myListView.ItemsSource = GetList();
        }

        private List<Persona> GetList()
        {
            return new List<Persona>() 
            {
                new Persona() { Nombre = "Randy Manuel Pena Jimenez" },
                new Persona() { Nombre = "Randy Manuel Pena Jimenez" },
                new Persona() { Nombre = "Randy Manuel Pena Jimenez" },
                new Persona() { Nombre = "Randy Manuel Pena Jimenez" },
                new Persona() { Nombre = "Randy Manuel Pena Jimenez" },
                new Persona() { Nombre = "Randy Manuel Pena Jimenez" },
                new Persona() { Nombre = "Randy Manuel Pena Jimenez" },
                new Persona() { Nombre = "Randy Manuel Pena Jimenez" },
                new Persona() { Nombre = "Randy Manuel Pena Jimenez" }
            };
        }
    }
}
