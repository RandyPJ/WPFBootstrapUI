using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
