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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCExpped> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCExpped>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
