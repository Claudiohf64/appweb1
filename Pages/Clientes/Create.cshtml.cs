using appweb1.Data;
using appweb1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class CreateModel : PageModel
    {
        public readonly AppDbContext _ctx;
        public CreateModel(AppDbContext ctx){
            _ctx = ctx;
        }
        [BindProperty]
        public Cliente clientes {get; set;}
        public void OnGet()
        {
        }
        public IActionResult OnPost(){
            _ctx.Clientes.Add(clientes);
            _ctx.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
