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
    /// Classe referente a tabela PCValecx
    /// </summary>
    [XmlType("PCVALECX")]
    public class PCValecx : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Coment�rio: 
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Coment�rio: 
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCRECLI
        /// Coment�rio: Indica o cr�dito de cliente.
        /// </summary>
        private decimal codcrecli;
        [XmlElement(ElementName = "CODCRECLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcrecli
        {
            get { return  codcrecli; }
            set {  codcrecli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: 
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFECHA
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncfecha;
        [XmlElement(ElementName = "CODFUNCFECHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfecha
        {
            get { return  codfuncfecha; }
            set {  codfuncfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAOSERVINT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtexportacaoservint;
        [XmlElement(ElementName = "DTEXPORTACAOSERVINT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacaoservint
        {
            get { return  dtexportacaoservint; }
            set {  dtexportacaoservint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfecha;
        [XmlElement(ElementName = "DTFECHA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfecha
        {
            get { return  dtfecha; }
            set {  dtfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAOSERVPRINC
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtimportacaoservprinc;
        [XmlElement(ElementName = "DTIMPORTACAOSERVPRINC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportacaoservprinc
        {
            get { return  dtimportacaoservprinc; }
            set {  dtimportacaoservprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANC
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtlanc;
        [XmlElement(ElementName = "DTLANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlanc
        {
            get { return  dtlanc; }
            set {  dtlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADOSERVINT
        /// Coment�rio: 
        /// </summary>
        private string exportadoservint;
        [XmlElement(ElementName = "EXPORTADOSERVINT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportadoservint
        {
            get { return  exportadoservint; }
            set {  exportadoservint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Coment�rio: 
        /// </summary>
        private string historico;
        [XmlElement(ElementName = "HISTORICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Historico
        {
            get { return  historico; }
            set {  historico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORALANC
        /// Coment�rio: 
        /// </summary>
        private decimal horalanc;
        [XmlElement(ElementName = "HORALANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horalanc
        {
            get { return  horalanc; }
            set {  horalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADOSERVPRINC
        /// Coment�rio: 
        /// </summary>
        private string importadoservprinc;
        [XmlElement(ElementName = "IMPORTADOSERVPRINC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importadoservprinc
        {
            get { return  importadoservprinc; }
            set {  importadoservprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOLANC
        /// Coment�rio: 
        /// </summary>
        private decimal minutolanc;
        [XmlElement(ElementName = "MINUTOLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutolanc
        {
            get { return  minutolanc; }
            set {  minutolanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCX
        /// Coment�rio: 
        /// </summary>
        private decimal numcx;
        [XmlElement(ElementName = "NUMCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numcx
        {
            get { return  numcx; }
            set {  numcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIEEQUIP
        /// Coment�rio: 
        /// </summary>
        private string numserieequip;
        [XmlElement(ElementName = "NUMSERIEEQUIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numserieequip
        {
            get { return  numserieequip; }
            set {  numserieequip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANS
        /// Coment�rio: N�mero de transa��o.
        /// </summary>
        private decimal numtrans;
        [XmlElement(ElementName = "NUMTRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtrans
        {
            get { return  numtrans; }
            set {  numtrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVALE
        /// Coment�rio: 
        /// </summary>
        private decimal numvale;
        [XmlElement(ElementName = "NUMVALE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numvale
        {
            get { return  numvale; }
            set {  numvale = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVALEECF
        /// Coment�rio: 
        /// </summary>
        private decimal numvaleecf;
        [XmlElement(ElementName = "NUMVALEECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numvaleecf
        {
            get { return  numvaleecf; }
            set {  numvaleecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVALEINTERMEDIARIO
        /// Coment�rio: 
        /// </summary>
        private decimal numvaleintermediario;
        [XmlElement(ElementName = "NUMVALEINTERMEDIARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numvaleintermediario
        {
            get { return  numvaleintermediario; }
            set {  numvaleintermediario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOSANGRIA
        /// Coment�rio: Indica o tipo de sangria efetuada.
        /// </summary>
        private string tiposangria;
        [XmlElement(ElementName = "TIPOSANGRIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiposangria
        {
            get { return  tiposangria; }
            set {  tiposangria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCValecx()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCVALECX";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCValecx> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCValecx>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCValecx> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCValecx>(where);
        }

        #endregion
    }
}
