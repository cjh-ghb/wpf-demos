﻿#pragma checksum "..\..\..\..\Views\Editing and Selection\SelectionDemo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A13575DDA34756D07EDFA664A1E4E3235B13F60BEE74AA0A347197EEB2C25614"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Syncfusion;
using Syncfusion.UI.Xaml.Controls.DataPager;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Converter;
using Syncfusion.UI.Xaml.Grid.RowFilter;
using Syncfusion.UI.Xaml.TreeGrid;
using Syncfusion.UI.Xaml.TreeGrid.Filtering;
using Syncfusion.Windows;
using Syncfusion.Windows.Collections;
using Syncfusion.Windows.ComponentModel;
using Syncfusion.Windows.Controls.Cells;
using Syncfusion.Windows.Controls.Grid;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Controls.Scroll;
using Syncfusion.Windows.Controls.VirtualTreeView;
using Syncfusion.Windows.Data;
using Syncfusion.Windows.Diagnostics;
using Syncfusion.Windows.GridCommon;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Styles;
using Syncfusion.Windows.Tools.Controls;
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
using syncfusion.demoscommon.wpf;
using syncfusion.treegriddemos.wpf;


namespace syncfusion.treegriddemos.wpf {
    
    
    /// <summary>
    /// SelectionDemo
    /// </summary>
    public partial class SelectionDemo : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\Views\Editing and Selection\SelectionDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSelectionMode;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\Editing and Selection\SelectionDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbnavigationMode;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Views\Editing and Selection\SelectionDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Shared.ColorPicker colorPicker;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Views\Editing and Selection\SelectionDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.TreeGrid.SfTreeGrid treeGrid;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\Views\Editing and Selection\SelectionDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
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
            System.Uri resourceLocater = new System.Uri("/syncfusion.treegriddemos.wpf;component/views/editing%20and%20selection/selection" +
                    "demo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Editing and Selection\SelectionDemo.xaml"
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
            this.cmbSelectionMode = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.cmbnavigationMode = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.colorPicker = ((Syncfusion.Windows.Shared.ColorPicker)(target));
            return;
            case 4:
            this.treeGrid = ((Syncfusion.UI.Xaml.TreeGrid.SfTreeGrid)(target));
            return;
            case 5:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
