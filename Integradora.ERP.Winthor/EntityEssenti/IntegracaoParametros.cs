using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe de parâmetros da integração
    /// </summary>
    [XmlType("INTEGRACAOPARAMETROS")]
    public class IntegracaoParametros: OracleTable
    {
        #region Atributos
        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Apresenta o código da filial da venda
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 2)]
        public string Codfilial
        {
            get { return codfilial; }
            set { codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALRETIRA
        /// Comentário: Apresenta o código da filial retira
        /// </summary>
        private string codfilialretira;
        [XmlElement(ElementName = "CODFILIALRETIRA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 2)]
        public string Codfilialretira
        {
            get { return codfilialretira; }
            set { codfilialretira = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Comentário: Código do supervisor
        /// </summary>
        private decimal codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 4)]
        public decimal Codsupervisor
        {
            get { return codsupervisor; }
            set { codsupervisor = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: Código do RCA padrão 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 4)]
        public decimal Codusur
        {
            get { return codusur; }
            set { codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACA
        /// Comentário: Código da praça
        /// </summary>
        private decimal codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public decimal Codpraca
        {
            get { return codpraca; }
            set { codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Comentário: Número de região
        /// </summary>
        private decimal numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 4)]
        public decimal Numregiao
        {
            get { return numregiao; }
            set { numregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODATIV
        /// Comentário: Código atividade.
        /// </summary>
        private decimal codativ;
        [XmlElement(ElementName = "CODATIV", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 6)]
        public decimal Codativ
        {
            get { return codativ; }
            set { codativ = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Comentário: Código de cobrança
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Comentário: Plano de pagamento
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: MATRICULA
        /// Comentário: código do usuário do sistema
        /// </summary>
        private decimal matricula;
        [XmlElement(ElementName = "MATRICULA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 8)]
        public decimal Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: CODCONTABIL
        /// Comentário: código do usuário do sistema
        /// </summary>
        private string contacontabilcliente;
        [XmlElement(ElementName = "CODCONTABIL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 20)]
        public string ContaContabilCliente
        {
            get { return contacontabilcliente; }
            set { contacontabilcliente = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public IntegracaoParametros()
        {
            Codfilial =  Integradora.Biblioteca.Dictionaries.Settings.CodFilialVenda();
            Codfilialretira = Integradora.Biblioteca.Dictionaries.Settings.CodFilialRetira();
            Codcob =  Integradora.Biblioteca.Dictionaries.Settings.CodCobranca();
            Codplpag =  Integradora.Biblioteca.Dictionaries.Settings.CodPlanoPagamento();
            Codusur =  Integradora.Biblioteca.Dictionaries.Settings.CodRCA();
            Codsupervisor =  Integradora.Biblioteca.Dictionaries.Settings.CodSupervisor();
            Codativ =  Integradora.Biblioteca.Dictionaries.Settings.CodRamoAtividade();
            Matricula = Integradora.Biblioteca.Dictionaries.Settings.Matricula();
            ContaContabilCliente = Integradora.Biblioteca.Dictionaries.Settings.ContaContabilCliente();

            try
            {
                PCConsum pcconsum = PCConsum.Listar("1=1").Single();
                Numregiao = pcconsum.Numregiaopadrao;
            }
            catch
            { 

            }

            if (Codusur > 0)
            {
                PCUsuari pcusuari = null;
                try
                {
                    pcusuari = PCUsuari.Listar("CODUSUR = " + Codusur.ToString()).Single();
                    codpraca = pcusuari.Codpracaprincipal;
                }
                catch
                {
                    pcusuari = null;
                }
            }
            if (codpraca == 0)
            {
                Codpraca = Integradora.Biblioteca.Dictionaries.Settings.CodPraca();
            }
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "INTEGRACAOPARAMETROS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<IntegracaoParametros> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<IntegracaoParametros>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<IntegracaoParametros> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<IntegracaoParametros>(where);
        }

        #endregion
    }
}
