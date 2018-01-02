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
    /// Classe referente a tabela PCProdutnutri
    /// </summary>
    [XmlType("PCPRODUTNUTRI")]
    public class PCProdutnutri : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CALCIO
        /// Comentário: 
        /// </summary>
        private decimal calcio;
        [XmlElement(ElementName = "CALCIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Calcio
        {
            get { return  calcio; }
            set {  calcio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARBOIDRATOS
        /// Comentário: 
        /// </summary>
        private decimal carboidratos;
        [XmlElement(ElementName = "CARBOIDRATOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Carboidratos
        {
            get { return  carboidratos; }
            set {  carboidratos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,16)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLESTEROL
        /// Comentário: 
        /// </summary>
        private decimal colesterol;
        [XmlElement(ElementName = "COLESTEROL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Colesterol
        {
            get { return  colesterol; }
            set {  colesterol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FERRO
        /// Comentário: 
        /// </summary>
        private decimal ferro;
        [XmlElement(ElementName = "FERRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Ferro
        {
            get { return  ferro; }
            set {  ferro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIBRAALIMENTAR
        /// Comentário: 
        /// </summary>
        private decimal fibraalimentar;
        [XmlElement(ElementName = "FIBRAALIMENTAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Fibraalimentar
        {
            get { return  fibraalimentar; }
            set {  fibraalimentar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GORDURASATURADA
        /// Comentário: 
        /// </summary>
        private decimal gordurasaturada;
        [XmlElement(ElementName = "GORDURASATURADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Gordurasaturada
        {
            get { return  gordurasaturada; }
            set {  gordurasaturada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GORDURATOTAL
        /// Comentário: 
        /// </summary>
        private decimal gorduratotal;
        [XmlElement(ElementName = "GORDURATOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Gorduratotal
        {
            get { return  gorduratotal; }
            set {  gorduratotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GORDURATRANS
        /// Comentário: Indica o valor nutricional da gordura tans.
        /// </summary>
        private decimal gorduratrans;
        [XmlElement(ElementName = "GORDURATRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Gorduratrans
        {
            get { return  gorduratrans; }
            set {  gorduratrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORCAO
        /// Comentário: 
        /// </summary>
        private string porcao;
        [XmlElement(ElementName = "PORCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,35)]
        public string Porcao
        {
            get { return  porcao; }
            set {  porcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTEINAS
        /// Comentário: 
        /// </summary>
        private decimal proteinas;
        [XmlElement(ElementName = "PROTEINAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proteinas
        {
            get { return  proteinas; }
            set {  proteinas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SODIO
        /// Comentário: 
        /// </summary>
        private decimal sodio;
        [XmlElement(ElementName = "SODIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Sodio
        {
            get { return  sodio; }
            set {  sodio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADEPORCAO
        /// Comentário: 
        /// </summary>
        private string unidadeporcao;
        [XmlElement(ElementName = "UNIDADEPORCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Unidadeporcao
        {
            get { return  unidadeporcao; }
            set {  unidadeporcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCALORICO
        /// Comentário: 
        /// </summary>
        private decimal valorcalorico;
        [XmlElement(ElementName = "VALORCALORICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Valorcalorico
        {
            get { return  valorcalorico; }
            set {  valorcalorico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VDCALCIO
        /// Comentário: 
        /// </summary>
        private decimal vdcalcio;
        [XmlElement(ElementName = "VDCALCIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vdcalcio
        {
            get { return  vdcalcio; }
            set {  vdcalcio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VDCARBOIDRATOS
        /// Comentário: 
        /// </summary>
        private decimal vdcarboidratos;
        [XmlElement(ElementName = "VDCARBOIDRATOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vdcarboidratos
        {
            get { return  vdcarboidratos; }
            set {  vdcarboidratos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VDCOLESTEROL
        /// Comentário: 
        /// </summary>
        private decimal vdcolesterol;
        [XmlElement(ElementName = "VDCOLESTEROL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vdcolesterol
        {
            get { return  vdcolesterol; }
            set {  vdcolesterol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VDFERRO
        /// Comentário: 
        /// </summary>
        private decimal vdferro;
        [XmlElement(ElementName = "VDFERRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vdferro
        {
            get { return  vdferro; }
            set {  vdferro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VDFIBRAALIMENTAR
        /// Comentário: 
        /// </summary>
        private decimal vdfibraalimentar;
        [XmlElement(ElementName = "VDFIBRAALIMENTAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vdfibraalimentar
        {
            get { return  vdfibraalimentar; }
            set {  vdfibraalimentar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VDGORDURASATURADA
        /// Comentário: 
        /// </summary>
        private decimal vdgordurasaturada;
        [XmlElement(ElementName = "VDGORDURASATURADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vdgordurasaturada
        {
            get { return  vdgordurasaturada; }
            set {  vdgordurasaturada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VDGORDURATOTAL
        /// Comentário: 
        /// </summary>
        private decimal vdgorduratotal;
        [XmlElement(ElementName = "VDGORDURATOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vdgorduratotal
        {
            get { return  vdgorduratotal; }
            set {  vdgorduratotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VDGORDURATRANS
        /// Comentário: Indica o valor para consumo diario de gordura trans
        /// </summary>
        private decimal vdgorduratrans;
        [XmlElement(ElementName = "VDGORDURATRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vdgorduratrans
        {
            get { return  vdgorduratrans; }
            set {  vdgorduratrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VDPROTEINAS
        /// Comentário: 
        /// </summary>
        private decimal vdproteinas;
        [XmlElement(ElementName = "VDPROTEINAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vdproteinas
        {
            get { return  vdproteinas; }
            set {  vdproteinas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VDSODIO
        /// Comentário: 
        /// </summary>
        private decimal vdsodio;
        [XmlElement(ElementName = "VDSODIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vdsodio
        {
            get { return  vdsodio; }
            set {  vdsodio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VDVALORCALORICO
        /// Comentário: 
        /// </summary>
        private decimal vdvalorcalorico;
        [XmlElement(ElementName = "VDVALORCALORICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vdvalorcalorico
        {
            get { return  vdvalorcalorico; }
            set {  vdvalorcalorico = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCProdutnutri()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODUTNUTRI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCProdutnutri> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdutnutri>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCProdutnutri> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdutnutri>(where);
        }

        #endregion
    }
}
