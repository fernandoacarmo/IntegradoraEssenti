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
    /// Classe referente a tabela PCVersaoobjbd
    /// </summary>
    [XmlType("PCVERSAOOBJBD")]
    public class PCVersaoobjbd : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DTATUALIZACAOCLIENTE
        /// Coment�rio: Data da atualiza��o do registro feito pelas rotinas de atualiza��o de objeto no banco de dados.
        /// </summary>
        private DateTime? dtatualizacaocliente;
        [XmlElement(ElementName = "DTATUALIZACAOCLIENTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtatualizacaocliente
        {
            get { return  dtatualizacaocliente; }
            set {  dtatualizacaocliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTATUALIZACAOPC
        /// Coment�rio: Data da atualiza��o do registro feito pela 560.
        /// </summary>
        private DateTime? dtatualizacaopc;
        [XmlElement(ElementName = "DTATUALIZACAOPC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtatualizacaopc
        {
            get { return  dtatualizacaopc; }
            set {  dtatualizacaopc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MSGALERTA
        /// Coment�rio: Mensagem de alerta para atualiza��o do objeto no banco de dados.
        /// </summary>
        private string msgalerta;
        [XmlElement(ElementName = "MSGALERTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Msgalerta
        {
            get { return  msgalerta; }
            set {  msgalerta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEOBJETO
        /// Coment�rio: Nome do objeto no banco de dados.
        /// </summary>
        private string nomeobjeto;
        [XmlElement(ElementName = "NOMEOBJETO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,30)]
        public string Nomeobjeto
        {
            get { return  nomeobjeto; }
            set {  nomeobjeto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDACAOOBRIGATORIA
        /// Coment�rio: Define se a valida��o de versionamento de objetos do banco de dados � obrigatoria.
        /// </summary>
        private string validacaoobrigatoria;
        [XmlElement(ElementName = "VALIDACAOOBRIGATORIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validacaoobrigatoria
        {
            get { return  validacaoobrigatoria; }
            set {  validacaoobrigatoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDAROBJ
        /// Coment�rio: Validar versionamento de objeto do banco de dados.
        /// </summary>
        private string validarobj;
        [XmlElement(ElementName = "VALIDAROBJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validarobj
        {
            get { return  validarobj; }
            set {  validarobj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOCLIENTE
        /// Coment�rio: Vers�o da rotina de atualiza��o de objetos no cliente.
        /// </summary>
        private decimal versaocliente;
        [XmlElement(ElementName = "VERSAOCLIENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Versaocliente
        {
            get { return  versaocliente; }
            set {  versaocliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOPC
        /// Coment�rio: Vers�o da rotina de atualiza��o de objetos atual.
        /// </summary>
        private decimal versaopc;
        [XmlElement(ElementName = "VERSAOPC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Versaopc
        {
            get { return  versaopc; }
            set {  versaopc = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCVersaoobjbd()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCVERSAOOBJBD";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCVersaoobjbd> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCVersaoobjbd>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCVersaoobjbd> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCVersaoobjbd>(where);
        }

        #endregion
    }
}
