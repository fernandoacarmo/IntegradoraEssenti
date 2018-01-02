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
    /// Classe referente a tabela PCComissaomot
    /// </summary>
    [XmlType("PCCOMISSAOMOT")]
    public class PCComissaomot : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFAIXA
        /// Coment�rio: N�mero sequencial gerado automaticamente para identificar unicamente as faixas. |Campo do tipo num�rico, de tamanho 8, sem casas decimais, obrigat�ria.
        /// </summary>
        private decimal codfaixa;
        [XmlElement(ElementName = "CODFAIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfaixa
        {
            get { return  codfaixa; }
            set {  codfaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAFINAL
        /// Coment�rio: Faixa final para indicar qual o percentual ser� usadono c�lculo da comiss�o do motorista, freteiro ou ajudante. |Campo do tipo num�rico, de tamanho 18, com 6 casas decimais.
        /// </summary>
        private decimal faixafinal;
        [XmlElement(ElementName = "FAIXAFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Faixafinal
        {
            get { return  faixafinal; }
            set {  faixafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAINICIAL
        /// Coment�rio: Faixa inicial para indicar qual o percentual ser� usadono c�lculo da comiss�o do motorista, freteiro ou ajudante. |Campo do tipo num�rico, de tamanho 18, com 6 casas decimais.
        /// </summary>
        private decimal faixainicial;
        [XmlElement(ElementName = "FAIXAINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Faixainicial
        {
            get { return  faixainicial; }
            set {  faixainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERAJUDTRANSBORDO
        /// Coment�rio: Indica o percentual comiss�o motorista ajudante.
        /// </summary>
        private decimal perajudtransbordo;
        [XmlElement(ElementName = "PERAJUDTRANSBORDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perajudtransbordo
        {
            get { return  perajudtransbordo; }
            set {  perajudtransbordo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCAJUD
        /// Coment�rio: Percentual de comiss�o, por faixa, a ser aplicado  no c�lculo da comiss�o para o ajudante. |Campo do tipo num�rico, de tamanho 6, com 2 casas decimais.
        /// </summary>
        private decimal percajud;
        [XmlElement(ElementName = "PERCAJUD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percajud
        {
            get { return  percajud; }
            set {  percajud = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMOT
        /// Coment�rio: Percentual de comiss�o, por faixa, a ser aplicado  no c�lculo da comiss�o para o motorista. |Campo do tipo num�rico, de tamanho 6, com 2 casas decimais.
        /// </summary>
        private decimal percmot;
        [XmlElement(ElementName = "PERCMOT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percmot
        {
            get { return  percmot; }
            set {  percmot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCTERC
        /// Coment�rio: Percentual de comiss�o, por faixa, a ser aplicado  no c�lculo da comiss�o para o motorista freteiro. |Campo do tipo num�rico, de tamanho 6, com 2 casas decimais.
        /// </summary>
        private decimal percterc;
        [XmlElement(ElementName = "PERCTERC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percterc
        {
            get { return  percterc; }
            set {  percterc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMOTTRANSBORDO
        /// Coment�rio: Indica o percentual comiss�o motorista transbordo.
        /// </summary>
        private decimal permottransbordo;
        [XmlElement(ElementName = "PERMOTTRANSBORDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Permottransbordo
        {
            get { return  permottransbordo; }
            set {  permottransbordo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: Identifica se a faixa ser� por Valor ou Peso do carregamento. |Campo do tipo caracter, de tamanho 2.
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
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
        public PCComissaomot()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOMISSAOMOT";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCComissaomot> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCComissaomot>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCComissaomot> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCComissaomot>(where);
        }

        #endregion
    }
}
