﻿#pragma checksum "..\..\bookslist.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "054319D77E85F5D6E9601A1B2CDBC41576878DFC95AAB7BB5370831831328791"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AP01Project;
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


namespace AP01Project {
    
    
    /// <summary>
    /// bookslist
    /// </summary>
    public partial class bookslist : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\bookslist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridbooks;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\bookslist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showbooks;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\bookslist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox shenase;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\bookslist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addtolist;
        
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
            System.Uri resourceLocater = new System.Uri("/AP01Project;component/bookslist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\bookslist.xaml"
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
            this.dataGridbooks = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.showbooks = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\bookslist.xaml"
            this.showbooks.Click += new System.Windows.RoutedEventHandler(this.show_books);
            
            #line default
            #line hidden
            return;
            case 3:
            this.shenase = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.addtolist = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\bookslist.xaml"
            this.addtolist.Click += new System.Windows.RoutedEventHandler(this.add_tocart);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 47 "..\..\bookslist.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.backtodash);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

