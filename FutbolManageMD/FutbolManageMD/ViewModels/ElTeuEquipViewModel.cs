using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FutbolManageMD.ViewModels
{
    public class ElTeuEquipViewModel : ViewModelBase
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
        public ICommand MostrarJugadorsViewCommand { get; }
        public ICommand MostrarSolicitudEquipViewCommand { get; }

        public ElTeuEquipViewModel()
        {
            //Inicialitzar commands
            MostrarJugadorsViewCommand = new ViewModelCommand(ExecutarMostrarJugadorsViewCommand);
            MostrarSolicitudEquipViewCommand = new ViewModelCommand(ExecutarMostrarSolicitudEquipViewCommand);

            //Vista Predeterminada
            ExecutarMostrarJugadorsViewCommand(null);
        }

        //Mostrar JugadorsView
        private void ExecutarMostrarJugadorsViewCommand(object obj)
        {
            VistaFillaActual = new JugadorsViewModel();
        }

        //Mostrar SolicitudsEquipView
        private void ExecutarMostrarSolicitudEquipViewCommand(object obj)
        {
            VistaFillaActual = new SolicitudsEquipViewModel();
        }
    }
}
