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
    /// Classe referente a tabela PCCampanhar
    /// </summary>
    [XmlType("PCCAMPANHAR")]
    public class PCCampanhar : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCAMPANHA
        /// Comentário: Indica o código da campanha.
        /// </summary>
        private decimal codcampanha;
        [XmlElement(ElementName = "CODCAMPANHA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codcampanha
        {
            get { return  codcampanha; }
            set {  codcampanha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERV
        /// Comentário: Indica o código do Supervisor do RCA da campanha.
        /// </summary>
        private decimal codsuperv;
        [XmlElement(ElementName = "CODSUPERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codsuperv
        {
            get { return  codsuperv; }
            set {  codsuperv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: Indica o código do RCA da campanha.
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
        /// Propriedade referente ao campo: METAPERCPOSITIV
        /// Comentário: Indica a meta em percentual de clientes positivados por RCA.
        /// </summary>
        private decimal metapercpositiv;
        [XmlElement(ElementName = "METAPERCPOSITIV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Metapercpositiv
        {
            get { return  metapercpositiv; }
            set {  metapercpositiv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: METAQTDE
        /// Comentário: Indica a meta em quantidade por RCA.
        /// </summary>
        private decimal metaqtde;
        [XmlElement(ElementName = "METAQTDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Metaqtde
        {
            get { return  metaqtde; }
            set {  metaqtde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: METAQTPOSITIV
        /// Comentário: Indica a meta em quantidade de clientes positivados por RCA.
        /// </summary>
        private decimal metaqtpositiv;
        [XmlElement(ElementName = "METAQTPOSITIV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Metaqtpositiv
        {
            get { return  metaqtpositiv; }
            set {  metaqtpositiv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: METAVALOR
        /// Comentário: Indica a meta em valor por RCA.
        /// </summary>
        private decimal metavalor;
        [XmlElement(ElementName = "METAVALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Metavalor
        {
            get { return  metavalor; }
            set {  metavalor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCLIATIVOS
        /// Comentário: Indica a quantidade de clientes ativos por RCA no fechamento da campanha.
        /// </summary>
        private decimal qtcliativos;
        [XmlElement(ElementName = "QTCLIATIVOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtcliativos
        {
            get { return  qtcliativos; }
            set {  qtcliativos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCLIPOSITIVADOS
        /// Comentário: Indica a quantidade de clientes positivados por RCA no fechamento da campanha.
        /// </summary>
        private decimal qtclipositivados;
        [XmlElement(ElementName = "QTCLIPOSITIVADOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtclipositivados
        {
            get { return  qtclipositivados; }
            set {  qtclipositivados = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIXMINIMOPOSITIV
        /// Comentário: Indica a quantidade do mix mínimo a ser vendido para considerar como positivação.
        /// </summary>
        private decimal qtmixminimopositiv;
        [XmlElement(ElementName = "QTMIXMINIMOPOSITIV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmixminimopositiv
        {
            get { return  qtmixminimopositiv; }
            set {  qtmixminimopositiv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAPRODRCA
        /// Comentário: Indica a quantidade total vendida de cada produto da campanha pelo RCA no fechamento da campanha.
        /// </summary>
        private decimal qtvendaprodrca;
        [XmlElement(ElementName = "QTVENDAPRODRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtvendaprodrca
        {
            get { return  qtvendaprodrca; }
            set {  qtvendaprodrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPREMIACAO
        /// Comentário: Indica o valor total da premiação paga ao RCA no fechamento da campanha.
        /// </summary>
        private decimal vlpremiacao;
        [XmlElement(ElementName = "VLPREMIACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpremiacao
        {
            get { return  vlpremiacao; }
            set {  vlpremiacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAPRODRCA
        /// Comentário: Indica o valor total vendido de cada produto da campanha pelo RCA no fechamento da campanha.
        /// </summary>
        private decimal vlvendaprodrca;
        [XmlElement(ElementName = "VLVENDAPRODRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlvendaprodrca
        {
            get { return  vlvendaprodrca; }
            set {  vlvendaprodrca = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCampanhar()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCAMPANHAR";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCampanhar> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCampanhar>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCampanhar> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCampanhar>(where);
        }

        #endregion
    }
}
