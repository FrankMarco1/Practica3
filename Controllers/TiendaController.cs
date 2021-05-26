using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Practica3.Models;

namespace Practica3.Controllers
{
   public class TiendaController : Controller{
        private readonly ProductosContext _context;

        public TiendaController(ProductosContext context) {
            _context = context;
        }

        public IActionResult Producto() {
            var Producto = _context.Productos.Include(x => x.Categoria).OrderBy(r => r.NombreProducto).ToList();
            return View(Producto);
        }

        public IActionResult NuevoProducto() {
            ViewBag.Categorias = _context.Categorias.ToList().Select(r => new SelectListItem(r.Nombre, r.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult  NuevoProducto(Producto r) {
            if (ModelState.IsValid) {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("NuevoProductoConfirmacion");
            }
            return View(r);
        }

        public IActionResult NuevoProductoConfirmacion() {
            return View();
        }

          public IActionResult Categoria() {
            var Categorias = _context.Categorias.OrderBy(r => r.Nombre).ToList();
            return View(Categorias);
        }

        public IActionResult NuevaCategoria() {
            /*ViewBag.Categorias = _context.Categorias.ToList().Select(r => new SelectListItem(r.Nombre, r.Id.ToString()));*/
            return View();
        }

        [HttpPost]
        public IActionResult NuevaCategoria(Categoria r) {
            if (ModelState.IsValid) {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("NuevaCategoriaConfirmacion");
            }
            return View(r);
        }

        public IActionResult NuevaCategoriaConfirmacion() {
            return View();
        }
}
}
