using System;
using Microsoft.AspNetCore.Mvc;
using site.Models;

namespace site.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([FromForm]Usuario usuario)
        {

            if (ModelState.IsValid)
            {
                if (usuario.Email == "renatorock3@hotmail.com" && usuario.Senha == "123@Mudar123")
                {
                    return RedirectToAction("Index", "Palavra");
                }
                else
                {
                    ViewBag.Mensagem = "Os dados informados são inválidos";
                    return View();
                }

            } else
            {
                return View();
            }

            
        }
    }
}
