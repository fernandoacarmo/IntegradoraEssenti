using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ECommerce.OnLine.Orders;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Select;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.OnLine
{
    class Enviar : IProcessIntegration
    {
        private string idPedido { get; set; }
        private string idCliente { get; set; }
        public Integradora.ECommerce.OnLine.Integracao LojaECommerce { get; set; }

        public Enviar()
        {
            LojaECommerce = new ECommerce.OnLine.Integracao();
        }

        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            EnviarPedidos();
        }

        private void EnviarPedidos()
        {

            List<PCPedc> ListaPedidos = PCPedc.Listar(VWPedidoInternit.GetFiltro());

            if ((ListaPedidos != null) && (ListaPedidos.Count() > 0))
            {
                foreach (var item in ListaPedidos)
                {
                    idCliente = "";
                    idPedido = "";
                    string retorno = SendPedidoInternit(item, Biblioteca.Dictionaries.Tips.ReplicacaoAcao.Incluir);

                    if (retorno == "OK")
                    {
                        Processo.Notificar("Integradora.Norma.Winthor.OnLine"
                                          , "EnviarPedidos"
                                          , string.Format("Envio do pedido: {0} - Retorno: {1}", item.Numped.ToString(), retorno));

                        using (var transaction = new System.Transactions.CommittableTransaction())
                        {
                            try
                            {
                                Oracle bd = new Oracle(VWPedidoInternit.GetStringConnection());
                                string script = @"UPDATE PCPEDC  
                                                     SET ESC_DTENVIOINTERNIT  = SYSDATE 
                                                       , ESC_MENSAGEMINTERNIT = '{0}'
                                                       , ESC_IDPEDIDO         = '{1}'
                                                   WHERE NUMPED               = {2}";
                                script = string.Format(script
                                                      , retorno
                                                      , idPedido
                                                      , item.Numped.ToString());
                                bd.ExecuteNonQuery(script);

                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                Processo.Notificar("Integradora.Norma.Winthor.OnLine", "EnviarPedidos", ex);
                            }
                        }
                    }
                }
            }
        }
        private string SendPedidoInternit(PCPedc registro, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            Cabecalho cabecalho = new Cabecalho();
            string retorno = "";
            List<VWPedidoInternit> ListaItens = VWPedidoInternit.Listar(string.Format("NUMERO = '{0}'", registro.Numped.ToString()));

            if (ListaItens.Count > 0)
            {                
                cabecalho.numero = ListaItens.First().Numero;
                cabecalho.parcelas = ListaItens.First().Numparcelas.ToString();
                cabecalho.criacao = ListaItens.First().Criacao;
                cabecalho.filial = ListaItens.First().Filial;
                cabecalho.valorFrete = Convert.ToDouble(ListaItens.First().ValorFrete);
                cabecalho.planoPagamento = string.IsNullOrEmpty(ListaItens.First().PlanoPagamento) ? "" : ListaItens.First().PlanoPagamento;
                cabecalho.cobranca = string.IsNullOrEmpty(ListaItens.First().Cobranca) ? "" : ListaItens.First().Cobranca;

                cabecalho.cliente.codigo = string.IsNullOrEmpty(ListaItens.First().Codigo) ? "" : ListaItens.First().Codigo;
                cabecalho.cliente.nome = Formats.RemoveCaracteresEspeciais( string.IsNullOrEmpty(ListaItens.First().Nome) ? "" : ListaItens.First().Nome, true, true);
                cabecalho.cliente.cpfCnpj = string.IsNullOrEmpty(ListaItens.First().CpfCNPJ) ? "" : ListaItens.First().CpfCNPJ;
                cabecalho.cliente.email = string.IsNullOrEmpty(ListaItens.First().Email) ? "" : ListaItens.First().Email;
                cabecalho.cliente.logradouro = Formats.RemoveCaracteresEspeciais(string.IsNullOrEmpty(ListaItens.First().Logradouro) ? "" : ListaItens.First().Logradouro, true, true);
                cabecalho.cliente.numero = string.IsNullOrEmpty(ListaItens.First().NumeroEndereco) ? "" : ListaItens.First().NumeroEndereco;
                cabecalho.cliente.complemento = Formats.RemoveCaracteresEspeciais(string.IsNullOrEmpty(ListaItens.First().Complemento) ? "" : ListaItens.First().Complemento, true, true);
                cabecalho.cliente.bairro = Formats.RemoveCaracteresEspeciais(string.IsNullOrEmpty(ListaItens.First().Bairro) ? "" : ListaItens.First().Bairro, true, true);
                cabecalho.cliente.cidade = Formats.RemoveCaracteresEspeciais(string.IsNullOrEmpty(ListaItens.First().Cidade) ? "" : ListaItens.First().Cidade, true, true);
                cabecalho.cliente.estado = string.IsNullOrEmpty(ListaItens.First().Estado) ? "" : ListaItens.First().Estado;
                cabecalho.cliente.cep = string.IsNullOrEmpty(ListaItens.First().Cep) ? "" : ListaItens.First().Cep;
                cabecalho.cliente.emailRca = string.IsNullOrEmpty(ListaItens.First().emailRca) ? "" : ListaItens.First().emailRca;
                cabecalho.cliente.codigoRca = string.IsNullOrEmpty(ListaItens.First().codigoRca) ? "" : ListaItens.First().codigoRca;
                cabecalho.cliente.nomeRca = Formats.RemoveCaracteresEspeciais(string.IsNullOrEmpty(ListaItens.First().nomeRca) ? "" : ListaItens.First().nomeRca, true, true);

                foreach (var item in ListaItens)
                {
                    Itens produto = new Itens();
                    produto.codigo = item.Codprod.ToString();
                    produto.descricao = Formats.RemoveCaracteresEspeciais(item.Descricao, true, true);
                    produto.qtd = Convert.ToInt32(item.Qt);
                    produto.precoUnitario = Convert.ToDouble(item.Pvenda);
                    cabecalho.itens.Add(produto);
                }

                AtualizarPedido webservice = new AtualizarPedido();
                Biblioteca.Tools.XML.Export(cabecalho, "Pedido" + cabecalho.numero);
                Cabecalho resposta = webservice.Notificar(cabecalho);

                if (resposta != null)
                {
                    idPedido = resposta.id;
                    idCliente = resposta.cliente.id;
                    retorno = "OK";
                }
                else
                {
                    retorno = "Erro";
                }
            }
            return retorno;
        }
    }
}
