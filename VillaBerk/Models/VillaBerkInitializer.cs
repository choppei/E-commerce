using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VillaBerk.Models
{
    public class VillaBerkInitializer: DropCreateDatabaseAlways<VillaBerkContext>
    {
        protected override void Seed(VillaBerkContext context)
        {

            List<Category> kategoriler = new List<Category>()
            {
                new Category() { Name="Furniture" },
                new Category() { Name="Electronics" },
                new Category() { Name="Books" },
                new Category() { Name="Accessories" },
                new Category() { Name="Computers" },
                new Category() { Name="Camera" },
            };

            foreach (var item in kategoriler)
            {
                context.Categories.Add(item);
            }

            context.SaveChanges();



            List<Product> urunler = new List<Product>()
            {
                new Product() { Name="Photo Camera", Image="product1.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", isApproved=true, isFeatured=true, isHome=false, Price=99, CategoryId=1 },
                new Product() { Name="Comfortable Sofa", Image="product3.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", isApproved=true, isFeatured=true, Price=49, CategoryId=6 },
                new Product() { Name="Hand Bag", Image="product4.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", isApproved=true, isFeatured=true, isHome=true, Price=79, CategoryId=6 },
                new Product() { Name="Photo Camera", Image="product1.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", isApproved=true, isFeatured=true, Price=99, CategoryId=1 },
                new Product() { Name="Photo Camera", Image="product1.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", isApproved=false, isFeatured=false, isHome=true, Price=99, CategoryId=1 },
                new Product() { Name="Photo Camera", Image="product1.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", isApproved=true, isFeatured=true, isHome=true, Price=99, CategoryId=2 },
                new Product() { Name="Photo Camera", Image="product1.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", isApproved=false, isFeatured=true, isHome=false, Price=99, CategoryId=2 },
                new Product() { Name="Photo Camera", Image="product1.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", isApproved=true, isFeatured=true, isHome=true, Price=99, CategoryId=3 },
                new Product() { Name="Photo Camera", Image="product1.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", isApproved=true, isFeatured=false, Price=99, CategoryId=3 },
                new Product() { Name="Photo Camera", Image="product1.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", isApproved=true, isFeatured=false, Price=99, CategoryId=3 },
                new Product() { Name="Photo Camera", Image="product1.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", isApproved=false, isFeatured=true, Price=99, CategoryId=4 },
                new Product() { Name="Photo Camera", Image="product1.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", isApproved=true, isFeatured=false, Price=99, CategoryId=4 },
                new Product() { Name="Photo Camera", Image="product1.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", isApproved=false, isFeatured=false, Price=99, CategoryId=4 },
                new Product() { Name="Photo Camera", Image="product1.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", isApproved=false, isFeatured=true, Price=99, CategoryId=5 },
                new Product() { Name="Photo Camera", Image="product1.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", isApproved=true, isFeatured=false, Price=99, CategoryId=5 }

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