using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Biblioteca.Tools
{
    public sealed class Networks
    {
        /// <summary>
        /// Função externa para verificar se esta conectado na internet
        /// Utilizando a DLL: wininet.dll
        /// </summary>
        /// <param name="Description"></param>
        /// <param name="ReservedValue"></param>
        /// <returns></returns>
        [DllImport("wininet.dll")]
        private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);

        /// <summary>
        /// Verificado se esta conectado na internet
        /// </summary>
        /// <returns></returns>
        public static bool InternetAtiva()
        { //Verifica se a internet esta ativa ou não
            int Description;
            return InternetGetConnectedState(out Description, 0);
        }
    }
}
