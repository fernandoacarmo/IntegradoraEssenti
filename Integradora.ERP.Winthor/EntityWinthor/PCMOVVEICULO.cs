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
    /// Classe referente a tabela PCMovveiculo
    /// </summary>
    [XmlType("PCMOVVEICULO")]
    public class PCMovveiculo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODMOTORISTA
        /// Comentário: 
        /// </summary>
        private decimal codmotorista;
        [XmlElement(ElementName = "CODMOTORISTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codmotorista
        {
            get { return  codmotorista; }
            set {  codmotorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVEICULO
        /// Comentário: 
        /// </summary>
        private decimal codveiculo;
        [XmlElement(ElementName = "CODVEICULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codveiculo
        {
            get { return  codveiculo; }
            set {  codveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTRETORNO
        /// Comentário: 
        /// </summary>
        private DateTime? dtretorno;
        [XmlElement(ElementName = "DTRETORNO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtretorno
        {
            get { return  dtretorno; }
            set {  dtretorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSAIDAVEICULO
        /// Comentário: 
        /// </summary>
        private DateTime? dtsaidaveiculo;
        [XmlElement(ElementName = "DTSAIDAVEICULO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtsaidaveiculo
        {
            get { return  dtsaidaveiculo; }
            set {  dtsaidaveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICORETORNO
        /// Comentário: 
        /// </summary>
        private string historicoretorno;
        [XmlElement(ElementName = "HISTORICORETORNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,240)]
        public string Historicoretorno
        {
            get { return  historicoretorno; }
            set {  historicoretorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICOSAIDA
        /// Comentário: 
        /// </summary>
        private string historicosaida;
        [XmlElement(ElementName = "HISTORICOSAIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,240)]
        public string Historicosaida
        {
            get { return  historicosaida; }
            set {  historicosaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: KMFINAL
        /// Comentário: 
        /// </summary>
        private decimal kmfinal;
        [XmlElement(ElementName = "KMFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Kmfinal
        {
            get { return  kmfinal; }
            set {  kmfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: KMINICIAL
        /// Comentário: 
        /// </summary>
        private decimal kminicial;
        [XmlElement(ElementName = "KMINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Kminicial
        {
            get { return  kminicial; }
            set {  kminicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOMBUSTIVEL
        /// Comentário: 
        /// </summary>
        private decimal qtcombustivel;
        [XmlElement(ElementName = "QTCOMBUSTIVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtcombustivel
        {
            get { return  qtcombustivel; }
            set {  qtcombustivel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMBUSTIVEL
        /// Comentário: 
        /// </summary>
        private decimal vlcombustivel;
        [XmlElement(ElementName = "VLCOMBUSTIVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vlcombustivel
        {
            get { return  vlcombustivel; }
            set {  vlcombustivel = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMovveiculo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOVVEICULO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMovveiculo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovveiculo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMovveiculo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMovveiculo>(where);
        }

        #endregion
    }
}
