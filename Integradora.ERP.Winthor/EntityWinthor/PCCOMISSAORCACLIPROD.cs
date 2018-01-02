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
    /// Classe referente a tabela PCComissaorcacliprod
    /// </summary>
    [XmlType("PCCOMISSAORCACLIPROD")]
    public class PCComissaorcacliprod : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Código do cliente a ser utilizado na aplicação da comissão. |Campo do tipo numérico, de tamanho 6, sem casas decimais, obrigatória.
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Código do produto a ser utilizado para aplicação da comissão do RCA. |Campo do tipo numérico, de tamanho 6, sem casas decimais, obrigatória.
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
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: Código do RCA a ser utilizado na aplicação da comissão. |Campo do tipo numérico, de tamanho 4, sem casas decimais, obrigatória.
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFINAL
        /// Comentário: Data final de vigência da comissão do RCA. |Campo do tipo data, obrigatória.
        /// </summary>
        private DateTime? datafinal;
        [XmlElement(ElementName = "DATAFINAL", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Datafinal
        {
            get { return  datafinal; }
            set {  datafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAINICIAL
        /// Comentário: Data inicial de vigência da comissão do RCA. |Campo do tipo data, obrigatória.
        /// </summary>
        private DateTime? datainicial;
        [XmlElement(ElementName = "DATAINICIAL", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Datainicial
        {
            get { return  datainicial; }
            set {  datainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM
        /// Comentário: Valor do percentual da comissão do RCA. |Campo do tipo numérico, de tamanho 6, com 2 casas decimais.
        /// </summary>
        private decimal percom;
        [XmlElement(ElementName = "PERCOM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Percom
        {
            get { return  percom; }
            set {  percom = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCComissaorcacliprod()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOMISSAORCACLIPROD";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCComissaorcacliprod> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCComissaorcacliprod>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCComissaorcacliprod> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCComissaorcacliprod>(where);
        }

        #endregion
    }
}
