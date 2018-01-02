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
    /// Classe referente a tabela PCPreentdatavalidade
    /// </summary>
    [XmlType("PCPREENTDATAVALIDADE")]
    public class PCPreentdatavalidade : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: Informa��o referente ao c�digo do produto.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Coment�rio: Data de validade do produto contido no b�nus.
        /// </summary>
        private DateTime? dtvalidade;
        [XmlElement(ElementName = "DTVALIDADE", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtvalidade
        {
            get { return  dtvalidade; }
            set {  dtvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONUS
        /// Coment�rio: Informa��o referente ao n�mero do b�nus.
        /// </summary>
        private decimal numbonus;
        [XmlElement(ElementName = "NUMBONUS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numbonus
        {
            get { return  numbonus; }
            set {  numbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: Informa��o referente ao n�mero do lote.
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: Quantidade de entrada produto incluso no b�nus.
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTAVARIA
        /// Coment�rio: Quantidade de entrada avariada produto incluso no b�nus.
        /// </summary>
        private decimal qtavaria;
        [XmlElement(ElementName = "QTAVARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtavaria
        {
            get { return  qtavaria; }
            set {  qtavaria = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPreentdatavalidade()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPREENTDATAVALIDADE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPreentdatavalidade> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPreentdatavalidade>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPreentdatavalidade> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPreentdatavalidade>(where);
        }

        #endregion
    }
}
