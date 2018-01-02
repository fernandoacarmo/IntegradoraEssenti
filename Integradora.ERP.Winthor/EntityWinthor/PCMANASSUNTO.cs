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
    /// Classe referente a tabela PCManassunto
    /// </summary>
    [XmlType("PCMANASSUNTO")]
    public class PCManassunto : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ASSUNTO
        /// Comentário: 
        /// </summary>
        private string assunto;
        [XmlElement(ElementName = "ASSUNTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Assunto
        {
            get { return  assunto; }
            set {  assunto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATIVO
        /// Comentário: Indica se o registro esta ativo/inativo.
        /// </summary>
        private string ativo;
        [XmlElement(ElementName = "ATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ativo
        {
            get { return  ativo; }
            set {  ativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODASSUNTO
        /// Comentário: 
        /// </summary>
        private decimal codassunto;
        [XmlElement(ElementName = "CODASSUNTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codassunto
        {
            get { return  codassunto; }
            set {  codassunto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC1
        /// Comentário: 
        /// </summary>
        private decimal codfunc1;
        [XmlElement(ElementName = "CODFUNC1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc1
        {
            get { return  codfunc1; }
            set {  codfunc1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC2
        /// Comentário: 
        /// </summary>
        private decimal codfunc2;
        [XmlElement(ElementName = "CODFUNC2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc2
        {
            get { return  codfunc2; }
            set {  codfunc2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC3
        /// Comentário: 
        /// </summary>
        private decimal codfunc3;
        [XmlElement(ElementName = "CODFUNC3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc3
        {
            get { return  codfunc3; }
            set {  codfunc3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC4
        /// Comentário: 
        /// </summary>
        private decimal codfunc4;
        [XmlElement(ElementName = "CODFUNC4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc4
        {
            get { return  codfunc4; }
            set {  codfunc4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPERCOMUNICACAO
        /// Comentário: Indica o operador comunicação. 
        /// </summary>
        private decimal codopercomunicacao;
        [XmlElement(ElementName = "CODOPERCOMUNICACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codopercomunicacao
        {
            get { return  codopercomunicacao; }
            set {  codopercomunicacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETOR
        /// Comentário: 
        /// </summary>
        private decimal codsetor;
        [XmlElement(ElementName = "CODSETOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsetor
        {
            get { return  codsetor; }
            set {  codsetor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COPIA
        /// Comentário: 
        /// </summary>
        private string copia;
        [XmlElement(ElementName = "COPIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Copia
        {
            get { return  copia; }
            set {  copia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAAGENDA
        /// Comentário: Gera Agenda automaticamente ao gerar uma manifestação.
        /// </summary>
        private string geraagenda;
        [XmlElement(ElementName = "GERAAGENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geraagenda
        {
            get { return  geraagenda; }
            set {  geraagenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INTERNO
        /// Comentário: Manifestação Interna.
        /// </summary>
        private string interno;
        [XmlElement(ElementName = "INTERNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Interno
        {
            get { return  interno; }
            set {  interno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBRIGAQTDE
        /// Comentário: Obriga Quantidade
        /// </summary>
        private string obrigaqtde;
        [XmlElement(ElementName = "OBRIGAQTDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Obrigaqtde
        {
            get { return  obrigaqtde; }
            set {  obrigaqtde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOSETOR
        /// Comentário: 
        /// </summary>
        private decimal prazosetor;
        [XmlElement(ElementName = "PRAZOSETOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Prazosetor
        {
            get { return  prazosetor; }
            set {  prazosetor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO1
        /// Comentário: 
        /// </summary>
        private decimal prazo1;
        [XmlElement(ElementName = "PRAZO1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Prazo1
        {
            get { return  prazo1; }
            set {  prazo1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO2
        /// Comentário: 
        /// </summary>
        private decimal prazo2;
        [XmlElement(ElementName = "PRAZO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Prazo2
        {
            get { return  prazo2; }
            set {  prazo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO3
        /// Comentário: 
        /// </summary>
        private decimal prazo3;
        [XmlElement(ElementName = "PRAZO3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Prazo3
        {
            get { return  prazo3; }
            set {  prazo3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO4
        /// Comentário: 
        /// </summary>
        private decimal prazo4;
        [XmlElement(ElementName = "PRAZO4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Prazo4
        {
            get { return  prazo4; }
            set {  prazo4 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCManassunto()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMANASSUNTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCManassunto> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCManassunto>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCManassunto> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCManassunto>(where);
        }

        #endregion
    }
}
