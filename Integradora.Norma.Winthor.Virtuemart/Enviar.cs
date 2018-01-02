using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Virtuemart
{
    class Enviar: IProcessIntegration
    {
        public Integradora.ECommerce.Virtuemart.Integracao LojaECommerce { get; set; }

        public Enviar()
        {
            LojaECommerce = new ECommerce.Virtuemart.Integracao();
        }

        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            var lista = Integradora.ERP.Winthor.Domain.ProcessarFila.LoadECommerce("");
            foreach (var item in lista)
            {
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        //Criando a classe e carregando
                        var integracao = Integradora.ERP.Winthor.Domain.ProcessarFila.CreateClasse(item.Tabela, "rowid = '" + item.Id + "'");
                        //Caso tenha encontrado processa
                        if (integracao != null)
                        {
                            switch (item.Tabela)
                            {
                                case "PCPRODUT":
                                    SendProduto((PCProdut)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCDEPTO":
                                    SendDepartamento((PCDepto)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCSECAO":
                                    SendSecao((PCSecao)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCCLIENT":
                                    SendCliente((PCClient)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCTABPR":
                                    SendTabelaPreco((PCTabpr)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                default:
                                    break;
                            }
                        }

                        Integradora.ERP.Winthor.Domain.ProcessarFila.Remove(item);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Processo.Notificar("Integradora.Norma.Winthor.Virtuemart", "Send", ex.ToString());
                    }
                }
            }
        }

        private void SendTabelaPreco(PCTabpr pCTabpr, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            throw new NotImplementedException();
        }

        private void SendCliente(PCClient pCClient, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            throw new NotImplementedException();
        }

        private void SendSecao(PCSecao pCSecao, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            throw new NotImplementedException();
        }

        private void SendDepartamento(PCDepto pCDepto, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            throw new NotImplementedException();
        }

        private void SendProduto(PCProdut pCProdut, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            throw new NotImplementedException();
        }
    }
}
