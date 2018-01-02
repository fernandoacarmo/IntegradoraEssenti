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
    /// Classe referente a tabela PCConfoperacaowms
    /// </summary>
    [XmlType("PCCONFOPERACAOWMS")]
    public class PCConfoperacaowms : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALTURACUBAGEMDOVOLUMEFLOWRACK
        /// Comentário: Define altura do flow-rack
        /// </summary>
        private decimal alturacubagemdovolumeflowrack;
        [XmlElement(ElementName = "ALTURACUBAGEMDOVOLUMEFLOWRACK", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Alturacubagemdovolumeflowrack
        {
            get { return  alturacubagemdovolumeflowrack; }
            set {  alturacubagemdovolumeflowrack = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTURACUBAGEMDOVOLUMET
        /// Comentário: Define altura para cubagem do E.T.
        /// </summary>
        private decimal alturacubagemdovolumet;
        [XmlElement(ElementName = "ALTURACUBAGEMDOVOLUMET", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Alturacubagemdovolumet
        {
            get { return  alturacubagemdovolumet; }
            set {  alturacubagemdovolumet = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATIVO
        /// Comentário: Define o status do modelo de sepração
        /// </summary>
        private string ativo;
        [XmlElement(ElementName = "ATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ativo
        {
            get { return  ativo; }
            set {  ativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTROLEACESSO
        /// Comentário: Define o código gerado como permissão de acesso
        /// </summary>
        private decimal codcontroleacesso;
        [XmlElement(ElementName = "CODCONTROLEACESSO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codcontroleacesso
        {
            get { return  codcontroleacesso; }
            set {  codcontroleacesso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPERACAO
        /// Comentário: Código da operação
        /// </summary>
        private decimal codoperacao;
        [XmlElement(ElementName = "CODOPERACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codoperacao
        {
            get { return  codoperacao; }
            set {  codoperacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOALT
        /// Comentário: Código do usuário que alterou
        /// </summary>
        private decimal codusuarioalt;
        [XmlElement(ElementName = "CODUSUARIOALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusuarioalt
        {
            get { return  codusuarioalt; }
            set {  codusuarioalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOCAD
        /// Comentário: Código do usuário que cadastrou
        /// </summary>
        private decimal codusuariocad;
        [XmlElement(ElementName = "CODUSUARIOCAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusuariocad
        {
            get { return  codusuariocad; }
            set {  codusuariocad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOEXC
        /// Comentário: Código do usuário que inativou
        /// </summary>
        private decimal codusuarioexc;
        [XmlElement(ElementName = "CODUSUARIOEXC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusuarioexc
        {
            get { return  codusuarioexc; }
            set {  codusuarioexc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPCUBAGEMDOVOLUMEFLOWRACK
        /// Comentário: Define cumprimento do flow-rack
        /// </summary>
        private decimal compcubagemdovolumeflowrack;
        [XmlElement(ElementName = "COMPCUBAGEMDOVOLUMEFLOWRACK", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Compcubagemdovolumeflowrack
        {
            get { return  compcubagemdovolumeflowrack; }
            set {  compcubagemdovolumeflowrack = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPCUBAGEMDOVOLUMET
        /// Comentário: Define cumprimento para cubagem do E.T.
        /// </summary>
        private decimal compcubagemdovolumet;
        [XmlElement(ElementName = "COMPCUBAGEMDOVOLUMET", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Compcubagemdovolumet
        {
            get { return  compcubagemdovolumet; }
            set {  compcubagemdovolumet = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRITERIOQUEBRAPALETE
        /// Comentário: Define o criterio de quebra do palete
        /// </summary>
        private string criterioquebrapalete;
        [XmlElement(ElementName = "CRITERIOQUEBRAPALETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Criterioquebrapalete
        {
            get { return  criterioquebrapalete; }
            set {  criterioquebrapalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUBAGEMDOVOLUMEFLOWRACK
        /// Comentário: Guarda cubagem do flow-rack
        /// </summary>
        private decimal cubagemdovolumeflowrack;
        [XmlElement(ElementName = "CUBAGEMDOVOLUMEFLOWRACK", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Cubagemdovolumeflowrack
        {
            get { return  cubagemdovolumeflowrack; }
            set {  cubagemdovolumeflowrack = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUBAGEMDOVOLUMEQPTRANSITAVEL
        /// Comentário: Guarda cubagem do E.T.
        /// </summary>
        private decimal cubagemdovolumeqptransitavel;
        [XmlElement(ElementName = "CUBAGEMDOVOLUMEQPTRANSITAVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Cubagemdovolumeqptransitavel
        {
            get { return  cubagemdovolumeqptransitavel; }
            set {  cubagemdovolumeqptransitavel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição do modelo de separação
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: Define a data de alteração do registro
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtalteracao
        {
            get { return  dtalteracao; }
            set {  dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: Define a data de cadastro do registro
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Comentário: Define a data de inativação do registro
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EQUIPAMENTOTRANSITAVEL
        /// Comentário: Define quantidade máxima por E.T.
        /// </summary>
        private decimal equipamentotransitavel;
        [XmlElement(ElementName = "EQUIPAMENTOTRANSITAVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Equipamentotransitavel
        {
            get { return  equipamentotransitavel; }
            set {  equipamentotransitavel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARMAPASEPARACAOCAIXAFECHADA
        /// Comentário: Define se gera mapa de separação caixa fechada com o.s.
        /// </summary>
        private string gerarmapaseparacaocaixafechada;
        [XmlElement(ElementName = "GERARMAPASEPARACAOCAIXAFECHADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarmapaseparacaocaixafechada
        {
            get { return  gerarmapaseparacaocaixafechada; }
            set {  gerarmapaseparacaocaixafechada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LARGURACUBAGEMDOVOLUMEFLOWRACK
        /// Comentário: Define largura do flow-rack
        /// </summary>
        private decimal larguracubagemdovolumeflowrack;
        [XmlElement(ElementName = "LARGURACUBAGEMDOVOLUMEFLOWRACK", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Larguracubagemdovolumeflowrack
        {
            get { return  larguracubagemdovolumeflowrack; }
            set {  larguracubagemdovolumeflowrack = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LARGURACUBAGEMDOVOLUMET
        /// Comentário: Define largura para cubagem do E.T.
        /// </summary>
        private decimal larguracubagemdovolumet;
        [XmlElement(ElementName = "LARGURACUBAGEMDOVOLUMET", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Larguracubagemdovolumet
        {
            get { return  larguracubagemdovolumet; }
            set {  larguracubagemdovolumet = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMITEPESOPALETE
        /// Comentário: Define limite de peso do palele
        /// </summary>
        private decimal limitepesopalete;
        [XmlElement(ElementName = "LIMITEPESOPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Limitepesopalete
        {
            get { return  limitepesopalete; }
            set {  limitepesopalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMITEVOLUMEPALETE
        /// Comentário: Define limite de volume do palete
        /// </summary>
        private decimal limitevolumepalete;
        [XmlElement(ElementName = "LIMITEVOLUMEPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Limitevolumepalete
        {
            get { return  limitevolumepalete; }
            set {  limitevolumepalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELOSEPARACAO
        /// Comentário: Define o modelo de separação
        /// </summary>
        private string modeloseparacao;
        [XmlElement(ElementName = "MODELOSEPARACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Modeloseparacao
        {
            get { return  modeloseparacao; }
            set {  modeloseparacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROITEMPOROS
        /// Comentário: Definie número de ítens por o.s.
        /// </summary>
        private decimal numeroitemporos;
        [XmlElement(ElementName = "NUMEROITEMPOROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numeroitemporos
        {
            get { return  numeroitemporos; }
            set {  numeroitemporos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: Observação sobre o modelo de separação
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SELECAODISTRIBUICAO
        /// Comentário: Define o tipo de distribuição
        /// </summary>
        private string selecaodistribuicao;
        [XmlElement(ElementName = "SELECAODISTRIBUICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Selecaodistribuicao
        {
            get { return  selecaodistribuicao; }
            set {  selecaodistribuicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARACAOFRACIONADAPALETIZADO
        /// Comentário: Define forma para separação fracionado paletizado
        /// </summary>
        private string separacaofracionadapaletizado;
        [XmlElement(ElementName = "SEPARACAOFRACIONADAPALETIZADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Separacaofracionadapaletizado
        {
            get { return  separacaofracionadapaletizado; }
            set {  separacaofracionadapaletizado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARAORDEMSERVICOCAIXAFECHADA
        /// Comentário: Define a forma de separar o.s. de caixa fechada
        /// </summary>
        private string separaordemservicocaixafechada;
        [XmlElement(ElementName = "SEPARAORDEMSERVICOCAIXAFECHADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Separaordemservicocaixafechada
        {
            get { return  separaordemservicocaixafechada; }
            set {  separaordemservicocaixafechada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARAPALETEFECHADOPULMAONOBOX
        /// Comentário: Define se separa palete fechado para pulmão box
        /// </summary>
        private string separapaletefechadopulmaonobox;
        [XmlElement(ElementName = "SEPARAPALETEFECHADOPULMAONOBOX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Separapaletefechadopulmaonobox
        {
            get { return  separapaletefechadopulmaonobox; }
            set {  separapaletefechadopulmaonobox = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARAPALETIZADOPORTIPOPRODUTO
        /// Comentário: Define se separa paletizado por tipo de produto
        /// </summary>
        private string separapaletizadoportipoproduto;
        [XmlElement(ElementName = "SEPARAPALETIZADOPORTIPOPRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Separapaletizadoportipoproduto
        {
            get { return  separapaletizadoportipoproduto; }
            set {  separapaletizadoportipoproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARAPEDCARREGEMBALADOFRACION
        /// Comentário: Define se separa por pedido no carregamento para produtos embalado/fracionado
        /// </summary>
        private string separapedcarregembaladofracion;
        [XmlElement(ElementName = "SEPARAPEDCARREGEMBALADOFRACION", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Separapedcarregembaladofracion
        {
            get { return  separapedcarregembaladofracion; }
            set {  separapedcarregembaladofracion = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARAPRODUTOCOMPESOVARIAVEL
        /// Comentário: Define se separa produto com estoque por peso variável
        /// </summary>
        private string separaprodutocompesovariavel;
        [XmlElement(ElementName = "SEPARAPRODUTOCOMPESOVARIAVEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Separaprodutocompesovariavel
        {
            get { return  separaprodutocompesovariavel; }
            set {  separaprodutocompesovariavel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARAPRODUTOESTOQUEPORLOTE
        /// Comentário: Define se separa produto com estoque por lote
        /// </summary>
        private string separaprodutoestoqueporlote;
        [XmlElement(ElementName = "SEPARAPRODUTOESTOQUEPORLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Separaprodutoestoqueporlote
        {
            get { return  separaprodutoestoqueporlote; }
            set {  separaprodutoestoqueporlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARAUTILIZANDOCONTROLEBOX
        /// Comentário: Define se separa utilizando controle de box
        /// </summary>
        private string separautilizandocontrolebox;
        [XmlElement(ElementName = "SEPARAUTILIZANDOCONTROLEBOX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Separautilizandocontrolebox
        {
            get { return  separautilizandocontrolebox; }
            set {  separautilizandocontrolebox = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARAUTILIZANDOENDERECOSTAGE
        /// Comentário: Define se separa utilizando endereço de stage
        /// </summary>
        private string separautilizandoenderecostage;
        [XmlElement(ElementName = "SEPARAUTILIZANDOENDERECOSTAGE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Separautilizandoenderecostage
        {
            get { return  separautilizandoenderecostage; }
            set {  separautilizandoenderecostage = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPERACROSSDOCKINGRESERVAESTOQ
        /// Comentário: 
        /// </summary>
        private string seperacrossdockingreservaestoq;
        [XmlElement(ElementName = "SEPERACROSSDOCKINGRESERVAESTOQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Seperacrossdockingreservaestoq
        {
            get { return  seperacrossdockingreservaestoq; }
            set {  seperacrossdockingreservaestoq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOQUEBRAOSCROSSDOCKINGRES
        /// Comentário: Define tipo de quebra de o.s. cross docking/reserva de estoque
        /// </summary>
        private string tipoquebraoscrossdockingres;
        [XmlElement(ElementName = "TIPOQUEBRAOSCROSSDOCKINGRES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Tipoquebraoscrossdockingres
        {
            get { return  tipoquebraoscrossdockingres; }
            set {  tipoquebraoscrossdockingres = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOQUEBRAOSPALFECHADOPULBOX
        /// Comentário: Define tipo de quebra de o.s. palete fechado para pulmão box
        /// </summary>
        private string tipoquebraospalfechadopulbox;
        [XmlElement(ElementName = "TIPOQUEBRAOSPALFECHADOPULBOX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Tipoquebraospalfechadopulbox
        {
            get { return  tipoquebraospalfechadopulbox; }
            set {  tipoquebraospalfechadopulbox = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDASALDOESTQUENASEPARACAO
        /// Comentário: Define se valida saldo de estoque no mapa de separação
        /// </summary>
        private string validasaldoestquenaseparacao;
        [XmlElement(ElementName = "VALIDASALDOESTQUENASEPARACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validasaldoestquenaseparacao
        {
            get { return  validasaldoestquenaseparacao; }
            set {  validasaldoestquenaseparacao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCConfoperacaowms()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONFOPERACAOWMS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCConfoperacaowms> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConfoperacaowms>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCConfoperacaowms> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConfoperacaowms>(where);
        }

        #endregion
    }
}
