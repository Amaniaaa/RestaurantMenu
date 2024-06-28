using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace restaurantMenu.Views.Menu
{
    public class IndexModel : PageModel
    {
        public List<MenuItem> MenuItems { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Menu";

            // Sample menu items
            MenuItems = new List<MenuItem>
            {
                new MenuItem { Id = 1, Name = "Item 1", Price = 10.99M },
                new MenuItem { Id = 2, Name = "Item 2", Price = 12.99M },
                // Add more items as needed
            };

        }
    }

    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
