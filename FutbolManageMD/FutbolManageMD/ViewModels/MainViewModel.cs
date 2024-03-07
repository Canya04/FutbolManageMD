using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using FontAwesome.Sharp;
using FutbolManageMD.Models;
using FutbolManageMD.Respositories;
using FutbolManageMD.View;

namespace FutbolManageMD.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        //Variables
        private CompteUsuariModel _usuariActual;
        private ViewModelBase _vistaFillaActual;
        private string _titol;
        private IconChar _icon;
        private IUsuariRepository usuariRepository;

        //Constructors
        public CompteUsuariModel UsuariActual
        {
            get
            { 
                return _usuariActual;
            }
            set
            {
                _usuariActual = value;
                OnPropertyChanged(nameof(UsuariActual));
            }
        }

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

        public string Titol
        {
            get
            {
                return _titol;
            }
            set
            {
                _titol = value;
                OnPropertyChanged(nameof(Titol));
            }
        }

        public IconChar Icon 
        {
            get 
            {
                return _icon;
            }
            set 
            {
                _icon = value;
                OnPropertyChanged(nameof(Icon));
            }
        }

        //--> Commands
        public ICommand MostrarApuntarTorneigViewCommand{ get; }
        public ICommand MostrarTornejosActiusViewCommand{ get; }
        public ICommand MostrarTornejosFinalitzatsViewCommand{ get; }
        public ICommand MostrarGestionarTorneigViewCommand { get; }

        public ICommand MostrarEquipsViewCommand{ get; }

        public MainViewModel() 
        {
            usuariRepository = new UsuariRepository();
            UsuariActual = new CompteUsuariModel();

            //Inicialitzar commands
            MostrarApuntarTorneigViewCommand = new ViewModelCommand(ExecutarMostrarApuntarTorneigViewCommand);
            MostrarTornejosActiusViewCommand = new ViewModelCommand(ExecutarMostrarTornejosActiusViewCommand);
            MostrarTornejosFinalitzatsViewCommand = new ViewModelCommand(ExecutarMostrarTornejosFinalitzatsViewCommand);
            MostrarGestionarTorneigViewCommand = new ViewModelCommand(ExecutarMostrarGestionarTorneigViewCommand);
            MostrarEquipsViewCommand = new ViewModelCommand(ExecutarMostrarEquipsViewCommand);

            //Vista Predeterminada
            ExecutarMostrarApuntarTorneigViewCommand(null);

            CarregarInformacioUsuariActual();
        }

        //Mostrar ApuntarTorneigView
        private void ExecutarMostrarApuntarTorneigViewCommand(object obj)
        {
            VistaFillaActual = new ApuntarTorneigViewModel();
            Titol = "Apuntar Torneig";
            Icon = IconChar.Pencil;
        }

        //Mostrar TornejosActiusView
        private void ExecutarMostrarTornejosActiusViewCommand(object obj)
        {
            VistaFillaActual = new TornejosActiusViewModel();
            Titol = "Tornejos Actius";
            Icon = IconChar.FutbolBall;
        }

        //Mostrar TornejosFinalitzatsView
        private void ExecutarMostrarTornejosFinalitzatsViewCommand(object obj)
        {
            VistaFillaActual = new TornejosFinalitzatsViewModel();
            Titol = "Tornejos Finalitzats";
            Icon = IconChar.RotateBack;
        }

        //Mostrar GestionarTroneigView
        private void ExecutarMostrarGestionarTorneigViewCommand(object obj)
        {
            VistaFillaActual = new TornejosFinalitzatsViewModel();
            Titol = "Gestionar Torneig";
            Icon = IconChar.Trophy;
        }

        //Mostrar EquipsView
        private void ExecutarMostrarEquipsViewCommand(object obj)
        {
            VistaFillaActual = new EquipsViewModel();
            Titol = "Equips";
            Icon = IconChar.Shirt;
        }







        private void CarregarInformacioUsuariActual()
        {
            var usuari = usuariRepository.GetByUsuari(Thread.CurrentPrincipal.Identity.Name);
            if (usuari != null) 
            {
                UsuariActual.Usuari = usuari.Usuari;
                UsuariActual.MostrarNom = $"{usuari.Nom} {usuari.Cognom}";
                UsuariActual.FotoPerfil = null;                
            }
            else 
            {
                UsuariActual.Usuari = "Usuari incorrecte, no has iniciat sessió";
            }
        }
    }
}
