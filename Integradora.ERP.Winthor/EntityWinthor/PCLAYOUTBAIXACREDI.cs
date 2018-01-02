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
    /// Classe referente a tabela PCLayoutbaixacredi
    /// </summary>
    [XmlType("PCLAYOUTBAIXACREDI")]
    public class PCLayoutbaixacredi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: Código do item do layout
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLAYOUT
        /// Comentário: Código do layout
        /// </summary>
        private decimal codlayout;
        [XmlElement(ElementName = "CODLAYOUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codlayout
        {
            get { return  codlayout; }
            set {  codlayout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição do item do layout
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: Observação referente ao campo
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAOFINAL
        /// Comentário: Posição final do layout
        /// </summary>
        private decimal posicaofinal;
        [XmlElement(ElementName = "POSICAOFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Posicaofinal
        {
            get { return  posicaofinal; }
            set {  posicaofinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAOFIXA
        /// Comentário: Posição fixa no layout do arquivo
        /// </summary>
        private decimal posicaofixa;
        [XmlElement(ElementName = "POSICAOFIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Posicaofixa
        {
            get { return  posicaofixa; }
            set {  posicaofixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAOINICIAL
        /// Comentário: Posição inicial do layout
        /// </summary>
        private decimal posicaoinicial;
        [XmlElement(ElementName = "POSICAOINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Posicaoinicial
        {
            get { return  posicaoinicial; }
            set {  posicaoinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIGLA
        /// Comentário: Sigla para identificar o layout
        /// </summary>
        private string sigla;
        [XmlElement(ElementName = "SIGLA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Sigla
        {
            get { return  sigla; }
            set {  sigla = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAMANHO
        /// Comentário: Tamanho da posição do layout
        /// </summary>
        private decimal tamanho;
        [XmlElement(ElementName = "TAMANHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Tamanho
        {
            get { return  tamanho; }
            set {  tamanho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: Tipo do layout
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORFIXO
        /// Comentário: Valor fixo no layout do arquivo
        /// </summary>
        private string valorfixo;
        [XmlElement(ElementName = "VALORFIXO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public string Valorfixo
        {
            get { return  valorfixo; }
            set {  valorfixo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLayoutbaixacredi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLAYOUTBAIXACREDI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLayoutbaixacredi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLayoutbaixacredi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLayoutbaixacredi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLayoutbaixacredi>(where);
        }

        #endregion
    }
}
