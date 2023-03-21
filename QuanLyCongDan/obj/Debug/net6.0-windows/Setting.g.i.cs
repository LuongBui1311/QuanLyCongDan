﻿#pragma checksum "..\..\..\Setting.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8509E838CFEF45F2049BB1727F19F0931E48AC2F"
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
    /// Setting
    /// </summary>
    public partial class Setting : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_TrangChu;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_CongDan;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_QuanLyDon;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Setting;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_LogOut;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton themeToggle;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyCongDan;component/setting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Setting.xaml"
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
            this.btn_TrangChu = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Setting.xaml"
            this.btn_TrangChu.Click += new System.Windows.RoutedEventHandler(this.btn_TrangChu_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_CongDan = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Setting.xaml"
            this.btn_CongDan.Click += new System.Windows.RoutedEventHandler(this.btn_CongDan_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_QuanLyDon = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Setting.xaml"
            this.btn_QuanLyDon.Click += new System.Windows.RoutedEventHandler(this.btn_QuanLyDon_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_Setting = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.btn_LogOut = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\Setting.xaml"
            this.btn_LogOut.Click += new System.Windows.RoutedEventHandler(this.btn_LogOut_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.themeToggle = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 101 "..\..\..\Setting.xaml"
            this.themeToggle.Click += new System.Windows.RoutedEventHandler(this.toggleTheme);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

