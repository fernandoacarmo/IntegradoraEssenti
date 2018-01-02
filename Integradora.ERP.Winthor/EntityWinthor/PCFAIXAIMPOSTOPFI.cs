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
    /// Classe referente a tabela PCFaixaimpostopfi
    /// </summary>
    [XmlType("PCFAIXAIMPOSTOPFI")]
    public class PCFaixaimpostopfi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALIQUOTA
        /// Coment�rio: Al�quota
        /// </summary>
        private decimal aliquota;
        [XmlElement(ElementName = "ALIQUOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Aliquota
        {
            get { return  aliquota; }
            set {  aliquota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: C�digo
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIMINTERVALO
        /// Coment�rio: Fim do intervalo
        /// </summary>
        private decimal fimintervalo;
        [XmlElement(ElementName = "FIMINTERVALO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Fimintervalo
        {
            get { return  fimintervalo; }
            set {  fimintervalo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INICIOINTERVALO
        /// Coment�rio: In�cio do intervalo
        /// </summary>
        private decimal iniciointervalo;
        [XmlElement(ElementName = "INICIOINTERVALO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Iniciointervalo
        {
            get { return  iniciointervalo; }
            set {  iniciointervalo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEDUCAOIR
        /// Coment�rio: Valor de dedu��o imposto de renda
        /// </summary>
        private decimal vldeducaoir;
        [XmlElement(ElementName = "VLDEDUCAOIR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldeducaoir
        {
            get { return  vldeducaoir; }
            set {  vldeducaoir = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCFaixaimpostopfi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFAIXAIMPOSTOPFI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCFaixaimpostopfi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFaixaimpostopfi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCFaixaimpostopfi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFaixaimpostopfi>(where);
        }

        #endregion
    }
}
