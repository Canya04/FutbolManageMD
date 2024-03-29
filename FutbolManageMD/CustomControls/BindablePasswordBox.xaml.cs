﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FutbolManageMD.CustomControls
{
    /// <summary>
    /// Lógica de interacción para BindablePasswordBox.xaml
    /// </summary>
    public partial class BindablePasswordBox : UserControl
    {
        public static readonly DependencyProperty ContrassenyaProperty =
            DependencyProperty.Register("Contrassenya", typeof(SecureString), typeof(BindablePasswordBox));

        public SecureString Contrassenya
        {
            get { return (SecureString)GetValue(ContrassenyaProperty); }
            set { SetValue(ContrassenyaProperty, value);}
        }
        public BindablePasswordBox()
        {
            InitializeComponent();
            txtContrassenya.PasswordChanged += OnContrassenyaChanged;
        }

        private void OnContrassenyaChanged(object sender, RoutedEventArgs e)
        {
            Contrassenya = txtContrassenya.SecurePassword;
        }
    }
}
