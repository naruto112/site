using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using site.Library.Mail;
using site.Models;

namespace site.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Contato = new Contato();
            return View();
        }

        public IActionResult ReceberContato([FromForm] Contato contato)
        {
            if(ModelState.IsValid)
            {
                //string conteudo = string.Format("Nome: {0}, E-mail: {1}, Assunto: {2}, Mensagem: {3}",
                //contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
                //return new ContentResult() { Content = conteudo };

                ViewBag.Contato = new Contato();
                SendMail.EnviarMensagem(contato);
                ViewBag.Mensagem = "Mensagem enviada com sucesso!";

                return View("Index");
            }
            else
            {
                ViewBag.Contato = contato;
                return View("Index");
            }

            
        }

        //public IActionResult ReceberContato()
        //{
        //    Contato contato = new Contato();

        //    contato.Nome = Request.Form["nome"];
        //    contato.Email = Request.Form["email"];
        //    contato.Assunto = Request.Form["assunto"];
        //    contato.Mensagem = Request.Form["mensagem"];

        //    string conteudo = string.Format("Nome: {0}, E-mail: {1}, Assunto: {2}, Mensagem: {3}",
        //        contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

        //    return new ContentResult() { Content = conteudo };
        //}
    }
}