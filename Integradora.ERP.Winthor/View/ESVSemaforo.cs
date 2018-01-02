using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.View
{
    /// <summary>
    /// Classe referente a tabela Esvsemaforo
    /// </summary>
    [XmlType("ESVSEMAFORO")]
    public class Esvsemaforo : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtalteracao
        {
            get { return dtalteracao; }
            set { dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtinclusao
        {
            get { return dtinclusao; }
            set { dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID
        /// Comentário: 
        /// </summary>
        private string id;
        [XmlElement(ElementName = "ID", DataType = "ROWID", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSINTEGRACAO
        /// Comentário: 
        /// </summary>
        private string obsintegracao;
        [XmlElement(ElementName = "OBSINTEGRACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 4000)]
        public string Obsintegracao
        {
            get { return obsintegracao; }
            set { obsintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEMAFORO
        /// Comentário: 
        /// </summary>
        private decimal semaforo;
        [XmlElement(ElementName = "SEMAFORO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public decimal Semaforo
        {
            get { return semaforo; }
            set { semaforo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TABELA
        /// Comentário: 
        /// </summary>
        private string tabela;
        [XmlElement(ElementName = "TABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 19)]
        public string Tabela
        {
            get { return tabela; }
            set { tabela = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Esvsemaforo()
        {
        }

        /// <summary>
        /// Obter nome da view
        /// </summary>
        public override string GetViewName()
        {
            return "ESVSEMAFORO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Esvsemaforo> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvsemaforo.GetStringConnection());
            return ba.Listar<Esvsemaforo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Esvsemaforo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvsemaforo.GetStringConnection());
            return ba.Existe<Esvsemaforo>(where);
        }

        public static IEntity CreateClasse(string name, string where)
        {
            try
            {
                switch (name)
                {//Tabelas
                    case "ESTCLIENTE": return ESTCliente.Listar(where).FirstOrDefault();
                    case "ESTDEPARTAMENTO": return ESTDepartamento.Listar(where).FirstOrDefault();
                    case "ESTFORNECEDOR": return ESTFornecedor.Listar(where).FirstOrDefault();
                    case "ESTNOTAENTRADA": return ESTNotaentrada.Listar(where).FirstOrDefault();
                    case "ESTNOTAENTRADAITENS": return ESTNotaentradaitens.Listar(where).FirstOrDefault();
                    case "ESTOCORRENCIA": return ESTOcorrencia.Listar(where).FirstOrDefault();
                    case "ESTPARAMETRO": return ESTParametro.Listar(where).FirstOrDefault();
                    case "ESTPEDIDOSAIDA": return ESTPedidosaida.Listar(where).FirstOrDefault();
                    case "ESTPEDIDOSAIDAITENS": return ESTPedidosaidaitens.Listar(where).FirstOrDefault();
                    case "ESTPRACA": return ESTPraca.Listar(where).FirstOrDefault();
                    case "ESTPRODUTO": return ESTProduto.Listar(where).FirstOrDefault();
                    case "ESTRAMOATIVIDADE": return ESTRamoatividade.Listar(where).FirstOrDefault();
                    case "ESTROTA": return ESTRota.Listar(where).FirstOrDefault();
                    case "ESTSECAO": return ESTSecao.Listar(where).FirstOrDefault();
                    default: return null;
                }
            }
            catch (Exception ex)
            {
                Logs.GerarLog( "Integradora.ERP.Winthor.View"
                             , "CreateClasse"
                             , string.Format("Erro ao carregar registro, tabela: {0}, Filtro: {1}, Erro: {2}", name, where, ex.ToString()));
                return null;
            }
        }
        #endregion

        public static void Save(Esvsemaforo item, string posicao)
        {
            Oracle bd = new Oracle(Esvsemaforo.GetStringConnection());

            string script = @"UPDATE {0}
                                 SET SEMAFORO = {1}
                               WHERE ROWID = '{2}'";

            script = string.Format( script
                                  , item.Tabela
                                  , posicao
                                  , item.Id
                                  );

            bd.ExecuteNonQuery(script);
        }
    }
}
