using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Biblioteca.Tools
{
    public class Logs
    {
        /// <summary>
        /// Notificação das mensagens de erro encontradas
        /// </summary>
        /// <param name="msg"></param>
        public static void Notify(string msg)
        {
            string pathArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.integradora.servico.log");
            StreamWriter vWriter = new StreamWriter(pathArquivo, true);
            vWriter.WriteLine(DateTime.Now.ToString() + ": " + msg);
            vWriter.Flush();
            vWriter.Close();
        }

        public static void GerarLog(string classe, string metodo, Exception erro)
        {
            GerarLog(classe, metodo, string.Empty, erro);
        }
        public static void GerarLog(string classe, string mensagem)
        {
            GerarLog(classe, string.Empty, mensagem, null);
        }
        public static void GerarLog(string classe, string metodo, string mensagem)
        {
            GerarLog(classe, metodo, mensagem, null);
        }
        public static void GerarLog(string mensagem)
        {
            GerarLog(string.Empty, string.Empty, mensagem, null);
        }
        public static void GerarLog(Exception erro)
        {
            GerarLog(string.Empty, string.Empty, string.Empty, erro);
        }
        public static void GerarLog(string classe, string metodo, string mensagem, Exception excessao)
        {
            try
            {
                string pathArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.integradora.processo.log");
                if (File.Exists(pathArquivo))
                {
                    const uint UMMEGA_BYTE = 1048576;
                    FileInfo arquivo = new FileInfo(pathArquivo);
                    if (arquivo.Length > (UMMEGA_BYTE))
                    {
                        string pathArquivoAnterior = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log Anteriores");
                        if (!Directory.Exists(pathArquivoAnterior))
                        {
                            Directory.CreateDirectory(pathArquivoAnterior);
                        }
                        pathArquivoAnterior = Path.Combine(pathArquivoAnterior, DateTime.Now.ToString("ddMMyyyyhhmmss")) + ".log";
                        File.Copy(pathArquivo, pathArquivoAnterior, true);
                        File.Delete(pathArquivo);
                    }
                }
                using (StreamWriter arquivoLog = new StreamWriter(new FileStream(pathArquivo, FileMode.Append)))
                {
                    arquivoLog.WriteLine("===================={0:dd/MM/yyy HH:mm:ss}=======================", DateTime.Now);
                    arquivoLog.WriteLine("Aplicação: {0}", Assembly.GetEntryAssembly() != null ? Assembly.GetEntryAssembly().GetName().Name : "Integradora");
                    arquivoLog.WriteLine("Versão: {0}", Assembly.GetEntryAssembly() != null ? Assembly.GetEntryAssembly().GetName().Version.ToString() : "Não foi possível identificar");
                    arquivoLog.WriteLine("Usuário: {0}", Environment.UserName);
                    arquivoLog.WriteLine("Usuário Domínimo: {0}", Environment.UserDomainName);
                    arquivoLog.WriteLine("Terminal: {0}", Environment.MachineName);
                    if (!string.IsNullOrEmpty(classe))
                    {
                        arquivoLog.WriteLine("Classe: {0}", classe);
                    }

                    if (!string.IsNullOrEmpty(metodo))
                    {
                        arquivoLog.WriteLine("Método: {0}", metodo);
                    }

                    if (!string.IsNullOrEmpty(mensagem))
                    {
                        arquivoLog.WriteLine("Mensagem: {0}", mensagem);
                    }

                    if (excessao != null)
                    {
                        arquivoLog.WriteLine("Exceção: {0}", excessao.Message);
                        Exception excecao = excessao;
                        arquivoLog.WriteLine("Exceção: {0}", excecao.Message);
                        arquivoLog.WriteLine("Pilha: {0} ", excecao.StackTrace);
                        arquivoLog.WriteLine("Source: {0} ", excecao.Source);
                        while (excecao.InnerException != null)
                        {
                            excecao = excecao.InnerException;
                            arquivoLog.WriteLine("Exceção: {0}", excecao.Message);
                            arquivoLog.WriteLine("Pilha: {0} ", excecao.StackTrace);
                            arquivoLog.WriteLine("Source: {0} ", excecao.Source);
                        }
                    }
                    arquivoLog.WriteLine("==============================================================");
                    arquivoLog.WriteLine();
                    arquivoLog.Flush();
                    arquivoLog.Close();
                }
            }
            catch
            {
            }
        }

    }
}
