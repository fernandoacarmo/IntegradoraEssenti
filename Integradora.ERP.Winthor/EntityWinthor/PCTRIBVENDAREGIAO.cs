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
    /// Classe referente a tabela PCTribvendaregiao
    /// </summary>
    [XmlType("PCTRIBVENDAREGIAO")]
    public class PCTribvendaregiao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCINCLUSAO
        /// Comentário: Código do funcionario inclusão
        /// </summary>
        private decimal codfuncinclusao;
        [XmlElement(ElementName = "CODFUNCINCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfuncinclusao
        {
            get { return  codfuncinclusao; }
            set {  codfuncinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALT
        /// Comentário: Código do funcionario última alteração
        /// </summary>
        private decimal codfuncultalt;
        [XmlElement(ElementName = "CODFUNCULTALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfuncultalt
        {
            get { return  codfuncultalt; }
            set {  codfuncultalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNCMEX
        /// Comentário: Código NCM+Ex
        /// </summary>
        private string codncmex;
        [XmlElement(ElementName = "CODNCMEX", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public string Codncmex
        {
            get { return  codncmex; }
            set {  codncmex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODST
        /// Comentário: Código do ST
        /// </summary>
        private decimal codst;
        [XmlElement(ElementName = "CODST", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codst
        {
            get { return  codst; }
            set {  codst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRIBPISCOFINS
        /// Comentário: Código da tributação do PIS/COFINS
        /// </summary>
        private decimal codtribpiscofins;
        [XmlElement(ElementName = "CODTRIBPISCOFINS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codtribpiscofins
        {
            get { return  codtribpiscofins; }
            set {  codtribpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRIBVENDAREGIAO
        /// Comentário: Código de tributação de venda por UF
        /// </summary>
        private decimal codtribvendaregiao;
        [XmlElement(ElementName = "CODTRIBVENDAREGIAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codtribvendaregiao
        {
            get { return  codtribvendaregiao; }
            set {  codtribvendaregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: Data de Inclusão
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALT
        /// Comentário: Data de última alteração
        /// </summary>
        private DateTime? dtultalt;
        [XmlElement(ElementName = "DTULTALT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalt
        {
            get { return  dtultalt; }
            set {  dtultalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Comentário: Número da regiáo a qual a tributação estara vinculada
        /// </summary>
        private decimal numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Numregiao
        {
            get { return  numregiao; }
            set {  numregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINAINCLUSAO
        /// Comentário: Rotina de inclusão
        /// </summary>
        private string rotinainclusao;
        [XmlElement(ElementName = "ROTINAINCLUSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Rotinainclusao
        {
            get { return  rotinainclusao; }
            set {  rotinainclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINAULTALT
        /// Comentário: Rotina de última alteração
        /// </summary>
        private string rotinaultalt;
        [XmlElement(ElementName = "ROTINAULTALT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Rotinaultalt
        {
            get { return  rotinaultalt; }
            set {  rotinaultalt = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTribvendaregiao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTRIBVENDAREGIAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTribvendaregiao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTribvendaregiao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTribvendaregiao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTribvendaregiao>(where);
        }

        #endregion
    }
}
