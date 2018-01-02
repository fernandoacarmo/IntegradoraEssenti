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
    /// Classe referente a tabela PCAgendareposicao
    /// </summary>
    [XmlType("PCAGENDAREPOSICAO")]
    public class PCAgendareposicao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCD
        /// Coment�rio: Filial de Origem (CD)
        /// </summary>
        private string codcd;
        [XmlElement(ElementName = "CODCD", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codcd
        {
            get { return  codcd; }
            set {  codcd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEVENTO
        /// Coment�rio: C�digo do Evento que depender� o Tipo de Evento selecionado.
        /// </summary>
        private string codevento;
        [XmlElement(ElementName = "CODEVENTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public string Codevento
        {
            get { return  codevento; }
            set {  codevento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLOJA
        /// Coment�rio: Filial de Destino (Loja)
        /// </summary>
        private string codloja;
        [XmlElement(ElementName = "CODLOJA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codloja
        {
            get { return  codloja; }
            set {  codloja = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOMINGO
        /// Coment�rio: Informa se haver� reposicao de produto no domingo. (S)im - (N)ao - Default = N�o
        /// </summary>
        private string domingo;
        [XmlElement(ElementName = "DOMINGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Domingo
        {
            get { return  domingo; }
            set {  domingo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUARTA
        /// Coment�rio: Informa se haver� reposicao de produto na quarta-feira. (S)im - (N)ao - Default = N�o
        /// </summary>
        private string quarta;
        [XmlElement(ElementName = "QUARTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Quarta
        {
            get { return  quarta; }
            set {  quarta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUINTA
        /// Coment�rio: Informa se haver� reposicao de produto na quinta-feira. (S)im - (N)ao - Default = N�o
        /// </summary>
        private string quinta;
        [XmlElement(ElementName = "QUINTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Quinta
        {
            get { return  quinta; }
            set {  quinta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SABADO
        /// Coment�rio: Informa se haver� reposicao de produto no s�bado. (S)im - (N)ao - Default = N�o
        /// </summary>
        private string sabado;
        [XmlElement(ElementName = "SABADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Sabado
        {
            get { return  sabado; }
            set {  sabado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEGUNDA
        /// Coment�rio: Informa se haver� reposicao de produto na segunda-feira. (S)im - (N)ao - Default = N�o
        /// </summary>
        private string segunda;
        [XmlElement(ElementName = "SEGUNDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Segunda
        {
            get { return  segunda; }
            set {  segunda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEXTA
        /// Coment�rio: Informa se haver� reposicao de produto na sexta-feira. (S)im - (N)ao - Default = N�o
        /// </summary>
        private string sexta;
        [XmlElement(ElementName = "SEXTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Sexta
        {
            get { return  sexta; }
            set {  sexta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TERCA
        /// Coment�rio: Informa se haver� reposicao de produto na ter�a-feira. (S)im - (N)ao - Default = N�o
        /// </summary>
        private string terca;
        [XmlElement(ElementName = "TERCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Terca
        {
            get { return  terca; }
            set {  terca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEVENTO
        /// Coment�rio: Tipo de Evento - [1-Sub-Categoria; 2-Categoria; 3-Se��o; 4-Departamento]
        /// </summary>
        private string tipoevento;
        [XmlElement(ElementName = "TIPOEVENTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Tipoevento
        {
            get { return  tipoevento; }
            set {  tipoevento = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCAgendareposicao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAGENDAREPOSICAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAgendareposicao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAgendareposicao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCAgendareposicao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAgendareposicao>(where);
        }

        #endregion
    }
}
