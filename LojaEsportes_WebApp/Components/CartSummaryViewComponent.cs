using Microsoft.AspNetCore.Mvc;
using LojaEsportes_WebApp.Models;

namespace LojaEsportes_WebApp.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}