﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ECFC96055DA5F1F809538DC7815BD238647BD1A8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

using AVPrehravac;
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


namespace AVPrehravac {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AVPrehravac.MainWindow wdwPrehravac;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement avPrehravac;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOtevri;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHraj;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPauza;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZavri;
        
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
            System.Uri resourceLocater = new System.Uri("/AVPrehravac;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.wdwPrehravac = ((AVPrehravac.MainWindow)(target));
            return;
            case 2:
            this.avPrehravac = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 3:
            this.btnOtevri = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.btnOtevri.Click += new System.Windows.RoutedEventHandler(this.BtnOtevri);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnHraj = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.btnHraj.Click += new System.Windows.RoutedEventHandler(this.BtnPrehraj);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnPauza = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\MainWindow.xaml"
            this.btnPauza.Click += new System.Windows.RoutedEventHandler(this.BtnPauza);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnZavri = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\MainWindow.xaml"
            this.btnZavri.Click += new System.Windows.RoutedEventHandler(this.BtnZavri);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 46 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ZavriOkno);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
