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
    /// Classe referente a tabela PCFinalizadora
    /// </summary>
    [XmlType("PCFINALIZADORA")]
    public class PCFinalizadora : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AUTORIZALIMITE
        /// Coment�rio: Autorizar Limite.
        /// </summary>
        private string autorizalimite;
        [XmlElement(ElementName = "AUTORIZALIMITE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Autorizalimite
        {
            get { return  autorizalimite; }
            set {  autorizalimite = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Coment�rio: Codigo da Cobran�a.
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da Filial
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFINALIZADORA
        /// Coment�rio: Codigo da Finalizadora.
        /// </summary>
        private decimal codfinalizadora;
        [XmlElement(ElementName = "CODFINALIZADORA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codfinalizadora
        {
            get { return  codfinalizadora; }
            set {  codfinalizadora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCINATIVACAO
        /// Coment�rio: Funcion�rio que inativou cadastro
        /// </summary>
        private decimal codfuncinativacao;
        [XmlElement(ElementName = "CODFUNCINATIVACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codfuncinativacao
        {
            get { return  codfuncinativacao; }
            set {  codfuncinativacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Coment�rio: Codigo do Plano de Pagamento.
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSULTACHEQUESITEF
        /// Coment�rio: Indica��o de uso de consulta de cheque
        /// </summary>
        private string consultachequesitef;
        [XmlElement(ElementName = "CONSULTACHEQUESITEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consultachequesitef
        {
            get { return  consultachequesitef; }
            set {  consultachequesitef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o da Finalizadora.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINATIVACAO
        /// Coment�rio: Data da Inativa��o
        /// </summary>
        private DateTime? dtinativacao;
        [XmlElement(ElementName = "DTINATIVACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinativacao
        {
            get { return  dtinativacao; }
            set {  dtinativacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESPECIE
        /// Coment�rio: Especie .
        /// </summary>
        private string especie;
        [XmlElement(ElementName = "ESPECIE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public string Especie
        {
            get { return  especie; }
            set {  especie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRIMEVINCULADO
        /// Coment�rio: Imprime Vinculado.
        /// </summary>
        private string imprimevinculado;
        [XmlElement(ElementName = "IMPRIMEVINCULADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Imprimevinculado
        {
            get { return  imprimevinculado; }
            set {  imprimevinculado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LERCMC7
        /// Coment�rio: Ler CMC7(Tarja Magnetica do cheque).
        /// </summary>
        private string lercmc7;
        [XmlElement(ElementName = "LERCMC7", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Lercmc7
        {
            get { return  lercmc7; }
            set {  lercmc7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIAS
        /// Coment�rio: Numero de Vias a serem impressas.
        /// </summary>
        private decimal numvias;
        [XmlElement(ElementName = "NUMVIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numvias
        {
            get { return  numvias; }
            set {  numvias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEDESCONTO
        /// Coment�rio: Permite Desconto.
        /// </summary>
        private string permitedesconto;
        [XmlElement(ElementName = "PERMITEDESCONTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitedesconto
        {
            get { return  permitedesconto; }
            set {  permitedesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEPARCELAMENTO
        /// Coment�rio: Permite parcelar pagamento
        /// </summary>
        private string permiteparcelamento;
        [XmlElement(ElementName = "PERMITEPARCELAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permiteparcelamento
        {
            get { return  permiteparcelamento; }
            set {  permiteparcelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITETROCO
        /// Coment�rio: Permitir efetuar troco na venda
        /// </summary>
        private string permitetroco;
        [XmlElement(ElementName = "PERMITETROCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitetroco
        {
            get { return  permitetroco; }
            set {  permitetroco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOLICITACLIENTE
        /// Coment�rio: Cliente deve ser informado na venda
        /// </summary>
        private string solicitacliente;
        [XmlElement(ElementName = "SOLICITACLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Solicitacliente
        {
            get { return  solicitacliente; }
            set {  solicitacliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACOMOENTRADA
        /// Coment�rio: Usa como entrada
        /// </summary>
        private string usacomoentrada;
        [XmlElement(ElementName = "USACOMOENTRADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacomoentrada
        {
            get { return  usacomoentrada; }
            set {  usacomoentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORMINIMOPARCELA
        /// Coment�rio: Valor m�nimo por parcela
        /// </summary>
        private decimal valorminimoparcela;
        [XmlElement(ElementName = "VALORMINIMOPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorminimoparcela
        {
            get { return  valorminimoparcela; }
            set {  valorminimoparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICALIMITE
        /// Coment�rio: Verificar Limite.
        /// </summary>
        private string verificalimite;
        [XmlElement(ElementName = "VERIFICALIMITE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Verificalimite
        {
            get { return  verificalimite; }
            set {  verificalimite = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAXIMO
        /// Coment�rio: Valor Maximo.
        /// </summary>
        private decimal vlmaximo;
        [XmlElement(ElementName = "VLMAXIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Vlmaximo
        {
            get { return  vlmaximo; }
            set {  vlmaximo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINIMO
        /// Coment�rio: Valor Minimo .
        /// </summary>
        private decimal vlminimo;
        [XmlElement(ElementName = "VLMINIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Vlminimo
        {
            get { return  vlminimo; }
            set {  vlminimo = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCFinalizadora()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFINALIZADORA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCFinalizadora> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFinalizadora>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCFinalizadora> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFinalizadora>(where);
        }

        #endregion
    }
}
