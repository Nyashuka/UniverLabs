﻿#pragma checksum "..\..\..\..\UserControls\DishMenuUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CAB2903E496CE5C927F9AD6FCCB0A1D356ECCE3E"
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
using Restaurant;
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


namespace Restaurant {
    
    
    /// <summary>
    /// DishMenuUserControl
    /// </summary>
    public partial class DishMenuUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\UserControls\DishMenuUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid DishData;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\UserControls\DishMenuUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.TransitioningContent TrainsitionigContentSlide;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\UserControls\DishMenuUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image DishImage;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\UserControls\DishMenuUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DishName;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\UserControls\DishMenuUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DishIngredients;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\UserControls\DishMenuUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DishPrice;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\UserControls\DishMenuUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DishCount;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Restaurant;component/usercontrols/dishmenuusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\DishMenuUserControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DishData = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.TrainsitionigContentSlide = ((MaterialDesignThemes.Wpf.Transitions.TransitioningContent)(target));
            return;
            case 3:
            this.DishImage = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.DishName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DishIngredients = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.DishPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.DishCount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 50 "..\..\..\..\UserControls\DishMenuUserControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonAdd_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

