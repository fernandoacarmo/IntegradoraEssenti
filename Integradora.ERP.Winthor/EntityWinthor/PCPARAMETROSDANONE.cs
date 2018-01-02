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
    /// Classe referente a tabela PCParametrosdanone
    /// </summary>
    [XmlType("PCPARAMETROSDANONE")]
    public class PCParametrosdanone : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DIASLEITURAGIRO
        /// Comentário: Número dias para desconsiderar os giros zerados.
        /// </summary>
        private decimal diasleituragiro;
        [XmlElement(ElementName = "DIASLEITURAGIRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Diasleituragiro
        {
            get { return  diasleituragiro; }
            set {  diasleituragiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTOQUE_DE_SEGURANCA
        /// Comentário: Estoque de Segurança em %.
        /// </summary>
        private decimal estoque_de_seguranca;
        [XmlElement(ElementName = "ESTOQUE_DE_SEGURANCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Estoque_De_Seguranca
        {
            get { return  estoque_de_seguranca; }
            set {  estoque_de_seguranca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSEGSEMESTOQUE
        /// Comentário: Percentual do estoque de segurança.
        /// </summary>
        private decimal percsegsemestoque;
        [XmlElement(ElementName = "PERCSEGSEMESTOQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percsegsemestoque
        {
            get { return  percsegsemestoque; }
            set {  percsegsemestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDE_COLETAS_REALIZADAS
        /// Comentário: Referência em Qtd. Coletas Realizadas.
        /// </summary>
        private decimal qtde_coletas_realizadas;
        [XmlElement(ElementName = "QTDE_COLETAS_REALIZADAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtde_Coletas_Realizadas
        {
            get { return  qtde_coletas_realizadas; }
            set {  qtde_coletas_realizadas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO_TROCA
        /// Comentário: Tipo de Troca (A,T,N).
        /// </summary>
        private string tipo_troca;
        [XmlElement(ElementName = "TIPO_TROCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipo_Troca
        {
            get { return  tipo_troca; }
            set {  tipo_troca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDA_SEM_COLETA_ESTOQUE
        /// Comentário: Permitir Venda sem Coleta de Estoque (S/N).
        /// </summary>
        private string venda_sem_coleta_estoque;
        [XmlElement(ElementName = "VENDA_SEM_COLETA_ESTOQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Venda_Sem_Coleta_Estoque
        {
            get { return  venda_sem_coleta_estoque; }
            set {  venda_sem_coleta_estoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICAQTCALCULADA
        /// Comentário: A quantidade calculada será sempre assumida na sugestão.
        /// </summary>
        private string verificaqtcalculada;
        [XmlElement(ElementName = "VERIFICAQTCALCULADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verificaqtcalculada
        {
            get { return  verificaqtcalculada; }
            set {  verificaqtcalculada = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCParametrosdanone()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPARAMETROSDANONE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCParametrosdanone> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCParametrosdanone>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCParametrosdanone> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCParametrosdanone>(where);
        }

        #endregion
    }
}
