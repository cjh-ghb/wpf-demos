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

namespace SplineAreaChart
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.Products = new ObservableCollection<Model>();
            Products.Add(new Model() { ProdName = "Toyota", Price = 11, Stock = 10 });
            Products.Add(new Model() { ProdName = "Volkswagen", Price = 8, Stock = 7 });
            Products.Add(new Model() { ProdName = "Audi", Price = 2, Stock = 1 });
            Products.Add(new Model() { ProdName = "Ford", Price = 8, Stock = 7 });
            Products.Add(new Model() { ProdName = "Mercedes", Price = 2, Stock = 1 });
            Products.Add(new Model() { ProdName = "Hyundai", Price = 5, Stock = 5 });
        }

        public ObservableCollection<Model> Products { get; set; }
    }
}
