using Integradora.Biblioteca.Interfaces;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Infracommerce
{
    public class Enviar : IProcessIntegration
    {
        public Integradora.ECommerce.Infracommerce.Integracao LojaECommerce { get; set; }

        public Enviar()
        {
            LojaECommerce = new ECommerce.Infracommerce.Integracao();
        }
        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            var lista = Integradora.ERP.Winthor.Domain.ProcessarFila.LoadECommerce("");
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    using (var transaction = new System.Transactions.CommittableTransaction())
                    {
                        try
                        {
                            //Criando a classe e carregando
                            var integracao = Integradora.ERP.Winthor.Domain.ProcessarFila.CreateClasse(item.Tabela, "rowid = '" + item.Id + "'");
                            //Caso tenha encontrado processa
                            bool PodeApagarRegistro = true;
                            if (integracao != null)
                            {
                                switch (item.Tabela)
                                {
                                    case "ESVINFRAPRODUTOS":
                                        SendEstoquePreco((ESVInfraProdutos)integracao, item.Acao);
                                        break;
                                    case "PCCLIENT":
                                        SendCliente((PCClient)integracao, item.Acao);
                                        break;
                                }
                            }

                            if (PodeApagarRegistro)
                            {
                                Integradora.ERP.Winthor.Domain.ProcessarFila.Remove(item);
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Processo.Notificar("Integradora.Norma.Winthor.Infracommerce", "Process", ex);
                        }
                    }
                }
            }
        }

        private void SendCliente(PCClient registro, decimal acao)
        {
            throw new NotImplementedException();
        }

        private void SendEstoquePreco(ESVInfraProdutos registro, decimal acao)
        {
            //EnviarPreço
            LojaECommerce.Preco(registro.Codauxiliar
                               , registro.Pvenda1
                               , registro.Pvenda2
                               , registro.Pvenda3
                               , registro.Pvenda4
                               , registro.Pvenda5
                               , registro.Pvenda6
                               );

            //Enviar estoque
            SendEstoque (registro.Codfilial
                        , registro.Codauxiliar
                        , registro.Qtdisponivel
                        );
        }

        public void SendEstoque(string Codfilial, decimal Codauxiliar, decimal Qtdisponivel)
        {
            LojaECommerce.Estoque(Codfilial
                                 ,Codauxiliar
                                 ,Qtdisponivel
                                 );
                                
        }
    }
}
