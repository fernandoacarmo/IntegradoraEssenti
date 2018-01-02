using Integradora.ERP.Corpem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace Integradora.WebserviceCorpem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    //[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public interface IServiceTrafego
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // Lista de objetos
        [OperationContract]
        List<ESTCliente> ListCliente(string semaforo);
        [OperationContract]
        List<ESTEmbalagem> ListEmbalagem(string semaforo);
        [OperationContract]
        List<ESTEndereco> ListEndereco(string semaforo);
        [OperationContract]
        List<ESTGerente> ListGerente(string semaforo);
        [OperationContract]
        List<ESTMarca> ListMarca(string semaforo);
        [OperationContract]
        List<ESTNcm> ListNcm(string semaforo);
        [OperationContract]
        List<ESTRamoatividade> ListRamoatividade(string semaforo);
        [OperationContract]
        List<ESTRca> ListRca(string semaforo);
        [OperationContract]
        List<ESTSupervisor> ListSupervisor(string semaforo);
        [OperationContract]
        List<ESTDepartamento> ListDepartamento(string semaforo);
        [OperationContract]
        List<ESTSecao> ListSecao(string semaforo);
        [OperationContract]
        List<ESTFilial> ListFilial(string semaforo);
        [OperationContract]
        List<ESTFornecedor> ListFornecedor(string semaforo);
        [OperationContract]
        List<ESTProduto> ListProduto(string semaforo);
        [OperationContract]
        List<ESTKit> ListKit(string semaforo);
        [OperationContract]
        List<ESTNotaentrada> ListNotaEntrada(string semaforo);
        [OperationContract]
        List<ESTNotaentradaitens> ListNotaEntradaItens(Int64 numTransacao);
        [OperationContract]
        List<ESTNotasaida> ListNotaSaida(string semaforo);
        [OperationContract]
        List<ESTNotasaidaitens> ListNotaSaidaItens(Int64 numTransacao);
        [OperationContract]
        List<ESTPedidosaida> ListPedidoSaida(string semaforo);
        [OperationContract]
        List<ESTPedidosaidaitens> ListPedidoSaidaItens(Int64 numPedido);
        [OperationContract]
        List<ESTPrePedidosaida> ListPrePedidoSaida(string semaforo);
        [OperationContract]
        List<ESTPrePedidosaidaitens> ListPrePedidoSaidaItens(Int64 numPedido);
        [OperationContract]
        List<ESTInventario> ListInventario(string semaforo);

        //Inserindo ou alterado registros
        [OperationContract]
        string InsertUpdateCliente(ESTCliente registro);
        [OperationContract]
        string InsertUpdateDepartamento(ESTDepartamento registro);
        [OperationContract]
        string InsertUpdateEmbalagem(ESTEmbalagem registro);
        [OperationContract]
        string InsertUpdateEndereco(ESTEndereco registro);
        [OperationContract]
        string InsertUpdateGerente(ESTGerente registro);
        [OperationContract]
        string InsertUpdateMarca(ESTMarca registro);
        [OperationContract]
        string InsertUpdateNcm(ESTNcm registro);
        [OperationContract]
        string InsertUpdateRamoatividade(ESTRamoatividade registro);
        [OperationContract]
        string InsertUpdateRca(ESTRca registro);
        [OperationContract]
        string InsertUpdateSupervisor(ESTSupervisor registro);
        [OperationContract]
        string InsertUpdateSecao(ESTSecao registro);
        [OperationContract]
        string InsertUpdateFilial(ESTFilial registro);
        [OperationContract]
        string InsertUpdateFornecedor(ESTFornecedor registro);
        [OperationContract]
        string InsertUpdateProduto(ESTProduto registro);
        [OperationContract]
        string InsertUpdateKit(ESTKit registro);
        [OperationContract]
        string InsertUpdateNotaEntrada(ESTNotaentrada registro);
        [OperationContract]
        string InsertUpdateNotaEntradaItens(ESTNotaentradaitens registro);
        [OperationContract]
        string InsertUpdateNotaSaida(ESTNotasaida registro);
        [OperationContract]
        string InsertUpdateNotaSaidaItens(ESTNotasaidaitens registro);
        [OperationContract]
        string InsertUpdatePedidoSaida(ESTPedidosaida registro);
        [OperationContract]
        string InsertUpdatePedidoSaidaItens(ESTPedidosaidaitens registro);
        [OperationContract]
        string InsertUpdatePrePedidoSaida(ESTPrePedidosaida registro);
        [OperationContract]
        string InsertUpdatePrePedidoSaidaItens(ESTPrePedidosaidaitens registro);
        [OperationContract]
        string InsertUpdateInventario(ESTInventario registro);

        //Deletar registros
        [OperationContract]
        string DeleteCliente(ESTCliente registro);
        [OperationContract]
        string DeleteEmbalagem(ESTEmbalagem registro);
        [OperationContract]
        string DeleteEndereco(ESTEndereco registro);
        [OperationContract]
        string DeleteGerente(ESTGerente registro);
        [OperationContract]
        string DeleteMarca(ESTMarca registro);
        [OperationContract]
        string DeleteNcm(ESTNcm registro);
        [OperationContract]
        string DeleteRamoatividade(ESTRamoatividade registro);
        [OperationContract]
        string DeleteRca(ESTRca registro);
        [OperationContract]
        string DeleteSupervisor(ESTSupervisor registro);
        [OperationContract]
        string DeleteDepartamento(ESTDepartamento registro);
        [OperationContract]
        string DeleteSecao(ESTSecao registro);
        [OperationContract]
        string DeleteFilial(ESTFilial registro);
        [OperationContract]
        string DeleteFornecedor(ESTFornecedor registro);
        [OperationContract]
        string DeleteKit(ESTKit registro);
        [OperationContract]
        string DeleteProduto(ESTProduto registro);
        [OperationContract]
        string DeleteNotaEntrada(ESTNotaentrada registro);
        [OperationContract]
        string DeleteNotaEntradaItens(ESTNotaentradaitens registro);
        [OperationContract]
        string DeleteNotaSaida(ESTNotasaida registro);
        [OperationContract]
        string DeleteNotaSaidaItens(ESTNotasaidaitens registro);
        [OperationContract]
        string DeletePedidoSaida(ESTPedidosaida registro);
        [OperationContract]
        string DeletePedidoSaidaItens(ESTPedidosaidaitens registro);
        [OperationContract]
        string DeletePrePedidoSaida(ESTPrePedidosaida registro);
        [OperationContract]
        string DeletePrePedidoSaidaItens(ESTPrePedidosaidaitens registro);
        [OperationContract]
        string DeleteInventario(ESTInventario registro);

        //Alterar status do registro
        [OperationContract]
        string UpdateStatusCliente(ESTCliente registro, string semaforo);
        [OperationContract]
        string UpdateStatusDepartamento(ESTDepartamento registro, string semaforo);
        [OperationContract]
        string UpdateStatusSecao(ESTSecao registro, string semaforo);
        [OperationContract]
        string UpdateStatusFilial(ESTFilial registro, string semaforo);
        [OperationContract]
        string UpdateStatusFornecedor(ESTFornecedor registro, string semaforo);
        [OperationContract]
        string UpdateStatusProduto(ESTProduto registro, string semaforo);
        [OperationContract]
        string UpdateStatusKit(ESTKit registro, string semaforo);
        [OperationContract]
        string UpdateStatusNotaEntrada(ESTNotaentrada registro, string semaforo);
        [OperationContract]
        string UpdateStatusNotaEntradaItens(ESTNotaentradaitens registro, string semaforo);
        [OperationContract]
        string UpdateStatusNotaSaida(ESTNotasaida registro, string semaforo);
        [OperationContract]
        string UpdateStatusNotaSaidaItens(ESTNotasaidaitens registro, string semaforo);
        [OperationContract]
        string UpdateStatusPedidoSaida(ESTPedidosaida registro, string semaforo);
        [OperationContract]
        string UpdateStatusPrePedidoSaidaItens(ESTPrePedidosaidaitens registro, string semaforo);
        [OperationContract]
        string UpdateStatusPrePedidoSaida(ESTPrePedidosaida registro, string semaforo);
        [OperationContract]
        string UpdateStatusPedidoSaidaItens(ESTPedidosaidaitens registro, string semaforo);
        [OperationContract]
        string UpdateStatusEmbalagem(ESTEmbalagem registro, string semaforo);
        [OperationContract]
        string UpdateStatusEndereco(ESTEndereco registro, string semaforo);
        [OperationContract]
        string UpdateStatusGerente(ESTGerente registro, string semaforo);
        [OperationContract]
        string UpdateStatusMarca(ESTMarca registro, string semaforo);
        [OperationContract]
        string UpdateStatusNcm(ESTNcm registro, string semaforo);
        [OperationContract]
        string UpdateStatusRamoatividade(ESTRamoatividade registro, string semaforo);
        [OperationContract]
        string UpdateStatusRca(ESTRca registro, string semaforo);
        [OperationContract]
        string UpdateStatusSupervisor(ESTSupervisor registro, string semaforo);
        [OperationContract]
        string UpdateStatusInventario(ESTInventario registro, string semaforo);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
