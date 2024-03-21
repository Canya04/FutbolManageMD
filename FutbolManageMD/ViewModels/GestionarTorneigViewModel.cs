using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FutbolManageMD.ViewModels
{
    public class GestionarTorneigViewModel : ViewModelBase
    {
        //Variables
        private ViewModelBase _vistaFillaActual;

        public ViewModelBase VistaFillaActual
        {
            get
            {
                return _vistaFillaActual;
            }
            set
            {
                _vistaFillaActual = value;
                OnPropertyChanged(nameof(VistaFillaActual));
            }
        }

        //--> Commands
        public ICommand MostrarGestionarTorneigPartitsViewCommand { get; }
        public ICommand MostrarGestionarTorneigClassificacioViewCommand { get; }
        public ICommand MostrarGestionarTorneigEquipsViewCommand { get; }

        public GestionarTorneigViewModel()
        {
            //Inicialitzar commands
            MostrarGestionarTorneigPartitsViewCommand = new ViewModelCommand(ExecutarMostrarGestionarTorneigPartitsViewCommand);
            MostrarGestionarTorneigClassificacioViewCommand = new ViewModelCommand(ExecutarMostrarGestionarTorneigClassificacioViewCommand);
            MostrarGestionarTorneigEquipsViewCommand = new ViewModelCommand(ExecutarMostrarGestionarTorneigEquipsViewCommand);

            //Vista Predeterminada
            ExecutarMostrarGestionarTorneigPartitsViewCommand(null);
        }

        //Mostrar GestionarTorneigPartitsView
        private void ExecutarMostrarGestionarTorneigPartitsViewCommand(object obj)
        {
            VistaFillaActual = new GestionarTorneigPartitsViewModel();
        }

        //Mostrar GestionarTorneigClassificacioView
        private void ExecutarMostrarGestionarTorneigClassificacioViewCommand(object obj)
        {
            VistaFillaActual = new GestionarTorneigClassificacioViewModel();
        }

        //Mostrar GestionarTorneigEquipsView
        private void ExecutarMostrarGestionarTorneigEquipsViewCommand(object obj)
        {
            VistaFillaActual = new GestionarTorneigEquipsViewModel();
        }
    }
}
