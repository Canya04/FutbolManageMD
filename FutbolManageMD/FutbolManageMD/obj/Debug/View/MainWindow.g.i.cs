﻿#pragma checksum "..\..\..\View\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9ABB4CDA64625BDF32D00D2B0D81260A9011E8093D9E378876FC69FB5917D67B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.Sharp;
using FutbolManageMD.View;
using FutbolManageMD.ViewModels;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace FutbolManageMD {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 168 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnlBarraControl;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botoTancar;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botoMaximitzar;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botoMinimitzar;
        
        #line default
        #line hidden
        
        
        #line 234 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botoSingOut;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FutbolManageMD;component/view/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.pnlBarraControl = ((System.Windows.Controls.StackPanel)(target));
            
            #line 174 "..\..\..\View\MainWindow.xaml"
            this.pnlBarraControl.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.pnlBarraControl_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 175 "..\..\..\View\MainWindow.xaml"
            this.pnlBarraControl.MouseEnter += new System.Windows.Input.MouseEventHandler(this.pnlBarraControl_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 2:
            this.botoTancar = ((System.Windows.Controls.Button)(target));
            
            #line 180 "..\..\..\View\MainWindow.xaml"
            this.botoTancar.Click += new System.Windows.RoutedEventHandler(this.botoTancar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.botoMaximitzar = ((System.Windows.Controls.Button)(target));
            
            #line 188 "..\..\..\View\MainWindow.xaml"
            this.botoMaximitzar.Click += new System.Windows.RoutedEventHandler(this.botoMaximitzar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.botoMinimitzar = ((System.Windows.Controls.Button)(target));
            
            #line 195 "..\..\..\View\MainWindow.xaml"
            this.botoMinimitzar.Click += new System.Windows.RoutedEventHandler(this.botoMinimitzar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.botoSingOut = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

