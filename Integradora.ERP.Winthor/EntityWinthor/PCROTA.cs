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
    /// Classe referente a tabela PCRota
    /// </summary>
    [XmlType("PCROTA")]
    public class PCRota : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODROTA
        /// Comentário: 
        /// </summary>
        private decimal codrota;
        [XmlElement(ElementName = "CODROTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codrota
        {
            get { return  codrota; }
            set {  codrota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEMANA
        /// Comentário: 
        /// </summary>
        private decimal diasemana;
        [XmlElement(ElementName = "DIASEMANA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Diasemana
        {
            get { return  diasemana; }
            set {  diasemana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASENTREGA
        /// Comentário: Dias de Entrega
        /// </summary>
        private decimal diasentrega;
        [XmlElement(ElementName = "DIASENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Diasentrega
        {
            get { return  diasentrega; }
            set {  diasentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Comentário: 
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
        /// Propriedade referente ao campo: DTULTALTERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtultalteracao;
        [XmlElement(ElementName = "DTULTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalteracao
        {
            get { return  dtultalteracao; }
            set {  dtultalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFESCANTV14
        /// Comentário: Próximo número de NF-e
        /// </summary>
        private decimal proxnumnfescantv14;
        [XmlElement(ElementName = "PROXNUMNFESCANTV14", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Proxnumnfescantv14
        {
            get { return  proxnumnfescantv14; }
            set {  proxnumnfescantv14 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFETV14
        /// Comentário: Próximo número de NF-e
        /// </summary>
        private decimal proxnumnfetv14;
        [XmlElement(ElementName = "PROXNUMNFETV14", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Proxnumnfetv14
        {
            get { return  proxnumnfetv14; }
            set {  proxnumnfetv14 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENFESCANTV14
        /// Comentário: Série NFe
        /// </summary>
        private decimal serienfescantv14;
        [XmlElement(ElementName = "SERIENFESCANTV14", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Serienfescantv14
        {
            get { return  serienfescantv14; }
            set {  serienfescantv14 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENFETV14
        /// Comentário: Série NFe
        /// </summary>
        private decimal serienfetv14;
        [XmlElement(ElementName = "SERIENFETV14", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Serienfetv14
        {
            get { return  serienfetv14; }
            set {  serienfetv14 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRota()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCROTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRota> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRota>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRota> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRota>(where);
        }

        #endregion
    }
}
