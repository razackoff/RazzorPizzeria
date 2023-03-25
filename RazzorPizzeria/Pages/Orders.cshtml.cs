using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazzorPizzeria.Data;
using RazzorPizzeria.Models;

namespace RazzorPizzeria.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();
        
        private readonly ApplicationDbContext context;

        public OrdersModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            PizzaOrders = context.PizzaOrders.ToList();
        }
    }
}
