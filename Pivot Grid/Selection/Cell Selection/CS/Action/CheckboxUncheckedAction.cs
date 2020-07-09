#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace CellSelection.Action
{
    using System.Windows.Controls;
    using System.Windows.Interactivity;

    class CheckboxUncheckedAction : TargetedTriggerAction<ListBox>
    {
        protected override void Invoke(object parameter)
        {
            this.Target.ItemsSource = null;
        }
    }
}