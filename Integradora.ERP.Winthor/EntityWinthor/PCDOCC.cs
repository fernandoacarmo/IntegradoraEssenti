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
    /// Classe referente a tabela PCDocc
    /// </summary>
    [XmlType("PCDOCC")]
    public class PCDocc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODDOC
        /// Comentário: 
        /// </summary>
        private decimal coddoc;
        [XmlElement(ElementName = "CODDOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddoc
        {
            get { return  coddoc; }
            set {  coddoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCAL
        /// Comentário: 
        /// </summary>
        private string codfiscal;
        [XmlElement(ElementName = "CODFISCAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public string Codfiscal
        {
            get { return  codfiscal; }
            set {  codfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESPACAMENTO
        /// Comentário: 
        /// </summary>
        private string espacamento;
        [XmlElement(ElementName = "ESPACAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Espacamento
        {
            get { return  espacamento; }
            set {  espacamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRESSORA
        /// Comentário: 
        /// </summary>
        private string impressora;
        [XmlElement(ElementName = "IMPRESSORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Impressora
        {
            get { return  impressora; }
            set {  impressora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LETRA
        /// Comentário: 
        /// </summary>
        private string letra;
        [XmlElement(ElementName = "LETRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Letra
        {
            get { return  letra; }
            set {  letra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLINHAS
        /// Comentário: 
        /// </summary>
        private decimal numlinhas;
        [XmlElement(ElementName = "NUMLINHAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numlinhas
        {
            get { return  numlinhas; }
            set {  numlinhas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERACAO
        /// Comentário: 
        /// </summary>
        private string operacao;
        [XmlElement(ElementName = "OPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Operacao
        {
            get { return  operacao; }
            set {  operacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMAXITENS
        /// Comentário: 
        /// </summary>
        private decimal qtmaxitens;
        [XmlElement(ElementName = "QTMAXITENS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtmaxitens
        {
            get { return  qtmaxitens; }
            set {  qtmaxitens = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: 
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODOC
        /// Comentário: 
        /// </summary>
        private string tipodoc;
        [XmlElement(ElementName = "TIPODOC", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public string Tipodoc
        {
            get { return  tipodoc; }
            set {  tipodoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPRECO
        /// Comentário: 
        /// </summary>
        private string tipopreco;
        [XmlElement(ElementName = "TIPOPRECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipopreco
        {
            get { return  tipopreco; }
            set {  tipopreco = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDocc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDOCC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDocc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDocc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDocc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDocc>(where);
        }

        #endregion
    }
}
