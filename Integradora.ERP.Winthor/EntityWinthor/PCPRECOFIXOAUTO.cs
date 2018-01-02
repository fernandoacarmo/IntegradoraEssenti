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
    /// Classe referente a tabela PCPrecofixoauto
    /// </summary>
    [XmlType("PCPRECOFIXOAUTO")]
    public class PCPrecofixoauto : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Código do Cliente
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código Filial
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: Código
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Código do produto
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOCLI
        /// Comentário: Código do tipo de cliente
        /// </summary>
        private decimal codtipocli;
        [XmlElement(ElementName = "CODTIPOCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codtipocli
        {
            get { return  codtipocli; }
            set {  codtipocli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Comentário: Data de Cancelamento
        /// </summary>
        private DateTime? dtcancel;
        [XmlElement(ElementName = "DTCANCEL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancel
        {
            get { return  dtcancel; }
            set {  dtcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIM
        /// Comentário: Data final
        /// </summary>
        private DateTime? dtfim;
        [XmlElement(ElementName = "DTFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfim
        {
            get { return  dtfim; }
            set {  dtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Comentário: Data inicial
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MULTIPLO
        /// Comentário: Mutiplo
        /// </summary>
        private decimal multiplo;
        [XmlElement(ElementName = "MULTIPLO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Multiplo
        {
            get { return  multiplo; }
            set {  multiplo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOMISSAO
        /// Comentário: Percentual de Comissão
        /// </summary>
        private decimal perccomissao;
        [XmlElement(ElementName = "PERCCOMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perccomissao
        {
            get { return  perccomissao; }
            set {  perccomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOFIXO
        /// Comentário: Preço Fixo
        /// </summary>
        private decimal precofixo;
        [XmlElement(ElementName = "PRECOFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Precofixo
        {
            get { return  precofixo; }
            set {  precofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTFIMINTERVALO
        /// Comentário: Quantidade intervalo final
        /// </summary>
        private decimal qtfimintervalo;
        [XmlElement(ElementName = "QTFIMINTERVALO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtfimintervalo
        {
            get { return  qtfimintervalo; }
            set {  qtfimintervalo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTINICIOINTERVALO
        /// Comentário: Quantidade intervalo inicial
        /// </summary>
        private decimal qtiniciointervalo;
        [XmlElement(ElementName = "QTINICIOINTERVALO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtiniciointervalo
        {
            get { return  qtiniciointervalo; }
            set {  qtiniciointervalo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINIMA
        /// Comentário: Quantidade mínima
        /// </summary>
        private decimal qtminima;
        [XmlElement(ElementName = "QTMINIMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtminima
        {
            get { return  qtminima; }
            set {  qtminima = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTOFERTA
        /// Comentário: Quantidade da Oferta
        /// </summary>
        private decimal qtoferta;
        [XmlElement(ElementName = "QTOFERTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtoferta
        {
            get { return  qtoferta; }
            set {  qtoferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPOLITICA
        /// Comentário: Tipo política
        /// </summary>
        private string tipopolitica;
        [XmlElement(ElementName = "TIPOPOLITICA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipopolitica
        {
            get { return  tipopolitica; }
            set {  tipopolitica = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPrecofixoauto()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRECOFIXOAUTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPrecofixoauto> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPrecofixoauto>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPrecofixoauto> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPrecofixoauto>(where);
        }

        #endregion
    }
}
