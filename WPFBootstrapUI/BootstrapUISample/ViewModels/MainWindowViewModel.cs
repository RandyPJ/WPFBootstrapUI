using Prism.Mvvm;

namespace BootstrapUISample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            Contrasena = "Hola mundo";
        }

        private string _contrasena;
        public string Contrasena
        {
            get => _contrasena;
            set
            {
                SetProperty(ref _contrasena, value);
            }
        }
    }
}
