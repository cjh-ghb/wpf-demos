#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace syncfusion.treeviewdemos.wpf
{
    /// <summary>
    /// Interaction logic for DragDropBetweenTreeViewAndDataGridDemo.xaml
    /// </summary>
    public partial class DragDropBetweenTreeViewAndDataGridDemo : DemoControl
    {
        public DragDropBetweenTreeViewAndDataGridDemo()
        {
            InitializeComponent();
        }
		
		public DragDropBetweenTreeViewAndDataGridDemo(string themename) : base(themename)
        {
            InitializeComponent();
        }
		
        protected override void Dispose(bool disposing)
        {
            // Release all managed resources
            if (this.sfTreeView != null)
            {
                this.sfTreeView.Dispose();
                this.sfTreeView = null;
            }
            if (this.sfDataGrid != null)
            {
                this.sfDataGrid.Dispose();
                this.sfDataGrid = null;
            }
             
            base.Dispose(disposing);
        }
    }
}
