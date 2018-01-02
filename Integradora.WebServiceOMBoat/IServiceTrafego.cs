using Integradora.ECommerce.Ajuri.Metodos;
using Integradora.ECommerce.Ajuri.Retornos;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;

namespace Integradora.WebServiceOMBoat
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "")]

    [XmlSerializerFormat]
    public interface IServiceTrafego
    {
        [OperationContract(Name = "integrarEntidadeMestra")]
        [WebInvoke(Method = "POST")]
        [return: MessageParameter(Name = "ResponseOf")]
        ResponseOf wms_entidade(AlimentaEntidadeMestraXML xml);

        [OperationContract(Name = "integrarProduto")]
        [WebInvoke(Method = "POST")]
        [return: MessageParameter(Name = "ResponseOf")]
        ResponseOf wms_produto(AlimentaProdutoXML xml);

        [OperationContract(Name = "integrarDocumento")]
        [WebInvoke(Method = "POST")]
        [return: MessageParameter(Name = "ResponseOf")]
        ResponseOf wms_inout(AlimentaIOXML xml);

        [OperationContract(Name = "cancelaDocumento")]
        [WebInvoke(Method = "POST")]
        [return: MessageParameter(Name = "ResponseOf")]
        ResponseOf wms_inout_cancela(CancelarIOXML xml);

        [OperationContract(Name = "integrarAtuacao")]
        [WebInvoke(Method = "POST")]
        [return: MessageParameter(Name = "RetornaAtuarEstoque")]
        RetornaAtuarEstoque wms_estoque_atuacao(AlimentaAtuarEstoqueXML xml);

        [OperationContract(Name = "integrarCorrecao")]
        [WebInvoke(Method = "POST")]
        [return: MessageParameter(Name = "RetornaCorrigeEstoque")]
        RetornaCorrigeEstoque wms_estoque_corrige(CorrigeEstoqueXML xml);

        [OperationContract(Name = "integrarInventario")]
        [WebInvoke(Method = "POST")]
        [return: MessageParameter(Name = "ResponseOf")]
        ResponseOf wms_inventario(InventarioXML xml);

        [OperationContract(Name = "integrarInventarioConferido")]
        [WebInvoke(Method = "POST")]
        [return: MessageParameter(Name = "ResponseOf")]
        ResponseOf wms_inventarioConferido(RetornaInventarioXML xml);

        [OperationContract(Name = "statusDocumento")]
        [WebInvoke(Method = "POST")]
        [return: MessageParameter(Name = "ResponseStatusDocumento")]
        ResponseStatusDocumento wms_statusDocumento(string tipoDocumento, string numeroDocumento);

        [OperationContract(Name = "posicaoEstoquePorMotivo")]
        [WebInvoke(Method = "POST")]
        [return: MessageParameter(Name = "ResponsePosicaoEstoquePorMotivo")]
        ResponsePosicaoEstoquePorMotivo wms_posicaoEstoquePorMotivo(string motivo, string partNumber, string lote);
    }
}
