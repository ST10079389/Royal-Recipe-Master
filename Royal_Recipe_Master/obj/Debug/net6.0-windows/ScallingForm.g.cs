﻿#pragma checksum "..\..\..\ScallingForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EF97CAC580AA0166C51B0B1ACB2879720D373B58"
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
    /// ScallingForm
    /// </summary>
    public partial class ScallingForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\ScallingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ExitOption;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\ScallingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\ScallingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\ScallingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RecipeNameBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\ScallingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveRecipeButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\ScallingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox scalebox;
        
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
            System.Uri resourceLocater = new System.Uri("/ST10079389_Kaushil_Dajee_PROG6211POE;component/scallingform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ScallingForm.xaml"
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
            
            #line 18 "..\..\..\ScallingForm.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ExitOption = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\..\ScallingForm.xaml"
            this.ExitOption.Click += new System.Windows.RoutedEventHandler(this.ExitOption_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\ScallingForm.xaml"
            this.SearchBox.GotFocus += new System.Windows.RoutedEventHandler(this.SearchBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\ScallingForm.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RecipeNameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.SaveRecipeButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\ScallingForm.xaml"
            this.SaveRecipeButton.Click += new System.Windows.RoutedEventHandler(this.AlterRecipeButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.scalebox = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

