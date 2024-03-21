using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FutbolManageMD.ViewModels
{
    //Classe abstracta perquè només es pugui utilitzar mitjançant herència. Per a generar events quan una propietat canvia
    public abstract class ViewModelBase: INotifyPropertyChanged //Notificar canvi de propietat
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //Funció per generar un event quan una propietat ha canviat
        public void OnPropertyChanged(string propertyName) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
