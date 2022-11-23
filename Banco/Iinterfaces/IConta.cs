using System;
using System.Collections.Generic;
using System.Text;
using Banco.Entities;
namespace Banco.Iinterfaces
{
    public interface IConta
    {
        void transferir(Conta origem, Conta destino, float valor);
    }
}
