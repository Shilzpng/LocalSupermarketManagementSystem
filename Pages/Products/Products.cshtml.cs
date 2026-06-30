using Microsoft.AspNetCore.Mvc.RazorPages;
using LocalSupermarketManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalSupermarketManagementSystem.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly AppDbContext _context;

        public ProductsModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Product> ProductList { get; set; } = new();

        public async Task OnGetAsync()
        {
            ProductList = await _context.Products.ToListAsync();
        }
    }
}