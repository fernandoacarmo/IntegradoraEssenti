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
    /// Classe referente a tabela PCCisparqant
    /// </summary>
    [XmlType("PCCISPARQANT")]
    public class PCCisparqant : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CNPJCISP
        /// Coment�rio: CNPJ ou CPF do cliente cadastrado.
        /// </summary>
        private string cnpjcisp;
        [XmlElement(ElementName = "CNPJCISP", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Cnpjcisp
        {
            get { return  cnpjcisp; }
            set {  cnpjcisp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data que foi gerado o ultimo arquivo
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTMAIORACUMULADO
        /// Coment�rio: Data que o cliente teve maior saldo Devedor
        /// </summary>
        private DateTime? dtmaioracumulado;
        [XmlElement(ElementName = "DTMAIORACUMULADO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtmaioracumulado
        {
            get { return  dtmaioracumulado; }
            set {  dtmaioracumulado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTIMACOMPRA
        /// Coment�rio: Data da Ultima Compra do Cliente
        /// </summary>
        private DateTime? dtultimacompra;
        [XmlElement(ElementName = "DTULTIMACOMPRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultimacompra
        {
            get { return  dtultimacompra; }
            set {  dtultimacompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEDIAARITMETPAGO
        /// Coment�rio: M�dia Aritm�tica de Pagamentos
        /// </summary>
        private decimal mediaaritmetpago;
        [XmlElement(ElementName = "MEDIAARITMETPAGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Mediaaritmetpago
        {
            get { return  mediaaritmetpago; }
            set {  mediaaritmetpago = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEDIAPONDERADAATRASOPAGO
        /// Coment�rio: M�dia ponderada de pagamentos atrasados
        /// </summary>
        private decimal mediaponderadaatrasopago;
        [XmlElement(ElementName = "MEDIAPONDERADAATRASOPAGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Mediaponderadaatrasopago
        {
            get { return  mediaponderadaatrasopago; }
            set {  mediaponderadaatrasopago = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEDIAPONDERADAAVENCER
        /// Coment�rio: M�dia Ponderada dos titulos a vencer
        /// </summary>
        private decimal mediaponderadaavencer;
        [XmlElement(ElementName = "MEDIAPONDERADAAVENCER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Mediaponderadaavencer
        {
            get { return  mediaponderadaavencer; }
            set {  mediaponderadaavencer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEDIAPONDERADAVENCMAIS15DIAS
        /// Coment�rio: M�dia Ponderada dos titulos vencidos a + de 15 dias
        /// </summary>
        private decimal mediaponderadavencmais15dias;
        [XmlElement(ElementName = "MEDIAPONDERADAVENCMAIS15DIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Mediaponderadavencmais15dias
        {
            get { return  mediaponderadavencmais15dias; }
            set {  mediaponderadavencmais15dias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEDIAPONDERADAVENCMAIS30DIAS
        /// Coment�rio: M�dia Ponderada dos titulos vencidos a + de 30 dias
        /// </summary>
        private decimal mediaponderadavencmais30dias;
        [XmlElement(ElementName = "MEDIAPONDERADAVENCMAIS30DIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Mediaponderadavencmais30dias
        {
            get { return  mediaponderadavencmais30dias; }
            set {  mediaponderadavencmais30dias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEDIAPONDERADAVENCMAIS5DIAS
        /// Coment�rio: M�dia Ponderada dos titulos vencidos a + de 5 dias
        /// </summary>
        private decimal mediaponderadavencmais5dias;
        [XmlElement(ElementName = "MEDIAPONDERADAVENCMAIS5DIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Mediaponderadavencmais5dias
        {
            get { return  mediaponderadavencmais5dias; }
            set {  mediaponderadavencmais5dias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMEDIOVENDAS
        /// Coment�rio: Prazo m�dio das vendas
        /// </summary>
        private decimal prazomediovendas;
        [XmlElement(ElementName = "PRAZOMEDIOVENDAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Prazomediovendas
        {
            get { return  prazomediovendas; }
            set {  prazomediovendas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDEBITOATUAL
        /// Coment�rio: Valor do D�bito atual do cliente na empresa
        /// </summary>
        private decimal valordebitoatual;
        [XmlElement(ElementName = "VALORDEBITOATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valordebitoatual
        {
            get { return  valordebitoatual; }
            set {  valordebitoatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORMAIORACUMULADO
        /// Coment�rio: Maior Valor que o Cliente teve de saldo Devedor
        /// </summary>
        private decimal valormaioracumulado;
        [XmlElement(ElementName = "VALORMAIORACUMULADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valormaioracumulado
        {
            get { return  valormaioracumulado; }
            set {  valormaioracumulado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORULTIMACOMPRA
        /// Coment�rio: Valor da Ultima Compra
        /// </summary>
        private decimal valorultimacompra;
        [XmlElement(ElementName = "VALORULTIMACOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valorultimacompra
        {
            get { return  valorultimacompra; }
            set {  valorultimacompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEBITOAVENCER
        /// Coment�rio: Valor do D�bito atual de titulos n�o vencidos
        /// </summary>
        private decimal vldebitoavencer;
        [XmlElement(ElementName = "VLDEBITOAVENCER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldebitoavencer
        {
            get { return  vldebitoavencer; }
            set {  vldebitoavencer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEBITOVENCMAIS15DIAS
        /// Coment�rio: Valor dos D�bitos Venc a + de 15 dias
        /// </summary>
        private decimal vldebitovencmais15dias;
        [XmlElement(ElementName = "VLDEBITOVENCMAIS15DIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldebitovencmais15dias
        {
            get { return  vldebitovencmais15dias; }
            set {  vldebitovencmais15dias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEBITOVENCMAIS30DIAS
        /// Coment�rio: Valor dos D�bitos Venc a + de 30 dias
        /// </summary>
        private decimal vldebitovencmais30dias;
        [XmlElement(ElementName = "VLDEBITOVENCMAIS30DIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldebitovencmais30dias
        {
            get { return  vldebitovencmais30dias; }
            set {  vldebitovencmais30dias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEBITOVENCMAIS5DIAS
        /// Coment�rio: Valor dos D�bitos Venc a + de 5 dias
        /// </summary>
        private decimal vldebitovencmais5dias;
        [XmlElement(ElementName = "VLDEBITOVENCMAIS5DIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldebitovencmais5dias
        {
            get { return  vldebitovencmais5dias; }
            set {  vldebitovencmais5dias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAGOMESPASSADO
        /// Coment�rio: Valor Pago pelo cliente no M�s Passado
        /// </summary>
        private decimal vlpagomespassado;
        [XmlElement(ElementName = "VLPAGOMESPASSADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlpagomespassado
        {
            get { return  vlpagomespassado; }
            set {  vlpagomespassado = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCisparqant()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCISPARQANT";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCisparqant> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCisparqant>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCisparqant> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCisparqant>(where);
        }

        #endregion
    }
}
