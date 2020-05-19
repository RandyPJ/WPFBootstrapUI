using System.Collections.Generic;
using System.Windows;
using WPFBootstrapUI.Controls;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           ModalMananger.ShowModal(this,"Modal","Mensajesasadfbdsaf asdf asdfas dasd f" +
               "asdf asdfa sdfasdf asdfas asd asdf asdfas dafsdf asdfasd asdf asdf asd" +
               "asd fasdf asdfa sdasdf asdf asdfa sdfas fasd fasdf a sfa sdasd fasd fasdf asdf" +
               "asd fasdf asdf asd fasdfasdfadsf sahdfasdfisadfkhsadbfkhsadfksadbfkjsadbfkjsadfsadfsadf" +
               "asdfasdfasdfasdfasdfsadfasdfsadfasgsadgsadgfasdfasdfasdfasdfasdfasdfasdfasdfsadfsadf.dsafdsafasdf" +
               "asdfsadfsadfasdfasdfasdfasdfasdfsadfbsaidbfsadf" +
               "sadfasd" +
               "fsa" +
               "dfa" +
               "sdf" +
               "sad" +
               "fsadfsadfsad" +
               "fsad" +
               "f" +
               "sadf" +
               "sad" +
               "fas" +
               "df" +
               "sad" +
               "fsa" +
               "df" +
               "ads" +
               "fas" +
               "df" +
               "asd" +
               "f" +
               "sadf" +
               "sad" +
               "fsa" +
               "df" +
               "asd" +
               "fsa" +
               "df" +
               "sad" +
               "fasd" +
               "f" +
               "sadf" +
               "sa" +
               "df" +
               "sad" +
               "fdsa" +
               "f" +
               "sadf" +
               "sad" +
               "fa" +
               "sdf" +
               "asd" +
               "fa" +
               "sdf" +
               "sa" +
               "df" +
               "sadf" +
               "asd" +
               "fa" +
               "dsf" +
               "asd" +
               "fa" +
               "sdf" +
               "sad" +
               "fa" +
               "sdf" +
               "asd" +
               "fa" +
               "sdf" +
               "sad" +
               "fa" +
               "sdf" +
               "sad" +
               "f" +
               "dsfsadfsadfasdfasdfasdfasdgafdsgsdfgdsfgdsfg" +
               "sdfgsdfgdsfgsdfgdsfgsdfgsdfgdsfgsdfgsdfg" +
               "sdfgdsfgdsfgsdfgdsfgdsfgdsfgsdfgdsfgdsfgsdfgsdfg" +
               "sdfgdsfgdsfgdsfgsdfgsdfgsdfgsdfgdsfgdsfgerewrgerg" +
               "sfdgsdfgdsfgsdfgsdfgdsfgdsfgdsfgdsfgdsfgdsfgdsfgdsfg" +
               "sdfgsdfgdsfgdsfgsdfgdsfgdsfgdsfgsdfgdsfgdsfgdsfgdsfgsdfgdf" +
               "sdafsadfasdfasdfasdf","Aceptar","Cancelar");
        }
    }
}
