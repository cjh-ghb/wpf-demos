#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syncfusion.chartdemos.wpf
{
   public class ScatterChartViewModel
    {
       public ScatterChartViewModel()
       {
           this.DataPoints = new ObservableCollection<ScatterChartModel>();
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.600f, WaitingTime = 79 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.800f, WaitingTime = 54 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.333f, WaitingTime = 74 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.283f, WaitingTime = 62 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.533f, WaitingTime = 85 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.883f, WaitingTime = 55 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.700f, WaitingTime = 88 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.600f, WaitingTime = 85 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.950f, WaitingTime = 51 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.350f, WaitingTime = 85 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.833f, WaitingTime = 54 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.917f, WaitingTime = 84 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.200f, WaitingTime = 78 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.750f, WaitingTime = 47 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.700f, WaitingTime = 83 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.167f, WaitingTime = 52 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.750f, WaitingTime = 62 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.800f, WaitingTime = 84 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.600f, WaitingTime = 52 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.250f, WaitingTime = 79 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.800f, WaitingTime = 51 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.750f, WaitingTime = 47 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.450f, WaitingTime = 78 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.067f, WaitingTime = 69 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.533f, WaitingTime = 74 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.600f, WaitingTime = 83 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.967f, WaitingTime = 55 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.083f, WaitingTime = 76 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.850f, WaitingTime = 78 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.433f, WaitingTime = 79 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.300f, WaitingTime = 73 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.467f, WaitingTime = 77 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.367f, WaitingTime = 66 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.033f, WaitingTime = 80 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.833f, WaitingTime = 74 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.017f, WaitingTime = 52 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.867f, WaitingTime = 48 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.833f, WaitingTime = 80 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.833f, WaitingTime = 59 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.783f, WaitingTime = 90 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.350f, WaitingTime = 80 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.883f, WaitingTime = 58 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.567f, WaitingTime = 84 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.750f, WaitingTime = 58 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.533f, WaitingTime = 73 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.317f, WaitingTime = 83 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.833f, WaitingTime = 64 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.100f, WaitingTime = 53 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.633f, WaitingTime = 82 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.000f, WaitingTime = 59 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.800f, WaitingTime = 75 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.716f, WaitingTime = 90 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.833f, WaitingTime = 54 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.833f, WaitingTime = 80 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.733f, WaitingTime = 54 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.883f, WaitingTime = 83 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.717f, WaitingTime = 71 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.667f, WaitingTime = 64 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.567f, WaitingTime = 77 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.317f, WaitingTime = 81 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.233f, WaitingTime = 59 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.500f, WaitingTime = 84 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.750f, WaitingTime = 48 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.800f, WaitingTime = 82 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.817f, WaitingTime = 60 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.400f, WaitingTime = 92 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.167f, WaitingTime = 78 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.700f, WaitingTime = 78 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.067f, WaitingTime = 65 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.700f, WaitingTime = 73 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.033f, WaitingTime = 82 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.967f, WaitingTime = 56 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.500f, WaitingTime = 79 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.000f, WaitingTime = 71 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.983f, WaitingTime = 62 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 5.067f, WaitingTime = 76 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.017f, WaitingTime = 60 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.567f, WaitingTime = 78 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.883f, WaitingTime = 76 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.600f, WaitingTime = 83 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.133f, WaitingTime = 75 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.333f, WaitingTime = 82 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.100f, WaitingTime = 70 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.633f, WaitingTime = 65 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.067f, WaitingTime = 73 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.933f, WaitingTime = 88 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.950f, WaitingTime = 76 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.517f, WaitingTime = 80 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.167f, WaitingTime = 48 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.000f, WaitingTime = 86 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.200f, WaitingTime = 60 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.333f, WaitingTime = 90 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.867f, WaitingTime = 50 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.817f, WaitingTime = 78 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.833f, WaitingTime = 63 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.300f, WaitingTime = 72 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.667f, WaitingTime = 84 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.750f, WaitingTime = 75 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.867f, WaitingTime = 51 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.900f, WaitingTime = 82 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.483f, WaitingTime = 62 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.367f, WaitingTime = 88 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.100f, WaitingTime = 49 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.500f, WaitingTime = 83 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.050f, WaitingTime = 81 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.867f, WaitingTime = 47 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.700f, WaitingTime = 84 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.783f, WaitingTime = 52 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.850f, WaitingTime = 86 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.683f, WaitingTime = 81 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.733f, WaitingTime = 75 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.300f, WaitingTime = 59 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.900f, WaitingTime = 89 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.417f, WaitingTime = 79 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.700f, WaitingTime = 59 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.633f, WaitingTime = 81 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.317f, WaitingTime = 50 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.600f, WaitingTime = 85 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.817f, WaitingTime = 59 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.417f, WaitingTime = 87 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.617f, WaitingTime = 53 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.067f, WaitingTime = 69 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.250f, WaitingTime = 77 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.967f, WaitingTime = 56 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.600f, WaitingTime = 88 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.767f, WaitingTime = 81 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.917f, WaitingTime = 45 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.500f, WaitingTime = 82 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.267f, WaitingTime = 55 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.650f, WaitingTime = 90 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.867f, WaitingTime = 45 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.167f, WaitingTime = 83 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.800f, WaitingTime = 56 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.333f, WaitingTime = 89 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.833f, WaitingTime = 46 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.383f, WaitingTime = 82 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.883f, WaitingTime = 51 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.933f, WaitingTime = 86 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.033f, WaitingTime = 53 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.733f, WaitingTime = 79 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.233f, WaitingTime = 81 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.233f, WaitingTime = 60 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.533f, WaitingTime = 82 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.817f, WaitingTime = 77 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.333f, WaitingTime = 76 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.983f, WaitingTime = 59 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.633f, WaitingTime = 80 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.017f, WaitingTime = 49 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 5.100f, WaitingTime = 96 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.800f, WaitingTime = 53 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 5.033f, WaitingTime = 77 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.000f, WaitingTime = 77 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.400f, WaitingTime = 65 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.600f, WaitingTime = 81 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.567f, WaitingTime = 71 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.000f, WaitingTime = 70 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.500f, WaitingTime = 81 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.083f, WaitingTime = 93 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.800f, WaitingTime = 53 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.967f, WaitingTime = 89 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.200f, WaitingTime = 45 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.150f, WaitingTime = 86 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.000f, WaitingTime = 58 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.833f, WaitingTime = 78 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.500f, WaitingTime = 66 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.583f, WaitingTime = 76 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.367f, WaitingTime = 63 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 5.000f, WaitingTime = 88 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.933f, WaitingTime = 52 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.617f, WaitingTime = 93 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.917f, WaitingTime = 49 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.083f, WaitingTime = 57 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.583f, WaitingTime = 77 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.333f, WaitingTime = 68 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.167f, WaitingTime = 81 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.333f, WaitingTime = 81 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.500f, WaitingTime = 73 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.417f, WaitingTime = 50 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.000f, WaitingTime = 85 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.167f, WaitingTime = 74 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.883f, WaitingTime = 55 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.583f, WaitingTime = 77 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.250f, WaitingTime = 83 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.767f, WaitingTime = 83 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.033f, WaitingTime = 51 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.433f, WaitingTime = 78 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.083f, WaitingTime = 84 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.833f, WaitingTime = 46 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.417f, WaitingTime = 83 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.183f, WaitingTime = 55 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.800f, WaitingTime = 81 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.833f, WaitingTime = 57 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.800f, WaitingTime = 76 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.100f, WaitingTime = 84 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.966f, WaitingTime = 77 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.233f, WaitingTime = 81 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.500f, WaitingTime = 87 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.366f, WaitingTime = 77 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.250f, WaitingTime = 51 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.667f, WaitingTime = 78 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.100f, WaitingTime = 60 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.350f, WaitingTime = 82 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.133f, WaitingTime = 91 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.867f, WaitingTime = 53 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.600f, WaitingTime = 78 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.783f, WaitingTime = 46 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.367f, WaitingTime = 77 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.850f, WaitingTime = 84 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.933f, WaitingTime = 49 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.500f, WaitingTime = 83 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.383f, WaitingTime = 71 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.700f, WaitingTime = 80 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.867f, WaitingTime = 49 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.833f, WaitingTime = 75 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.417f, WaitingTime = 64 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.233f, WaitingTime = 76 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.400f, WaitingTime = 53 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.800f, WaitingTime = 94 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.000f, WaitingTime = 55 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.150f, WaitingTime = 76 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.867f, WaitingTime = 50 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.267f, WaitingTime = 82 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.750f, WaitingTime = 54 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.483f, WaitingTime = 75 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.000f, WaitingTime = 78 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.117f, WaitingTime = 79 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.083f, WaitingTime = 78 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.267f, WaitingTime = 78 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.917f, WaitingTime = 70 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.550f, WaitingTime = 79 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.083f, WaitingTime = 70 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.417f, WaitingTime = 54 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.183f, WaitingTime = 86 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.217f, WaitingTime = 50 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.450f, WaitingTime = 90 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.883f, WaitingTime = 54 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.850f, WaitingTime = 54 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.283f, WaitingTime = 77 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.950f, WaitingTime = 79 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.333f, WaitingTime = 64 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.150f, WaitingTime = 75 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.350f, WaitingTime = 47 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.933f, WaitingTime = 86 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.900f, WaitingTime = 63 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.583f, WaitingTime = 85 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.833f, WaitingTime = 82 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.083f, WaitingTime = 57 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.367f, WaitingTime = 82 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.133f, WaitingTime = 67 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.350f, WaitingTime = 74 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.200f, WaitingTime = 54 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.450f, WaitingTime = 83 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.567f, WaitingTime = 73 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.500f, WaitingTime = 73 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.150f, WaitingTime = 88 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.817f, WaitingTime = 80 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 3.917f, WaitingTime = 71 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.450f, WaitingTime = 83 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.000f, WaitingTime = 56 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.283f, WaitingTime = 79 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.767f, WaitingTime = 78 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.533f, WaitingTime = 84 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.850f, WaitingTime = 58 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.250f, WaitingTime = 83 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.983f, WaitingTime = 43 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.250f, WaitingTime = 60 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.750f, WaitingTime = 75 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.117f, WaitingTime = 81 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 2.150f, WaitingTime = 46 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.417f, WaitingTime = 90 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 1.817f, WaitingTime = 46 });
           DataPoints.Add(new ScatterChartModel() { Eruptions = 4.467f, WaitingTime = 74 });
       }                                       
                           
       public ObservableCollection<ScatterChartModel> DataPoints
       {
           get;
           set;
       }
    }
}



