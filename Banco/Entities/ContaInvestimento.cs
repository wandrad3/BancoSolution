using System;
using System.Collections.Generic;
using System.Text;

using Banco.Iinterfaces;

namespace Banco.Entities
{
    class ContaInvestimento : Conta, IConta
    {
        public float saldo { get => saldo; set => saldo = value; }
        public override float depositar(float valor) =>  saldo + valor;
        

        public override float sacar(float valor) => saldo - ((saldo - valor) * 0.1F);


        void IConta.transferir(Conta origem, Conta destino, float valor)
        {
            origem.sacar(valor);
            origem.depositar(valor);
        }


    }
}
