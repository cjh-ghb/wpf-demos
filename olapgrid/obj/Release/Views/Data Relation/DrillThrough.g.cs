﻿#pragma checksum "..\..\..\..\Views\Data Relation\DrillThrough.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "04A59B653E89780502DF4992AF541224D68292306DE95F24CA695D5AE702634F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
using Syncfusion;
using Syncfusion.Olap.Manager;
using Syncfusion.Olap.Reports;
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
using Syncfusion.Windows.Grid.Olap;
using Syncfusion.Windows.GridCommon;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Shared.Olap;
using Syncfusion.Windows.Styles;
using Syncfusion.Windows.Tools;
using Syncfusion.Windows.Tools.Controls;
using Syncfusion.Windows.Tools.Olap;
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
using syncfusion.olapgriddemos.wpf;


namespace syncfusion.olapgriddemos.wpf {
    
    
    /// <summary>
    /// DrillThrough
    /// </summary>
    public partial class DrillThrough : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\Views\Data Relation\DrillThrough.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Grid.Olap.OlapGrid olapGrid1;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\Data Relation\DrillThrough.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Grid.Olap.OlapGrid olapGrid2;
        
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
            System.Uri resourceLocater = new System.Uri("/syncfusion.olapgriddemos.wpf;component/views/data%20relation/drillthrough.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Data Relation\DrillThrough.xaml"
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
            this.olapGrid1 = ((Syncfusion.Windows.Grid.Olap.OlapGrid)(target));
            return;
            case 2:
            this.olapGrid2 = ((Syncfusion.Windows.Grid.Olap.OlapGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
