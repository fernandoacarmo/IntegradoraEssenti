﻿using Integradora.Database.Oracle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ECommerce.UseAll.EntityOracle
{
    /// <summary>
    /// Classe referente a tabela V_Faturas_Emitidas_Itens
    /// </summary>
    [XmlType("V_FATURAS_EMITIDAS")]
    public class V_Faturas_emitidas : OracleObjeto
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CD_CADASTRO
        /// Comentário: 
        /// </summary>
        private decimal cd_cadastro;
        [XmlElement(ElementName = "CD_CADASTRO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Cd_Cadastro
        {
            get { return  cd_cadastro; }
            set {  cd_cadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DT_LANCAMENTO
        /// Comentário: 
        /// </summary>
        private DateTime? dt_lancamento;
        [XmlElement(ElementName = "DT_LANCAMENTO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dt_lancamento
        {
            get { return dt_lancamento; }
            set { dt_lancamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DT_VENCIMENTO
        /// Comentário: 
        /// </summary>
        private DateTime? dt_vencimento;
        [XmlElement(ElementName = "DT_VENCIMENTO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dt_vencimento
        {
            get { return dt_vencimento; }
            set { dt_vencimento = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: COMPETENCIA
        /// Comentário: 
        /// </summary>
        private DateTime? competencia;
        [XmlElement(ElementName = "COMPETENCIA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Competencia
        {
            get { return competencia; }
            set { competencia = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: IDUC
        /// Comentário: 
        /// </summary>
        private decimal iduc;
        [XmlElement(ElementName = "IDUC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Iduc
        {
            get { return  iduc; }
            set {  iduc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDUNICO
        /// Comentário: 
        /// </summary>
        private decimal idunico;
        [XmlElement(ElementName = "IDUNICO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Idunico
        {
            get { return  idunico; }
            set {  idunico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID_CONTA
        /// Comentário: 
        /// </summary>
        private decimal id_conta;
        [XmlElement(ElementName = "ID_CONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Id_Conta
        {
            get { return  id_conta; }
            set {  id_conta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CD_PORTADOR
        /// Comentário: 
        /// </summary>
        private decimal cd_portador;
                [XmlElement(ElementName = "CD_PORTADOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Cd_portador
        {
            get { return cd_portador; }
            set { cd_portador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID_ZONA
        /// Comentário: 
        /// </summary>
        private decimal id_zona;
        [XmlElement(ElementName = "ID_ZONA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Id_Zona
        {
            get { return  id_zona; }
            set {  id_zona = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NR_TITULO
        /// Comentário: 
        /// </summary>
        private decimal nr_titulo;
        [XmlElement(ElementName = "NR_TITULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Nr_Titulo
        {
            get { return  nr_titulo; }
            set {  nr_titulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VL_TITULO
        /// Comentário: 
        /// </summary>
        private decimal vl_titulo;
        [XmlElement(ElementName = "VL_TITULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,15)]
        public decimal Vl_titulo
        {
            get { return vl_titulo; }
            set { vl_titulo = value; }
        }

        /// Propriedade referente ao campo: OBS
        /// Comentário: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false, false, false, 1)]
        public string Obs
        {
            get { return obs; }
            set { obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BARRA
        /// Comentário: 
        /// </summary>
        private string barra;
        [XmlElement(ElementName = "BARRA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 100)]
        public string Barra
        {
            get { return barra; }
            set { barra = value; }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public V_Faturas_emitidas()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "V_FATURAS_EMITIDAS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<V_Faturas_emitidas> Listar(string where)
        {
            Persistencia ba = new Persistencia(V_Faturas_emitidas.GetStringConnection());
            return ba.Listar<V_Faturas_emitidas>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<V_Faturas_emitidas> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(V_Faturas_emitidas.GetStringConnection());
            return ba.Existe<V_Faturas_emitidas>(where);
        }

        #endregion
    }
}
