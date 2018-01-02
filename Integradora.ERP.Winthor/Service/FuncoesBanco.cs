using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ERP.Winthor.Service
{
    public sealed class FuncoesBanco
    {
        public static string integradoraWeb_Modelo_01()
        {
            return "importarvendas.importarpedidoweb";
        }
        public static string integradoraWeb_Modelo_02()
        {
            return "importarvendas.importar_pedido_web";
        }

        public static string integradoraForcaVenda()
        {
            return "importarvendas.importarpedido";
        }

        public static string cortepedido()
        {
            return "esk_logistica.cortaitem";
        }

        public static string cancelarpedidovenda()
        {
            return "Pkg_cancela_pedido.prc_cancela";
        }
    }
}
