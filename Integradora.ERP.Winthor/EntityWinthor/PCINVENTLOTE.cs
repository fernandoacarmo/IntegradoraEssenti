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
    /// Classe referente a tabela PCInventlote
    /// </summary>
    [XmlType("PCINVENTLOTE")]
    public class PCInventlote : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLOCAL
        /// Comentário: Código do local do inventário
        /// </summary>
        private string codlocal;
        [XmlElement(ElementName = "CODLOCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codlocal
        {
            get { return  codlocal; }
            set {  codlocal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTO
        /// Comentário: Custo do produto no invetário
        /// </summary>
        private decimal custo;
        [XmlElement(ElementName = "CUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custo
        {
            get { return  custo; }
            set {  custo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
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
        /// Propriedade referente ao campo: DATACONT1
        /// Comentário: 
        /// </summary>
        private DateTime? datacont1;
        [XmlElement(ElementName = "DATACONT1", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacont1
        {
            get { return  datacont1; }
            set {  datacont1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACONT2
        /// Comentário: 
        /// </summary>
        private DateTime? datacont2;
        [XmlElement(ElementName = "DATACONT2", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacont2
        {
            get { return  datacont2; }
            set {  datacont2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACONT3
        /// Comentário: 
        /// </summary>
        private DateTime? datacont3;
        [XmlElement(ElementName = "DATACONT3", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacont3
        {
            get { return  datacont3; }
            set {  datacont3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTATUALIZADO
        /// Comentário: 
        /// </summary>
        private DateTime? dtatualizado;
        [XmlElement(ElementName = "DTATUALIZADO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtatualizado
        {
            get { return  dtatualizado; }
            set {  dtatualizado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Comentário: Campo para data de validade
        /// </summary>
        private DateTime? dtvalidade;
        [XmlElement(ElementName = "DTVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidade
        {
            get { return  dtvalidade; }
            set {  dtvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVAL1
        /// Comentário: Data de Validade 1
        /// </summary>
        private DateTime? dtval1;
        [XmlElement(ElementName = "DTVAL1", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtval1
        {
            get { return  dtval1; }
            set {  dtval1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVAL2
        /// Comentário: Data de Validade 2
        /// </summary>
        private DateTime? dtval2;
        [XmlElement(ElementName = "DTVAL2", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtval2
        {
            get { return  dtval2; }
            set {  dtval2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVAL3
        /// Comentário: Data de Validade 3
        /// </summary>
        private DateTime? dtval3;
        [XmlElement(ElementName = "DTVAL3", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtval3
        {
            get { return  dtval3; }
            set {  dtval3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMINVENT
        /// Comentário: 
        /// </summary>
        private decimal numinvent;
        [XmlElement(ElementName = "NUMINVENT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numinvent
        {
            get { return  numinvent; }
            set {  numinvent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Comentário: 
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTATUALIZADA
        /// Comentário: Indica o estoque que foi atualizado no inventário.
        /// </summary>
        private decimal qtatualizada;
        [XmlElement(ElementName = "QTATUALIZADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtatualizada
        {
            get { return  qtatualizada; }
            set {  qtatualizada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTEST
        /// Comentário: Estoque Contábil do produto
        /// </summary>
        private decimal qtest;
        [XmlElement(ElementName = "QTEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtest
        {
            get { return  qtest; }
            set {  qtest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGER
        /// Comentário: 
        /// </summary>
        private decimal qtestger;
        [XmlElement(ElementName = "QTESTGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtestger
        {
            get { return  qtestger; }
            set {  qtestger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTLOTE
        /// Comentário: 
        /// </summary>
        private decimal qtlote;
        [XmlElement(ElementName = "QTLOTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtlote
        {
            get { return  qtlote; }
            set {  qtlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUTILIZAATUALIZACAO
        /// Comentário: Quantidade utilizada na atualização do estoque.
        /// </summary>
        private decimal qtutilizaatualizacao;
        [XmlElement(ElementName = "QTUTILIZAATUALIZACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtutilizaatualizacao
        {
            get { return  qtutilizaatualizacao; }
            set {  qtutilizaatualizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT1
        /// Comentário: 
        /// </summary>
        private decimal qt1;
        [XmlElement(ElementName = "QT1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt1
        {
            get { return  qt1; }
            set {  qt1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT2
        /// Comentário: 
        /// </summary>
        private decimal qt2;
        [XmlElement(ElementName = "QT2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt2
        {
            get { return  qt2; }
            set {  qt2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT3
        /// Comentário: 
        /// </summary>
        private decimal qt3;
        [XmlElement(ElementName = "QT3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt3
        {
            get { return  qt3; }
            set {  qt3 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCInventlote()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINVENTLOTE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCInventlote> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCInventlote>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCInventlote> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCInventlote>(where);
        }

        #endregion
    }
}
