using Integradora.Biblioteca.Tools;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.FBits
{
    class PedidoViaEmail
    {
        public List<Cabecalho>  pedidos;
        public PedidoViaEmail()
        {
        }
        public List<Cabecalho> Pedidos
        {
            get
            {
                if (pedidos == null)
                { pedidos = new List<Cabecalho>(); }
                return pedidos;
            }
            set
            {
                pedidos = value;
            }
        }

        public void EnviarEmail(decimal numPedido)
        {
            try
            {
                if ((Pedidos != null) && (Pedidos.Count > 0))
                {
                    Biblioteca.Tools.XML.Export(pedidos, "hortifruti_" + numPedido.ToString());

                    foreach (var cabecalho in Pedidos)
                    {

                        string corpoMensagem = "";
                        corpoMensagem = corpoMensagem + "Pedido.........: " + cabecalho.pedidoWeb + Environment.NewLine;
                        corpoMensagem = corpoMensagem + "Cliente........: " + cabecalho.codCliente.ToString() + " - " + cabecalho.cliente + Environment.NewLine;
                        corpoMensagem = corpoMensagem + "Data do pedido.: " + cabecalho.dataRecebimento.Date.ToString("dd/MM/yyyy") + Environment.NewLine;
                        corpoMensagem = corpoMensagem + "Data de entrega no Decisão: " + cabecalho.dataRecebimento.AddDays(1).Date.ToString("dd/MM/yyyy") + " até 12:00h" + Environment.NewLine;
                        corpoMensagem = corpoMensagem + Environment.NewLine;
                        corpoMensagem = corpoMensagem + "Quantidade   Produto " + Environment.NewLine;
                        corpoMensagem = corpoMensagem + "==========================================================================" + Environment.NewLine;
                        foreach (var itemproduto in cabecalho.ListaItens)
                        {
                            corpoMensagem = corpoMensagem + itemproduto.quantidade.ToString(",0.00").PadLeft(10, ' ')
                                                          + " - " + itemproduto.descricao + Environment.NewLine;
                        }

                        //Gerando registro no e-mail para ser enviado
                        Correspondencias entregador = new Correspondencias();
                        entregador.Correspondencia_Id = entregador.Proximo("SEQ_CORRESPONDENCIAS");
                        entregador.Destinatario = cabecalho.emailComercial + "," +
                                                        cabecalho.emailSupervisor + "," +
                                                        Biblioteca.Dictionaries.Settings.EmailErroFinanceiro();
                        entregador.Email = entregador.Destinatario;
                        entregador.Titulo = "PEDIDO DECISÃO DELIVERY - " + cabecalho.cliente;
                        entregador.Mensagem = corpoMensagem;
                        entregador.Dtinclusao = DateTime.Now;
                        entregador.Gravar();
                    }
                }
            }

            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.FBtis", "EnviarEmail", "Erro ao enviar email: " + ex.ToString());
            }
        }
    }

    public class Cabecalho
    {
        private List<Itens> itens;
        public Cabecalho()
        {
        }
        public DateTime dataRecebimento { get; set; }
        public DateTime dataEntrega { get; set; }
        public string pedidoWeb { get; set; }
        public Decimal codFornecedor { get; set; }
        public string fornecedor { get; set; }
        public Decimal codCliente { get; set; }
        public string cliente { get; set; }
        public string emailComercial { get; set; }
        public string emailSupervisor { get; set; }
        public List<Itens> ListaItens
        {
            get
            {
                if (itens == null)
                { itens = new List<Itens>(); }
                return itens;
            }
            set
            {
                itens = value;
            }
        }
        public void DadosFornecedor()
        {
            try
            {
                //Buscando os dados do fornecedor
                PCFornec registro = PCFornec.Listar("CODFORNEC = " + codFornecedor.ToString()).FirstOrDefault();
                //Nome do fornecedor
                fornecedor = registro.Fornecedor;
                //Obtendo o e-mail
                emailComercial = registro.Com_Email;
                if (!string.IsNullOrEmpty(emailComercial))
                {//Ajustando o e-mail
                    emailComercial = emailComercial.ToLower();
                }
                emailSupervisor = registro.Sup_Email;
                if (!string.IsNullOrEmpty(emailSupervisor))
                {//Ajustando o e-mail
                    emailSupervisor = emailSupervisor.ToLower();
                }
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.FBtis", "DadosFornecedor", "Erro ao carregar o fornecedor: " + ex.ToString());
            }
        }
    }

    public class Itens
    { 
        public Decimal codProduto { get; set; }
        public string descricao { get; set;  }
        public Decimal quantidade { get; set; }

    }
}
