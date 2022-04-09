using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancarioHeranca.Model
{
    class ContaPoupanca : Conta
    {
        //atributos
        private double reajusteMensal;

        //Métodos GET e SET

        public double getReajusteMensal()
        {
            return reajusteMensal;
        }
        public void setReajusteMensal(double reajusteMensal)
        {
            this.reajusteMensal = reajusteMensal;
        }

        //Construtores
        public ContaPoupanca(): base()
        {
            this.reajusteMensal = 0;
        }
        public ContaPoupanca(int numero, double saldo, double reajusteMensal): base(numero, saldo)
        {
            this.reajusteMensal = reajusteMensal;
        }
        //Métodos
        public void calcularRendimento(double taxa)
        {
            if(taxa>0 && getSaldo() > 0)
            {
                setReajusteMensal(getSaldo() * taxa / 100);
                atualizarSaldo();
            }
        }
        private void atualizarSaldo()
        {
            setSaldo(getSaldo() + getReajusteMensal());
        }
    }
}
