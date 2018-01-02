﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe referente a tabela ESTPcpparametros
    /// </summary>
    [XmlType("ESTPCPPARAMETROS")]
    public class ESTPcpparametros : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOALT
        /// Comentário: 
        /// </summary>
        private decimal codusuarioalt;
        [XmlElement(ElementName = "CODUSUARIOALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal Codusuarioalt
        {
            get { return codusuarioalt; }
            set { codusuarioalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOEXC
        /// Comentário: 
        /// </summary>
        private decimal codusuarioexc;
        [XmlElement(ElementName = "CODUSUARIOEXC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal Codusuarioexc
        {
            get { return codusuarioexc; }
            set { codusuarioexc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOINC
        /// Comentário: 
        /// </summary>
        private decimal codusuarioinc;
        [XmlElement(ElementName = "CODUSUARIOINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal Codusuarioinc
        {
            get { return codusuarioinc; }
            set { codusuarioinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 100)]
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtalteracao
        {
            get { return dtalteracao; }
            set { dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtcadastro
        {
            get { return dtcadastro; }
            set { dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtexclusao
        {
            get { return dtexclusao; }
            set { dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: 
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 500)]
        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: 
        /// </summary>
        private string valor;
        [XmlElement(ElementName = "VALOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTPcpparametros()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTPCPPARAMETROS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTPcpparametros> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTPcpparametros.GetStringConnection());
            return ba.Listar<ESTPcpparametros>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTPcpparametros> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTPcpparametros.GetStringConnection());
            return ba.Existe<ESTPcpparametros>(where);
        }

        #endregion
    }
}
