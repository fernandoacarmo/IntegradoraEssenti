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
    /// Classe referente a tabela PCExpped
    /// </summary>
    [XmlType("PCEXPPED")]
    public class PCExpped : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONFERENTE
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncconferente;
        [XmlElement(ElementName = "CODFUNCCONFERENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncconferente
        {
            get { return  codfuncconferente; }
            set {  codfuncconferente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONFERENTE2
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncconferente2;
        [XmlElement(ElementName = "CODFUNCCONFERENTE2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncconferente2
        {
            get { return  codfuncconferente2; }
            set {  codfuncconferente2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXP
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncexp;
        [XmlElement(ElementName = "CODFUNCEXP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncexp
        {
            get { return  codfuncexp; }
            set {  codfuncexp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXPFIM
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncexpfim;
        [XmlElement(ElementName = "CODFUNCEXPFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncexpfim
        {
            get { return  codfuncexpfim; }
            set {  codfuncexpfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFINALIZAENTREGA
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncfinalizaentrega;
        [XmlElement(ElementName = "CODFUNCFINALIZAENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfinalizaentrega
        {
            get { return  codfuncfinalizaentrega; }
            set {  codfuncfinalizaentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCINICIOENTREGA
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncinicioentrega;
        [XmlElement(ElementName = "CODFUNCINICIOENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncinicioentrega
        {
            get { return  codfuncinicioentrega; }
            set {  codfuncinicioentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLIBERACAO
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncliberacao;
        [XmlElement(ElementName = "CODFUNCLIBERACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncliberacao
        {
            get { return  codfuncliberacao; }
            set {  codfuncliberacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCRESPEXP
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncrespexp;
        [XmlElement(ElementName = "CODFUNCRESPEXP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncrespexp
        {
            get { return  codfuncrespexp; }
            set {  codfuncrespexp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENTREGAEXP
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtentregaexp;
        [XmlElement(ElementName = "DTENTREGAEXP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtentregaexp
        {
            get { return  dtentregaexp; }
            set {  dtentregaexp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINALIZA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfinaliza;
        [XmlElement(ElementName = "DTFINALIZA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinaliza
        {
            get { return  dtfinaliza; }
            set {  dtfinaliza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINALIZAENTREGA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfinalizaentrega;
        [XmlElement(ElementName = "DTFINALIZAENTREGA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinalizaentrega
        {
            get { return  dtfinalizaentrega; }
            set {  dtfinalizaentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOENTREGA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtinicioentrega;
        [XmlElement(ElementName = "DTINICIOENTREGA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicioentrega
        {
            get { return  dtinicioentrega; }
            set {  dtinicioentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLIBERACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtliberacao;
        [XmlElement(ElementName = "DTLIBERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtliberacao
        {
            get { return  dtliberacao; }
            set {  dtliberacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: 
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCExpped()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCEXPPED";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCExpped> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCExpped>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCExpped> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCExpped>(where);
        }

        #endregion
    }
}
