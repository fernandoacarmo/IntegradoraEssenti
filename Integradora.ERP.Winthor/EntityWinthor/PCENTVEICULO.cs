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
    /// Classe referente a tabela PCEntveiculo
    /// </summary>
    [XmlType("PCENTVEICULO")]
    public class PCEntveiculo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODENTVEICULO
        /// Comentário: 
        /// </summary>
        private decimal codentveiculo;
        [XmlElement(ElementName = "CODENTVEICULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codentveiculo
        {
            get { return  codentveiculo; }
            set {  codentveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECTRANSP
        /// Comentário: 
        /// </summary>
        private decimal codfornectransp;
        [XmlElement(ElementName = "CODFORNECTRANSP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornectransp
        {
            get { return  codfornectransp; }
            set {  codfornectransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Comentário: 
        /// </summary>
        private decimal codfunclanc;
        [XmlElement(ElementName = "CODFUNCLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunclanc
        {
            get { return  codfunclanc; }
            set {  codfunclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEMOTORISTA
        /// Comentário: 
        /// </summary>
        private string nomemotorista;
        [XmlElement(ElementName = "NOMEMOTORISTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Nomemotorista
        {
            get { return  nomemotorista; }
            set {  nomemotorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLACA
        /// Comentário: 
        /// </summary>
        private string placa;
        [XmlElement(ElementName = "PLACA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Placa
        {
            get { return  placa; }
            set {  placa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVEICULO
        /// Comentário: 
        /// </summary>
        private string tipoveiculo;
        [XmlElement(ElementName = "TIPOVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Tipoveiculo
        {
            get { return  tipoveiculo; }
            set {  tipoveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Comentário: 
        /// </summary>
        private string uf;
        [XmlElement(ElementName = "UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uf
        {
            get { return  uf; }
            set {  uf = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCEntveiculo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCENTVEICULO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCEntveiculo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEntveiculo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCEntveiculo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEntveiculo>(where);
        }

        #endregion
    }
}
