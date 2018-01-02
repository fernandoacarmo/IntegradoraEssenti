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
    /// Classe referente a tabela PCSituacaocheques
    /// </summary>
    [XmlType("PCSITUACAOCHEQUES")]
    public class PCSituacaocheques : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CHEQUEUTILIZADO
        /// Coment�rio: Cheque utilizado
        /// </summary>
        private string chequeutilizado;
        [XmlElement(ElementName = "CHEQUEUTILIZADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Chequeutilizado
        {
            get { return  chequeutilizado; }
            set {  chequeutilizado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�digo do cliente
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CPFCNPJ
        /// Coment�rio: CPF / CNPJ do cheque
        /// </summary>
        private string cpfcnpj;
        [XmlElement(ElementName = "CPFCNPJ", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,18)]
        public string Cpfcnpj
        {
            get { return  cpfcnpj; }
            set {  cpfcnpj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Coment�rio: Data de vencimento
        /// </summary>
        private DateTime? dtvenc;
        [XmlElement(ElementName = "DTVENC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc
        {
            get { return  dtvenc; }
            set {  dtvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DVCHEQUE
        /// Coment�rio: DV do Cheque
        /// </summary>
        private decimal dvcheque;
        [XmlElement(ElementName = "DVCHEQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Dvcheque
        {
            get { return  dvcheque; }
            set {  dvcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FUNCLIBERACAO
        /// Coment�rio: Funcion�rio que liberou o cheque
        /// </summary>
        private decimal funcliberacao;
        [XmlElement(ElementName = "FUNCLIBERACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Funcliberacao
        {
            get { return  funcliberacao; }
            set {  funcliberacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID_PCSERASA_CONSULTAS
        /// Coment�rio: ID da tabela PCSERASA_CONSULTAS
        /// </summary>
        private decimal id_pcserasa_consultas;
        [XmlElement(ElementName = "ID_PCSERASA_CONSULTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Id_Pcserasa_Consultas
        {
            get { return  id_pcserasa_consultas; }
            set {  id_pcserasa_consultas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAGENCIA
        /// Coment�rio: N�mero da ag�ncia
        /// </summary>
        private decimal numagencia;
        [XmlElement(ElementName = "NUMAGENCIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numagencia
        {
            get { return  numagencia; }
            set {  numagencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBANCO
        /// Coment�rio: N�mero do banco
        /// </summary>
        private decimal numbanco;
        [XmlElement(ElementName = "NUMBANCO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numbanco
        {
            get { return  numbanco; }
            set {  numbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCHEQUE
        /// Coment�rio: N�mero do cheque
        /// </summary>
        private decimal numcheque;
        [XmlElement(ElementName = "NUMCHEQUE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numcheque
        {
            get { return  numcheque; }
            set {  numcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONTA
        /// Coment�rio: N�mero da conta
        /// </summary>
        private decimal numconta;
        [XmlElement(ElementName = "NUMCONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numconta
        {
            get { return  numconta; }
            set {  numconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCA
        /// Coment�rio: N�MERO DO OR�AMENTO
        /// </summary>
        private decimal numorca;
        [XmlElement(ElementName = "NUMORCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numorca
        {
            get { return  numorca; }
            set {  numorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDIDO
        /// Coment�rio: N�mero do pedido
        /// </summary>
        private decimal numpedido;
        [XmlElement(ElementName = "NUMPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedido
        {
            get { return  numpedido; }
            set {  numpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Coment�rio: Observa��o do cheque.
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Coment�rio: Situa��o do cheque
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Coment�rio: UF do cheque
        /// </summary>
        private string uf;
        [XmlElement(ElementName = "UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uf
        {
            get { return  uf; }
            set {  uf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: Valor do cheque
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCSituacaocheques()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSITUACAOCHEQUES";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCSituacaocheques> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSituacaocheques>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCSituacaocheques> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSituacaocheques>(where);
        }

        #endregion
    }
}
