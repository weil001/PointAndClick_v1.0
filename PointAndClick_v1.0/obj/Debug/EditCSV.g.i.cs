﻿#pragma checksum "..\..\EditCSV.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C28F21B524973492C19AED2A66FBE5A1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PointAndClick_v1._0;
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


namespace PointAndClick_v1._0 {
    
    
    /// <summary>
    /// EditCSV
    /// </summary>
    public partial class EditCSV : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\EditCSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\EditCSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid csvDataGrid;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\EditCSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DepartmentID;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\EditCSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DepartmentID2;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\EditCSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TaxCategoryID;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\EditCSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\EditCSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Cancel;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\EditCSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backButton;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\EditCSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Back;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\EditCSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackupButton;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\EditCSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Next;
        
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
            System.Uri resourceLocater = new System.Uri("/PointAndClick_v1.0;component/editcsv.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditCSV.xaml"
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
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.csvDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 51 "..\..\EditCSV.xaml"
            this.csvDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.csvDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DepartmentID = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.DepartmentID2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TaxCategoryID = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\EditCSV.xaml"
            this.cancelButton.Click += new System.Windows.RoutedEventHandler(this.cancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Cancel = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.backButton = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\EditCSV.xaml"
            this.backButton.Click += new System.Windows.RoutedEventHandler(this.backButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Back = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.BackupButton = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\EditCSV.xaml"
            this.BackupButton.Click += new System.Windows.RoutedEventHandler(this.backupButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Next = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

