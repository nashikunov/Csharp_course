﻿#pragma checksum "..\..\TableWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D7242D1F949AE9DFF08317851B78715772D224BF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HW;
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


namespace HW {
    
    
    /// <summary>
    /// TableWindow
    /// </summary>
    public partial class TableWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FavButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxRoutes;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OkRouteButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OkStopButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxStops;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridTable;
        
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
            System.Uri resourceLocater = new System.Uri("/HW;component/tablewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TableWindow.xaml"
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
            
            #line 21 "..\..\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FavButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\TableWindow.xaml"
            this.FavButton.Click += new System.Windows.RoutedEventHandler(this.FavouriteButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 25 "..\..\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FavouriteEditButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.comboBoxRoutes = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.OkRouteButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\TableWindow.xaml"
            this.OkRouteButton.Click += new System.Windows.RoutedEventHandler(this.ButtonOkRoute_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.OkStopButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\TableWindow.xaml"
            this.OkStopButton.Click += new System.Windows.RoutedEventHandler(this.ButtonOkStop_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 41 "..\..\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ResetButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.comboBoxStops = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.dataGridTable = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
