using Practical_6_ProductCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_6_ProductCatalog.Controllers
{
    public class ProductDetailsController : Controller
    {
        // GET: ProductDetails
        public ActionResult Index()
        {

            List<Product> products = GetProducts();
            return View(products);
        }

        public ActionResult Donell(int id)
        {
            List<Product> products = GetProducts();
            Product product = products.FirstOrDefault(p => p.ProductId == id);
            return View("Donell", product);
        }
        private List<Product> GetProducts() {

            List<Product> products = new List<Product>();


            Product p1 = new Product();

            p1.ProductId = 101;
            p1.ProductName = "MacBook Air";
            p1.ProductDetails = "13.6-inch,Powered by the Apple M5 chip with a fast Neural Engine built for AI and Apple Intelligence,Up to 18 hours on a single charge";
            p1.productCategory = "Laptop";
            p1.ProductPrice = "₹1,49,900";
            p1.ProductQuantity = 30;
            p1.productimg= "https://tse2.mm.bing.net/th/id/OIP.aEeox6DSzQs9EVxx-Uj9UwHaEI?r=0&rs=1&pid=ImgDetMain&o=7&rm=3";




            Product p2 = new Product();

            p2.ProductId = 102;
            p2.ProductName = "iPhone 17 Pro Max";
            p2.ProductDetails = "6.9-inch Super Retina XDR OLED display with a 120Hz refresh rate and 2868x1320 resolution, Apple A19 Pro chip with 12 GB of RAM.";
            p2.productCategory = "Mobile";
            p2.ProductPrice = "₹1,37,900";
            p2.ProductQuantity = 50;
            p2.productimg = "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcRHNWgj6Bk55p1kvZZB8lWLN5Wb_XkLJcpvCl_LjWttgu5UPVA";



            Product p3 = new Product();

            p3.ProductId = 103;
            p3.ProductName = "Apple AirPods 4 ";
            p3.ProductDetails = "Powered by the H2 chip, supporting Personalized Spatial Audio and Voice Isolation for clearer calls.";
            p3.productCategory = "AirPods";
            p3.ProductPrice = "₹12,499";
            p3.ProductQuantity = 10;
            p3.productimg = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9-3ywNg_ER47qZNckquLJtbjmztBKhnT84FPsNls5s0DlU3MBYlDqZ9AR&s=10";

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            return products;
        }
        }
    }
