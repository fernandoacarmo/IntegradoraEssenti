using Integradora.Biblioteca.Tools;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.Norma.Winthor.VTex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManutencaoVTEX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<PCPedctemp> ListaPedidos = PCPedctemp.Listar(@"NUMPED > 0 
                                                       AND NOT EXISTS (SELECT 1 
                                                                         FROM PCPRESTTEMP
                                                                        WHERE PCPRESTTEMP.NUMPEDWEB = PCPEDCTEMP.NUMPEDWEB
                                                                         -- AND NUMPEDCLI  like  '%-%'  --Teste no meu banco 
                                                                       )");
            if (ListaPedidos.Count() > 0)
            {
                //Passando pedido a pedido
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 0;
                progressBar1.Step = 1;
                progressBar1.Maximum = ListaPedidos.Count();
                foreach (var pedido in ListaPedidos)
                {
                    labelPedido.Text = pedido.Numpedrca.ToString() + " - " + pedido.Numpedcli;
                    Application.DoEvents();
                    //Criando a conexão com a VText
                    Integradora.ECommerce.VTex.Orders.Pedido VTexPedidoConsulta = new Integradora.ECommerce.VTex.Orders.Pedido();
                    //Obter o pedido do e-commerce
                    Integradora.ECommerce.VTex.Orders.RootPedido VTexPedido = VTexPedidoConsulta.Consultar(pedido.Numpedcli);
                    //Caso tenha carregado continua o processo
                    if (VTexPedido != null)
                    {
                        //Montando a lista de parcelas que receberá as parcelas
                        List<PCPresttemp> ListaParcelas = new List<PCPresttemp>();
                        //Carregando o marketplace, caso exista
                        ESTMarketplace marketplace = ESTMarketplace.Listar(string.Format("UPPER(MARKETPLACE_ID) = '{0}'", VTexPedido.affiliateId.ToUpper())).FirstOrDefault();
                        if (marketplace != null)
                        {
                            pedido.Codclirecebedor = marketplace.Codcli;
                        }
                        //Criando o objeto de obter as informações das parcelas
                        Receber Processador = new Receber();
                        //Obtendo as parcelas 
                        try
                        {
                            Processador.ImportarFinanceiro(pedido
                                                          , ListaParcelas
                                                          , VTexPedidoConsulta
                                                          , VTexPedido
                                                          , marketplace
                                                          );
                        }
                        catch
                        {
                            ListaParcelas = null;
                        }
                        //Verificando se preencheu o objeto das parcelas
                        if ((ListaParcelas != null) && (ListaParcelas.Count() > 0))
                        {
                            using (var transaction = new System.Transactions.CommittableTransaction())
                            {
                                try
                                {
                                    pedido.ESC_AjustarFinanceiro = "X"; //Para indicar que foi gerado a parcela novamente

                                    foreach (var parcela in ListaParcelas)
                                    {
                                        if (pedido.Codclirecebedor > 0)
                                        {
                                            parcela.Codcli = Numbers.ToInt32(pedido.Codclirecebedor.ToString());
                                        }
                                        else
                                        {
                                            parcela.Codcli = pedido.Codcli;
                                        }

                                        parcela.Codusur = pedido.Codusur;
                                        parcela.Idtitulo = pedido.Proximo("DFSEQ_PCPRESTTEMP_IDTITULO");
                                        parcela.Dtinclusao = pedido.DataHoraServidor();
                                        parcela.Integradora = pedido.Integradora;
                                        parcela.Tipointegracao = pedido.Tipointegracao;
                                        parcela.Dtemissao = pedido.Data;
                                        parcela.Vltxboleto = 0;
                                        parcela.Numpedweb = pedido.Numpedweb;
                                        parcela.Nossonumbco = "";
                                        if (parcela.Codcob == "")
                                        {
                                            parcela.Codcob = pedido.Codcob;
                                        }
                                        parcela.Gravar();
                                    }
                                    pedido.Codclirecebedor = 0;
                                    pedido.Gravar();
                                    transaction.Commit();
                                }
                                catch (Exception erro)
                                {
                                    MessageBox.Show("Erro ao gravar pedido:  " + pedido.Numpedrca.ToString() + " - Erro: " + erro);
                                    transaction.Rollback();
                                }

                            }
                        }
                    }
                    progressBar1.Increment(1);
                    Application.DoEvents();
                }
                MessageBox.Show("Processamento concluído!");
            }
            else
            {
                MessageBox.Show("Nenhum pedido para ser processado!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmailDescriptografado.Text = RetornarEmail(EmailCriptografado.Text);
        }

        private string RetornarEmail(string emailCripotrafado)
        {
            string retorno = emailCripotrafado;
            if (!string.IsNullOrEmpty(emailCripotrafado))
            {


                //Criando a conexão com a VText
                Integradora.ECommerce.VTex.Orders.Pedido VTexPedidoConsulta = new Integradora.ECommerce.VTex.Orders.Pedido();

                retorno = VTexPedidoConsulta.EmailDescriptografado(EmailCriptografado.Text.ToLower());
                if (string.IsNullOrEmpty(retorno))
                {
                    retorno = emailCripotrafado;
                }
            }
            else
            {
                MessageBox.Show("Informe o e-mail a ser descriptogrado!");
                retorno = emailCripotrafado;
            }
            return retorno;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Integradora.ECommerce.VTex.Orders.Pedido VTexPedidoConsulta = new Integradora.ECommerce.VTex.Orders.Pedido();
            Integradora.ECommerce.VTex.Orders.RootPedido VTexPedido = VTexPedidoConsulta.Consultar(numeroPedidoEcommerce.Text);

            foreach (Integradora.ECommerce.VTex.Orders.Transaction transacao in VTexPedido.paymentData.transactions)
            {
                foreach (Integradora.ECommerce.VTex.Orders.Payment parcelas in transacao.payments)
                {
                    string NSU = "";
                    if (parcelas.installments > 0)
                    {
                        for (int i = 0; i < parcelas.installments; i++)
                        {
                            var NSU_Vtex = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(parcelas.connectorResponses.Nsu);
                            if (NSU != NSU_Vtex)
                            {
                                NSUAntigo.Text = parcelas.connectorResponses.Nsu;

                                NSU = NSU_Vtex;  //Backup do antigo;
                                NSUNovo.Text = VTexPedidoConsulta.ObterPagamentoNSU(transacao.transactionId, parcelas);
                            }
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<PCClient> listaCliente = PCClient.Listar("EMAILNFE like '%ct.vtex.com.br%' and ROWNUM < 2000");
            if (listaCliente.Count() > 0)
            {
                progressBar2.Style = ProgressBarStyle.Blocks;
                progressBar2.Value = 0;
                progressBar2.Step = 1;
                progressBar2.Maximum = listaCliente.Count();
                foreach (var cliente in listaCliente)
                {
                    string novo  = RetornarEmail(cliente.Emailnfe);
                    if (cliente.Emailnfe != novo)
                    {
                        cliente.Emailnfe = novo;
                        using (var transaction = new System.Transactions.CommittableTransaction())
                        {
                            try
                            {
                                cliente.Gravar();
                                transaction.Commit();
                            }
                            catch
                            {
                                transaction.Rollback();
                            }
                        }
                    }
                    progressBar2.Increment(1);
                    Application.DoEvents();
                }
                            MessageBox.Show("Processamento concluído!");
            }
            else
            {
                MessageBox.Show("Nenhum cliente para ser processado!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPedidoDownload.Text))
            {
                Integradora.ECommerce.VTex.Orders.Pedido VTexPedidoConsulta = new Integradora.ECommerce.VTex.Orders.Pedido();
                Integradora.ECommerce.VTex.Orders.RootPedido VTexPedido = VTexPedidoConsulta.Consultar(txtPedidoDownload.Text);


                var retorno = Integradora.Biblioteca.Tools.JSON.Export(VTexPedido, txtPedidoDownload.Text);

                MessageBox.Show("Pedido salvo no arquivo: " + retorno);


            }
            else
            {
                MessageBox.Show("Informe o número do pedido!");
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            btnObterParcelas.Enabled = Integradora.Biblioteca.Dictionaries.Settings.Administrador() == "S";
            btnObterNSU.Enabled = Integradora.Biblioteca.Dictionaries.Settings.Administrador() == "S";
            btnDescriptografarEmail.Enabled = Integradora.Biblioteca.Dictionaries.Settings.Administrador() == "S";
            btnDescriptografarCadastro.Enabled = Integradora.Biblioteca.Dictionaries.Settings.Administrador() == "S";
            //btnDownloadPedido.Enabled = Integradora.Biblioteca.Dictionaries.Settings.Administrador() == "S";
        }
    }
}
