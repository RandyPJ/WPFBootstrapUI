using System.Collections.Generic;
using System.Windows;
using WPFBootstrapUI.Controls.Modals;

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
        }

        private List<Persona> GetList()
        {
            return new List<Persona>() 
            {
                new Persona() { Nombre = "Steve Jobbs" },
                new Persona() { Nombre = "Bill Gates" },
                new Persona() { Nombre = "Mark Zuckerberg" },
                new Persona() { Nombre = "Scott Hanshelman" }
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _ = ModalService.ShowModal(this, "Modal", "This is a modal", "Aceptar", "Cancelar", true);
        }
    }
}
