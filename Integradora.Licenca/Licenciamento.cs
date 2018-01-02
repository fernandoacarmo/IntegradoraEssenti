using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Integradora.Biblioteca.Dictionaries;
using Integradora.Biblioteca.Tools;

namespace Integradora.Licenca
{
    public struct RespostaLicenciamento
    {
        public bool permitido;
        public Tips.ClientePC codigoClientePC;
    }
    public sealed class Licenciamento
    {
       
        /// <summary>
        /// Propriedade referente ao campo: DTVENCIMENTO
        /// Comentário: Data de vencimento da versão demo
        /// </summary>
        private DateTime dtvencimento;
        [XmlElement(ElementName = "DTVENCIMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime Dtvencimento
        {
            get { return dtvencimento; }
            set { dtvencimento = value; }
        }


        private Tips.ClientePC clientepc;
        [XmlElement(ElementName = "CLIENTEPC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public Tips.ClientePC ClientePC
        {
            get { return clientepc; }
            set { clientepc = value; }
        }

        public static RespostaLicenciamento ValidarClienteWinthor()
        {
            decimal CodCliPC = 0;
            RespostaLicenciamento Resposta = new RespostaLicenciamento();
            Resposta.permitido = false;

            try
            {
                CodCliPC = PCConsum.Listar().Single().Codclipc;
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Licenca", "ValidarClienteWinthor", ex);
            }

            Resposta.codigoClientePC = (Tips.ClientePC)CodCliPC;

            switch (Resposta.codigoClientePC )
            {
                case Tips.ClientePC.MinhaMaquina:
                    Resposta.permitido = true;
                    break;
                case Tips.ClientePC.AgroShop:
                    Resposta.permitido = true;
                    break;
                case Tips.ClientePC.Cergrand:
                    Resposta.permitido = true;
                    break;
                case Tips.ClientePC.DecisaoAtacadista:
                    Resposta.permitido = true;
                    break;
                case Tips.ClientePC.FrioPecas:
                    Resposta.permitido = true;
                    break;
                case Tips.ClientePC.FrioPecas2:
                    Resposta.permitido = true;
                    break;
                case Tips.ClientePC.PCSistemas:
                    Resposta.permitido = true;
                    break;
                case Tips.ClientePC.JorgeBatista:
                    Resposta.permitido = true;
                    break;
                case Tips.ClientePC.LojasLivia:
                    Resposta.permitido = true;
                    break;
                case Tips.ClientePC.ClimaRio:
                    Resposta.permitido = true;
                    break;
                case Tips.ClientePC.Pacaluz:
                    Resposta.permitido = true;
                    break;
                case Tips.ClientePC.Inga:
                    Resposta.permitido = true;
                    break;
                case Tips.ClientePC.Machado:
                    Resposta.permitido = true;
                    break;
                case Tips.ClientePC.FlashRio:
                    Resposta.permitido = true;
                    break;
                case Tips.ClientePC.OMBoat:
                    Resposta.permitido = true;
                    break;
                case Tips.ClientePC.TekDistribuidora:
                    Resposta.permitido = true;
                    break;
                case Tips.ClientePC.Lippaus:
                    Resposta.permitido = true;
                    break;
                default:
                    Resposta.permitido = false;
                    break;
            }

            Logs.Notify("Código cliente PC: " + CodCliPC.ToString());
            return Resposta;
        }
    }
}
