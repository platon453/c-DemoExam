using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace ShopShoes123.ViewModels
{
    public class ProductViewModel
    {

        public ProductViewModel(Products product)
        {
            ProductID = product.ProductID;
            Article = product.Article;
            ProductNameID = product.ProductNameID;
            Unit = product.Unit;
            Price = product.Price;
            SupplierID = product.SupplierID;
            ProducerID = product.ProducerID;
            CategoryID = product.CategoryID;
            Discount = product.Discount;
            QuantityInStock = product.QuantityInStock;
            Description = product.Description;
            Photo = product.Photo;
            Categories = product.Categories;
            OrdersProducts = product.OrdersProducts;
            Producers = product.Producers;
            ProductNames = product.ProductNames;
            Suppliers = product.Suppliers;

            GetBackground();
            GetPhoto();

        }
        public int ProductID { get; set; }
        public string Article { get; set; }
        public Nullable<int> ProductNameID { get; set; }
        public string Unit { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> ProducerID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<double> QuantityInStock { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public virtual Categories Categories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersProducts> OrdersProducts { get; set; }
        public virtual Producers Producers { get; set; }
        public virtual ProductNames ProductNames { get; set; }
        public virtual Suppliers Suppliers { get; set; }
        public Brush Background { get; set; }
        private void GetBackground()
        {
            if (Discount >= 15)
            {
                Background = (Brush)new BrushConverter().ConvertFromString("#2e8b57");
                return;
            }
            else if (QuantityInStock == 0)
            {
                Background = Brushes.LightBlue;
                return;
            }
            else
            {
                Background = (Brush)new BrushConverter().ConvertFromString("#7fff00");
                return;
            }
        }
        private void GetPhoto()
        {
            if (!string.IsNullOrEmpty(Photo) || Photo != "")
                return;
            Photo = "Res/picture.png";
        }



    }
}
