﻿#pragma checksum "..\..\..\..\Views\MainView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8C9394FE8E81B9A4E45D4714F798A4AB46E255AD"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Integrated_Platform_App;
using Integrated_Platform_App.Common.Extensions;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Prism.DryIoc;
using Prism.Interactivity;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Regions.Behaviors;
using Prism.Services.Dialogs;
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


namespace Integrated_Platform_App {
    
    
    /// <summary>
    /// MainView
    /// </summary>
    public partial class MainView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 59 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minbtn;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button maxbtn;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closebtn;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton MenuToggleButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Integrated_Platform_App;V1.0.0.0;component/views/mainview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\MainView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 54 "..\..\..\..\Views\MainView.xaml"
            ((MaterialDesignThemes.Wpf.ColorZone)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.colorZone_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\..\Views\MainView.xaml"
            ((MaterialDesignThemes.Wpf.ColorZone)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.colorZone_MouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.minbtn = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\Views\MainView.xaml"
            this.minbtn.Click += new System.Windows.RoutedEventHandler(this.minbtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.maxbtn = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\Views\MainView.xaml"
            this.maxbtn.Click += new System.Windows.RoutedEventHandler(this.maxbtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.closebtn = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\..\Views\MainView.xaml"
            this.closebtn.Click += new System.Windows.RoutedEventHandler(this.closebtn_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MenuToggleButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

