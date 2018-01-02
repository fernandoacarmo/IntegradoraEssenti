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
    /// Classe referente a tabela PCGuiaselo
    /// </summary>
    [XmlType("PCGUIASELO")]
    public class PCGuiaselo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCOR
        /// Comentário: Codigo da cor dos selos da guia
        /// </summary>
        private decimal codcor;
        [XmlElement(ElementName = "CODCOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcor
        {
            get { return  codcor; }
            set {  codcor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPO
        /// Comentário: Código do grupo de produtos, criado para controlar as saídas dos produtos que utilizam selo. Se houver venda do produto que está no grupo, o sistema considera a venda no livro de controle para a guia cadastrada.
        /// </summary>
        private decimal codgrupo;
        [XmlElement(ElementName = "CODGRUPO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codgrupo
        {
            get { return  codgrupo; }
            set {  codgrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGUIA
        /// Comentário: Código interno necessário para determinar qual guia o sistema movimenta primeiro.
        /// </summary>
        private decimal codguia;
        [XmlElement(ElementName = "CODGUIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codguia
        {
            get { return  codguia; }
            set {  codguia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: Usuário que fez a alteração da guia no sistema
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSURCANCEL
        /// Comentário: Código do usuário que cancelou o registro da guia
        /// </summary>
        private decimal codusurcancel;
        [XmlElement(ElementName = "CODUSURCANCEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusurcancel
        {
            get { return  codusurcancel; }
            set {  codusurcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Comentário: Data do cancelamento do registro da guia
        /// </summary>
        private DateTime? dtcancel;
        [XmlElement(ElementName = "DTCANCEL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancel
        {
            get { return  dtcancel; }
            set {  dtcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTGUIA
        /// Comentário: Data de emissão da Guia
        /// </summary>
        private DateTime? dtguia;
        [XmlElement(ElementName = "DTGUIA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtguia
        {
            get { return  dtguia; }
            set {  dtguia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: Data de inclusão da guia no sistema
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPOSELO
        /// Comentário: Grupo ou Subgrupo dos selos da guia, se houver.
        /// </summary>
        private string gruposelo;
        [XmlElement(ElementName = "GRUPOSELO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Gruposelo
        {
            get { return  gruposelo; }
            set {  gruposelo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMGUIA
        /// Comentário: Número da Guia
        /// </summary>
        private string numguia;
        [XmlElement(ElementName = "NUMGUIA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,14)]
        public string Numguia
        {
            get { return  numguia; }
            set {  numguia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSELOFINAL
        /// Comentário: Número do selo final da guia
        /// </summary>
        private string numselofinal;
        [XmlElement(ElementName = "NUMSELOFINAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public string Numselofinal
        {
            get { return  numselofinal; }
            set {  numselofinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSELOINICIAL
        /// Comentário: Número do selo inicial da guia
        /// </summary>
        private string numseloinicial;
        [XmlElement(ElementName = "NUMSELOINICIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public string Numseloinicial
        {
            get { return  numseloinicial; }
            set {  numseloinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSCANCEL
        /// Comentário: Observação em caso de cancelamento do registro da guia
        /// </summary>
        private string obscancel;
        [XmlElement(ElementName = "OBSCANCEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obscancel
        {
            get { return  obscancel; }
            set {  obscancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSELOSGUIA
        /// Comentário: Quantidade de selos presentes na guia
        /// </summary>
        private decimal qtselosguia;
        [XmlElement(ElementName = "QTSELOSGUIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,14)]
        public decimal Qtselosguia
        {
            get { return  qtselosguia; }
            set {  qtselosguia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIESELO
        /// Comentário: Série dos selos da guia
        /// </summary>
        private string serieselo;
        [XmlElement(ElementName = "SERIESELO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,3)]
        public string Serieselo
        {
            get { return  serieselo; }
            set {  serieselo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCGuiaselo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCGUIASELO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCGuiaselo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCGuiaselo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCGuiaselo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCGuiaselo>(where);
        }

        #endregion
    }
}
