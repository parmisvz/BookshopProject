﻿#pragma checksum "..\..\AdminUserSearch.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D2CF67B18079BFA5A230AF7AAAEDF388FB57D77857B25188DEE55B22CF69E8CD"
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
    /// AdminUserSearch
    /// </summary>
    public partial class AdminUserSearch : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\AdminUserSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridUsers;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\AdminUserSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowUsers;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\AdminUserSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowFilteredUsers;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\AdminUserSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBoxUser;
        
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
            System.Uri resourceLocater = new System.Uri("/AP01Project;component/adminusersearch.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminUserSearch.xaml"
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
            this.dataGridUsers = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.ShowUsers = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\AdminUserSearch.xaml"
            this.ShowUsers.Click += new System.Windows.RoutedEventHandler(this.ShowUsers_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ShowFilteredUsers = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\AdminUserSearch.xaml"
            this.ShowFilteredUsers.Click += new System.Windows.RoutedEventHandler(this.ShowFilteredUsers_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SearchBoxUser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 62 "..\..\AdminUserSearch.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.backtodash);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
