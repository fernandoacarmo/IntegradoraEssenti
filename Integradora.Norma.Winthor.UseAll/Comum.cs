using Integradora.ECommerce.UseAll.EntityOracle;
using Integradora.ERP.Winthor.EntityEssenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.UseAll
{
    public class Comum
    {
        public static void GravarRegistro(string tabela, string coluna, decimal registro, string metodo, string observacao, string complemento, string documento, bool sucesso)
        {
            //Gravando log de replicacao
            Integradora.ECommerce.UseAll.EntityOracle.ESVReplicacao LogReplicacao = new Integradora.ECommerce.UseAll.EntityOracle.ESVReplicacao();
            LogReplicacao.Tabela = tabela;
            LogReplicacao.Coluna = coluna;
            LogReplicacao.Registro = registro;

            Integradora.ECommerce.UseAll.EntityOracle.ESVReplicacao.GravarRegistroImportado( LogReplicacao
                                                                                           , metodo
                                                                                           , observacao
                                                                                           , complemento
                                                                                           , documento
                                                                                           , sucesso);

            if (!sucesso)
            {
                GerarMensagemEmail( metodo
                                  , observacao
                                  , complemento
                                  , documento
                                  );
            }
        }

        public static void GravarRegistro(ESVReplicacao item, string metodo, string observacao, string complemento, string documento, bool sucesso)
        {
            Integradora.ECommerce.UseAll.EntityOracle.ESVReplicacao.GravarRegistroImportado( item
                                                                                           , metodo
                                                                                           , observacao
                                                                                           , complemento
                                                                                           , documento
                                                                                           , sucesso);

            if (!sucesso)
            {
                GerarMensagemEmail( metodo
                                  , observacao
                                  , complemento
                                  , documento
                                  );
            }
        }

        private static void GerarMensagemEmail(string metodo, string observacao, string complemento, string documento)
        {
            //Grava log na tabela de mensagens a ser enviadas.
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
                Correio.Mensagem = Correio.Mensagem + "Data.......: " + Correio.Dtinclusao.ToString() + Environment.NewLine;
                Correio.Mensagem = Correio.Mensagem + "Método.....: " + metodo + Environment.NewLine;
                Correio.Mensagem = Correio.Mensagem + "Documento..: " + documento + Environment.NewLine;
                Correio.Mensagem = Correio.Mensagem + "Mensagem...: " + observacao + Environment.NewLine;
                Correio.Mensagem = Correio.Mensagem + "Complemento: " + complemento + Environment.NewLine;

                Correio.Gravar();
            }
        }
    }
}
