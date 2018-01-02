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
    /// Classe referente a tabela ESTLogintegracao
    /// </summary>
    [XmlType("ESTLOGINTEGRACAO")]
    public class ESTLogintegracao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
        /// </summary>
        private decimal? codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal? Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtcadastro
        {
            get { return dtcadastro; }
            set { dtcadastro = value; }
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
        /// Propriedade referente ao campo: NUMAJURI
        /// Comentário: 
        /// </summary>
        private string numajuri;
        [XmlElement(ElementName = "NUMAJURI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Numajuri
        {
            get { return numajuri; }
            set { numajuri = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: 
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 500)]
        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TABELA
        /// Comentário: 
        /// </summary>
        private string tabela;
        [XmlElement(ElementName = "TABELA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 40)]
        public string Tabela
        {
            get { return tabela; }
            set { tabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEM
        /// Comentário: 
        /// </summary>
        private string origem;
        [XmlElement(ElementName = "ORIGEM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 1)]
        public string Origem
        {
            get { return origem; }
            set { origem = value; }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTLogintegracao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTLOGINTEGRACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTLogintegracao> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTLogintegracao.GetStringConnection());
            return ba.Listar<ESTLogintegracao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTLogintegracao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTLogintegracao.GetStringConnection());
            return ba.Existe<ESTLogintegracao>(where);
        }

        public static void GerarLog( string classe
                                   , string metodo
                                   , string mensagem
                                   , string tabela
                                   , decimal codigoEssenti
                                   , string codigoCommerce
                                   , bool WinthorParaAjuri
                                   , bool sucesso)
        {
            //Gerando o log em arquivo
            if (!sucesso)
            { //Somente se for erro
                Logs.GerarLog(classe
                             , metodo
                             , mensagem);
            }
            
            //Gerando o log em tabela
            try
            {
                ESTLogintegracao registro = new ESTLogintegracao();
                registro.Dtcadastro = DateTime.Now;
                registro.Importado = sucesso ? "S" : "N";
                registro.Observacao = mensagem;
                registro.Numajuri = codigoCommerce;
                registro.Tabela = tabela;
                registro.Origem = WinthorParaAjuri ? "W" : "A";
                if (codigoEssenti > 0)
                {
                    registro.Codigo = codigoEssenti;
                }
                registro.Gravar();
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ERP.Winthor.EntityEssenti"
                             , "EstlogIntegracao"
                             , "Erro ao salvar no banco de dados: " + ex.ToString());
            }
        }

        #endregion
    }
}
