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
    /// Classe referente a tabela PCCapalote
    /// </summary>
    [XmlType("PCCAPALOTE")]
    public class PCCapalote : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AMBIENTECLE
        /// Comentário: AMBIENTE CAPA DE LOTE
        /// </summary>
        private string ambientecle;
        [XmlElement(ElementName = "AMBIENTECLE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Ambientecle
        {
            get { return  ambientecle; }
            set {  ambientecle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVECLE
        /// Comentário: CHAVE CAPA DE LOTE
        /// </summary>
        private string chavecle;
        [XmlElement(ElementName = "CHAVECLE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Chavecle
        {
            get { return  chavecle; }
            set {  chavecle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCAPALOTE
        /// Comentário: NUMERO SEQUENCIAL CAPA LOTE
        /// </summary>
        private decimal codcapalote;
        [XmlElement(ElementName = "CODCAPALOTE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codcapalote
        {
            get { return  codcapalote; }
            set {  codcapalote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: CODIGO DA FILIAL
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACLE
        /// Comentário: DATA CAPA DE LOTE
        /// </summary>
        private DateTime? datacle;
        [XmlElement(ElementName = "DATACLE", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Datacle
        {
            get { return  datacle; }
            set {  datacle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODALIDADETRANSP
        /// Comentário: MODALIDADE DE TRANSPORTE
        /// </summary>
        private string modalidadetransp;
        [XmlElement(ElementName = "MODALIDADETRANSP", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Modalidadetransp
        {
            get { return  modalidadetransp; }
            set {  modalidadetransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIAS
        /// Comentário: NUMERO DE VIAS IMPRESSAS
        /// </summary>
        private decimal numvias;
        [XmlElement(ElementName = "NUMVIAS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numvias
        {
            get { return  numvias; }
            set {  numvias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLACACARRETA1
        /// Comentário: PLACA DA CARRETA 1
        /// </summary>
        private string placacarreta1;
        [XmlElement(ElementName = "PLACACARRETA1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Placacarreta1
        {
            get { return  placacarreta1; }
            set {  placacarreta1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLACACARRETA2
        /// Comentário: PLACA DA CARRETA 2
        /// </summary>
        private string placacarreta2;
        [XmlElement(ElementName = "PLACACARRETA2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Placacarreta2
        {
            get { return  placacarreta2; }
            set {  placacarreta2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLACAVEICULO
        /// Comentário: PLACA DO VEICULO
        /// </summary>
        private string placaveiculo;
        [XmlElement(ElementName = "PLACAVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Placaveiculo
        {
            get { return  placaveiculo; }
            set {  placaveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAOCLE
        /// Comentário: SITUACAO CAPA DE LOTE
        /// </summary>
        private decimal situacaocle;
        [XmlElement(ElementName = "SITUACAOCLE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Situacaocle
        {
            get { return  situacaocle; }
            set {  situacaocle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFDESTINO
        /// Comentário: UF DE DESTINO DA CAPA DE LOTE
        /// </summary>
        private string ufdestino;
        [XmlElement(ElementName = "UFDESTINO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Ufdestino
        {
            get { return  ufdestino; }
            set {  ufdestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFORIGEM
        /// Comentário: UF DE ORIGEM DA CAPA DE LOTE
        /// </summary>
        private string uforigem;
        [XmlElement(ElementName = "UFORIGEM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Uforigem
        {
            get { return  uforigem; }
            set {  uforigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFPLACACARRETA1
        /// Comentário: UF DA PLACA DA CARRETA 1
        /// </summary>
        private string ufplacacarreta1;
        [XmlElement(ElementName = "UFPLACACARRETA1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufplacacarreta1
        {
            get { return  ufplacacarreta1; }
            set {  ufplacacarreta1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFPLACACARRETA2
        /// Comentário: UF PLACA DA CARRETA 2
        /// </summary>
        private string ufplacacarreta2;
        [XmlElement(ElementName = "UFPLACACARRETA2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufplacacarreta2
        {
            get { return  ufplacacarreta2; }
            set {  ufplacacarreta2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFPLACAVEICULO
        /// Comentário: UF DA PLACA DO VEICULO
        /// </summary>
        private string ufplacaveiculo;
        [XmlElement(ElementName = "UFPLACAVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufplacaveiculo
        {
            get { return  ufplacaveiculo; }
            set {  ufplacaveiculo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCapalote()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCAPALOTE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCapalote> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCapalote>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCapalote> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCapalote>(where);
        }

        #endregion
    }
}
