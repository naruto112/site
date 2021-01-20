using System;
using System.Net;
using System.Net.Mail;
using site.Models;

namespace site.Library.Mail
{
    public class SendMail
    {
        public static void EnviarMensagem(Contato contato)
        {

            string conteudo = string.Format("Nome: {0}<br /> E-mail: {1}<br /> Assunto: {2}<br /> Mensagem: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

            SmtpClient smtp = new SmtpClient(Constants.ServerSMTP, Constants.PortSMTP);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha);


            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress(Constants.Usuario);
            mensagem.To.Add("realberlym@gmail.com");
            mensagem.Subject = "Formulário de contato";

            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h1>Formulário de contato</h1>" + conteudo;

            smtp.Send(mensagem);
        }
    }
}
