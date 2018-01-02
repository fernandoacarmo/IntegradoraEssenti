using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.DataHub.EntityJSON;
using Integradora.ECommerce.DataHub.Interfaces;
using Integradora.ECommerce.DataHub.ReturnWebService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub
{
    public class Integracao : Integradora.ECommerce.Lojavirtual
    {
        public override Biblioteca.Dictionaries.Tips.ECommerce ECommerce()
        {
            return Biblioteca.Dictionaries.Tips.ECommerce.DataHub;
        }

        public override void Initialize()
        {
            CriarCreditoParaCliente = false;
        }

        public enum TipoRegistro
        {
            Clientes,
            Produtos,
            Fornecedores,
            NFEntrada,
            NFSaida,
            CancelaNFSaida,
            CancelaNFEntrada,
            CancelaCupom,
            CupomFiscal,
            CupomNaoFiscal,
            TabelaPreco,
            FechamentoCaixa,
            ReducaoZ,
            TituloReceber,
            TituloPagar
        }

        public string Enviar(TipoRegistro tipo, Object registro)
        {

            string resultado = string.Empty;
            switch (tipo)
            {
                case TipoRegistro.Clientes:
                    CadastroCliente Enviarcliente = new CadastroCliente();
                    Enviarcliente.lista.Add((Cliente)registro);
                    Enviarcliente.assinatura = Integradora.Biblioteca.Dictionaries.Settings.DataHub_Alimentos();
                    Enviarcliente.sistema = 4;
                    //Integradora.Biblioteca.Tools.XML.Serialize(Enviarcliente, tipo.ToString());
                    resultado = Enviarcliente.GetRequest(true);         
                    break;
                case TipoRegistro.Produtos:
                    CadastroProduto Enviarproduto = new CadastroProduto();
                    Enviarproduto.lista.Add((Produto)registro);
                    Enviarproduto.assinatura = Integradora.Biblioteca.Dictionaries.Settings.DataHub_Alimentos();
                    Enviarproduto.sistema = 4;
                    resultado = Enviarproduto.GetRequest(true);         
                    break;
                case TipoRegistro.Fornecedores:
                    CadastroFornecedor Enviarfornecedor = new CadastroFornecedor();
                    Enviarfornecedor.lista.Add((Fornecedor)registro);
                    Enviarfornecedor.assinatura = Integradora.Biblioteca.Dictionaries.Settings.DataHub_Alimentos();
                    Enviarfornecedor.sistema = 4;
                    resultado = Enviarfornecedor.GetRequest(true);         
                    break;
                case TipoRegistro.NFEntrada:
                    break;
                case TipoRegistro.NFSaida:
                    break;
                case TipoRegistro.CancelaNFSaida:
                    break;
                case TipoRegistro.CancelaNFEntrada:
                    break;
                case TipoRegistro.CancelaCupom:
                    break;
                case TipoRegistro.CupomFiscal:
                    break;
                case TipoRegistro.CupomNaoFiscal:
                    break;
                case TipoRegistro.TabelaPreco:
                    break;
                case TipoRegistro.FechamentoCaixa:
                    break;
                case TipoRegistro.ReducaoZ:
                    break;
                case TipoRegistro.TituloReceber:
                    break;
                case TipoRegistro.TituloPagar:
                    break;
                default:
                    break;
            }


            if (resultado == "[{\"mensagem\":\"ok\"}]\n")
            {
                return "OK";
            }
            else
            {
                Logs.GerarLog("Integradora.ECommerce.DataHub", "Enviar", resultado.ToString());
                return "Erro";
            }

        }
    }  
}
