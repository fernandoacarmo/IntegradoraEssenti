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
    /// Classe referente a tabela PCDatacheq
    /// </summary>
    [XmlType("PCDATACHEQ")]
    public class PCDatacheq : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CGCENT
        /// Coment�rio: Campo utilizado para informar o CPF/CNPJ do cliente.
        /// </summary>
        private string cgcent;
        [XmlElement(ElementName = "CGCENT", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,18)]
        public string Cgcent
        {
            get { return  cgcent; }
            set {  cgcent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTOCORRENCIA
        /// Coment�rio: Indica a data da �ltima ocorr�ncia
        /// </summary>
        private DateTime? dtultocorrencia;
        [XmlElement(ElementName = "DTULTOCORRENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultocorrencia
        {
            get { return  dtultocorrencia; }
            set {  dtultocorrencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAGENCIA
        /// Coment�rio: Indica o n�mero da ag�ncia.
        /// </summary>
        private decimal numagencia;
        [XmlElement(ElementName = "NUMAGENCIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numagencia
        {
            get { return  numagencia; }
            set {  numagencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBANCO
        /// Coment�rio: Indica o n�mero do banco.
        /// </summary>
        private decimal numbanco;
        [XmlElement(ElementName = "NUMBANCO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numbanco
        {
            get { return  numbanco; }
            set {  numbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTOCORRENCIA
        /// Coment�rio: Indica a quantidade de ocorr�ncias.
        /// </summary>
        private decimal qtocorrencia;
        [XmlElement(ElementName = "QTOCORRENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Qtocorrencia
        {
            get { return  qtocorrencia; }
            set {  qtocorrencia = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDatacheq()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDATACHEQ";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDatacheq> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDatacheq>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDatacheq> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDatacheq>(where);
        }

        #endregion
    }
}
