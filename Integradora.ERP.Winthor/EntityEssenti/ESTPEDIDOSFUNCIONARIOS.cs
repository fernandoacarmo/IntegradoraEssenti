using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe referente a tabela ESTPedidosfuncionarios
    /// </summary>
    [XmlType("ESTPEDIDOSFUNCIONARIOS")]
    public class ESTPedidosfuncionarios : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLIENTE
        /// Coment�rio: 
        /// </summary>
        private decimal codcliente;
        [XmlElement(ElementName = "CODCLIENTE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcliente
        {
            get { return  codcliente; }
            set {  codcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTATO
        /// Coment�rio: 
        /// </summary>
        private decimal codcontato;
        [XmlElement(ElementName = "CODCONTATO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcontato
        {
            get { return  codcontato; }
            set {  codcontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOALT
        /// Coment�rio: 
        /// </summary>
        private decimal codusuarioalt;
        [XmlElement(ElementName = "CODUSUARIOALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusuarioalt
        {
            get { return  codusuarioalt; }
            set {  codusuarioalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOEXC
        /// Coment�rio: 
        /// </summary>
        private decimal? codusuarioexc;
        [XmlElement(ElementName = "CODUSUARIOEXC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codusuarioexc
        {
            get { return  codusuarioexc; }
            set {  codusuarioexc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOINC
        /// Coment�rio: 
        /// </summary>
        private decimal codusuarioinc;
        [XmlElement(ElementName = "CODUSUARIOINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusuarioinc
        {
            get { return  codusuarioinc; }
            set {  codusuarioinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime Dtalteracao
        {
            get { return  dtalteracao; }
            set {  dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: 
        /// </summary>
        private DateTime dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTRECEBIMENTO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtrecebimento;
        [XmlElement(ElementName = "DTRECEBIMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtrecebimento
        {
            get { return  dtrecebimento; }
            set {  dtrecebimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMETIQUETA
        /// Coment�rio: 
        /// </summary>
        private decimal numetiqueta;
        [XmlElement(ElementName = "NUMETIQUETA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numetiqueta
        {
            get { return  numetiqueta; }
            set {  numetiqueta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDIDO
        /// Coment�rio: 
        /// </summary>
        private decimal numpedido;
        [XmlElement(ElementName = "NUMPEDIDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numpedido
        {
            get { return  numpedido; }
            set {  numpedido = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public ESTPedidosfuncionarios()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTPEDIDOSFUNCIONARIOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<ESTPedidosfuncionarios> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTPedidosfuncionarios.GetStringConnection());
            return ba.Listar<ESTPedidosfuncionarios>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<ESTPedidosfuncionarios> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTPedidosfuncionarios.GetStringConnection());
            return ba.Existe<ESTPedidosfuncionarios>(where);
        }

        #endregion
    }
}
