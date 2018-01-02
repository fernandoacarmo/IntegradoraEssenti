using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.DataHub.EntityJSON;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ECommerce.DataHub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integradora.ERP.Winthor.Select;

namespace Integradora.Norma.Winthor.DataHub
{
    class Enviar : IProcessIntegration
    {
        public Integradora.ECommerce.DataHub.Integracao LojaECommerce { get; set; }
        private List<VWFiliais> ListaFilial { get; set; }

        public Enviar()
        {
            LojaECommerce = new ECommerce.DataHub.Integracao();
        }

        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            //Listando filiais ativas
            ListaFilial = VWFiliais.Listar("");

            //Verificando se tem registro das filiais para ser enviado
            var lista = Integradora.ERP.Winthor.Domain.ProcessarFila.LoadECommerce("");

            //Per correndo a lista
            foreach (var item in lista)
            {
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        //Criando a classe e carregando
                        var integracao = Integradora.ERP.Winthor.Domain.ProcessarFila.CreateClasse(item.Tabela, "rowid = '" + item.Id + "'  for update");
                        //Caso tenha encontrado processa
                        if (integracao != null)
                        {
                            switch (item.Tabela)
                            {
                                case "PCPRODUT":
                                    SendProduto((PCProdut)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCCLIENT":
                                    SendCliente((PCClient)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCFORNEC":
                                    SendFornecedor((PCFornec)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCTABPR":
                                    SendTabelaPreco((PCTabpr)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCNFSAID":
                                    SendCupomFiscal((PCNfsaid)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCPREST":
                                    SendContasAReceber((PCPrest)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                            }
                        }

                        Integradora.ERP.Winthor.Domain.ProcessarFila.Remove(item);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Processo.Notificar("Integradora.Norma.Winthor.Corpem", "Send", ex);
                    }
                }
            }
        }

        private void SendContasAReceber(PCPrest dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            TituloReceber datahub = new TituloReceber();
            datahub.codcli = dados.Codcli.ToString();
            datahub.dtcad = dados.Dtinclusao.ToString();
            datahub.dtemi = dados.Dtemissao.ToString();
            datahub.dtpagantec = dados.Dtpag.ToString();
            datahub.dtvenc = dados.Dtvenc.ToString();
            datahub.numtit = dados.Duplic.ToString();
            datahub.vlrtit = dados.Valor.ToString();
            datahub.txjuros = dados.Txperm.ToString();
            datahub.txdesc = dados.Perdesc.ToString();

            LojaECommerce.Enviar(Integradora.ECommerce.DataHub.Integracao.TipoRegistro.TituloReceber, (Object)datahub);
        }        

        private void SendCupomFiscal(PCNfsaid dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            CancelaNotaFiscalSaida datahub = new CancelaNotaFiscalSaida();
            datahub.ti048UnidadeIu = NumeroFilial( dados.Codfilial );
            datahub.ti048NotaFiscalIu = Numbers.ToInt32( dados.Numnota.ToString() );
            datahub.ti048SerieIu = dados.Serie;
            datahub.ti048TipoNotaFiscalIu = dados.Condvenda.ToString();
            datahub.ti048DataEmissaoIu = dados.Dtsaida.ToString();
            datahub.ti048CodigoEdc = dados.Especie;
            datahub.ti048CodigoEmpresa = Numbers.ToInt32( dados.Codemitente.ToString() );
            datahub.ti048CodigoFilial =  NumeroFilial( dados.Codfilial );
            datahub.ti048NumeroChaveAcessoNfe = Numbers.ToInt64( dados.Chavenfe );
            datahub.ti048IdEspecialista = dados.Numtransvenda.ToString();
            datahub.ti048DataCancelamento = dados.Dtcancel.ToString();

            LojaECommerce.Enviar(Integradora.ECommerce.DataHub.Integracao.TipoRegistro.CupomFiscal, (Object)datahub);
        }

        private void SendTabelaPreco(PCTabpr dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            TabelaPreco datahub = new TabelaPreco();
            datahub.ti114Codemp = 1;
            if (DateTime.ParseExact(datahub.ti114Datfim, "dd/MM/yyyy", null) > DateTime.Now)
            {
                datahub.ti114Sitreg = "A";
            }
            else
            {
                datahub.ti114Sitreg = "I";
            }            
            datahub.ti114Codtpr = dados.Precomaxconsum.ToString();
            datahub.ti114Datini = dados.Dtiniciovalidade.ToString();
            datahub.ti114Datfim = dados.Dtfimvalidade.ToString();
            datahub.ti114IdEspecialista = "";

            LojaECommerce.Enviar(Integradora.ECommerce.DataHub.Integracao.TipoRegistro.TabelaPreco, (Object)datahub);
        }

        private void SendFornecedor(PCFornec dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            Fornecedor datahub = new Fornecedor();
            datahub.fornecedorIu = Numbers.ToInt32( dados.Codfornec.ToString() );
            datahub.nome = Formats.Cortar( dados.Fornecedor, 35);
            datahub.razaoSocial = Formats.Cortar( dados.Fantasia, 35);
            datahub.tipoPessoa = string.IsNullOrEmpty(dados.Tipopessoa) ? "J" : dados.Tipopessoa;
            datahub.estrangeiro = dados.Estado == "EX" ? "E" : "I";
            datahub.inscEstadual = string.IsNullOrEmpty(dados.Ie) ? "ISENTO" : Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(dados.Ie);
            datahub.inscMunicipal = string.IsNullOrEmpty(dados.Inscmunicip) ? "" : Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(dados.Inscmunicip);
            datahub.cpfCnpj = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(dados.Cgc);
            datahub.codigoSuframa = string.IsNullOrEmpty(dados.Suframa) ? "" : Formats.Cortar(dados.Suframa, 10);
            datahub.endereco = Formats.Cortar(dados.Ender, 35);
            datahub.numeroEndereco = Formats.Cortar(dados.Numeroend, 10);
            datahub.complEndereco = "";
            datahub.bairro = Formats.Cortar(dados.Bairro, 20);
            datahub.cep = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(dados.Cep);
            datahub.cidade = Formats.Cortar(dados.Cidade, 25);
            datahub.uf = dados.Estado;
            datahub.dddFone1 = "";
            datahub.telefone1 = Formats.Cortar(Formats.Telefone(dados.Telefoneadm), 20);
            datahub.dddFone2 = "";
            datahub.telefone2 = Formats.Cortar(Formats.Telefone(dados.Telefonecom), 20);
            datahub.dddFone3 = "";
            datahub.telefone3 = Formats.Cortar(Formats.Telefone(dados.Telrep), 20);
            datahub.fax = Formats.Cortar(Formats.Telefone(dados.Faxrep), 20);
            datahub.cxPostal = 0;
            datahub.email = Formats.Cortar(dados.Email,40);
            datahub.situacao = dados.Dtexclusao == null ? "A" : "I";
            datahub.codigoPais = Numbers.ToInt32( dados.Codpais.ToString() );
            datahub.tipoFornecedor = "A";
            datahub.usuarioAlteracao = Biblioteca.Dictionaries.Settings.Matricula().ToString();
            datahub.idEspecialista = dados.Codfornec.ToString();
            datahub.operacaoRegistro = dados.Dtexclusao == null ? "I" : "E";

            foreach (var filial in ListaFilial)
            {
                DefinicoesFornecedor definicao = new DefinicoesFornecedor();
                definicao.unidade = NumeroFilial(filial.Codigo);
                if (definicao.unidade > 0)
                {
                    definicao.condicaoPagamento = "XXXXXX";
                    definicao.operacaoRegistro = datahub.operacaoRegistro;
                    definicao.codigoEmpresa = definicao.unidade;
                    definicao.codigoFilial = definicao.unidade;

                    datahub.definicoesFornecedor.Add(definicao);
                }
            }
            LojaECommerce.Enviar(Integradora.ECommerce.DataHub.Integracao.TipoRegistro.Fornecedores, (Object)datahub);
        }

        private void SendCliente(PCClient dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            Cliente datahub = new Cliente();
            datahub.nome = dados.Cliente;
            datahub.nomeFantasia = string.IsNullOrEmpty(dados.Fantasia) ? dados.Cliente : dados.Fantasia;
            datahub.tipoCliente = string.IsNullOrEmpty(dados.Tipofj) ? "J" : dados.Tipofj;
            datahub.tipoMercado = "I";
            datahub.tipoAcerto = 1;
            datahub.contribuinteICMS = dados.Contribuinte;
            datahub.inscEstadual = string.IsNullOrEmpty(dados.Iest) ? "ISENTO" : Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(dados.Iest);
            datahub.inscMunicipal = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(dados.Iment);
            datahub.cpfCnpj =  Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(dados.Cgcent);
            datahub.beneficioFiscal = "3";
            datahub.inscAliqSuframa = Formats.Cortar(dados.Sulframa, 9);
            datahub.endereco = Formats.Cortar(dados.Enderent, 35);
            datahub.numeroEndereco = string.IsNullOrEmpty(dados.Numeroent) ? "S/N" : Formats.Cortar(dados.Numeroent, 10);
            datahub.complEndereco = "";
            datahub.refEndereco = "";
            datahub.cep = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(dados.Cepent);
            datahub.bairro =  Formats.Cortar(dados.Bairroent, 20);
            datahub.cidade =  Formats.Cortar(dados.Municent, 25);
            datahub.uf = dados.Estent;
            datahub.codigoPais = dados.Codpais.ToString();
            datahub.ddd1 = "";
            datahub.ddd2 = "";
            datahub.ddd3 = "";
            datahub.ddd4 = "";
            datahub.ddd5 = "";
            datahub.telefone1 = Formats.Cortar(Formats.Telefone(dados.Telent), 20);
            datahub.telefone2 = Formats.Cortar(Formats.Telefone(dados.Telent1), 20);
            datahub.telefone3 = Formats.Cortar(Formats.Telefone(dados.Telcelent), 20);
            datahub.telefone4 = Formats.Cortar(Formats.Telefone(dados.Telcob), 20);
            datahub.telefone5 = Formats.Cortar(Formats.Telefone(dados.Telcom), 20);
            datahub.fax = Formats.Cortar(dados.Faxcli, 20);
            datahub.cxPostal = Biblioteca.Tools.Numbers.ToInt32( dados.Caixapostal.ToString());
            datahub.email = Formats.Cortar(dados.Email, 70);
            if (dados.Dtexclusao == null)
            {
                datahub.situacao = "A";
            }
            else
            {
                datahub.situacao = "I";
            }
            datahub.usuarioAlteracao = Biblioteca.Dictionaries.Settings.Matricula();
            datahub.emailNFE = string.IsNullOrEmpty(dados.Emailnfe) ? datahub.email : Formats.Cortar(dados.Emailnfe, 100);
            datahub.idSistemaEspecialista =  Biblioteca.Tools.Numbers.ToInt32( dados.Codcli.ToString() );
            datahub.operacaoRegistro = "I"; //inclusao do registro
            datahub.idEspecialista = dados.Codcli.ToString();

            foreach (var filial in ListaFilial)
            {
                DefinicoesCliente definicao = new DefinicoesCliente();
                definicao.unidade =  NumeroFilial(filial.Codigo);
                if (definicao.unidade > 0)
                {
                    definicao.codigoEmpresa = 1;
                    definicao.codigoFilial = 1;
                    definicao.codigoRepresentante = Biblioteca.Tools.Numbers.ToInt32(dados.Codusur1.ToString());
                    definicao.condicaoPagamento = "XXXXXX";

                    datahub.definicoesCliente.Add(definicao);
                }
            }

            LojaECommerce.Enviar(Integradora.ECommerce.DataHub.Integracao.TipoRegistro.Clientes, (Object)datahub);
        }

        private void SendProduto(PCProdut dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            Produto datahub = new Produto();
            datahub.operacaoRegistro = dados.Dtexclusao == null ? "I" : "E";
            datahub.produtoIu = Numbers.ToInt32( dados.Codprod.ToString() );
            datahub.descricao = Formats.Cortar( dados.Descricao, 45);
            datahub.descricaoComplementar = Formats.Cortar(dados.Descricao1, 120);
            datahub.classificacaoFiscal = dados.Codfiscal.ToString();
            datahub.situacaoTributaria = string.IsNullOrEmpty(dados.Sittribut) ? "00" : dados.Sittribut;
            datahub.codigoBarras = Formats.Cortar( dados.Codauxiliar.ToString(), 14);
            datahub.familia = string.IsNullOrEmpty(dados.Codprodprinc.ToString()) ? dados.Codprod.ToString() : dados.Codprodprinc.ToString();
            datahub.unidadeVenda = dados.Unidade;
            datahub.tributacaoPis = "N";
            datahub.idEspecialista = dados.Codprod.ToString();

            foreach (var filial in ListaFilial)
            {
                ProdutosUnidade definicao = new ProdutosUnidade();
                definicao.unidadeIu = NumeroFilial(filial.Codigo);
                if (definicao.unidadeIu> 0)
                {
                    definicao.codigoEmpresa = 1;
                    definicao.produtoAtivo = dados.Dtexclusao == null ? "A" : "I";
                    definicao.operacaoRegistro = datahub.operacaoRegistro;
                    definicao.classificacaoTipo = "0";

                    datahub.produtosUnidade.Add(definicao);
                }
            }

            LojaECommerce.Enviar(Integradora.ECommerce.DataHub.Integracao.TipoRegistro.Produtos, (Object)datahub);
        }

        private Int32 NumeroFilial(string codigoFilial)
        {
            return Numbers.ToInt32(Numbers.OnlyNumbers(codigoFilial));
        }
    }
}
