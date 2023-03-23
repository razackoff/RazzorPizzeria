using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazzorPizzeria.Models;

namespace RazzorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizzas { get; set; }
        public void OnGet()
        {
        }
    }
}
