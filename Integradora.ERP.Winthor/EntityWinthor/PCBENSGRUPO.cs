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
    /// Classe referente a tabela PCBensgrupo
    /// </summary>
    [XmlType("PCBENSGRUPO")]
    public class PCBensgrupo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPO
        /// Coment�rio: Indica o c�digo do grupo de bens.
        /// </summary>
        private decimal codgrupo;
        [XmlElement(ElementName = "CODGRUPO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codgrupo
        {
            get { return  codgrupo; }
            set {  codgrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHISTORICO
        /// Coment�rio: Indica o c�digo do historico.
        /// </summary>
        private decimal codhistorico;
        [XmlElement(ElementName = "CODHISTORICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codhistorico
        {
            get { return  codhistorico; }
            set {  codhistorico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHISTORICOATRIBUIDO
        /// Coment�rio: C�digo do hist�rico para o valor atribuido
        /// </summary>
        private decimal codhistoricoatribuido;
        [XmlElement(ElementName = "CODHISTORICOATRIBUIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codhistoricoatribuido
        {
            get { return  codhistoricoatribuido; }
            set {  codhistoricoatribuido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHISTORICOCORRIGIDO
        /// Coment�rio: C�digo do hist�rico para o valor corrigido
        /// </summary>
        private decimal codhistoricocorrigido;
        [XmlElement(ElementName = "CODHISTORICOCORRIGIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codhistoricocorrigido
        {
            get { return  codhistoricocorrigido; }
            set {  codhistoricocorrigido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLANOCONTA
        /// Coment�rio: Indica o c�digo do plano de contas.
        /// </summary>
        private decimal codplanoconta;
        [XmlElement(ElementName = "CODPLANOCONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Codplanoconta
        {
            get { return  codplanoconta; }
            set {  codplanoconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTAATIVO
        /// Coment�rio: Indica a conta do ativo.
        /// </summary>
        private string contaativo;
        [XmlElement(ElementName = "CONTAATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Contaativo
        {
            get { return  contaativo; }
            set {  contaativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTAATIVOATRIBUIDO
        /// Coment�rio: Conta do ativo para o valor atribuido
        /// </summary>
        private string contaativoatribuido;
        [XmlElement(ElementName = "CONTAATIVOATRIBUIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Contaativoatribuido
        {
            get { return  contaativoatribuido; }
            set {  contaativoatribuido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTAATIVOCORRIGIDO
        /// Coment�rio: Conta do ativo para o valor corrigido
        /// </summary>
        private string contaativocorrigido;
        [XmlElement(ElementName = "CONTAATIVOCORRIGIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Contaativocorrigido
        {
            get { return  contaativocorrigido; }
            set {  contaativocorrigido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTADEPRECIACAO
        /// Coment�rio: Indica a conta de deprecia��o.
        /// </summary>
        private string contadepreciacao;
        [XmlElement(ElementName = "CONTADEPRECIACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Contadepreciacao
        {
            get { return  contadepreciacao; }
            set {  contadepreciacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTADEPRECIACAOATRIBUIDO
        /// Coment�rio: Conta deprecia��o para o valor atribuido
        /// </summary>
        private string contadepreciacaoatribuido;
        [XmlElement(ElementName = "CONTADEPRECIACAOATRIBUIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Contadepreciacaoatribuido
        {
            get { return  contadepreciacaoatribuido; }
            set {  contadepreciacaoatribuido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTADEPRECIACAOCORRIGIDO
        /// Coment�rio: Conta deperecia��o para o valor corrigido
        /// </summary>
        private string contadepreciacaocorrigido;
        [XmlElement(ElementName = "CONTADEPRECIACAOCORRIGIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Contadepreciacaocorrigido
        {
            get { return  contadepreciacaocorrigido; }
            set {  contadepreciacaocorrigido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTADESPDEPRECIACAO
        /// Coment�rio: Indica a conta despesa deprecia��o.
        /// </summary>
        private string contadespdepreciacao;
        [XmlElement(ElementName = "CONTADESPDEPRECIACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Contadespdepreciacao
        {
            get { return  contadespdepreciacao; }
            set {  contadespdepreciacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTADESPDEPRECIACAOATRIBUIDO
        /// Coment�rio: Conta despesa de deprecia��o para o valor atribuido
        /// </summary>
        private string contadespdepreciacaoatribuido;
        [XmlElement(ElementName = "CONTADESPDEPRECIACAOATRIBUIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Contadespdepreciacaoatribuido
        {
            get { return  contadespdepreciacaoatribuido; }
            set {  contadespdepreciacaoatribuido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTADESPDEPRECIACAOCORRIGIDO
        /// Coment�rio: Conta despesa de deprecia��o para o valor corrigido
        /// </summary>
        private string contadespdepreciacaocorrigido;
        [XmlElement(ElementName = "CONTADESPDEPRECIACAOCORRIGIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Contadespdepreciacaocorrigido
        {
            get { return  contadespdepreciacaocorrigido; }
            set {  contadespdepreciacaocorrigido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCGRUPO
        /// Coment�rio: Indica a descri��o do grupo de bens.
        /// </summary>
        private string descgrupo;
        [XmlElement(ElementName = "DESCGRUPO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,60)]
        public string Descgrupo
        {
            get { return  descgrupo; }
            set {  descgrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXADEPRECIACAO
        /// Coment�rio: Indica a taxa de deprecia��o.
        /// </summary>
        private decimal taxadepreciacao;
        [XmlElement(ElementName = "TAXADEPRECIACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Taxadepreciacao
        {
            get { return  taxadepreciacao; }
            set {  taxadepreciacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCONTABILIZACAO
        /// Coment�rio: Tipo de valor para contabiliza��o
        /// </summary>
        private string tipocontabilizacao;
        [XmlElement(ElementName = "TIPOCONTABILIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocontabilizacao
        {
            get { return  tipocontabilizacao; }
            set {  tipocontabilizacao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCBensgrupo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBENSGRUPO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCBensgrupo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBensgrupo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCBensgrupo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBensgrupo>(where);
        }

        #endregion
    }
}
