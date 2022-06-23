using Green_Backen.DAL;
using Green_Backen.Models;
using Green_Backen.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Green_Backen.Controllers
{
    public class GreenController : Controller
    {
        private readonly AppDbContext context;

        public GreenController(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            GreenVM model = new GreenVM
            {
                Sliders = await context.Sliders.ToListAsync(),
                MainIcons = await context.MainIcons.ToListAsync(),
                About = await context.Abouts.FirstOrDefaultAsync(),
                Services = await context.Services.ToListAsync(),
                Contacts =await context.contacts.ToListAsync()
                
            };
            return View(model);
        }
    }
}
