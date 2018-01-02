using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integradora.Biblioteca.Dictionaries;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.Database.Oracle;
using Integradora.Biblioteca.Tools;
using Integradora.ERP.Winthor.EntityEssenti;

namespace Integradora.ERP.Winthor.Domain
{
    public class MovimentarCaixa
    {
        PCEstcr SaldoCaixa;
        PCMovcr Lancamento;
        public MovimentarCaixa()
        {

        }

        public bool LancarMovimento(Tips.OperacaoFinanceira operacao,
                                    decimal valorLancamento,
                                    Int32 codContaGerencial,
                                    decimal codBanco,
                                    string historico1,
                                    string historico2,
                                    string Numpedido)
        {
            bool retorno = false;
            decimal SaldoCaixa = 0;
            decimal ContaContabil = 0;
            string codCobranca = Integradora.Biblioteca.Dictionaries.Settings.CodCobrancaMovimentoCaixa();
            if (string.IsNullOrEmpty(codCobranca))
            {
                codCobranca = "COBS";
            }

            if (valorLancamento > 0)
            {
                SaldoCaixa = Saldo(codBanco, codCobranca);

                Lancamento = new PCMovcr();

                Lancamento.Numtrans = Lancamento.Proximo("PCCONSUM", "PROXNUMTRANS");
                Lancamento.Codbanco = codBanco;
                Lancamento.Codcob = codCobranca;
                Lancamento.Valor = valorLancamento;
                Lancamento.Historico = historico1;
                Lancamento.Historico2 = historico2;
                Lancamento.Numcarr = 0;
                Lancamento.Vlsaldo = SaldoCaixa;
                Lancamento.Indice = "A";
                Lancamento.Numdoc = Numpedido;
                Lancamento.Codrotinalanc = Integradora.Biblioteca.Dictionaries.Settings.Rotina();
                Lancamento.Codfunc = Integradora.Biblioteca.Dictionaries.Settings.Matricula();

                DateTime DataLancamento = Lancamento.DataHoraServidor();
                Lancamento.Data = DataLancamento.Date;
                Lancamento.Hora = DataLancamento.Hour;
                Lancamento.Minuto = DataLancamento.Minute;

                switch (operacao)
                {
                    case Tips.OperacaoFinanceira.Debito:
                        ContaContabil = ObterContaContabil(codBanco, codCobranca);
                        Lancamento.Tipo = "D";
                        if (ContaContabil > 0)
                        {
                            Lancamento.Codcontadeb = ContaContabil;
                        }
                        break;
                    case Tips.OperacaoFinanceira.Credito:
                        ContaContabil = ObterContaContabil(codContaGerencial);
                        Lancamento.Tipo = "C";
                        if (ContaContabil > 0)
                        {
                            Lancamento.Codcontacred = ContaContabil;
                        }
                        break;
                    default:
                        break;
                }

                Persistencia ba = new Persistencia(PCMovcr.GetStringConnection());
                ba.Inserir(Lancamento);

                AtualizarSaldo(valorLancamento);
            }
            return retorno;
        }

        private decimal ObterContaContabil(int codContaGerencial)
        {
            PCConta Conta = null;
            decimal retorno = 0;
            try
            {
                Conta = PCConta.Listar(string.Format("CODCONTA = {0}", codContaGerencial)).Single();
                retorno = Convert.ToInt64(Conta.Contacontabil);
            }
            catch
            {
                Conta = null;
                retorno = 0;
            }

            return retorno;
        }

        private decimal ObterContaContabil(decimal codBanco, string codCobranca)
        {
            PCBanco Banco = null;
            decimal retorno = 0;
            try
            {
                Banco = PCBanco.Listar(string.Format("CODBANCO = {0}", codBanco)).Single();
            }
            catch
            {
                Banco = null;
                retorno = 0;
            }

            if (Banco != null)
            {
                switch (codCobranca)
                {
                    case "DNI":
                        retorno = Banco.Codcontabildni;
                        break;
                    case "COBS":
                        retorno = Banco.Codcontabilcobs;
                        break;
                    case "CHDV":
                        retorno = Banco.Codcontabilchdv;
                        break;
                    default:
                        break;
                }
            }

            return retorno;
        }

        private decimal Saldo(decimal codBanco, string codCobranca)
        {
            decimal valorSaldo = 0;

            try
            {
                SaldoCaixa = PCEstcr.Listar(string.Format("CODBANCO = {0} AND CODCOB = '{1}' FOR UPDATE", codBanco, codCobranca)).Single();
            }
            catch
            {
                SaldoCaixa = new PCEstcr();
                SaldoCaixa.Codbanco = codBanco;
                SaldoCaixa.Codcob = codCobranca;
                SaldoCaixa.Valor = 0;

                GravarSaldo(true);

                SaldoCaixa = PCEstcr.Listar(string.Format("CODBANCO = {0} AND CODCOB = '{1}' FOR UPDATE", codBanco, codCobranca)).Single();
            }

            valorSaldo = SaldoCaixa.Valor;

            return valorSaldo;
        }

        private void AtualizarSaldo(decimal valor)
        {
            SaldoCaixa.Valor += valor;
            GravarSaldo(false);
        }

        public void LancarCreditoCliente(decimal Codcli, string CodFilial, decimal valorLancamento, decimal numped)
        {
            try
            {
                PCCrecli Credito = new PCCrecli();
                DateTime DataLancamento = Credito.DataHoraServidor();
                Credito.Dtlanc = DataLancamento.Date;
                Credito.Hora = DataLancamento.Hour;
                Credito.Minuto = DataLancamento.Minute;
                Credito.Codigo = Credito.Proximo("DFSEQ_PCCRECLI");
                Credito.Codcli = Codcli;
                Credito.Codfilial = CodFilial;
                Credito.Valor = valorLancamento;
                Credito.Codfunc = Integradora.Biblioteca.Dictionaries.Settings.Matricula();
                Credito.Codfunclanc = Credito.Codfunc;
                Credito.Origem = "M";
                Credito.Historico = "Pedido via web";
                Credito.Numerario = "S";
                Credito.Codrotina = 9801;
                Credito.Numped = numped;

                Persistencia ba = new Persistencia(PCCrecli.GetStringConnection());
                ba.Inserir(Credito);

            }
            catch (Exception ex)
            {
                Logs.GerarLog("MovimentarCaixa", "LancarCreditoCliente", "Gerar crédito do cliente", ex);
            }
        }

        public void LancarDespesaCredito(decimal Codcli, string CodFilial, decimal valorLancamento, decimal numped)
        {
            try
            {
                PCLanc Credito = new PCLanc();
                DateTime DataLancamento = Credito.DataHoraServidor();

                Credito.Recnum = Credito.Proximo("PCCONSUM", "PROXNUMLANC");
                Credito.Dtlanc = DataLancamento.Date;
                Credito.Dtvenc = DataLancamento.Date;
                Credito.Dtemissao = DataLancamento.Date;
                Credito.Dtcompetencia = DataLancamento.Date;
                Credito.Dtultalter = DataLancamento.Date;
                Credito.Dtpagto = DataLancamento.Date;
                Credito.Codfilial = CodFilial;
                Credito.Historico = "Pedido via web";
                Credito.Duplic = "1";
                Credito.Prest = "1";
                Credito.Parcela = "1";
                Credito.Indice = "A";
                Credito.Tipolanc = "A";
                Credito.Moeda = "R";
                Credito.Numvia = 1;
                Credito.Cotacao = 1;
                Credito.Tipoparceiro = "C";
                Credito.Numnota = numped;
                Credito.Codfuncultalter = Integradora.Biblioteca.Dictionaries.Settings.Matricula();
                Credito.Codfuncbaixa = Credito.Codfuncultalter;
                Credito.Codrotinabaixa = 9801;
                Credito.Codrotinacad = Credito.Codrotinabaixa.ToString();
                Credito.Codrotinaalt = Credito.Codrotinabaixa.ToString();
                Credito.Valor = valorLancamento * -1;
                Credito.Vpago = Credito.Valor;
                Credito.Codfornec = Codcli;
                Credito.Codconta = Integradora.Biblioteca.Dictionaries.Settings.ContaGerencialReceitaDeCredito();
                if (Credito.Codconta == 0)
                {
                    Credito.Codconta = PCConsum.Listar("1=1").FirstOrDefault().Codcontdescconc;
                }

                Persistencia ba = new Persistencia(PCCrecli.GetStringConnection());
                ba.Inserir(Credito);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("MovimentarCaixa", "LancarDespesaCredito", "Gerar lançamento de despesas de crédito", ex);
            }
        }

        private void GravarSaldo(bool inserirRegistro)
        {
            Persistencia ba = new Persistencia(PCCrecli.GetStringConnection());

            if (inserirRegistro)
            {
                ba.Inserir(SaldoCaixa);
            }
            else
            {
                ba.Alterar(SaldoCaixa);
            }
        }
    }
}
