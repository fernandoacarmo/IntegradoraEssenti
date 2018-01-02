using Integradora.Biblioteca.Dictionaries;
using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityEssenti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.Norma.Winthor
{
    public abstract class Processo : Integradora.Norma.Integracao
    {
        protected abstract override void Send();
        protected abstract override void Receive();
        protected abstract override void Initialize();

        private Tips.ClientePC clientepc;
        [XmlElement(ElementName = "CLIENTEPC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public Tips.ClientePC ClientePC
        {
            get { return clientepc; }
            set { clientepc = value; }
        }

        public static void Notificar(string local, string funcao, Exception mensagem)
        {
            Notificar(local, funcao, mensagem.ToString());
        }

        public static void Notificar(string local, string funcao, string mensagem)
        {
            try
            { //Grava log na tabela de mensagens a ser enviadas.
                if (!String.IsNullOrEmpty(Biblioteca.Dictionaries.Settings.EmailErro())
                 && !String.IsNullOrEmpty(Biblioteca.Dictionaries.Settings.EmailSMTP())
                 && !String.IsNullOrEmpty(Biblioteca.Dictionaries.Settings.EmailSenha()))
                {//Gerando mensagem para o email.
                    Correspondencias Correio = new Correspondencias();
                    Correio.Correspondencia_Id = Correio.Proximo("SEQ_CORRESPONDENCIAS");
                    Correio.Destinatario = Biblioteca.Dictionaries.Settings.EmailErro();
                    Correio.Email = Biblioteca.Dictionaries.Settings.EmailErro();
                    Correio.Dtinclusao = DateTime.Now;
                    Correio.Titulo = "Notificação da integradora";
                    Correio.Mensagem = "";
                    Correio.Mensagem = Correio.Mensagem + "Data....: " + Correio.Dtinclusao.ToString() + Environment.NewLine;
                    Correio.Mensagem = Correio.Mensagem + "Local...: " + local + Environment.NewLine; 
                    Correio.Mensagem = Correio.Mensagem + "Função..: " + funcao + Environment.NewLine; 
                    Correio.Mensagem = Correio.Mensagem + "Mensagem: " + mensagem.Replace("'", "`") + Environment.NewLine; 

                    Persistencia ba = new Persistencia(Correspondencias.GetStringConnection());
                    ba.Inserir(Correio);
                }
            }
            catch
            { 

            }
            //Gravar log em arquivo 
            Logs.GerarLog(local, funcao, mensagem);
        }
        public override void Execute()
        {
            try
            {
                ValidarBancoDeDados();
            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.Norma.Winthor", "Execute", "Erro ao atualizar banco de dados: " + erro);
            }

            try
            {
                SendMail();
                Send(); //Enviando registros
                SendMail();
                Receive(); //Recebendo registros 
                SendMail();
            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.Norma.Winthor", "Execute", erro);
            }
        }

        private void ValidarBancoDeDados()
        {
            if (Biblioteca.Dictionaries.Settings.ManutencaoBancoDados() == "S")
            {
                ManutencaoBancoDados Validador = new ManutencaoBancoDados();
                Validador.Executar();
            }
        }

        private void SendMail()
        {
            if (!string.IsNullOrEmpty(Biblioteca.Dictionaries.Settings.EmailSMTP()))
            {
                //Obtendo lista de e-mails não enviados
                var lista = Integradora.ERP.Winthor.Domain.Notificacao.Load();
                foreach (var item in lista)
                {   //Iniciando transação com o banco de dados
                    using (var transaction = new System.Transactions.CommittableTransaction())
                    {
                        try
                        {   //Enviar e-mail
                            Integradora.Mensageiro.Correspondencia.EnviarEmail(item.Email, item.Titulo, item.Mensagem);
                            //Intervalo para o próximo email a ser enviado
                            Thread.Sleep(500);
                            //Retira o registro da fila para não ser mais enviado
                            Integradora.ERP.Winthor.Domain.Notificacao.Remove(item);
                            //Commitir da transação
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {   //Tratamento de exceções
                            transaction.Rollback();
                            Logs.GerarLog("Integradora.Norma.Winthor", "SendMail", ex);
                            return; //Caso de erro não tenta enviar os demais.
                        }
                    }
                }
            }
        }
    }
}
