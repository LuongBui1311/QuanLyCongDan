﻿#pragma checksum "..\..\..\User_QuanLyDon.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1C2A47A5379BFBEA9B1118E54543F543CA72A353"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using QuanLyCongDan;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace QuanLyCongDan {
    
    
    /// <summary>
    /// User_QuanLyDon
    /// </summary>
    public partial class User_QuanLyDon : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\User_QuanLyDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_User_TrangChu;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\User_QuanLyDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_User_CongDan;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\User_QuanLyDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_QuanLyDon;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\User_QuanLyDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton themeToggle;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\User_QuanLyDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_LogOut;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QuanLyCongDan;V1.0.0.0;component/user_quanlydon.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\User_QuanLyDon.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 14 "..\..\..\User_QuanLyDon.xaml"
            ((QuanLyCongDan.User_QuanLyDon)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_User_TrangChu = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\User_QuanLyDon.xaml"
            this.btn_User_TrangChu.Click += new System.Windows.RoutedEventHandler(this.btn_User_TrangChu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_User_CongDan = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\User_QuanLyDon.xaml"
            this.btn_User_CongDan.Click += new System.Windows.RoutedEventHandler(this.btn_User_CongDan_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_QuanLyDon = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.themeToggle = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 64 "..\..\..\User_QuanLyDon.xaml"
            this.themeToggle.Click += new System.Windows.RoutedEventHandler(this.toggleTheme);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_LogOut = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\User_QuanLyDon.xaml"
            this.btn_LogOut.Click += new System.Windows.RoutedEventHandler(this.btn_LogOut_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

