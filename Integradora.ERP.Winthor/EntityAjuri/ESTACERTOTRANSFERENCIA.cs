using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityAjuri
{
    /// <summary>
    /// Classe referente a tabela ESTAcertotransferencia
    /// </summary>
    [XmlType("ESTACERTOTRANSFERENCIA")]
    public class ESTAcertotransferencia : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 10)]
        public decimal Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOVIMENTO
        /// Comentário: 
        /// </summary>
        private string codmovimento;
        [XmlElement(ElementName = "CODMOVIMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string Codmovimento
        {
            get { return codmovimento; }
            set { codmovimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTODESTINO
        /// Comentário: 
        /// </summary>
        private decimal codprodutodestino;
        [XmlElement(ElementName = "CODPRODUTODESTINO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal Codprodutodestino
        {
            get { return codprodutodestino; }
            set { codprodutodestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTOORIGEM
        /// Comentário: 
        /// </summary>
        private decimal codprodutoorigem;
        [XmlElement(ElementName = "CODPRODUTOORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal Codprodutoorigem
        {
            get { return codprodutoorigem; }
            set { codprodutoorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOCUMENTOCEMA
        /// Comentário: 
        /// </summary>
        private string documentocema;
        [XmlElement(ElementName = "DOCUMENTOCEMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string Documentocema
        {
            get { return documentocema; }
            set { documentocema = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtalteracao
        {
            get { return dtalteracao; }
            set { dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFABRICAODESTINO
        /// Comentário: 
        /// </summary>
        private DateTime? dtfabricaodestino;
        [XmlElement(ElementName = "DTFABRICAODESTINO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtfabricaodestino
        {
            get { return dtfabricaodestino; }
            set { dtfabricaodestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFABRICAOORIGEM
        /// Comentário: 
        /// </summary>
        private DateTime? dtfabricaoorigem;
        [XmlElement(ElementName = "DTFABRICAOORIGEM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtfabricaoorigem
        {
            get { return dtfabricaoorigem; }
            set { dtfabricaoorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtinclusao
        {
            get { return dtinclusao; }
            set { dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCIMENTODESTINO
        /// Comentário: 
        /// </summary>
        private DateTime? dtvencimentodestino;
        [XmlElement(ElementName = "DTVENCIMENTODESTINO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtvencimentodestino
        {
            get { return dtvencimentodestino; }
            set { dtvencimentodestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCIMENTOORIGEM
        /// Comentário: 
        /// </summary>
        private DateTime? dtvencimentoorigem;
        [XmlElement(ElementName = "DTVENCIMENTOORIGEM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtvencimentoorigem
        {
            get { return dtvencimentoorigem; }
            set { dtvencimentoorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELODESTINO
        /// Comentário: 
        /// </summary>
        private string modelodestino;
        [XmlElement(ElementName = "MODELODESTINO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string Modelodestino
        {
            get { return modelodestino; }
            set { modelodestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELOORIGEM
        /// Comentário: 
        /// </summary>
        private string modeloorigem;
        [XmlElement(ElementName = "MODELOORIGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string Modeloorigem
        {
            get { return modeloorigem; }
            set { modeloorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAJURIDESTINO
        /// Comentário: 
        /// </summary>
        private string numajuridestino;
        [XmlElement(ElementName = "NUMAJURIDESTINO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Numajuridestino
        {
            get { return numajuridestino; }
            set { numajuridestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAJURIORIGEM
        /// Comentário: 
        /// </summary>
        private string numajuriorigem;
        [XmlElement(ElementName = "NUMAJURIORIGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Numajuriorigem
        {
            get { return numajuriorigem; }
            set { numajuriorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTEDESTINO
        /// Comentário: 
        /// </summary>
        private string numlotedestino;
        [XmlElement(ElementName = "NUMLOTEDESTINO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 15)]
        public string Numlotedestino
        {
            get { return numlotedestino; }
            set { numlotedestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTEORIGEM
        /// Comentário: 
        /// </summary>
        private string numloteorigem;
        [XmlElement(ElementName = "NUMLOTEORIGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 15)]
        public string Numloteorigem
        {
            get { return numloteorigem; }
            set { numloteorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSINTEGRACAO
        /// Comentário: 
        /// </summary>
        private string obsintegracao;
        [XmlElement(ElementName = "OBSINTEGRACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 4000)]
        public string Obsintegracao
        {
            get { return obsintegracao; }
            set { obsintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTIDADEDESTINO
        /// Comentário: 
        /// </summary>
        private decimal quantidadedestino;
        [XmlElement(ElementName = "QUANTIDADEDESTINO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Quantidadedestino
        {
            get { return quantidadedestino; }
            set { quantidadedestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTIDADEORIGEM
        /// Comentário: 
        /// </summary>
        private decimal quantidadeorigem;
        [XmlElement(ElementName = "QUANTIDADEORIGEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Quantidadeorigem
        {
            get { return quantidadeorigem; }
            set { quantidadeorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEMAFORO
        /// Comentário: 
        /// </summary>
        private decimal semaforo;
        [XmlElement(ElementName = "SEMAFORO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 2)]
        public decimal Semaforo
        {
            get { return semaforo; }
            set { semaforo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIALDESTINO
        /// Comentário: 
        /// </summary>
        private string serialdestino;
        [XmlElement(ElementName = "SERIALDESTINO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Serialdestino
        {
            get { return serialdestino; }
            set { serialdestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIALORIGEM
        /// Comentário: 
        /// </summary>
        private string serialorigem;
        [XmlElement(ElementName = "SERIALORIGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Serialorigem
        {
            get { return serialorigem; }
            set { serialorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 30)]
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTAcertotransferencia()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTACERTOTRANSFERENCIA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTAcertotransferencia> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTAcertotransferencia.GetStringConnection());
            return ba.Listar<ESTAcertotransferencia>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTAcertotransferencia> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTAcertotransferencia.GetStringConnection());
            return ba.Existe<ESTAcertotransferencia>(where);
        }

        #endregion
    }
}
