﻿#pragma checksum "..\..\..\..\ScrollableAutoHidden\View\ScrollableAutoHiddenPanel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "326D4869AE6A79946B94C07FD6F63277214AF3E260B6503B4053E6F20CE88264"
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
using Syncfusion.Windows;
using Syncfusion.Windows.Collections;
using Syncfusion.Windows.ComponentModel;
using Syncfusion.Windows.Controls.Cells;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Controls.Scroll;
using Syncfusion.Windows.Controls.VirtualTreeView;
using Syncfusion.Windows.Diagnostics;
using Syncfusion.Windows.Edit;
using Syncfusion.Windows.GridCommon;
using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Styles;
using Syncfusion.Windows.Tools;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using syncfusion.dockingmanagerdemos.wpf;


namespace syncfusion.dockingmanagerdemos.wpf {
    
    
    /// <summary>
    /// ScrollableAutoHiddenPanel
    /// </summary>
    public partial class ScrollableAutoHiddenPanel : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\ScrollableAutoHidden\View\ScrollableAutoHiddenPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mygrid;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\ScrollableAutoHidden\View\ScrollableAutoHiddenPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MenuGrid;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\ScrollableAutoHidden\View\ScrollableAutoHiddenPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Tools.Controls.DockingManager dockingManager;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\ScrollableAutoHidden\View\ScrollableAutoHiddenPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl autoHiddenWindow;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\..\ScrollableAutoHidden\View\ScrollableAutoHiddenPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl ContentControl1;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\..\ScrollableAutoHidden\View\ScrollableAutoHiddenPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl ContentControl2;
        
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
            System.Uri resourceLocater = new System.Uri("/syncfusion.dockingmanagerdemos.wpf;component/scrollableautohidden/view/scrollabl" +
                    "eautohiddenpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ScrollableAutoHidden\View\ScrollableAutoHiddenPanel.xaml"
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
            this.mygrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.MenuGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.dockingManager = ((Syncfusion.Windows.Tools.Controls.DockingManager)(target));
            return;
            case 4:
            this.autoHiddenWindow = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 5:
            this.ContentControl1 = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 6:
            this.ContentControl2 = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
