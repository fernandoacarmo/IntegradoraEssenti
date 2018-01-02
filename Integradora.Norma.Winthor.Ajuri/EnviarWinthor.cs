using Integradora.Biblioteca.Tools;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Ajuri
{
    internal class EnviarWinthor
    {
        internal void SendCancelamento(ESTCancelamento registro)
        {
            //            if (registro.Tipo == "ENTRADA")
            //            {
            //                PCWmsnfcancel cadastro = new PCWmsnfcancel();
            //
            //                cadastro.Codfilial = Biblioteca.Dictionaries.Settings.CodFilialVenda();
            //                cadastro.Codfunc = 1;
            //                cadastro.Codoper = "E";
            //                cadastro.Data = registro.Data;
            //                cadastro.Motivo = registro.Obsintegracao;
            //                cadastro.Numnota = registro.Numero;
            //                cadastro.Semaforo = (decimal)Biblioteca.Dictionaries.Tips.SemaforoPosicaoOMBoat.DigitacaoDadosAjuri;
            //
            //                cadastro.Gravar();
            //            }
            //            else
            //            {
            //                PCWmspedcancel cadastro = new PCWmspedcancel();
            //
            //                cadastro.Codfilial = Biblioteca.Dictionaries.Settings.CodFilialVenda();
            //                cadastro.Codfunc = 1;
            //                cadastro.Data = registro.Data;
            //                cadastro.Motivo = registro.Obsintegracao;
            //                cadastro.Numcar = 0;
            //                cadastro.Numped = registro.Numero;
            //                cadastro.Semaforo = (decimal)Biblioteca.Dictionaries.Tips.SemaforoPosicaoOMBoat.DigitacaoDadosAjuri;
            //
            //                cadastro.Gravar();
            //            }
        }
        internal void SendMovimentacaoEstoque(ESTMovestoque registro)
        {
            PCWmsbloqueioest cadastro = new PCWmsbloqueioest();

            cadastro.Codfilial = Biblioteca.Dictionaries.Settings.CodFilialVenda();
            cadastro.Codprod = registro.Codproduto;
            cadastro.Codrotina = 9800;
            cadastro.Data = registro.Dtinclusao;
            cadastro.Dtlanc = registro.Dtinclusao;
            cadastro.Motivo = registro.Tipo;
            cadastro.Nomeresponsavel = "AJURI";
            cadastro.Numlote = registro.Numlote;
            cadastro.Qt = registro.Quantidade;
            cadastro.Responsavel = 1;
            cadastro.Tipobloq = registro.Tipo == "BLOQUEIO" ? "BC" : "DC";
            cadastro.Semaforo = (decimal)Biblioteca.Dictionaries.Tips.SemaforoPosicaoOMBoat.DigitacaoDadosAjuri;

            cadastro.Gravar();
        }
        internal void SendCliente(ESTCliente registro)
        {
            PCWmsclient cadastro = PCWmsclient.Listar("CODCLI = " + registro.Codigo.ToString()).FirstOrDefault();
            if (cadastro == null)
            {
                cadastro = new PCWmsclient();
            }

            cadastro.Bairroent = registro.Bairro;
            cadastro.Cepent = registro.Cep;
            cadastro.Cgcent = registro.Cnpj_Cpf;
            cadastro.Cliente = registro.Nome;
            cadastro.Codcli = registro.Codigo;
            cadastro.Codpraca = registro.Codpraca == 0 ? 1 : registro.Codpraca;
            cadastro.Dtprocessamento = registro.DataHoraServidor();
            cadastro.Enderent = registro.Endereco;
            cadastro.Estent = registro.Estado;
            cadastro.Fantasia = registro.Nome;
            cadastro.Ieent = registro.Ie;
            cadastro.Municent = registro.Cidade;
            cadastro.Telent = registro.Telefone;
            cadastro.Semaforo = (decimal)Biblioteca.Dictionaries.Tips.SemaforoPosicaoOMBoat.DigitacaoDadosAjuri;

            cadastro.Gravar();
        }
        internal void SendDepartamento(ESTDepartamento registro)
        {
            if (string.IsNullOrEmpty(registro.Numajuri))
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Ajuri", "SendDepartamento", "Número ajuri não informado para o departamento: " + registro.Codigo.ToString());
                return;
            }

            PCWmsdepto cadastro = PCWmsdepto.Listar("CODEPTO = " + registro.Numajuri).FirstOrDefault();
            if (cadastro == null)
            {
                cadastro = new PCWmsdepto();
            }

            cadastro.Codepto = Convert.ToDecimal(registro.Numajuri);
            cadastro.Descricao = registro.Descricao;
            cadastro.Tipomerc = "L";
            cadastro.Atualizainvgeral = "S";
            cadastro.Dtprocessamento = registro.DataHoraServidor();
            cadastro.Semaforo = (decimal)Biblioteca.Dictionaries.Tips.SemaforoPosicaoOMBoat.DigitacaoDadosAjuri;

            cadastro.Gravar();
        }
        internal void SendFornecedor(ESTFornecedor registro)
        {
            PCWmsfornec cadastro = PCWmsfornec.Listar("CODFORNEC = " + registro.Codigo.ToString()).FirstOrDefault();
            if (cadastro == null)
            {
                cadastro = new PCWmsfornec();
            }

            cadastro.Codfornec = registro.Codigo;
            cadastro.Dtprocessamento = registro.DataHoraServidor();
            cadastro.Fornecedor = registro.Nome;
            cadastro.Semaforo = (decimal)Biblioteca.Dictionaries.Tips.SemaforoPosicaoOMBoat.DigitacaoDadosAjuri;

            cadastro.Gravar();
        }
        internal void SendNotaEntrada(ESTNotaentrada registro)
        {
            PCWmsnfent cadastro = PCWmsnfent.Listar("NUMTRANSENT = " + registro.Numtransacao.ToString()).FirstOrDefault();
            if (cadastro == null)
            {
                cadastro = new PCWmsnfent();
            }

            cadastro.Codfilial = registro.Codfilial;
            cadastro.Codfornec = registro.Codfornecedor;
            cadastro.Dtdescarga = registro.Dtemissao;
            cadastro.Dtemissao = registro.Dtemissao;
            cadastro.Dtent = registro.Dtemissao;
            cadastro.Codcont = Biblioteca.Dictionaries.Settings.ContaGerencialEntrada();
            cadastro.Especie = "NF";
            cadastro.Tipodescarga = "1";
            cadastro.Dtprocessamento = registro.DataHoraServidor();
            cadastro.Dtsaida = registro.Dtemissao;
            cadastro.Numnota = registro.Numnota;
            cadastro.Numtransent = registro.Numtransacao;
            cadastro.Serie = string.IsNullOrEmpty(registro.Serie) ? "." : registro.Serie;
            cadastro.Vltotal = registro.Vltotal;
            cadastro.Semaforo = (decimal)Biblioteca.Dictionaries.Tips.SemaforoPosicaoOMBoat.DigitacaoDadosAjuri;

            if (cadastro.Gravar())
            {
                List<ESTNotaentradaitens> itensNotas = ESTNotaentradaitens.Listar("NUMTRANSACAO = " + registro.Numtransacao.ToString());
                foreach (var item in itensNotas)
                {
                    SendNotaEntradaItens(registro, item);
                }
            }
        }
        internal void SendNotaEntradaItens(ESTNotaentrada cabecalho, ESTNotaentradaitens item)
        {
            PCWmsmov cadastro = PCWmsmov.Listar((string.Format("NUMTRANSENT = {0} AND CODPROD = {1}", cabecalho.Numtransacao, item.Codproduto))).FirstOrDefault();
            if (cadastro == null)
            {
                cadastro = new PCWmsmov();
            }

            cadastro.Codprod = item.Codproduto;
            cadastro.Dtmov = cabecalho.Dtemissao;
            cadastro.Codfilial = cabecalho.Codfilial;
            cadastro.Codfornec = cabecalho.Codfornecedor;
            cadastro.Codoper = "E";
            cadastro.Dtprocessamento = cabecalho.DataHoraServidor();
            cadastro.Numnota = cabecalho.Numnota;
            cadastro.Numtransent = cabecalho.Numtransacao;
            cadastro.Punit = item.Vlunitario;
            cadastro.Qt = item.Quantidade;
            cadastro.Qtavaria = item.Qtavaria;
            cadastro.Qtbloqueada = item.Qtavaria;
            cadastro.Semaforo = (decimal)Biblioteca.Dictionaries.Tips.SemaforoPosicaoOMBoat.DigitacaoDadosAjuri;

            cadastro.Gravar();
        }
        internal void SendPedidoDefinir(ESTPedidosaida registro)
        {
            if (registro.TipoDocumento == "SD")
            {
                SendNotaDevolucaoSaida(registro);
            }
            else
            {
                SendPedidoSaida(registro);
            }
        }
        private void SendNotaDevolucaoSaida(ESTPedidosaida registro)
        {
            PCWmsnfsaid cadastro = PCWmsnfsaid.Listar(("NUMNOTA = " + registro.Numpedido.ToString())).FirstOrDefault();
            if (cadastro == null)
            {
                cadastro = new PCWmsnfsaid();
            }

            cadastro.Codcli = registro.Codcliente;
            cadastro.Codfilial = registro.Codfilial;
            cadastro.Codusur = 1;
            cadastro.Condvenda = 1;
            cadastro.Dtprocessamento = registro.DataHoraServidor();
            cadastro.Tipovenda = "1";
            cadastro.Totpeso = 0;
            cadastro.Totvolume = 0;
            cadastro.Vlcustofin = 0;
            cadastro.Vltotal = registro.Vltotal;
            cadastro.Semaforo = (decimal)Biblioteca.Dictionaries.Tips.SemaforoPosicaoOMBoat.DigitacaoDadosAjuri;
            cadastro.Dtsaida = registro.Dtinclusao;
            cadastro.Especie = "OE";
            cadastro.Numnota = registro.Numpedido;
            cadastro.Numtransvenda = cadastro.Proximo("PCCONSUM", "PROXNUMTRANSVENDA");
            cadastro.Totpeso = 0;
            cadastro.Totvolume = 0;
            cadastro.Vlcustofin = 0;
            cadastro.Vltotal = 1;

            if (cadastro.Gravar())
            {
                List<ESTPedidosaidaitens> itensNotas = ESTPedidosaidaitens.Listar("NUMPEDIDO = " + registro.Numpedido.ToString());
                foreach (var item in itensNotas)
                {
                    SendNotaDevolucaoSaidaItens(cadastro, item);
                }
            }
        }

        private void SendNotaDevolucaoSaidaItens(PCWmsnfsaid cabecalho, ESTPedidosaidaitens item)
        {
            PCWmsmov cadastro = PCWmsmov.Listar((string.Format("NUMNOTA = {0} AND CODPROD = {1}", cabecalho.Numnota, item.Codproduto))).FirstOrDefault();
            if (cadastro == null)
            {
                cadastro = new PCWmsmov();
            }

            cadastro.Codprod = item.Codproduto;
            cadastro.Dtmov = cabecalho.Dtsaida;
            cadastro.Codfilial = cabecalho.Codfilial;
            cadastro.Codcli = cabecalho.Codcli;
            cadastro.Codoper = "SD";
            cadastro.Dtprocessamento = cabecalho.DataHoraServidor();
            cadastro.Numnota = cabecalho.Numnota;
            cadastro.Numtransvenda = cabecalho.Numtransvenda;
            cadastro.Punit = item.Vlunitario;
            cadastro.Qt = item.Quantidade;
            cadastro.Qtavaria = 0;
            cadastro.Qtbloqueada = item.Quantidade;
            cadastro.Semaforo = (decimal)Biblioteca.Dictionaries.Tips.SemaforoPosicaoOMBoat.DigitacaoDadosAjuri;

            cadastro.Gravar();
        }
        internal void SendPedidoSaida(ESTPedidosaida registro)
        {
            PCWmspedc cadastro = PCWmspedc.Listar(("NUMPED = " + registro.Numpedido.ToString())).FirstOrDefault();
            if (cadastro == null)
            {
                cadastro = new PCWmspedc();
            }

            cadastro.Codcli = registro.Codcliente;
            cadastro.Codcob = "D";
            cadastro.Coddistrib = "1";
            cadastro.Codfilial = registro.Codfilial;
            cadastro.Codpraca = Biblioteca.Dictionaries.Settings.CodPraca();
            cadastro.Codsupervisor = 1;
            cadastro.Codusur = 1;
            cadastro.Data = registro.Dtinclusao;
            cadastro.Dtentrega = registro.DataServidor().AddDays(3);
            cadastro.Dtprocessamento = registro.DataHoraServidor();
            cadastro.Hora = registro.DataServidor().Hour;
            cadastro.Minuto = registro.DataServidor().Minute;
            cadastro.Numcar = 0;
            cadastro.Numped = registro.Numpedido;
            cadastro.Numseqentrega = 1;
            cadastro.Numseqmontagem = 1;
            cadastro.Numitens = registro.Qtitens;
            cadastro.Posicao = "L";
            cadastro.Tipovenda = "1";
            cadastro.Totpeso = 0;
            cadastro.Totvolume = 0;
            cadastro.Vlcustofin = 0;
            cadastro.Vltotal = registro.Vltotal;
            cadastro.Semaforo = (decimal)Biblioteca.Dictionaries.Tips.SemaforoPosicaoOMBoat.DigitacaoDadosAjuri;

            if (registro.Codcliente > 0)
            {
                ESTCliente cliente = ESTCliente.Listar("CODIGO = " + registro.Codcliente.ToString()).FirstOrDefault();
                if (cliente != null)
                    cadastro.Codpraca = cliente.Codpraca;
            }

            if (cadastro.Gravar())
            {
                List<ESTPedidosaidaitens> itensNotas = ESTPedidosaidaitens.Listar("NUMPEDIDO = " + registro.Numpedido.ToString());
                foreach (var item in itensNotas)
                {
                    SendPedidoSaidaItens(registro, item);
                }
            }
        }
        internal void SendPedidoSaidaItens(ESTPedidosaida cabecalho, ESTPedidosaidaitens item)
        {
            PCWmspedi cadastro = PCWmspedi.Listar((string.Format("NUMPED = {0} AND CODPROD = {1}", cabecalho.Numpedido, item.Codproduto) )).FirstOrDefault();
            if (cadastro == null)
            {
                cadastro = new PCWmspedi();
            }

            cadastro.Codprod = item.Codproduto;
            cadastro.Data = cabecalho.Dtinclusao;
            cadastro.Codcli = cabecalho.Codcliente;
            cadastro.Codusur = 1;
            cadastro.Dtprocessamento = cabecalho.DataHoraServidor();
            cadastro.Numped = cabecalho.Numpedido;
            cadastro.Posicao = "L";
            cadastro.Pvenda = item.Vlunitario;
            cadastro.Qt = item.Quantidade;
            cadastro.Vlcustofin = 0;
            cadastro.Semaforo = (decimal)Biblioteca.Dictionaries.Tips.SemaforoPosicaoOMBoat.DigitacaoDadosAjuri;

            cadastro.Gravar();
        }
        internal void SendPraca(ESTPraca registro)
        {
            PCWmspraca cadastro = PCWmspraca.Listar("CODPRACA = " + registro.Codigo.ToString()).FirstOrDefault();
            if (cadastro == null)
            {
                cadastro = new PCWmspraca();
            }

            cadastro.Codpraca = registro.Codigo;
            cadastro.Dtprocessamento = registro.DataHoraServidor();
            cadastro.Praca = registro.Codigo.ToString();
            cadastro.Rota = registro.Codigo;
            cadastro.Semaforo = (decimal)Biblioteca.Dictionaries.Tips.SemaforoPosicaoOMBoat.DigitacaoDadosAjuri;

            cadastro.Gravar();
        }
        internal void SendProduto(ESTProduto registro)
        {
            PCWmsprodut cadastro = PCWmsprodut.Listar("CODPROD = " + registro.Codigo.ToString()).FirstOrDefault();
            if (cadastro == null)
            {
                cadastro = new PCWmsprodut();
                cadastro.Alturaarm = registro.Altura;
                cadastro.Alturam3 = registro.Altura;
                cadastro.Alturapal = registro.Altura;
                cadastro.Atualizadadoslogisticos = "S";
                cadastro.Codauxiliar = registro.Codbarra;
                cadastro.Codauxiliar2 = registro.Codbarra;
                ESTSecao secao = ESTSecao.Listar("CODIGO = " + registro.Codsecao.ToString()).Single();
                cadastro.Codsec = Convert.ToDecimal(secao.Numajuri);
                cadastro.Codfornec = registro.Codfornec;
                cadastro.Codprod = registro.Codigo;
                cadastro.Codfab = registro.Numajuri;
                cadastro.Codmarca = Convert.ToDecimal(registro.Serial);
                cadastro.Codprodprinc = registro.Codigo;
                cadastro.Comprimentoarm = registro.Comprimento;
                cadastro.Comprimentom3 = registro.Comprimento;
                cadastro.Controledtvalidade = "S";
                cadastro.Descricao = registro.Descricaocompleta.Replace("'", "`");
                cadastro.Dtcadastro = registro.DataServidor();
                cadastro.Dtprocessamento = registro.DataHoraServidor();
                cadastro.Embalagem = registro.Embalagem;
                cadastro.Embalagemmaster = registro.Embalagem;
                cadastro.Larguraarm = registro.Largura;
                cadastro.Larguram3 = registro.Largura;
                cadastro.Lastropal = registro.Largura;
                cadastro.Pesobruto = registro.Pesobruto;
                cadastro.Pesoliq = registro.Pesoliquido;
                cadastro.Qtunit = registro.Qtunitaria;
                cadastro.Qtunitcx = registro.Qtembalagem;
                cadastro.Unidade = registro.Unidade;
                cadastro.Unidademaster = registro.Unidade;
                cadastro.Volume = registro.Volume;
                cadastro.Volumearm = registro.Volume;
                cadastro.Semaforo = (decimal)Biblioteca.Dictionaries.Tips.SemaforoPosicaoOMBoat.DigitacaoDadosAjuri;
            }

            if (registro.Codsecao > 0)
            {
                ESTSecao secao = ESTSecao.Listar("CODIGO = " + registro.Codsecao.ToString()).FirstOrDefault();
                if (secao != null)
                {
                    cadastro.Codsec = Convert.ToDecimal(secao.Numajuri);

                    ESTDepartamento departamento = ESTDepartamento.Listar("CODIGO = " + secao.Coddepartamento.ToString()).Single();
                    cadastro.Codepto = Convert.ToDecimal(departamento.Numajuri);
                }
            }

            cadastro.Gravar();
        }
        internal void SendRota(ESTRota registro)
        {
            PCWmsrotaexp cadastro = PCWmsrotaexp.Listar("CODROTA = " + registro.Codigo.ToString()).FirstOrDefault();
            if (cadastro == null)
            {
                cadastro = new PCWmsrotaexp();
            }

            cadastro.Codrota = registro.Codigo;
            cadastro.Descricao = registro.Descricao;
            cadastro.Dtprocessamento = registro.DataHoraServidor();

            cadastro.Gravar();
        }
        internal void SendSecao(ESTSecao registro)
        {
            if (string.IsNullOrEmpty(registro.Numajuri))
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Ajuri", "SendSecao", "Número ajuri não informado para a seção: " + registro.Codigo.ToString());
                return;
            }
            PCWmssecao cadastro = PCWmssecao.Listar("CODSEC = " + registro.Numajuri).FirstOrDefault();
            if (cadastro == null)
            {
                cadastro = new PCWmssecao();
            }

            cadastro.Codsec = Convert.ToDecimal(registro.Numajuri);
            ESTDepartamento departamento = ESTDepartamento.Listar("CODIGO = " + registro.Coddepartamento.ToString()).Single();
            cadastro.Codepto = Convert.ToDecimal(departamento.Numajuri);
            cadastro.Descricao = registro.Descricao;
            cadastro.Dtprocessamento = registro.DataHoraServidor();

            cadastro.Gravar();
        }

    }
}
