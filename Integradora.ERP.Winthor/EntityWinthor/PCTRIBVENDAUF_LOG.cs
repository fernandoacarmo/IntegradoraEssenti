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
    /// Classe referente a tabela PCTribvendauf_log
    /// </summary>
    [XmlType("PCTRIBVENDAUF_LOG")]
    public class PCTribvendauf_log : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL_NEW
        /// Coment�rio: C�digo da filial de origem Novo
        /// </summary>
        private string codfilial_new;
        [XmlElement(ElementName = "CODFILIAL_NEW", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial_New
        {
            get { return  codfilial_new; }
            set {  codfilial_new = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL_OLD
        /// Coment�rio: C�digo da filial de origem Anterior
        /// </summary>
        private string codfilial_old;
        [XmlElement(ElementName = "CODFILIAL_OLD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial_Old
        {
            get { return  codfilial_old; }
            set {  codfilial_old = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: Cod.Funcionario altera��o
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
        /// Coment�rio: C�digo NCM mais Ex Novo
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
        /// Coment�rio: C�digo NCM mais Ex Anterior
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
        /// Coment�rio: C�digo do ST Novo
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
        /// Coment�rio: C�digo do ST Anterior
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
        /// Coment�rio: C�digo da tributa��o do PIS/COFINS Novo
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
        /// Coment�rio: C�digo da tributa��o do PIS/COFINS Anterior
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
        /// Propriedade referente ao campo: CODTRIBVENDAUF
        /// Coment�rio: C�digo de tributa��o de venda por UF
        /// </summary>
        private decimal codtribvendauf;
        [XmlElement(ElementName = "CODTRIBVENDAUF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codtribvendauf
        {
            get { return  codtribvendauf; }
            set {  codtribvendauf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data da altera��o
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
        /// Propriedade referente ao campo: OPERACAO
        /// Coment�rio: Tipo de Opera��o Inclus�o, Edi��o
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
        /// Coment�rio: Rotina que realizou altera��o
        /// </summary>
        private string rotina;
        [XmlElement(ElementName = "ROTINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Rotina
        {
            get { return  rotina; }
            set {  rotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFDESTINO_NEW
        /// Coment�rio: Estado de destino Novo
        /// </summary>
        private string ufdestino_new;
        [XmlElement(ElementName = "UFDESTINO_NEW", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufdestino_New
        {
            get { return  ufdestino_new; }
            set {  ufdestino_new = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFDESTINO_OLD
        /// Coment�rio: Estado de destino Anterio
        /// </summary>
        private string ufdestino_old;
        [XmlElement(ElementName = "UFDESTINO_OLD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufdestino_Old
        {
            get { return  ufdestino_old; }
            set {  ufdestino_old = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCTribvendauf_log()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTRIBVENDAUF_LOG";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCTribvendauf_log> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTribvendauf_log>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCTribvendauf_log> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTribvendauf_log>(where);
        }

        #endregion
    }
}
