using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Threading.Tasks;

namespace Integradora.Mensageiro
{
    public static class Correspondencia
    {
        public static bool EnviarNotificacao(string textoTitulo, string textoMensagem)
        {
            string Emaildestinarario = Integradora.Biblioteca.Dictionaries.Settings.EmailErro();
            string Assunto = textoTitulo;
            if (string.IsNullOrEmpty(Assunto))
            {
                Assunto = "Integradora - Notificação";
            }
            return EnviarEmail(Emaildestinarario, Assunto, textoMensagem);
        }
        public static bool EnviarEmail(string emailDestinatario, string assunto, string textoMensagem)
        {
            if (string.IsNullOrEmpty(emailDestinatario))
            {
                emailDestinatario = Integradora.Biblioteca.Dictionaries.Settings.EmailErro();
            }

            if (string.IsNullOrEmpty(emailDestinatario))
            {
                return false;
            }

            bool resultado = false;
            string servidorSMTP = Integradora.Biblioteca.Dictionaries.Settings.EmailSMTP();
            string email = Integradora.Biblioteca.Dictionaries.Settings.EmailEnvio();
            string senha = Integradora.Biblioteca.Dictionaries.Settings.EmailSenha();
            try
            {
                SmtpClient SmtpServer = new SmtpClient(servidorSMTP);
                var mail = new MailMessage();
                mail.From = new MailAddress(email, "Integradora");
                mail.To.Add(emailDestinatario);
                mail.Subject = assunto;
                mail.IsBodyHtml = true;
                string htmlBody;
                htmlBody = TextToHtml(textoMensagem);
                mail.Body = htmlBody;
                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(email, senha);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);

                resultado = true;
            }
            catch (Exception erro)
            {
                Integradora.Biblioteca.Tools.Logs.GerarLog("Integradora.Mensageiro", "EnviarEmail", erro);
                resultado = false;
            }
            return resultado;
        }

        public static string TextToHtml(string text)
        {
            text = HttpUtility.HtmlEncode(text);
            text = text.Replace("\r\n", "\r");
            text = text.Replace("\n", "\r");
            text = text.Replace("\r", "<br>\r\n");
            text = text.Replace("  ", " &nbsp;");
            return text;
        }
        public static bool EnviarEmail(string emailDestinatario, string nomeDestinatario, string assunto, string textoMensagem, string arquivoAnexo, Configuracao configuracao, Proxy proxy, out Exception erroEmail)
        {
            List<string> anexos = new List<string>();
            if (!string.IsNullOrEmpty(arquivoAnexo))
            {
                anexos.Add(arquivoAnexo);
            }
            List<Destinatario> destinatarios = new List<Destinatario>();
            destinatarios.Add(new Destinatario()
            {
                Nome = nomeDestinatario,
                Email = emailDestinatario,
            });
            return EnviarEmail(destinatarios, assunto, textoMensagem, anexos.ToArray(), configuracao, proxy, out erroEmail);
        }

        public static bool EnviarEmail(List<Destinatario> destinatarios, string assunto, string textoMensagem, string arquivoAnexo, Configuracao configuracao, Proxy proxy, out Exception erroEmail)
        {
            List<string> anexos = new List<string>();
            if (!string.IsNullOrEmpty(arquivoAnexo))
            {
                anexos.Add(arquivoAnexo);
            }
            return EnviarEmail(destinatarios, assunto, textoMensagem, anexos.ToArray(), configuracao, proxy, out erroEmail);
        }

        public static bool EnviarEmail(List<Destinatario> destinatarios, string assunto, string textoMensagem, string[] anexos, Configuracao configuracao, Proxy proxy, out Exception erroEmail)
        {
            erroEmail = null;
            if (!string.IsNullOrEmpty(configuracao.EmailRemetente) && destinatarios.Count > 0)
            {
                try
                {
                    MailAddress enderecoDe = new MailAddress(configuracao.EmailRemetente.Trim(), configuracao.NomeRemetente);
                    MailAddress enderecoResposta = new MailAddress(configuracao.EmailResposta.Trim(), configuracao.NomeResposta);

                    MailMessage mensagem = new MailMessage();
                    mensagem.From = enderecoDe;

                    foreach (Destinatario destinatario in destinatarios)
                    {
                        if (!string.IsNullOrEmpty(destinatario.Nome))
                        {
                            mensagem.Bcc.Add(new MailAddress(destinatario.Email, destinatario.Nome));
                        }
                        else
                        {
                            mensagem.Bcc.Add(new MailAddress(destinatario.Email));
                        }
                    }

                    mensagem.Subject = assunto;
                    mensagem.IsBodyHtml = true;

                    StringBuilder mensagemHTML = new StringBuilder();
                    //mensagemHTML.AppendLine("<SPAN STYLE='FONT-FAMILY: Tahoma;FONT-SIZE: 8pt;COLOR: black;'>");
                    mensagemHTML.AppendLine(textoMensagem);
                    //mensagemHTML.AppendLine("</SPAN>");

                    mensagem.Body = mensagemHTML.ToString();

                    mensagem.Priority = MailPriority.High;
                    if (!string.IsNullOrEmpty(configuracao.EmailResposta))
                    {
                        mensagem.ReplyToList.Add(new MailAddress(configuracao.EmailResposta, configuracao.NomeResposta));
                    }
                    //  mensagem.CC.Add(enderecoResposta);
                    foreach (string arquivo in anexos)
                    {
                        if (File.Exists(arquivo))
                        {
                            mensagem.Attachments.Add(new Attachment(arquivo));
                        }
                    }

                    SmtpClient smtp = new SmtpClient(configuracao.Endereco, configuracao.Porta);
                    smtp.UseDefaultCredentials = true;

                    NetworkCredential credencial = new NetworkCredential(configuracao.Usuario, configuracao.Senha);
                    smtp.Credentials = credencial;
                    smtp.EnableSsl = configuracao.AtivaSSL;
                    smtp.Timeout = 900000;
                    smtp.Send(mensagem);
                    return true;
                }
                catch (Exception erro)
                {
                    erroEmail = erro;
                    Integradora.Biblioteca.Tools.Logs.GerarLog("Integradora.Mensageiro", "EnviarEmail", erro);
                    return false;
                }
                finally
                {
                }
            }
            else
            {
                erroEmail = new Exception("Email destinário ou remetente vazio");
            }
            return false;
        }

        public class Destinatario
        {
            public string Nome { get; set; }
            public string Email { get; set; }
        }

        public class Proxy
        {
            public string Usuario { get; set; }
            public string Senha { get; set; }
            public string Endereco { get; set; }
            public int Porta { get; set; }
            public static Proxy Novo(string usuario, string senha, string endereco, int porta)
            {
                return new Proxy()
                {
                    Usuario = usuario,
                    Senha = senha,
                    Endereco = endereco,
                    Porta = porta
                };
            }
        }

        public class Configuracao
        {
            public string NomeRemetente { get; set; }
            public string EmailRemetente { get; set; }
            public string Endereco { get; set; }
            public int Porta { get; set; }
            public string Usuario { get; set; }
            public string Senha { get; set; }
            public string EmailResposta { get; set; }
            public string NomeResposta { get; set; }
            public bool AtivaSSL { get; set; }
            public static Configuracao Novo(string emailRemetente, string nomeRemetente, string endereco, int porta, string usuario, string senha, string emailResposta, string nomeResposta, bool ativaSSL)
            {
                return new Configuracao()
                {
                    EmailRemetente = emailRemetente,
                    NomeRemetente = nomeRemetente,
                    Endereco = endereco,
                    Porta = porta,
                    Usuario = usuario,
                    Senha = senha,
                    EmailResposta = emailResposta,
                    NomeResposta = nomeResposta,
                    AtivaSSL = ativaSSL,
                };
            }
        }
    }
}
