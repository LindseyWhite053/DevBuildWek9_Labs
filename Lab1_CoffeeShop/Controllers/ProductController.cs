using Microsoft.AspNetCore.Mvc;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using Lab1_CoffeeShop.Models;

namespace Lab1_CoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=coffeeshop;Uid=root;Pwd=generalpw1");

            List<Product> prods = db.GetAll<Product>().ToList();

            return View(prods);
        }

        public IActionResult Detail(string id)
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=coffeeshop;Uid=root;Pwd=generalpw1");
            Product product = db.Get<Product>(id);

            return View(product);
        }
    }
}
