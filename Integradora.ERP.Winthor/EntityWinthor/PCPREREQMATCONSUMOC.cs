using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityWinthor
{
    /// <summary>
    /// Classe referente a tabela PCPrereqmatconsumoc
    /// </summary>
    [XmlType("PCPREREQMATCONSUMOC")]
    public class PCPrereqmatconsumoc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Filial da pr�-requisi��o
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCREQ
        /// Coment�rio: Funcion�rio requisitante
        /// </summary>
        private decimal codfuncreq;
        [XmlElement(ElementName = "CODFUNCREQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncreq
        {
            get { return  codfuncreq; }
            set {  codfuncreq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data da pr�-requisi��o
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVO
        /// Coment�rio: Motivo da pr�-requisi��o
        /// </summary>
        private string motivo;
        [XmlElement(ElementName = "MOTIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Motivo
        {
            get { return  motivo; }
            set {  motivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPREREQUISICAO
        /// Coment�rio: Numero da requisicao
        /// </summary>
        private decimal numprerequisicao;
        [XmlElement(ElementName = "NUMPREREQUISICAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numprerequisicao
        {
            get { return  numprerequisicao; }
            set {  numprerequisicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: N�mero da transa��o de venda.
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRERECORIGEM
        /// Coment�rio: Prerequisito original.
        /// </summary>
        private string prerecorigem;
        [XmlElement(ElementName = "PRERECORIGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Prerecorigem
        {
            get { return  prerecorigem; }
            set {  prerecorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Coment�rio: Situa��o da pr�-requisi��o
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPrereqmatconsumoc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPREREQMATCONSUMOC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPrereqmatconsumoc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPrereqmatconsumoc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPrereqmatconsumoc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPrereqmatconsumoc>(where);
        }

        #endregion
    }
}
