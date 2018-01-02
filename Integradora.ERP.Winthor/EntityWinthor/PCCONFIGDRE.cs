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
    /// Classe referente a tabela PCConfigdre
    /// </summary>
    [XmlType("PCCONFIGDRE")]
    public class PCConfigdre : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BASEVERTICAL
        /// Comentário: Indica o grupo para análise vertical.
        /// </summary>
        private string basevertical;
        [XmlElement(ElementName = "BASEVERTICAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Basevertical
        {
            get { return  basevertical; }
            set {  basevertical = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONFIG
        /// Comentário: 
        /// </summary>
        private decimal codconfig;
        [XmlElement(ElementName = "CODCONFIG", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Codconfig
        {
            get { return  codconfig; }
            set {  codconfig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONFIGPAI
        /// Comentário: 
        /// </summary>
        private decimal codconfigpai;
        [XmlElement(ElementName = "CODCONFIGPAI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Codconfigpai
        {
            get { return  codconfigpai; }
            set {  codconfigpai = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAREDUZIDO
        /// Comentário: Código da conta reduzido
        /// </summary>
        private string codcontareduzido;
        [XmlElement(ElementName = "CODCONTAREDUZIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Codcontareduzido
        {
            get { return  codcontareduzido; }
            set {  codcontareduzido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDEMONST
        /// Comentário: . Faz relacionamento com o demonstrativo a qual as regras pertencem. 
        /// </summary>
        private decimal coddemonst;
        [XmlElement(ElementName = "CODDEMONST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Coddemonst
        {
            get { return  coddemonst; }
            set {  coddemonst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLANOCONTA
        /// Comentário: 
        /// </summary>
        private decimal codplanoconta;
        [XmlElement(ElementName = "CODPLANOCONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Codplanoconta
        {
            get { return  codplanoconta; }
            set {  codplanoconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESC_OPERACAO
        /// Comentário: 
        /// </summary>
        private string desc_operacao;
        [XmlElement(ElementName = "DESC_OPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Desc_Operacao
        {
            get { return  desc_operacao; }
            set {  desc_operacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESC_RESULTADO
        /// Comentário: 
        /// </summary>
        private string desc_resultado;
        [XmlElement(ElementName = "DESC_RESULTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Desc_Resultado
        {
            get { return  desc_resultado; }
            set {  desc_resultado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NATUREZALANC
        /// Comentário: Considera ST NF no Custo Contábil.
        /// </summary>
        private string naturezalanc;
        [XmlElement(ElementName = "NATUREZALANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Naturezalanc
        {
            get { return  naturezalanc; }
            set {  naturezalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEM
        /// Comentário: 
        /// </summary>
        private decimal ordem;
        [XmlElement(ElementName = "ORDEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Ordem
        {
            get { return  ordem; }
            set {  ordem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REGRA
        /// Comentário: 
        /// </summary>
        private string regra;
        [XmlElement(ElementName = "REGRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Regra
        {
            get { return  regra; }
            set {  regra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDODFC
        /// Comentário: Considera ST Guia no Custo Contábil.
        /// </summary>
        private decimal saldodfc;
        [XmlElement(ElementName = "SALDODFC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Saldodfc
        {
            get { return  saldodfc; }
            set {  saldodfc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPORESULTADO
        /// Comentário: 
        /// </summary>
        private string tiporesultado;
        [XmlElement(ElementName = "TIPORESULTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiporesultado
        {
            get { return  tiporesultado; }
            set {  tiporesultado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORMANUAL
        /// Comentário: 
        /// </summary>
        private decimal valormanual;
        [XmlElement(ElementName = "VALORMANUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valormanual
        {
            get { return  valormanual; }
            set {  valormanual = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCConfigdre()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONFIGDRE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCConfigdre> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConfigdre>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCConfigdre> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConfigdre>(where);
        }

        #endregion
    }
}
