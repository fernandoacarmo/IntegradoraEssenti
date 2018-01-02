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
    /// Classe referente a tabela PCVolumeos
    /// </summary>
    [XmlType("PCVOLUMEOS")]
    public class PCVolumeos : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECO
        /// Coment�rio: 
        /// </summary>
        private decimal codendereco;
        [XmlElement(ElementName = "CODENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codendereco
        {
            get { return  codendereco; }
            set {  codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECOESTORNO
        /// Coment�rio: 
        /// </summary>
        private decimal codenderecoestorno;
        [XmlElement(ElementName = "CODENDERECOESTORNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codenderecoestorno
        {
            get { return  codenderecoestorno; }
            set {  codenderecoestorno = value; }
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
        /// Propriedade referente ao campo: CODFUNCAGRUPAMENTO
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncagrupamento;
        [XmlElement(ElementName = "CODFUNCAGRUPAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncagrupamento
        {
            get { return  codfuncagrupamento; }
            set {  codfuncagrupamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCORTE
        /// Coment�rio: 
        /// </summary>
        private decimal codfunccorte;
        [XmlElement(ElementName = "CODFUNCCORTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccorte
        {
            get { return  codfunccorte; }
            set {  codfunccorte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCESTORNO
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncestorno;
        [XmlElement(ElementName = "CODFUNCESTORNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncestorno
        {
            get { return  codfuncestorno; }
            set {  codfuncestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCMONTAPALETE
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncmontapalete;
        [XmlElement(ElementName = "CODFUNCMONTAPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncmontapalete
        {
            get { return  codfuncmontapalete; }
            set {  codfuncmontapalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Coment�rio: 
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINAESTORNO
        /// Coment�rio: 
        /// </summary>
        private string codrotinaestorno;
        [XmlElement(ElementName = "CODROTINAESTORNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codrotinaestorno
        {
            get { return  codrotinaestorno; }
            set {  codrotinaestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAAGRUPAMENTO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dataagrupamento;
        [XmlElement(ElementName = "DATAAGRUPAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataagrupamento
        {
            get { return  dataagrupamento; }
            set {  dataagrupamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAPALETE
        /// Coment�rio: Data do palete no agrupamento
        /// </summary>
        private DateTime? datapalete;
        [XmlElement(ElementName = "DATAPALETE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datapalete
        {
            get { return  datapalete; }
            set {  datapalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAUTILIZACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? datautilizacao;
        [XmlElement(ElementName = "DATAUTILIZACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datautilizacao
        {
            get { return  datautilizacao; }
            set {  datautilizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCORTE
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtcorte;
        [XmlElement(ElementName = "DTCORTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcorte
        {
            get { return  dtcorte; }
            set {  dtcorte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTESTORNO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtestorno;
        [XmlElement(ElementName = "DTESTORNO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtestorno
        {
            get { return  dtestorno; }
            set {  dtestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMBARCADO
        /// Coment�rio: Volume embarcado
        /// </summary>
        private string embarcado;
        [XmlElement(ElementName = "EMBARCADO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Embarcado
        {
            get { return  embarcado; }
            set {  embarcado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LETRA
        /// Coment�rio: 
        /// </summary>
        private string letra;
        [XmlElement(ElementName = "LETRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Letra
        {
            get { return  letra; }
            set {  letra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Coment�rio: 
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPALETE
        /// Coment�rio: 
        /// </summary>
        private decimal numpalete;
        [XmlElement(ElementName = "NUMPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numpalete
        {
            get { return  numpalete; }
            set {  numpalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVOL
        /// Coment�rio: 
        /// </summary>
        private decimal numvol;
        [XmlElement(ElementName = "NUMVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numvol
        {
            get { return  numvol; }
            set {  numvol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUMECORTADO
        /// Coment�rio: 
        /// </summary>
        private string volumecortado;
        [XmlElement(ElementName = "VOLUMECORTADO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Volumecortado
        {
            get { return  volumecortado; }
            set {  volumecortado = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCVolumeos()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCVOLUMEOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCVolumeos> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCVolumeos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCVolumeos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCVolumeos>(where);
        }

        #endregion
    }
}
