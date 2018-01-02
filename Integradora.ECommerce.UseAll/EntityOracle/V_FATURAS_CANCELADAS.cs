using Integradora.Database.Oracle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ECommerce.UseAll.EntityOracle
{
    /// <summary>
    /// Classe referente a tabela V_Faturas_Canceladas
    /// </summary>
    [XmlType("V_FATURAS_CANCELADAS")]
    public class V_Faturas_Canceladas : OracleObjeto
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CD_CADASTRO
        /// Comentário: 
        /// </summary>
        private decimal cd_cadastro;
        [XmlElement(ElementName = "CD_CADASTRO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Cd_Cadastro
        {
            get { return  cd_cadastro; }
            set {  cd_cadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CD_PORTADOR
        /// Comentário: 
        /// </summary>
        private decimal cd_portador;
        [XmlElement(ElementName = "CD_PORTADOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Cd_Portador
        {
            get { return  cd_portador; }
            set {  cd_portador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPETENCIA
        /// Comentário: 
        /// </summary>
        private DateTime? competencia;
        [XmlElement(ElementName = "COMPETENCIA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Competencia
        {
            get { return  competencia; }
            set {  competencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPETENCIA_ORIGINAL
        /// Comentário: 
        /// </summary>
        private DateTime? competencia_original;
        [XmlElement(ElementName = "COMPETENCIA_ORIGINAL", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Competencia_Original
        {
            get { return  competencia_original; }
            set {  competencia_original = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA_DEVOLUCAO
        /// Comentário: 
        /// </summary>
        private DateTime? data_devolucao;
        [XmlElement(ElementName = "DATA_DEVOLUCAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data_Devolucao
        {
            get { return  data_devolucao; }
            set {  data_devolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DT_LANCAMENTO
        /// Comentário: 
        /// </summary>
        private DateTime? dt_lancamento;
        [XmlElement(ElementName = "DT_LANCAMENTO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dt_Lancamento
        {
            get { return  dt_lancamento; }
            set {  dt_lancamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DT_VENCIMENTO
        /// Comentário: 
        /// </summary>
        private DateTime? dt_vencimento;
        [XmlElement(ElementName = "DT_VENCIMENTO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dt_Vencimento
        {
            get { return  dt_vencimento; }
            set {  dt_vencimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDUC
        /// Comentário: 
        /// </summary>
        private decimal iduc;
        [XmlElement(ElementName = "IDUC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Iduc
        {
            get { return  iduc; }
            set {  iduc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID_CONTA
        /// Comentário: 
        /// </summary>
        private decimal id_conta;
        [XmlElement(ElementName = "ID_CONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Id_Conta
        {
            get { return  id_conta; }
            set {  id_conta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID_ZONA
        /// Comentário: 
        /// </summary>
        private decimal id_zona;
        [XmlElement(ElementName = "ID_ZONA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Id_Zona
        {
            get { return  id_zona; }
            set {  id_zona = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NR_TITULO
        /// Comentário: 
        /// </summary>
        private decimal nr_titulo;
        [XmlElement(ElementName = "NR_TITULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Nr_Titulo
        {
            get { return  nr_titulo; }
            set {  nr_titulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VL_TITULO
        /// Comentário: 
        /// </summary>
        private decimal vl_titulo;
        [XmlElement(ElementName = "VL_TITULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vl_Titulo
        {
            get { return  vl_titulo; }
            set {  vl_titulo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public V_Faturas_Canceladas()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "V_FATURAS_CANCELADAS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<V_Faturas_Canceladas> Listar(string where)
        {
            Persistencia ba = new Persistencia(V_Faturas_Canceladas.GetStringConnection());
            return ba.Listar<V_Faturas_Canceladas>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<V_Faturas_Canceladas> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(V_Faturas_Canceladas.GetStringConnection());
            return ba.Existe<V_Faturas_Canceladas>(where);
        }

        #endregion
    }
}
