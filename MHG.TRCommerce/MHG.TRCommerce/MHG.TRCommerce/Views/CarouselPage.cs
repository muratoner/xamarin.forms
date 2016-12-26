using System.Collections.Generic;
using MHG.TRCommerce.Model;

namespace MHG.TRCommerce.Views {
    public class Carousel : Xamarin.Forms.CarouselPage
    {
        public Carousel()
        {
            var model = new List<ProductModel>
            {
                new ProductModel { Id = 1, ProductName = "ASUS Laptop", Price = 7000M },
                new ProductModel { Id = 2, ProductName = "HTC ONE", Price = 2000M },
                new ProductModel { Id = 3, ProductName = "Retina Table", Price = 1500M },
                new ProductModel { Id = 4, ProductName = "iPhone 7S", Price = 1900M },
                new ProductModel { Id = 5, ProductName = "Sony C5 Ultra", Price = 6500M }
            };

            Children.Add(new Main(model, "En Çok Satanlar"));

            model = new List<ProductModel>
            {
                new ProductModel { Id = 1, ProductName = "Arya TV Ünitesi", Price = 700M },
                new ProductModel { Id = 2, ProductName = "A35 Rio Çalışma Koltuğu", Price = 2000M }
            };

            Children.Add(new Main(model, "En Yeniler"));
        }
    }
}
