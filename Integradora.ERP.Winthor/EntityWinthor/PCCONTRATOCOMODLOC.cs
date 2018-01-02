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
    /// Classe referente a tabela PCContratocomodloc
    /// </summary>
    [XmlType("PCCONTRATOCOMODLOC")]
    public class PCContratocomodloc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: Indica o c�digo do cliente.
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
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Indica o c�digo da filial.
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
        /// Propriedade referente ao campo: CODRCA
        /// Coment�rio: C�digo do RCA do Contrato
        /// </summary>
        private decimal codrca;
        [XmlElement(ElementName = "CODRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codrca
        {
            get { return  codrca; }
            set {  codrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: C�digo do RCA do Contrato
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Indica a data de cadastro do contrato.
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
        /// Propriedade referente ao campo: DTVIGENCIAFIN
        /// Coment�rio: Indica a data final de vig�ncia.
        /// </summary>
        private DateTime? dtvigenciafin;
        [XmlElement(ElementName = "DTVIGENCIAFIN", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvigenciafin
        {
            get { return  dtvigenciafin; }
            set {  dtvigenciafin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVIGENCIAFINORIG
        /// Coment�rio: Indica a data final de vig�ncia original.
        /// </summary>
        private DateTime? dtvigenciafinorig;
        [XmlElement(ElementName = "DTVIGENCIAFINORIG", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvigenciafinorig
        {
            get { return  dtvigenciafinorig; }
            set {  dtvigenciafinorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVIGENCIAINI
        /// Coment�rio: Indica a data inicial de vig�ncia.
        /// </summary>
        private DateTime? dtvigenciaini;
        [XmlElement(ElementName = "DTVIGENCIAINI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvigenciaini
        {
            get { return  dtvigenciaini; }
            set {  dtvigenciaini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONTRATO
        /// Coment�rio: Indica o n�mero do contrato.
        /// </summary>
        private decimal numcontrato;
        [XmlElement(ElementName = "NUMCONTRATO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numcontrato
        {
            get { return  numcontrato; }
            set {  numcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Infica a observa��o do contrato.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Coment�rio: Status do Contrato de Comodato.
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
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: Indica o tipo do contrato.
        /// </summary>
        private decimal tipo;
        [XmlElement(ElementName = "TIPO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCContratocomodloc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTRATOCOMODLOC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCContratocomodloc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCContratocomodloc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCContratocomodloc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCContratocomodloc>(where);
        }

        #endregion
    }
}
