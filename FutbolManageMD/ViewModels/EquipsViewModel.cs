using FutbolManageMD.Models;
using FutbolManageMD.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FutbolManageMD.ViewModels
{
    public class EquipsViewModel : ViewModelBase
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
        public ICommand MostrarVeureEquipsViewCommand { get; }
        public ICommand MostrarElTeuEquipViewCommand { get; }

        public EquipsViewModel()
        {
            //Inicialitzar commands
            MostrarVeureEquipsViewCommand = new ViewModelCommand(ExecutarMostrarVeureEquipsViewCommand);
            MostrarElTeuEquipViewCommand = new ViewModelCommand(ExecutarMostrarElTeuEquipViewCommand);

            //Vista Predeterminada
            ExecutarMostrarVeureEquipsViewCommand(null);
        }

        //Mostrar TornejosFinalitzatsView
        private void ExecutarMostrarVeureEquipsViewCommand(object obj)
        {
            VistaFillaActual = new VeureEquipsViewModel();
        }

        //Mostrar ElTeuEquipView
        private void ExecutarMostrarElTeuEquipViewCommand(object obj)
        {
            VistaFillaActual = new ElTeuEquipViewModel();
        }
    }
}
