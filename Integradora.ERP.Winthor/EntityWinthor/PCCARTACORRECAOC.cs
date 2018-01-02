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
    /// Classe referente a tabela PCCartacorrecaoc
    /// </summary>
    [XmlType("PCCARTACORRECAOC")]
    public class PCCartacorrecaoc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AMBIENTECARTACORRECAO
        /// Comentário: Ambienta da Carta de Correção
        /// </summary>
        private string ambientecartacorrecao;
        [XmlElement(ElementName = "AMBIENTECARTACORRECAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ambientecartacorrecao
        {
            get { return  ambientecartacorrecao; }
            set {  ambientecartacorrecao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVECCE
        /// Comentário: Chave da Carta de Correção
        /// </summary>
        private string chavecce;
        [XmlElement(ElementName = "CHAVECCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,65)]
        public string Chavecce
        {
            get { return  chavecce; }
            set {  chavecce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOALTERACAO
        /// Comentário: Codigo do usuario que alterou a carta de correção
        /// </summary>
        private decimal codusuarioalteracao;
        [XmlElement(ElementName = "CODUSUARIOALTERACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusuarioalteracao
        {
            get { return  codusuarioalteracao; }
            set {  codusuarioalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOINCLUSAO
        /// Comentário: Codigo do usuario que fez a carta de correção
        /// </summary>
        private decimal codusuarioinclusao;
        [XmlElement(ElementName = "CODUSUARIOINCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusuarioinclusao
        {
            get { return  codusuarioinclusao; }
            set {  codusuarioinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACARTACORRECAO
        /// Comentário: Data da Carta de Correção
        /// </summary>
        private DateTime? datacartacorrecao;
        [XmlElement(ElementName = "DATACARTACORRECAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Datacartacorrecao
        {
            get { return  datacartacorrecao; }
            set {  datacartacorrecao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIADOEMAIL
        /// Comentário: Enviado email Cce
        /// </summary>
        private string enviadoemail;
        [XmlElement(ElementName = "ENVIADOEMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviadoemail
        {
            get { return  enviadoemail; }
            set {  enviadoemail = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESPECIE
        /// Comentário: Espéci da Carta de Correção
        /// </summary>
        private string especie;
        [XmlElement(ElementName = "ESPECIE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Especie
        {
            get { return  especie; }
            set {  especie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOVIMENTO
        /// Comentário: Movimento da Nota Saída ou Entrada
        /// </summary>
        private string movimento;
        [XmlElement(ElementName = "MOVIMENTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Movimento
        {
            get { return  movimento; }
            set {  movimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARTACORRECAO
        /// Comentário: Número Sequencial Identificador da Carta de Correção
        /// </summary>
        private decimal numcartacorrecao;
        [XmlElement(ElementName = "NUMCARTACORRECAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numcartacorrecao
        {
            get { return  numcartacorrecao; }
            set {  numcartacorrecao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROSEQUENCIA
        /// Comentário: Número de sequência de envio para sefaz
        /// </summary>
        private decimal numerosequencia;
        [XmlElement(ElementName = "NUMEROSEQUENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numerosequencia
        {
            get { return  numerosequencia; }
            set {  numerosequencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Comentário: Número da Transação da Nota Fiscal
        /// </summary>
        private decimal numtransacao;
        [XmlElement(ElementName = "NUMTRANSACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numtransacao
        {
            get { return  numtransacao; }
            set {  numtransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLOCCE
        /// Comentário: Protocolo da Carta de Correção
        /// </summary>
        private string protocolocce;
        [XmlElement(ElementName = "PROTOCOLOCCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Protocolocce
        {
            get { return  protocolocce; }
            set {  protocolocce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAOCCE
        /// Comentário: Situação da Carta de Correção
        /// </summary>
        private decimal situacaocce;
        [XmlElement(ElementName = "SITUACAOCCE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Situacaocce
        {
            get { return  situacaocce; }
            set {  situacaocce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODOC
        /// Comentário: Tipo documento NFE=0 e CTE=1
        /// </summary>
        private decimal tipodoc;
        [XmlElement(ElementName = "TIPODOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Tipodoc
        {
            get { return  tipodoc; }
            set {  tipodoc = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCartacorrecaoc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCARTACORRECAOC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCartacorrecaoc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCartacorrecaoc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCartacorrecaoc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCartacorrecaoc>(where);
        }

        #endregion
    }
}
