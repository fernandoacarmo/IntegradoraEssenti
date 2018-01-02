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
        /// Coment�rio: Ambienta da Carta de Corre��o
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
        /// Coment�rio: Chave da Carta de Corre��o
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
        /// Coment�rio: Codigo do usuario que alterou a carta de corre��o
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
        /// Coment�rio: Codigo do usuario que fez a carta de corre��o
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
        /// Coment�rio: Data da Carta de Corre��o
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
        /// Coment�rio: Enviado email Cce
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
        /// Coment�rio: Esp�ci da Carta de Corre��o
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
        /// Coment�rio: Movimento da Nota Sa�da ou Entrada
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
        /// Coment�rio: N�mero Sequencial Identificador da Carta de Corre��o
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
        /// Coment�rio: N�mero de sequ�ncia de envio para sefaz
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
        /// Coment�rio: N�mero da Transa��o da Nota Fiscal
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
        /// Coment�rio: Protocolo da Carta de Corre��o
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
        /// Coment�rio: Situa��o da Carta de Corre��o
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
        /// Coment�rio: Tipo documento NFE=0 e CTE=1
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

        #region M�todos
        /// <summary>
        /// M�todo create
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
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCartacorrecaoc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCartacorrecaoc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
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
