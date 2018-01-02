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
    /// Classe referente a tabela PCRemanejd
    /// </summary>
    [XmlType("PCREMANEJD")]
    public class PCRemanejd : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALDEST
        /// Comentário: Código filial destino.
        /// </summary>
        private string codfilialdest;
        [XmlElement(ElementName = "CODFILIALDEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialdest
        {
            get { return  codfilialdest; }
            set {  codfilialdest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALORIG
        /// Comentário: Código filial origem.
        /// </summary>
        private string codfilialorig;
        [XmlElement(ElementName = "CODFILIALORIG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialorig
        {
            get { return  codfilialorig; }
            set {  codfilialorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFINALIZADEST
        /// Comentário: Código do funcionário responsável pela finalização da etapa destino.
        /// </summary>
        private decimal codfuncfinalizadest;
        [XmlElement(ElementName = "CODFUNCFINALIZADEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfuncfinalizadest
        {
            get { return  codfuncfinalizadest; }
            set {  codfuncfinalizadest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFINALIZAORIG
        /// Comentário: Código do funcionário responsável pela finalização da etapa origem.
        /// </summary>
        private decimal codfuncfinalizaorig;
        [XmlElement(ElementName = "CODFUNCFINALIZAORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfuncfinalizaorig
        {
            get { return  codfuncfinalizaorig; }
            set {  codfuncfinalizaorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREMANEJI
        /// Comentário: Código que identifica a combinação: nº pedido, cod. Filial origem, cod. Filial destino e nº remessa remanejamento.
        /// </summary>
        private decimal codremaneji;
        [XmlElement(ElementName = "CODREMANEJI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codremaneji
        {
            get { return  codremaneji; }
            set {  codremaneji = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINALIZADEST
        /// Comentário: Data finalização da etapa destino.
        /// </summary>
        private DateTime? dtfinalizadest;
        [XmlElement(ElementName = "DTFINALIZADEST", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinalizadest
        {
            get { return  dtfinalizadest; }
            set {  dtfinalizadest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINALIZAORIG
        /// Comentário: Data finalização da etapa origem.
        /// </summary>
        private DateTime? dtfinalizaorig;
        [XmlElement(ElementName = "DTFINALIZAORIG", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinalizaorig
        {
            get { return  dtfinalizaorig; }
            set {  dtfinalizaorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVODIVERGDEST
        /// Comentário: Motivo divergência destino.
        /// </summary>
        private string motivodivergdest;
        [XmlElement(ElementName = "MOTIVODIVERGDEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Motivodivergdest
        {
            get { return  motivodivergdest; }
            set {  motivodivergdest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVODIVERGORIG
        /// Comentário: Motivo divergência origem.
        /// </summary>
        private string motivodivergorig;
        [XmlElement(ElementName = "MOTIVODIVERGORIG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Motivodivergorig
        {
            get { return  motivodivergorig; }
            set {  motivodivergorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: Número do pedido TV=10.
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREMESSA
        /// Comentário: Número da remessa de remanejamento.
        /// </summary>
        private decimal numremessa;
        [XmlElement(ElementName = "NUMREMESSA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numremessa
        {
            get { return  numremessa; }
            set {  numremessa = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRemanejd()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCREMANEJD";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRemanejd> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRemanejd>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRemanejd> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRemanejd>(where);
        }

        #endregion
    }
}
