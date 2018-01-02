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
    /// Classe referente a tabela PCCarreg_cte
    /// </summary>
    [XmlType("PCCARREG_CTE")]
    public class PCCarreg_cte : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIO
        /// Comentário: 
        /// </summary>
        private decimal codusuario;
        [XmlElement(ElementName = "CODUSUARIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codusuario
        {
            get { return  codusuario; }
            set {  codusuario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: KMFINAL
        /// Comentário: 
        /// </summary>
        private decimal kmfinal;
        [XmlElement(ElementName = "KMFINAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
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
        [XmlElement(ElementName = "KMINICIAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Kminicial
        {
            get { return  kminicial; }
            set {  kminicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: KMTOTAL
        /// Comentário: 
        /// </summary>
        private decimal kmtotal;
        [XmlElement(ElementName = "KMTOTAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Kmtotal
        {
            get { return  kmtotal; }
            set {  kmtotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Comentário: 
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMBUSTIVEL
        /// Comentário: 
        /// </summary>
        private decimal vlcombustivel;
        [XmlElement(ElementName = "VLCOMBUSTIVEL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vlcombustivel
        {
            get { return  vlcombustivel; }
            set {  vlcombustivel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOTOTAL
        /// Comentário: 
        /// </summary>
        private decimal vlcustototal;
        [XmlElement(ElementName = "VLCUSTOTOTAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vlcustototal
        {
            get { return  vlcustototal; }
            set {  vlcustototal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPESAS
        /// Comentário: 
        /// </summary>
        private decimal vldespesas;
        [XmlElement(ElementName = "VLDESPESAS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vldespesas
        {
            get { return  vldespesas; }
            set {  vldespesas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDIARIA
        /// Comentário: 
        /// </summary>
        private decimal vldiaria;
        [XmlElement(ElementName = "VLDIARIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vldiaria
        {
            get { return  vldiaria; }
            set {  vldiaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIMPOSTO
        /// Comentário: 
        /// </summary>
        private decimal vlimposto;
        [XmlElement(ElementName = "VLIMPOSTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vlimposto
        {
            get { return  vlimposto; }
            set {  vlimposto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLKMRODADO
        /// Comentário: 
        /// </summary>
        private decimal vlkmrodado;
        [XmlElement(ElementName = "VLKMRODADO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vlkmrodado
        {
            get { return  vlkmrodado; }
            set {  vlkmrodado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLKMTOTAL
        /// Comentário: 
        /// </summary>
        private decimal vlkmtotal;
        [XmlElement(ElementName = "VLKMTOTAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vlkmtotal
        {
            get { return  vlkmtotal; }
            set {  vlkmtotal = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCarreg_cte()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCARREG_CTE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCarreg_cte> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCarreg_cte>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCarreg_cte> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCarreg_cte>(where);
        }

        #endregion
    }
}
