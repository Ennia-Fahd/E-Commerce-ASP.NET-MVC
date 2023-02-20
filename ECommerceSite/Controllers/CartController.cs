using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceSite.Data;
using ECommerceSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ECommerceSite.Controllers
{
    public class CartController : Controller
    {
        private readonly ProductContext _context;
        private readonly IHttpContextAccessor _httpcontext;

        public CartController(ProductContext context, IHttpContextAccessor httpContext)
        {
            _context = context;
            _httpcontext = httpContext;
        }

        /// <summary>
        /// Adds a product to the shopping cart
        /// </summary>
        /// <param name="id">The id of the product to add</param>
        /// <returns></returns>
        public async Task<IActionResult> Add(int id, string prevUrl) // Id of the product to add
        {
            Product product = await ProductDb.GetProductAsync(_context, id);

            Panier.AddProductToCart(_httpcontext, product);

            TempData["Message"] = product.Title + " added successfully";

            // Redirect to previous page
            return Redirect(prevUrl);
        }



       

        public IActionResult ClearCart()
        {
            Panier.ClearCart(_httpcontext);
            TempData["Message"] = "Cart cleared successfully";
            return RedirectToAction("OrderConfirmation");
        }
        public IActionResult OrderConfirmation()
        {
            ViewBag.Message = "Thank you for your order!";
            return View();
        }
        public IActionResult Summary()
        { 
            
            List<Product> cartProducts = Panier.GetCartProducts(_httpcontext);
            decimal totalPrice = (decimal)cartProducts.Sum(p => p.Price);

            ViewBag.CartProducts = cartProducts;
            ViewBag.TotalPrice = totalPrice;
            return View(cartProducts); 
        }    
    }
}

