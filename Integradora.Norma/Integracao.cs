using Integradora.Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma
{
    public abstract class Integracao : IIntegration
    {
        public Integracao()
        {
            Initialize();
        }
        protected abstract void Send();

        protected abstract void Receive();

        protected abstract void Initialize();

        public abstract void Execute();
    }
}
