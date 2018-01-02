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
    /// Classe referente a tabela PCTribvendaregiao_log
    /// </summary>
    [XmlType("PCTRIBVENDAREGIAO_LOG")]
    public class PCTribvendaregiao_log : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Comentário: Cod.Funcionario alteração
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNCMEX_NEW
        /// Comentário: Código NCM+Ex Novo
        /// </summary>
        private string codncmex_new;
        [XmlElement(ElementName = "CODNCMEX_NEW", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codncmex_New
        {
            get { return  codncmex_new; }
            set {  codncmex_new = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNCMEX_OLD
        /// Comentário: Código NCM+Ex Anterior
        /// </summary>
        private string codncmex_old;
        [XmlElement(ElementName = "CODNCMEX_OLD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codncmex_Old
        {
            get { return  codncmex_old; }
            set {  codncmex_old = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODST_NEW
        /// Comentário: Código do ST Novo
        /// </summary>
        private decimal codst_new;
        [XmlElement(ElementName = "CODST_NEW", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codst_New
        {
            get { return  codst_new; }
            set {  codst_new = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODST_OLD
        /// Comentário: Código do ST Anterior
        /// </summary>
        private decimal codst_old;
        [XmlElement(ElementName = "CODST_OLD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codst_Old
        {
            get { return  codst_old; }
            set {  codst_old = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRIBPISCOFINS_NEW
        /// Comentário: Código da tributação do PIS/COFINS Novo
        /// </summary>
        private decimal codtribpiscofins_new;
        [XmlElement(ElementName = "CODTRIBPISCOFINS_NEW", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codtribpiscofins_New
        {
            get { return  codtribpiscofins_new; }
            set {  codtribpiscofins_new = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRIBPISCOFINS_OLD
        /// Comentário: Código da tributação do PIS/COFINS Anterior
        /// </summary>
        private decimal codtribpiscofins_old;
        [XmlElement(ElementName = "CODTRIBPISCOFINS_OLD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codtribpiscofins_Old
        {
            get { return  codtribpiscofins_old; }
            set {  codtribpiscofins_old = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRIBVENDAREGIAO
        /// Comentário: Código de tributação de venda por regiao
        /// </summary>
        private decimal codtribvendaregiao;
        [XmlElement(ElementName = "CODTRIBVENDAREGIAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codtribvendaregiao
        {
            get { return  codtribvendaregiao; }
            set {  codtribvendaregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: Data da alteração
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO_NEW
        /// Comentário: Número Regiao Novo
        /// </summary>
        private string numregiao_new;
        [XmlElement(ElementName = "NUMREGIAO_NEW", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Numregiao_New
        {
            get { return  numregiao_new; }
            set {  numregiao_new = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO_OLD
        /// Comentário: Número Regiao Anterior
        /// </summary>
        private string numregiao_old;
        [XmlElement(ElementName = "NUMREGIAO_OLD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Numregiao_Old
        {
            get { return  numregiao_old; }
            set {  numregiao_old = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERACAO
        /// Comentário: Tipo de Operação Inclusão, Edição
        /// </summary>
        private string operacao;
        [XmlElement(ElementName = "OPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Operacao
        {
            get { return  operacao; }
            set {  operacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINA
        /// Comentário: Rotina que realizou alteração
        /// </summary>
        private string rotina;
        [XmlElement(ElementName = "ROTINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Rotina
        {
            get { return  rotina; }
            set {  rotina = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTribvendaregiao_log()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTRIBVENDAREGIAO_LOG";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTribvendaregiao_log> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTribvendaregiao_log>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTribvendaregiao_log> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTribvendaregiao_log>(where);
        }

        #endregion
    }
}
