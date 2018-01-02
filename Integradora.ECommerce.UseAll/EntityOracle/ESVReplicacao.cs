using Integradora.Database.Oracle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ECommerce.UseAll.EntityOracle
{
    /// <summary>
    /// Classe referente a tabela Esvreplicacao
    /// </summary>
    [XmlType("ESVREPLICACAO")]
    public class ESVReplicacao : OracleObjeto
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACAO
        /// Coment�rio: 
        /// </summary>
        private decimal acao;
        [XmlElement(ElementName = "ACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Acao
        {
            get { return  acao; }
            set {  acao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNA
        /// Coment�rio: 
        /// </summary>
        private string coluna;
        [XmlElement(ElementName = "COLUNA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Coluna
        {
            get { return  coluna; }
            set {  coluna = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REGISTRO
        /// Coment�rio: 
        /// </summary>
        private decimal registro;
        [XmlElement(ElementName = "REGISTRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Registro
        {
            get { return  registro; }
            set {  registro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TABELA
        /// Coment�rio: 
        /// </summary>
        private string tabela;
        [XmlElement(ElementName = "TABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public string Tabela
        {
            get { return  tabela; }
            set {  tabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TITULO
        /// Coment�rio: 
        /// </summary>
        private string titulo;
        [XmlElement(ElementName = "TITULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Titulo
        {
            get { return  titulo; }
            set {  titulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARCELA
        /// Coment�rio: 
        /// </summary>
        private string parcela;
        [XmlElement(ElementName = "PARCELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string Parcela
        {
            get { return parcela; }
            set { parcela = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public ESVReplicacao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESVREPLICACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<ESVReplicacao> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESVReplicacao.GetStringConnection());
            return ba.Listar<ESVReplicacao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<ESVReplicacao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESVReplicacao.GetStringConnection());
            return ba.Existe<ESVReplicacao>(where);
        }

        public static void GravarRegistroImportado(ESVReplicacao item, string acao, string obs, string complemento, string documento, bool sucesso)
        {
            try
            {
                //A remo��o da lista de replica��o e feito uma grava��o na tabela de registro j� importado
                ESTRegistroImportado registro = new ESTRegistroImportado();
                registro.Tabela = item.Tabela;
                registro.Coluna = item.Coluna;
                registro.Registro = item.Registro;
                registro.Dtinclusao = item.DataHoraServidor();
                registro.Acao = acao;
                registro.Observacao = obs.Replace("'", "");
                registro.Complemento = complemento.Replace("'", "");
                registro.Importado = sucesso ? "S" : "N";
                registro.Documento = documento;

                Persistencia ba = new Persistencia(GetStringConnection());
                ba.Inserir(registro);

            }
            catch (Exception ex)
            {
                Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.UseAll", "ESVREPLICACAO", "GravarRegistroImportado", ex);
            }
        }

        public static List<ESVReplicacao> Load(string where)
        {
            List<ESVReplicacao> Lista;
            try
            {
                string filtro;
                filtro = Integradora.Biblioteca.Dictionaries.Settings.QuantidadeRegistroEnviar().ToString();
                if (!string.IsNullOrEmpty(filtro))
                {
                    filtro = "ROWNUM <= " + filtro;
                }

                if (!string.IsNullOrEmpty(where))
                {
                    filtro = filtro + " AND " + where;
                }

                Lista = ESVReplicacao.Listar(filtro);
            }
            catch
            {
                Lista = null;
            }
            return Lista;
        }
        #endregion
    }
}
