﻿#pragma checksum "..\..\FarmsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78F9037298A6E59E5B46D9A088FF5E42FCFA0BFF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Mleczarnia;
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


namespace Mleczarnia {
    
    
    /// <summary>
    /// FarmsWindow
    /// </summary>
    public partial class FarmsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 56 "..\..\FarmsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox farmsList;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\FarmsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\FarmsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox surname;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\FarmsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox adress;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\FarmsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nip;
        
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
            System.Uri resourceLocater = new System.Uri("/Mleczarnia;component/farmswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FarmsWindow.xaml"
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
            
            #line 12 "..\..\FarmsWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Delete_CanExecute);
            
            #line default
            #line hidden
            
            #line 12 "..\..\FarmsWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Delete_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 13 "..\..\FarmsWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Return_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 14 "..\..\FarmsWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Add_Executed);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 51 "..\..\FarmsWindow.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.GroupNone);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 52 "..\..\FarmsWindow.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.GroupSurname);
            
            #line default
            #line hidden
            return;
            case 6:
            this.farmsList = ((System.Windows.Controls.ListBox)(target));
            
            #line 56 "..\..\FarmsWindow.xaml"
            this.farmsList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.name = ((System.Windows.Controls.TextBox)(target));
            
            #line 75 "..\..\FarmsWindow.xaml"
            this.name.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextChanged);
            
            #line default
            #line hidden
            
            #line 75 "..\..\FarmsWindow.xaml"
            this.name.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.surname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.adress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.nip = ((System.Windows.Controls.TextBox)(target));
            
            #line 85 "..\..\FarmsWindow.xaml"
            this.nip.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextChanged);
            
            #line default
            #line hidden
            
            #line 85 "..\..\FarmsWindow.xaml"
            this.nip.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

