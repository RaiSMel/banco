using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancarioHeranca.Model
{
    class ContaCorrente: Conta      
    {
        //atributos
        private double limite;
        private double jurosChequeEspecial;

        //Métodos GET e SET
        public double getLimite()
        {
            return limite;
        }
        public void setLimite(double limite)
        {
            this.limite = limite;
        }

        public double getJurosChequeEspecial()
        {
            return jurosChequeEspecial;
        }
        public void setJurosChequeEspecial(double jurosChequeEspecial)
        {
            this.jurosChequeEspecial = jurosChequeEspecial;
        }

        //Construtores
        public ContaCorrente(): base()
        {
            this.limite= 0;
            this.jurosChequeEspecial = 0;
        }
        public ContaCorrente(int numero, double saldo, double limite, double jurosChequeEspecial)
            :base(numero, saldo)
        {
            this.limite = limite;
            this.jurosChequeEspecial = jurosChequeEspecial;
        }   

        //Métodos
        public override bool sacar(double valor)
        {
            if (valor > 0 && getSaldo() + getLimite() >= valor)
            {
                setSaldo(getSaldo()- valor);
                return true;
            }
                return false;
        }
        public void calcularJuros(double taxa)
        {
                if(taxa>0 && getSaldo()<0)
                {
                setJurosChequeEspecial(taxa/100*(-getSaldo()));
                }

        }
        public override string consultarSaldo()
        {
            return base.consultarSaldo() +
                    "\nO limite é: " + getLimite() +
                   "\nO valor do juros em cheque especial: " + getJurosChequeEspecial();
        }

    }
}

