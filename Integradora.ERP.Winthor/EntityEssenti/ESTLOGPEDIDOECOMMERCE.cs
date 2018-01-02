using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;
using Integradora.Biblioteca.Tools;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe referente a tabela ESTLogpedidoecommerce
    /// </summary>
    [XmlType("ESTLOGPEDIDOECOMMERCE")]
    public class ESTLogpedidoecommerce : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DTPRIMEIRA
        /// Comentário: 
        /// </summary>
        private DateTime? dtprimeira;
        [XmlElement(ElementName = "DTPRIMEIRA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtprimeira
        {
            get { return dtprimeira; }
            set { dtprimeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTIMA
        /// Comentário: 
        /// </summary>
        private DateTime? dtultima;
        [XmlElement(ElementName = "DTULTIMA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtultima
        {
            get { return dtultima; }
            set { dtultima = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADO
        /// Comentário: 
        /// </summary>
        private string importado;
        [XmlElement(ElementName = "IMPORTADO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 1)]
        public string Importado
        {
            get { return importado; }
            set { importado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ECOMMERCE
        /// Comentário: 
        /// </summary>
        private string ecommerce;
        [XmlElement(ElementName = "ECOMMERCE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 15)]
        public string Ecommerce
        {
            get { return ecommerce; }
            set { ecommerce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDRCA
        /// Comentário: 
        /// </summary>
        private decimal numpedrca;
        [XmlElement(ElementName = "NUMPEDRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal Numpedrca
        {
            get { return numpedrca; }
            set { numpedrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDWEB
        /// Comentário: 
        /// </summary>
        private string numpedweb;
        [XmlElement(ElementName = "NUMPEDWEB", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 50)]
        public string Numpedweb
        {
            get { return numpedweb; }
            set { numpedweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: 
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 3000)]
        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVEZES
        /// Comentário: 
        /// </summary>
        private decimal qtvezes;
        [XmlElement(ElementName = "QTVEZES", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 2)]
        public decimal Qtvezes
        {
            get { return qtvezes; }
            set { qtvezes = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTLogpedidoecommerce()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTLOGPEDIDOECOMMERCE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTLogpedidoecommerce> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTLogpedidoecommerce.GetStringConnection());
            return ba.Listar<ESTLogpedidoecommerce>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTLogpedidoecommerce> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTLogpedidoecommerce.GetStringConnection());
            return ba.Existe<ESTLogpedidoecommerce>(where);
        }

        public static bool Validar(string pedido, string nomeEcommerce)
        {
         //Usa o controle apenas se o parâmetro estiver habilitado
            bool retorno = (Biblioteca.Dictionaries.Settings.NumeroTentativaImportarPedido() > 0);
            if (retorno)
            {
                ESTLogpedidoecommerce logpedido = null;
                try
                {//Se existir verifica o número de vezes que foi processado
                    logpedido = ESTLogpedidoecommerce.Listar(string.Format("UPPER(NUMPEDWEB) = '{0}'", pedido.ToUpper())).Single();

                    retorno = (logpedido.qtvezes <= Biblioteca.Dictionaries.Settings.NumeroTentativaImportarPedido());
                }
                catch
                {//Senão cria o registro
                    logpedido = new ESTLogpedidoecommerce();
                    logpedido.Dtprimeira = logpedido.DataHoraServidor();
                    logpedido.Dtultima = logpedido.dtprimeira;
                    logpedido.Importado = "N";
                    logpedido.Numpedweb = pedido;
                    logpedido.Qtvezes = 0;
                    logpedido.Observacao = "Iniciando importação";
                    logpedido.Ecommerce = nomeEcommerce;
                    Persistencia ba = new Persistencia(ESTLogpedidoecommerce.GetStringConnection());
                    ba.Inserir(logpedido);
                }
            }
            else
            {
                retorno = true;
            }

            return retorno;
        }

        public static void GerarExcecao(string classe, string metodo, string mensagem, string numPedidoWeb, decimal numPedido, string concluido, string nomeECommerce, Int32 NumeroVezes = 0)
        {
            if (Biblioteca.Dictionaries.Settings.NumeroTentativaImportarPedido() > 0)
            {
                try
                {
                    ESTLogpedidoecommerce logpedido = ESTLogpedidoecommerce.Listar(string.Format("UPPER(NUMPEDWEB) = '{0}'", numPedidoWeb.ToUpper())).Single();

                    logpedido.Qtvezes = logpedido.Qtvezes + (NumeroVezes + 1);
                    logpedido.Numpedrca = numPedido;
                    logpedido.Observacao = mensagem;
                    logpedido.Importado = concluido;
                    logpedido.Ecommerce = nomeECommerce;

                    Persistencia ba = new Persistencia(ESTLogpedidoecommerce.GetStringConnection());
                    ba.Alterar(logpedido);

                    //if (concluido == "N") --Suspenso por enquanto
                    //
                    //{
                    //    //Grava log na tabela de mensagens a ser enviadas.
                    //    if (!String.IsNullOrEmpty(Biblioteca.Dictionaries.Settings.EmailErro())
                    //     && !String.IsNullOrEmpty(Biblioteca.Dictionaries.Settings.EmailSMTP())
                    //     && !String.IsNullOrEmpty(Biblioteca.Dictionaries.Settings.EmailSenha()))
                    //    {//Gerando mensagem para o email.
                    //        Correspondencias Correio = new Correspondencias();
                    //        Correio.Correspondencia_Id = Correio.Proximo("SEQ_CORRESPONDENCIAS");
                    //        Correio.Destinatario = Biblioteca.Dictionaries.Settings.EmailErro();
                    //        Correio.Email = Biblioteca.Dictionaries.Settings.EmailErro();
                    //        Correio.Dtinclusao = DateTime.Now;
                    //        Correio.Titulo = "Notificação da integradora";
                    //        Correio.Mensagem = "";
                    //        Correio.Mensagem = Correio.Mensagem + "Data....: " + Correio.Dtinclusao.ToString() + Environment.NewLine;
                    //        Correio.Mensagem = Correio.Mensagem + "Local...: " + classe + Environment.NewLine;
                    //        Correio.Mensagem = Correio.Mensagem + "Função..: " + metodo + Environment.NewLine;
                    //        Correio.Mensagem = Correio.Mensagem + "Mensagem: " + mensagem + Environment.NewLine;
                    //
                    //        ba.Inserir(Correio);
                    //    }
                    //}
                }
                catch (Exception erro  )
                {
                    Biblioteca.Tools.Logs.GerarLog(classe, metodo, string.Format("NUMPEDWEB: {0}, NUMPEDRCA: {1}", numPedidoWeb, numPedido) + " - Descrição do erro: " + erro);
                }
            }

            Logs.GerarLog(classe, metodo, mensagem);
        }
        #endregion
    }
}
