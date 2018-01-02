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
    /// Classe referente a tabela PCElementoformulatinta
    /// </summary>
    [XmlType("PCELEMENTOFORMULATINTA")]
    public class PCElementoformulatinta : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CHAVEPRINCIPAL
        /// Comentário: 
        /// </summary>
        private string chaveprincipal;
        [XmlElement(ElementName = "CHAVEPRINCIPAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Chaveprincipal
        {
            get { return  chaveprincipal; }
            set {  chaveprincipal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBASE
        /// Comentário: 
        /// </summary>
        private string codbase;
        [XmlElement(ElementName = "CODBASE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codbase
        {
            get { return  codbase; }
            set {  codbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORMULA
        /// Comentário: 
        /// </summary>
        private string codformula;
        [XmlElement(ElementName = "CODFORMULA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Codformula
        {
            get { return  codformula; }
            set {  codformula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMAQUINA
        /// Comentário: 
        /// </summary>
        private decimal codmaquina;
        [XmlElement(ElementName = "CODMAQUINA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codmaquina
        {
            get { return  codmaquina; }
            set {  codmaquina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODTINTA
        /// Comentário: 
        /// </summary>
        private string codprodtinta;
        [XmlElement(ElementName = "CODPRODTINTA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Codprodtinta
        {
            get { return  codprodtinta; }
            set {  codprodtinta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEM
        /// Comentário: 
        /// </summary>
        private decimal ordem;
        [XmlElement(ElementName = "ORDEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Ordem
        {
            get { return  ordem; }
            set {  ordem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDETINTAML
        /// Comentário: 
        /// </summary>
        private decimal qtdetintaml;
        [XmlElement(ElementName = "QTDETINTAML", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtdetintaml
        {
            get { return  qtdetintaml; }
            set {  qtdetintaml = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDETINTAML_GALAO
        /// Comentário: qtde de tinta em ML para um galao de tinta	qtde de tinta em ML para um galao de tinta
        /// </summary>
        private decimal qtdetintaml_galao;
        [XmlElement(ElementName = "QTDETINTAML_GALAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtdetintaml_Galao
        {
            get { return  qtdetintaml_galao; }
            set {  qtdetintaml_galao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDETINTAML_LATA
        /// Comentário: qtde de tinta em ML para uma lata de tinta	qtde de tinta em ML para uma lata de tinta
        /// </summary>
        private decimal qtdetintaml_lata;
        [XmlElement(ElementName = "QTDETINTAML_LATA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtdetintaml_Lata
        {
            get { return  qtdetintaml_lata; }
            set {  qtdetintaml_lata = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDETINTAML_QUARTO
        /// Comentário: qtde de tinta em ML para um quarto de tinta	qtde de tinta em ML para um quarto de tinta
        /// </summary>
        private decimal qtdetintaml_quarto;
        [XmlElement(ElementName = "QTDETINTAML_QUARTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtdetintaml_Quarto
        {
            get { return  qtdetintaml_quarto; }
            set {  qtdetintaml_quarto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD_GRAMA
        /// Comentário: 
        /// </summary>
        private decimal qtd_grama;
        [XmlElement(ElementName = "QTD_GRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Qtd_Grama
        {
            get { return  qtd_grama; }
            set {  qtd_grama = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD1
        /// Comentário: 
        /// </summary>
        private decimal qtd1;
        [XmlElement(ElementName = "QTD1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtd1
        {
            get { return  qtd1; }
            set {  qtd1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD1_GALAO
        /// Comentário: qtde de tinta em Pulso para um galao de tinta	qtde de tinta em Pulso para um galao de tinta
        /// </summary>
        private decimal qtd1_galao;
        [XmlElement(ElementName = "QTD1_GALAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtd1_Galao
        {
            get { return  qtd1_galao; }
            set {  qtd1_galao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD1_LATA
        /// Comentário: qtde de tinta em Pulso para uma lata de tinta	qtde de tinta em Pulso para uma lata de tinta
        /// </summary>
        private decimal qtd1_lata;
        [XmlElement(ElementName = "QTD1_LATA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtd1_Lata
        {
            get { return  qtd1_lata; }
            set {  qtd1_lata = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD1_QUARTO
        /// Comentário: qtde de tinta em Pulso para um quarto de tinta	qtde de tinta em Pulso para um quarto de tinta
        /// </summary>
        private decimal qtd1_quarto;
        [XmlElement(ElementName = "QTD1_QUARTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtd1_Quarto
        {
            get { return  qtd1_quarto; }
            set {  qtd1_quarto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD2
        /// Comentário: 
        /// </summary>
        private decimal qtd2;
        [XmlElement(ElementName = "QTD2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtd2
        {
            get { return  qtd2; }
            set {  qtd2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD2_GALAO
        /// Comentário: qtde de tinta em Pulso para um galao de tinta	qtde de tinta em Pulso para um galao de tinta
        /// </summary>
        private decimal qtd2_galao;
        [XmlElement(ElementName = "QTD2_GALAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtd2_Galao
        {
            get { return  qtd2_galao; }
            set {  qtd2_galao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD2_LATA
        /// Comentário: qtde de tinta em Pulso para uma lata de tinta	qtde de tinta em Pulso para uma lata de tinta
        /// </summary>
        private decimal qtd2_lata;
        [XmlElement(ElementName = "QTD2_LATA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtd2_Lata
        {
            get { return  qtd2_lata; }
            set {  qtd2_lata = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD2_QUARTO
        /// Comentário: qtde de tinta em Pulso para um quarto de tinta	qtde de tinta em Pulso para um quarto de tinta
        /// </summary>
        private decimal qtd2_quarto;
        [XmlElement(ElementName = "QTD2_QUARTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtd2_Quarto
        {
            get { return  qtd2_quarto; }
            set {  qtd2_quarto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD3
        /// Comentário: 
        /// </summary>
        private decimal qtd3;
        [XmlElement(ElementName = "QTD3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtd3
        {
            get { return  qtd3; }
            set {  qtd3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD3_GALAO
        /// Comentário: qtde de tinta em Pulso para um galao de tinta	qtde de tinta em Pulso para um galao de tinta
        /// </summary>
        private decimal qtd3_galao;
        [XmlElement(ElementName = "QTD3_GALAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtd3_Galao
        {
            get { return  qtd3_galao; }
            set {  qtd3_galao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD3_LATA
        /// Comentário: qtde de tinta em Pulso para uma lata de tinta	qtde de tinta em Pulso para uma lata de tinta
        /// </summary>
        private decimal qtd3_lata;
        [XmlElement(ElementName = "QTD3_LATA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtd3_Lata
        {
            get { return  qtd3_lata; }
            set {  qtd3_lata = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD3_QUARTO
        /// Comentário: qtde de tinta em Pulso para um quarto de tinta	qtde de tinta em Pulso para um quarto de tinta
        /// </summary>
        private decimal qtd3_quarto;
        [XmlElement(ElementName = "QTD3_QUARTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtd3_Quarto
        {
            get { return  qtd3_quarto; }
            set {  qtd3_quarto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD4
        /// Comentário: 
        /// </summary>
        private decimal qtd4;
        [XmlElement(ElementName = "QTD4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtd4
        {
            get { return  qtd4; }
            set {  qtd4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD4_GALAO
        /// Comentário: qtde de tinta em Pulso para um galao de tinta	qtde de tinta em Pulso para um galao de tinta
        /// </summary>
        private decimal qtd4_galao;
        [XmlElement(ElementName = "QTD4_GALAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtd4_Galao
        {
            get { return  qtd4_galao; }
            set {  qtd4_galao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD4_LATA
        /// Comentário: 
        /// </summary>
        private decimal qtd4_lata;
        [XmlElement(ElementName = "QTD4_LATA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtd4_Lata
        {
            get { return  qtd4_lata; }
            set {  qtd4_lata = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD4_QUARTO
        /// Comentário: qtde de tinta em Pulso para um quarto de tinta	qtde de tinta em Pulso para um quarto de tinta
        /// </summary>
        private decimal qtd4_quarto;
        [XmlElement(ElementName = "QTD4_QUARTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtd4_Quarto
        {
            get { return  qtd4_quarto; }
            set {  qtd4_quarto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Comentário: situação da formula de tinta
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMBALAGEMORIGINAL
        /// Comentário: tipo de embalagem	tipo de embalagem da tinta
        /// </summary>
        private string tipoembalagemoriginal;
        [XmlElement(ElementName = "TIPOEMBALAGEMORIGINAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoembalagemoriginal
        {
            get { return  tipoembalagemoriginal; }
            set {  tipoembalagemoriginal = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCElementoformulatinta()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCELEMENTOFORMULATINTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCElementoformulatinta> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCElementoformulatinta>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCElementoformulatinta> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCElementoformulatinta>(where);
        }

        #endregion
    }
}
