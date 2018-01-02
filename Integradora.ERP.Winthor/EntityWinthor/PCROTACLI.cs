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
    /// Classe referente a tabela PCRotacli
    /// </summary>
    [XmlType("PCROTACLI")]
    public class PCRotacli : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CICLOVISITA
        /// Coment�rio: 
        /// </summary>
        private decimal ciclovisita;
        [XmlElement(ElementName = "CICLOVISITA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Ciclovisita
        {
            get { return  ciclovisita; }
            set {  ciclovisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODUSURORIGEM
        /// Coment�rio: C�digo do RCA possuidor das rotas antes a transfer�ncia
        /// </summary>
        private decimal codusurorigem;
        [XmlElement(ElementName = "CODUSURORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusurorigem
        {
            get { return  codusurorigem; }
            set {  codusurorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAREF
        /// Coment�rio: 
        /// </summary>
        private DateTime? dataref;
        [XmlElement(ElementName = "DATAREF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataref
        {
            get { return  dataref; }
            set {  dataref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEMANA
        /// Coment�rio: 
        /// </summary>
        private string diasemana;
        [XmlElement(ElementName = "DIASEMANA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public string Diasemana
        {
            get { return  diasemana; }
            set {  diasemana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINAL
        /// Coment�rio: Indica a data final da rota de visita.
        /// </summary>
        private DateTime? dtfinal;
        [XmlElement(ElementName = "DTFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinal
        {
            get { return  dtfinal; }
            set {  dtfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Coment�rio: Indica a data de in�cio da rota de visita.
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
        /// Propriedade referente ao campo: DTPROXVISITA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtproxvisita;
        [XmlElement(ElementName = "DTPROXVISITA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtproxvisita
        {
            get { return  dtproxvisita; }
            set {  dtproxvisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTVISITAPREV
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultvisitaprev;
        [XmlElement(ElementName = "DTULTVISITAPREV", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultvisitaprev
        {
            get { return  dtultvisitaprev; }
            set {  dtultvisitaprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAVISITA
        /// Coment�rio: 
        /// </summary>
        private decimal horavisita;
        [XmlElement(ElementName = "HORAVISITA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horavisita
        {
            get { return  horavisita; }
            set {  horavisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOVISITA
        /// Coment�rio: 
        /// </summary>
        private decimal minutovisita;
        [XmlElement(ElementName = "MINUTOVISITA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutovisita
        {
            get { return  minutovisita; }
            set {  minutovisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEMANA
        /// Coment�rio: 
        /// </summary>
        private decimal numsemana;
        [XmlElement(ElementName = "NUMSEMANA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numsemana
        {
            get { return  numsemana; }
            set {  numsemana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMZONA
        /// Coment�rio: Indica o n�mero da zona da rota do cliente.
        /// </summary>
        private decimal numzona;
        [XmlElement(ElementName = "NUMZONA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numzona
        {
            get { return  numzona; }
            set {  numzona = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERIODICIDADE
        /// Coment�rio: 
        /// </summary>
        private decimal periodicidade;
        [XmlElement(ElementName = "PERIODICIDADE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Periodicidade
        {
            get { return  periodicidade; }
            set {  periodicidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQUENCIA
        /// Coment�rio: 
        /// </summary>
        private decimal sequencia;
        [XmlElement(ElementName = "SEQUENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Sequencia
        {
            get { return  sequencia; }
            set {  sequencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQ1
        /// Coment�rio: 
        /// </summary>
        private decimal seq1;
        [XmlElement(ElementName = "SEQ1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Seq1
        {
            get { return  seq1; }
            set {  seq1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQ2
        /// Coment�rio: 
        /// </summary>
        private decimal seq2;
        [XmlElement(ElementName = "SEQ2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Seq2
        {
            get { return  seq2; }
            set {  seq2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQ3
        /// Coment�rio: 
        /// </summary>
        private decimal seq3;
        [XmlElement(ElementName = "SEQ3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Seq3
        {
            get { return  seq3; }
            set {  seq3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal vlmetavenda;
        [XmlElement(ElementName = "VLMETAVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetavenda
        {
            get { return  vlmetavenda; }
            set {  vlmetavenda = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRotacli()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCROTACLI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRotacli> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRotacli>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRotacli> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRotacli>(where);
        }

        #endregion
    }
}
