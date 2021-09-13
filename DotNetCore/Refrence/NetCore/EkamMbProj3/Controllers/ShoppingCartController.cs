using EkamArtMBProj.Models;
using EkamArtMBProj.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkamArtMBProj.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPaintingRepo _paintingRepo;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPaintingRepo paintingRepo, ShoppingCart shoppingCart)
        {
            _paintingRepo = paintingRepo;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
               
            };

            return View(shoppingCartViewModel);

        }

        public RedirectToActionResult AddToShoppingCart(int paintingId)
        {
            var selectedPainting = _paintingRepo.Allpaintings.FirstOrDefault(p => p.PaintingId == paintingId);
            if (selectedPainting != null)
            {
                _shoppingCart.AddToCart(selectedPainting, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int paintingId)
        {
            var selectedPainting = _paintingRepo.Allpaintings.FirstOrDefault(p => p.PaintingId == paintingId);
            if (selectedPainting != null)
            {
                _shoppingCart.RemoveFromCart(selectedPainting);
            }
            return RedirectToAction("Index");
        }
    }
}
