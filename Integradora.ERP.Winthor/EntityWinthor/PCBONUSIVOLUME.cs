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
    /// Classe referente a tabela PCBonusivolume
    /// </summary>
    [XmlType("PCBONUSIVOLUME")]
    public class PCBonusivolume : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALESTOQUE
        /// Coment�rio: C�digo Filial Estoque
        /// </summary>
        private string codfilialestoque;
        [XmlElement(ElementName = "CODFILIALESTOQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Codfilialestoque
        {
            get { return  codfilialestoque; }
            set {  codfilialestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALGESTAO
        /// Coment�rio: C�digo Filial Gest�o
        /// </summary>
        private string codfilialgestao;
        [XmlElement(ElementName = "CODFILIALGESTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Codfilialgestao
        {
            get { return  codfilialgestao; }
            set {  codfilialgestao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOUMA
        /// Coment�rio: Informa a UMA que pertence o volume.
        /// </summary>
        private decimal codigouma;
        [XmlElement(ElementName = "CODIGOUMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Codigouma
        {
            get { return  codigouma; }
            set {  codigouma = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVO
        /// Coment�rio: O codigo do motivo da avaria referente a tabela PCTABDEV.CODDEVOL
        /// </summary>
        private decimal codmotivo;
        [XmlElement(ElementName = "CODMOTIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmotivo
        {
            get { return  codmotivo; }
            set {  codmotivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do produto ref a PCPRODUT.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHAMENTO
        /// Coment�rio: Data do Fechamento
        /// </summary>
        private DateTime? dtfechamento;
        [XmlElement(ElementName = "DTFECHAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfechamento
        {
            get { return  dtfechamento; }
            set {  dtfechamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANCAMENTO
        /// Coment�rio: Data do Lancamento do B�nus
        /// </summary>
        private DateTime? dtlancamento;
        [XmlElement(ElementName = "DTLANCAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlancamento
        {
            get { return  dtlancamento; }
            set {  dtlancamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Coment�rio: Informe a data de vencimento do produto.
        /// </summary>
        private DateTime? dtvalidade;
        [XmlElement(ElementName = "DTVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidade
        {
            get { return  dtvalidade; }
            set {  dtvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECADO
        /// Coment�rio: Quando S informa que o volume foi endere�ado, N informa que endere�amento esta pendente.
        /// </summary>
        private string enderecado;
        [XmlElement(ElementName = "ENDERECADO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enderecado
        {
            get { return  enderecado; }
            set {  enderecado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONUS
        /// Coment�rio: Informa o numero da confer�ncia de entrada.
        /// </summary>
        private decimal numbonus;
        [XmlElement(ElementName = "NUMBONUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numbonus
        {
            get { return  numbonus; }
            set {  numbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: Numero de lote informado pelo conferente.
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIAS
        /// Coment�rio: N�mero da Vias do B�nus
        /// </summary>
        private decimal numvias;
        [XmlElement(ElementName = "NUMVIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numvias
        {
            get { return  numvias; }
            set {  numvias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTRADA
        /// Coment�rio: Informado na confer�ncia, referente ao total do produto presente no volume.
        /// </summary>
        private decimal qtentrada;
        [XmlElement(ElementName = "QTENTRADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtentrada
        {
            get { return  qtentrada; }
            set {  qtentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTNF
        /// Coment�rio: Informa a quantidade do produto referente na nota fiscal de entrada.
        /// </summary>
        private decimal qtnf;
        [XmlElement(ElementName = "QTNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtnf
        {
            get { return  qtnf; }
            set {  qtnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPECAS
        /// Coment�rio: Informa a Quantidade de Pe�as Existentes no Volume
        /// </summary>
        private decimal qtpecas;
        [XmlElement(ElementName = "QTPECAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtpecas
        {
            get { return  qtpecas; }
            set {  qtpecas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: Quando o valor for "N" o produto ser� NORMAL, "A" igual a avaria.
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCBonusivolume()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBONUSIVOLUME";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCBonusivolume> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBonusivolume>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCBonusivolume> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBonusivolume>(where);
        }

        #endregion
    }
}
