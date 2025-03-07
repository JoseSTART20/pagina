﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pagina.Models;

namespace pagina.Controlers
{
    public class BrandController : Controller
    {
        private readonly webContext _context;
        public BrandController(webContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Empleados.ToListAsync());
        }
    }
}
