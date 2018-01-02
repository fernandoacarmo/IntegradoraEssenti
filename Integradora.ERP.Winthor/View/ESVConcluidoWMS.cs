using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.View
{
    /// <summary>
    /// Classe referente a tabela Esvconcluidowms
    /// </summary>
    [XmlType("ESVCONCLUIDOWMS")]
    public class ESVConcluidoWMS : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODEMITENTE
        /// Comentário: 
        /// </summary>
        private decimal codemitente;
        [XmlElement(ElementName = "CODEMITENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal Codemitente
        {
            get { return codemitente; }
            set { codemitente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOCUMENTOCEMA
        /// Comentário: 
        /// </summary>
        private string documentocema;
        [XmlElement(ElementName = "DOCUMENTOCEMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public string Documentocema
        {
            get { return documentocema; }
            set { documentocema = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Comentário: 
        /// </summary>
        private decimal numtransacao;
        [XmlElement(ElementName = "NUMTRANSACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Numtransacao
        {
            get { return numtransacao; }
            set { numtransacao = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: NUMAJURI
        /// Comentário: 
        /// </summary>
        private string numajuri;
        [XmlElement(ElementName = "NUMAJURI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Numajuri
        {
            get { return numajuri; }
            set { numajuri = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: NUMDOCUMENTO
        /// Comentário: 
        /// </summary>
        private decimal numdocumento;
        [XmlElement(ElementName = "NUMDOCUMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Numdocumento
        {
            get { return numdocumento; }
            set { numdocumento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTITENS
        /// Comentário: 
        /// </summary>
        private decimal qtitens;
        [XmlElement(ElementName = "QTITENS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Qtitens
        {
            get { return qtitens; }
            set { qtitens = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TABELA
        /// Comentário: 
        /// </summary>
        private string tabela;
        [XmlElement(ElementName = "TABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 11)]
        public string Tabela
        {
            get { return tabela; }
            set { tabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RAZAOSOCIAL
        /// Comentário: 
        /// </summary>
        private string razaosocial;
        [XmlElement(ElementName = "RAZAOSOCIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Razaosocial
        {
            get { return razaosocial; }
            set { razaosocial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJ_FILIAL
        /// Comentário: 
        /// </summary>
        private string cnpj_filial;
        [XmlElement(ElementName = "CNPJ_FILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Cnpj_filial
        {
            get { return cnpj_filial; }
            set { cnpj_filial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJ_CPF
        /// Comentário: 
        /// </summary>
        private string cnpj_cpf;
        [XmlElement(ElementName = "CNPJ_CPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Cnpj_cpf
        {
            get { return cnpj_cpf; }
            set { cnpj_cpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJ_EMITENTE
        /// Comentário: 
        /// </summary>
        private string cnpj_emitente;
        [XmlElement(ElementName = "CNPJ_EMITENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Cnpj_emitente
        {
            get { return cnpj_emitente; }
            set { cnpj_emitente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAMPODOCUMENTO
        /// Comentário: 
        /// </summary>
        private string campodocumento;
        [XmlElement(ElementName = "CAMPODOCUMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Campodocumento
        {
            get { return campodocumento; }
            set { campodocumento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAMPOCODIGO
        /// Comentário: 
        /// </summary>
        private string campocodigo;
        [XmlElement(ElementName = "CAMPOCODIGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Campocodigo
        {
            get { return campocodigo; }
            set { campocodigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: 
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public string Serie
        {
            get { return serie; }
            set { serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CFOP
        /// Comentário: 
        /// </summary>
        private string cfop;
        [XmlElement(ElementName = "CFOP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public string Cfop
        {
            get { return cfop; }
            set { cfop = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESVConcluidoWMS()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVCONCLUIDOWMS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESVConcluidoWMS> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESVConcluidoWMS.GetStringConnection());
            return ba.Listar<ESVConcluidoWMS>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESVConcluidoWMS> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESVConcluidoWMS.GetStringConnection());
            return ba.Existe<ESVConcluidoWMS>(where);
        }

        #endregion

        public string SQLClausulaWhere()
        {
            string sql = string.Format("{0} = '{1}' and {2} = '{3}'"
                                     , Campodocumento
                                     , Numdocumento
                                     , Campocodigo
                                     , Codemitente);
            return sql;
        }
        public void Save(string semaforo)
        {
            Oracle bd = new Oracle(Esvsemaforo.GetStringConnection());

            string script = @"UPDATE PCWMSOUTPUT
                                 SET SEMAFORO = '{0}'
                               WHERE {1} ";

            script = string.Format( script
                                  , semaforo
                                  , SQLClausulaWhere()
                                  );

            bd.ExecuteNonQuery(script);
        }
    }
}
