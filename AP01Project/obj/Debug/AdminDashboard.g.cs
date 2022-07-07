﻿#pragma checksum "..\..\AdminDashboard.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B66091977DFEE3E7ADB6DEAD1E1C980D61574D627ECC58C5ED300A55BD223C3B"
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
using AP01Project.MVVM.ViewModel;
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
    /// AdminDashboard
    /// </summary>
    public partial class AdminDashboard : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\AdminDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ViewUsers;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\AdminDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton AddedBooks;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\AdminDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton AccountBalance;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\AdminDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SearchBookForm;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\AdminDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SearchUserForm;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\AdminDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton AddBooks;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\AdminDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\AdminDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox username;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\AdminDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phone;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\AdminDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox password;
        
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
            System.Uri resourceLocater = new System.Uri("/AP01Project;component/admindashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminDashboard.xaml"
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
            this.ViewUsers = ((System.Windows.Controls.RadioButton)(target));
            
            #line 41 "..\..\AdminDashboard.xaml"
            this.ViewUsers.Checked += new System.Windows.RoutedEventHandler(this.ViewUsers_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddedBooks = ((System.Windows.Controls.RadioButton)(target));
            
            #line 47 "..\..\AdminDashboard.xaml"
            this.AddedBooks.Checked += new System.Windows.RoutedEventHandler(this.AddedBooks_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AccountBalance = ((System.Windows.Controls.RadioButton)(target));
            
            #line 53 "..\..\AdminDashboard.xaml"
            this.AccountBalance.Checked += new System.Windows.RoutedEventHandler(this.AccountBalance_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SearchBookForm = ((System.Windows.Controls.RadioButton)(target));
            
            #line 59 "..\..\AdminDashboard.xaml"
            this.SearchBookForm.Checked += new System.Windows.RoutedEventHandler(this.SearchBookForm_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SearchUserForm = ((System.Windows.Controls.RadioButton)(target));
            
            #line 65 "..\..\AdminDashboard.xaml"
            this.SearchUserForm.Checked += new System.Windows.RoutedEventHandler(this.SearchUserForm_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AddBooks = ((System.Windows.Controls.RadioButton)(target));
            
            #line 71 "..\..\AdminDashboard.xaml"
            this.AddBooks.Checked += new System.Windows.RoutedEventHandler(this.AddBooks_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.username = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.phone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.password = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 178 "..\..\AdminDashboard.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 179 "..\..\AdminDashboard.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowInformation);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

