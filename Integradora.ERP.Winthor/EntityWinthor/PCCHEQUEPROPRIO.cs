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
    /// Classe referente a tabela PCChequeproprio
    /// </summary>
    [XmlType("PCCHEQUEPROPRIO")]
    public class PCChequeproprio : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�digo do cliente pra quem foi direcionado o cheque
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Data de cadastro
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
        /// Propriedade referente ao campo: DTIMPRESSO
        /// Coment�rio: Data em que o cheque foi impresso
        /// </summary>
        private DateTime? dtimpresso;
        [XmlElement(ElementName = "DTIMPRESSO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimpresso
        {
            get { return  dtimpresso; }
            set {  dtimpresso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSUSTADO
        /// Coment�rio: Data em que o cheque foi sustado
        /// </summary>
        private DateTime? dtsustado;
        [XmlElement(ElementName = "DTSUSTADO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtsustado
        {
            get { return  dtsustado; }
            set {  dtsustado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTUTILIZADO
        /// Coment�rio: Data em que o cheque foi utilizado
        /// </summary>
        private DateTime? dtutilizado;
        [XmlElement(ElementName = "DTUTILIZADO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtutilizado
        {
            get { return  dtutilizado; }
            set {  dtutilizado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRTERCEIRO
        /// Coment�rio: Indicador se o cheque foi impresso em teceiros
        /// </summary>
        private string imprterceiro;
        [XmlElement(ElementName = "IMPRTERCEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Imprterceiro
        {
            get { return  imprterceiro; }
            set {  imprterceiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCHEQUE
        /// Coment�rio: N�mero do cheque pr�prio
        /// </summary>
        private decimal numcheque;
        [XmlElement(ElementName = "NUMCHEQUE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numcheque
        {
            get { return  numcheque; }
            set {  numcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTALAO
        /// Coment�rio: N�mero do tal�o do cheque
        /// </summary>
        private decimal numtalao;
        [XmlElement(ElementName = "NUMTALAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtalao
        {
            get { return  numtalao; }
            set {  numtalao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: Transa��o de Venda
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
        /// Propriedade referente ao campo: OBSERVACAO
        /// Coment�rio: Observa��o
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Coment�rio: Situa��o do Cheque
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUCADASTRO
        /// Coment�rio: Usu�rio que cadastrou
        /// </summary>
        private decimal usucadastro;
        [XmlElement(ElementName = "USUCADASTRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Usucadastro
        {
            get { return  usucadastro; }
            set {  usucadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUIMPRESSO
        /// Coment�rio: Usu�rio que imprimiu o cheque
        /// </summary>
        private decimal usuimpresso;
        [XmlElement(ElementName = "USUIMPRESSO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Usuimpresso
        {
            get { return  usuimpresso; }
            set {  usuimpresso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUSUSTADO
        /// Coment�rio: Usu�rio que sustou o cheque
        /// </summary>
        private decimal ususustado;
        [XmlElement(ElementName = "USUSUSTADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Ususustado
        {
            get { return  ususustado; }
            set {  ususustado = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCChequeproprio()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCHEQUEPROPRIO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCChequeproprio> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCChequeproprio>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCChequeproprio> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCChequeproprio>(where);
        }

        #endregion
    }
}
