using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancarioHeranca.Model
{
    class Conta
    {
        //Atributos
        private int numero;
        private double saldo;

        // Mé
        // todos de SET e GET
        public int getNumero()
        {
            return numero;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public double getSaldo()
        {
            return saldo;
        }
        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        // Construtores

        public Conta()
        {
            this.numero = 0;
            this.saldo = 0;
        }

        public Conta(int numero, double saldo)
        {
            this.numero = numero;
            this.saldo = saldo;
        }

        public Conta(int numero)
        {
            this.numero = numero;
            this.saldo = 0;
        }
        // Métodos
        public virtual void depositar(double valor)
        {
            if(valor > 0)
            {
                setSaldo(getSaldo() + (valor));
            }
           
        }
        public virtual bool sacar(double valor)
        {
            if(getSaldo()>=valor && getSaldo() > 0 )
            {
                setSaldo(getSaldo()-(valor));
                return true;
            }
            return false;
        }
        public virtual string transferir(double valor, Conta destino)
        {
            if(sacar(valor) && valor > 0)
            {
                destino.depositar(valor);
                return "o valor " + valor + " foi transferido com sucesso";
            }
            else
            {
                return "Valor para transferência insuficiente\nSaldo Atual: " + getSaldo();
            }
        }
        public virtual string consultarSaldo()
        {
            return  "o número da conta é: " + getNumero() +
                    "\nO saldo é:" + getSaldo();
        }
    }
}
