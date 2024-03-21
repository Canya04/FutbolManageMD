using FutbolManageMD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FutbolManageMD.Respositories;
using System.Security.Principal;
using System.Threading;

namespace FutbolManageMD.ViewModels
{
    //Heredem de la classe ViewModelBase
    public class LoginViewModel : ViewModelBase
    {
        //Variables
        private string _usuari;
        private SecureString _contrassenya;
        private string _missatgeError;
        private bool _isViewVisible = true;

        private IUsuariRepository usuariRepository;



        //Propietats
        public string Usuari 
        {
            get 
            {
                return _usuari;
            }

            set
            {
                _usuari = value;
                OnPropertyChanged(nameof(Usuari));
            }
        }

        public SecureString Contrassenya
        {
            get
            {
                return _contrassenya;
            }

            set
            {
                _contrassenya = value;
                OnPropertyChanged(nameof(Contrassenya));

            }
        }
        public string MissatgeError 
        {
            get
            {
                return _missatgeError;
            }
            set
            { 
                _missatgeError = value;
                OnPropertyChanged(nameof(MissatgeError));
            }
        }
        public bool IsViewVisible
        {
            get
            {
                return _isViewVisible;
            }
            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }

        //-> Commands
        public ICommand LoginCommand { get;}
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }

        //Construcotr
        public LoginViewModel() 
        {
            usuariRepository = new UsuariRepository();
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
            RecoverPasswordCommand = new ViewModelCommand(ExecuteRecoverPassCommand);
        }

        //Funcio per saber si pot executar la commanda per fer Login
        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData;

            //Si l'usuari té espais en blanc o té menys de 3 caracters o la contrassenya està buida o la contrassenya te menys de 3 caracters
            if (string.IsNullOrWhiteSpace(Usuari) || Usuari.Length<3 ||  
                Contrassenya == null || Contrassenya.Length<3)
                //l'informació no és correcta
                validData = false;
            else
                //Si no l'informació és correcta
                validData = true;

            return validData;
        }

        private void ExecuteLoginCommand(object obj)
        {
            var esUsuariValid = usuariRepository.AuthenticateUsuari(new System.Net.NetworkCredential(Usuari,Contrassenya));    
            if (esUsuariValid)
            {
                Thread.CurrentPrincipal = new GenericPrincipal(
                    new GenericIdentity(Usuari), null);
                IsViewVisible = false;
            }
            else
            {
                MissatgeError = "* Usuari o contrassenya incorrectes";
            }
        }
        private void ExecuteRecoverPassCommand(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
