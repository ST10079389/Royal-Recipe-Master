﻿#pragma checksum "..\..\..\ViewAllRecipes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BE8735107D4905D762AB07E741BB9E11A2CDFEC0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ST10079389_Kaushil_Dajee_PROG6211POE;
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


namespace ST10079389_Kaushil_Dajee_PROG6211POE {
    
    
    /// <summary>
    /// ViewAllRecipes
    /// </summary>
    public partial class ViewAllRecipes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\ViewAllRecipes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ExitOption;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\ViewAllRecipes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\ViewAllRecipes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\ViewAllRecipes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RecipeNameBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\ViewAllRecipes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\ViewAllRecipes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RecipeBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\ViewAllRecipes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox filterBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\ViewAllRecipes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputFilter;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\ViewAllRecipes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button viewButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ST10079389_Kaushil_Dajee_PROG6211POE;component/viewallrecipes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewAllRecipes.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 18 "..\..\..\ViewAllRecipes.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ExitOption = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\..\ViewAllRecipes.xaml"
            this.ExitOption.Click += new System.Windows.RoutedEventHandler(this.ExitOption_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\ViewAllRecipes.xaml"
            this.SearchBox.GotFocus += new System.Windows.RoutedEventHandler(this.SearchBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\ViewAllRecipes.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RecipeNameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.NextButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\ViewAllRecipes.xaml"
            this.NextButton.Click += new System.Windows.RoutedEventHandler(this.NextButton_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RecipeBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.filterBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.inputFilter = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\ViewAllRecipes.xaml"
            this.inputFilter.GotFocus += new System.Windows.RoutedEventHandler(this.inputFilter_GotFocus);
            
            #line default
            #line hidden
            return;
            case 10:
            this.viewButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\ViewAllRecipes.xaml"
            this.viewButton.Click += new System.Windows.RoutedEventHandler(this.ViewButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

