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
    /// Classe referente a tabela PCDocfornecedores
    /// </summary>
    [XmlType("PCDOCFORNECEDORES")]
    public class PCDocfornecedores : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: C�digo fornecedor.
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPODOCUMENTO
        /// Coment�rio: C�digo tipo documento.
        /// </summary>
        private decimal codtipodocumento;
        [XmlElement(ElementName = "CODTIPODOCUMENTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codtipodocumento
        {
            get { return  codtipodocumento; }
            set {  codtipodocumento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COPIAS
        /// Coment�rio: Copias.
        /// </summary>
        private decimal copias;
        [XmlElement(ElementName = "COPIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Copias
        {
            get { return  copias; }
            set {  copias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAS_AVISO
        /// Coment�rio: Dias de aviso.
        /// </summary>
        private decimal dias_aviso;
        [XmlElement(ElementName = "DIAS_AVISO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Dias_Aviso
        {
            get { return  dias_aviso; }
            set {  dias_aviso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Coment�rio: Observa��o.
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDADE
        /// Coment�rio: Validade.
        /// </summary>
        private DateTime? validade;
        [XmlElement(ElementName = "VALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Validade
        {
            get { return  validade; }
            set {  validade = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDocfornecedores()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDOCFORNECEDORES";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDocfornecedores> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDocfornecedores>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDocfornecedores> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDocfornecedores>(where);
        }

        #endregion
    }
}
