using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnadoluMobılya.Entitiy
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name="KAMERA", Description="Kamera ürünleri"},
                new Category(){Name="BİLGİSAYAR", Description="Bilgisayar ürünleri"}

            };
            foreach (var item in kategoriler)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
new Product() {Name="Canon", Description="Kamera", Price=2500 ,Stock=50, IsHome=true, CategoryId=1 , Image="kamera1.jpg", IsApproved=true,IsFeatured=false},
new Product() {Name="Asus", Description="Asus Bilgisayar", Price=4500 ,Stock=40, IsHome=false, CategoryId=2 , Image="pc1.jpg", IsApproved=true,IsFeatured=true},
new Product() {Name="Lenovo", Description="Lenovo Bilgisayar", Price=3500 ,Stock=10, IsHome=true, CategoryId=2 , Image="pc2.jpg", IsApproved=true,IsFeatured=false},
            };

            foreach (var item in urunler)
            {
                context.Products.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}