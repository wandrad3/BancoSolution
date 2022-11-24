using System;
using System.Collections.Generic;
using System.Text;
using Banco.Iinterfaces;

namespace Banco.Entities
{
    class ContaCorrente : Conta, IConta
    {
        public float Saldo { get => Saldo; set => Saldo = value; }
        public override float depositar(float valor) => Saldo + valor;

        public override float sacar(float valor) => Saldo - valor;

        void IConta.transferir(Conta origem, Conta destino, float valor)
        {
            origem.sacar(valor);
            origem.depositar(valor);
        }

        public float obterSaldo()
        {
            return saldo;
        }

    }
}

//TESTE2
