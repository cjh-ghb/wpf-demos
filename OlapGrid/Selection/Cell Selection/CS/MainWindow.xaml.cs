#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace CellSelection
{
    using System;
    using SampleUtils;

    public partial class MainWindow : SampleWindow
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            try
            {
                ViewModel.ViewModel.ConnectionString = GetConnectionString();
                InitializeComponent();
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }
        #endregion     
    }
}