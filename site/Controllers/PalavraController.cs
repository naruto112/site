using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using site.Database;
using site.Models;

namespace site.Controllers
{
    public class PalavraController : Controller
    {
        private DatabaseContext _db;
        public PalavraController(DatabaseContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var palavras = _db.Palavras.ToList();
            return View(palavras);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Palavra palavra)
        {

            return View();
        }

        [HttpGet]
        public IActionResult Atualizar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm]Palavra palavra)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
