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
    /// Classe referente a tabela PCLimitecompraperiodo
    /// </summary>
    [XmlType("PCLIMITECOMPRAPERIODO")]
    public class PCLimitecompraperiodo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCOMPRADOR
        /// Coment�rio: C�digo do comprador para lan�amento do valor de limite de compra por per�odo.
        /// </summary>
        private decimal codcomprador;
        [XmlElement(ElementName = "CODCOMPRADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcomprador
        {
            get { return  codcomprador; }
            set {  codcomprador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: GRAVAR O CODIGO DA FILIAL NO REGISTRO.
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
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: GRAVAR O CODIGO DO FORNECEDOR NO REGISTRO.
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFINAL
        /// Coment�rio: Data final do per�odo do limite de compra por comprador.
        /// </summary>
        private DateTime? datafinal;
        [XmlElement(ElementName = "DATAFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datafinal
        {
            get { return  datafinal; }
            set {  datafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAINICIAL
        /// Coment�rio: Data inicial do per�odo do limite de compra por comprador.
        /// </summary>
        private DateTime? datainicial;
        [XmlElement(ElementName = "DATAINICIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datainicial
        {
            get { return  datainicial; }
            set {  datainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORLIMITE
        /// Coment�rio: Valor limite do per�odo de compra por comprador.
        /// </summary>
        private decimal valorlimite;
        [XmlElement(ElementName = "VALORLIMITE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorlimite
        {
            get { return  valorlimite; }
            set {  valorlimite = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCLimitecompraperiodo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLIMITECOMPRAPERIODO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCLimitecompraperiodo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLimitecompraperiodo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCLimitecompraperiodo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLimitecompraperiodo>(where);
        }

        #endregion
    }
}
