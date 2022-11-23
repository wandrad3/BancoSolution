using System;
using System.Collections.Generic;
using System.Text;
using Banco.Iinterfaces;

namespace Banco.Entities
{
    public abstract class Conta
    {
        protected float saldo;


        public abstract float sacar(float valor);
        public abstract float depositar(float valor);

        

    }
}
