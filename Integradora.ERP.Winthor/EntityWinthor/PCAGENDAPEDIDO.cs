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
    /// Classe referente a tabela PCAgendapedido
    /// </summary>
    [XmlType("PCAGENDAPEDIDO")]
    public class PCAgendapedido : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AGENDAMENTO
        /// Comentário: Campo para informar se é um agendamento ou não 
        /// </summary>
        private string agendamento;
        [XmlElement(ElementName = "AGENDAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Agendamento
        {
            get { return  agendamento; }
            set {  agendamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BOX
        /// Comentário: Numero do box onde o caminhão será descarregado. Vai de 0 a 9 
        /// </summary>
        private decimal box;
        [XmlElement(ElementName = "BOX", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Box
        {
            get { return  box; }
            set {  box = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARACTERISTICA
        /// Comentário: Seco, Resfriado, Congelado, Perigoso
        /// </summary>
        private decimal caracteristica;
        [XmlElement(ElementName = "CARACTERISTICA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public decimal Caracteristica
        {
            get { return  caracteristica; }
            set {  caracteristica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAGENDA
        /// Comentário: Data do agendamento 
        /// </summary>
        private DateTime? dtagenda;
        [XmlElement(ElementName = "DTAGENDA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtagenda
        {
            get { return  dtagenda; }
            set {  dtagenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAAGENDA
        /// Comentário: Hora do agendamento 
        /// </summary>
        private string horaagenda;
        [XmlElement(ElementName = "HORAAGENDA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,5)]
        public string Horaagenda
        {
            get { return  horaagenda; }
            set {  horaagenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORACHEGADA
        /// Comentário: Hora que o caminhão chegou
        /// </summary>
        private string horachegada;
        [XmlElement(ElementName = "HORACHEGADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Horachegada
        {
            get { return  horachegada; }
            set {  horachegada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORALIBERACAONF
        /// Comentário: Hora que a nota fiscal caminhoneiro foi liberada pela expedição 
        /// </summary>
        private string horaliberacaonf;
        [XmlElement(ElementName = "HORALIBERACAONF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Horaliberacaonf
        {
            get { return  horaliberacaonf; }
            set {  horaliberacaonf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORASAIDA
        /// Comentário: Hora que o caminhão esta saindo 
        /// </summary>
        private string horasaida;
        [XmlElement(ElementName = "HORASAIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Horasaida
        {
            get { return  horasaida; }
            set {  horasaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: Numero pedido de compra 
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED1
        /// Comentário: Numero pedido de compra isso ocorre porque no caminhão pode vir uma carga com até 5 pedidos diferentes.
        /// </summary>
        private decimal numped1;
        [XmlElement(ElementName = "NUMPED1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped1
        {
            get { return  numped1; }
            set {  numped1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED2
        /// Comentário: Numero pedido de compra isso ocorre porque no caminhão pode vir uma carga com até 5 pedidos diferentes.
        /// </summary>
        private decimal numped2;
        [XmlElement(ElementName = "NUMPED2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped2
        {
            get { return  numped2; }
            set {  numped2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED3
        /// Comentário: Numero pedido de compra isso ocorre porque no caminhão pode vir uma carga com até 5 pedidos diferentes.
        /// </summary>
        private decimal numped3;
        [XmlElement(ElementName = "NUMPED3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped3
        {
            get { return  numped3; }
            set {  numped3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED4
        /// Comentário: Numero pedido de compra isso ocorre porque no caminhão pode vir uma carga com até 5 pedidos diferentes.
        /// </summary>
        private decimal numped4;
        [XmlElement(ElementName = "NUMPED4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped4
        {
            get { return  numped4; }
            set {  numped4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: Campo observação para anotar algum detalhe da carga 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESO
        /// Comentário: Peso da carga de todos os pedidos no caminhão. Igual rotina 209 
        /// </summary>
        private decimal peso;
        [XmlElement(ElementName = "PESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Peso
        {
            get { return  peso; }
            set {  peso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCAIXAS
        /// Comentário: Quantidade de caixas que vieram no caminhão 
        /// </summary>
        private decimal qtcaixas;
        [XmlElement(ElementName = "QTCAIXAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtcaixas
        {
            get { return  qtcaixas; }
            set {  qtcaixas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHA
        /// Comentário: Campo contém a senha informada ao caminhoneiro. Sua geração é automatica 
        /// </summary>
        private string senha;
        [XmlElement(ElementName = "SENHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Senha
        {
            get { return  senha; }
            set {  senha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPODESCARGA
        /// Comentário: Tempo que demorou para descarregar 
        /// </summary>
        private string tempodescarga;
        [XmlElement(ElementName = "TEMPODESCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tempodescarga
        {
            get { return  tempodescarga; }
            set {  tempodescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPODESCARGAPREVISTO
        /// Comentário: Previsão de tempo do descarregamento 
        /// </summary>
        private string tempodescargaprevisto;
        [XmlElement(ElementName = "TEMPODESCARGAPREVISTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tempodescargaprevisto
        {
            get { return  tempodescargaprevisto; }
            set {  tempodescargaprevisto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCARGA
        /// Comentário: Paletizada ou estivada
        /// </summary>
        private decimal tipocarga;
        [XmlElement(ElementName = "TIPOCARGA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public decimal Tipocarga
        {
            get { return  tipocarga; }
            set {  tipocarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFRETE
        /// Comentário: CIF ou FOB 
        /// </summary>
        private string tipofrete;
        [XmlElement(ElementName = "TIPOFRETE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipofrete
        {
            get { return  tipofrete; }
            set {  tipofrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUME
        /// Comentário: Volume da carga de todos os pedidos no caminhão. Igual rotina 209 
        /// </summary>
        private decimal volume;
        [XmlElement(ElementName = "VOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Volume
        {
            get { return  volume; }
            set {  volume = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCAgendapedido()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAGENDAPEDIDO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAgendapedido> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAgendapedido>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCAgendapedido> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAgendapedido>(where);
        }

        #endregion
    }
}
