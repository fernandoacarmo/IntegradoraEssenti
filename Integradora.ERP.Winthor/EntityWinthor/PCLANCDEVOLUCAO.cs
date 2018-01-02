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
    /// Classe referente a tabela PCLancdevolucao
    /// </summary>
    [XmlType("PCLANCDEVOLUCAO")]
    public class PCLancdevolucao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Data do cadastro
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
        /// Propriedade referente ao campo: DTESTORNO
        /// Coment�rio: Data do estorno
        /// </summary>
        private DateTime? dtestorno;
        [XmlElement(ElementName = "DTESTORNO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtestorno
        {
            get { return  dtestorno; }
            set {  dtestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Coment�rio: N�mero da transa��o de entrada
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: N�mero da transa��o de sa�da
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
        /// Propriedade referente ao campo: RECNUM
        /// Coment�rio: N�mero do t�tulo
        /// </summary>
        private decimal recnum;
        [XmlElement(ElementName = "RECNUM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Recnum
        {
            get { return  recnum; }
            set {  recnum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINACAD
        /// Coment�rio: Rotina que fez o cadastro
        /// </summary>
        private decimal rotinacad;
        [XmlElement(ElementName = "ROTINACAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Rotinacad
        {
            get { return  rotinacad; }
            set {  rotinacad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: Valor da devolu��o
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCLancdevolucao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLANCDEVOLUCAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCLancdevolucao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLancdevolucao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCLancdevolucao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLancdevolucao>(where);
        }

        #endregion
    }
}
