using BancarioHeranca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace BancarioHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc= new ContaCorrente(212423, 100, 1000, 0);
            ContaPoupanca cp= new ContaPoupanca(212429, 400, 0);

            int op = 0, op2 = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Conta Corrente\n2 - Conta Poupança\n0 - Sair");
                op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch(op)
                {
                    case 0:
                        Environment.Exit(1);
                        break;
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("1 - Depositar\n2 - Sacar\n3 - Transferir\n4 - Consultar Saldo\n5 - Calcular Juros Cheque Especial\n0 - Voltar para Menu inicial");
                            op2 = int.Parse(Console.ReadLine());
                            Console.Clear();

                           switch(op2)
                            {
                                case 0:
                                    break;
                                case 1:
                                    Console.WriteLine("Digite o valor para depósito: ");
                                    double valor = double.Parse(Console.ReadLine());
                                    cc.depositar(valor);
                                    Console.WriteLine("Valor depositado com sucesso!");
                                    break;
                                case 2:
                                    Console.WriteLine("Digite o valor para sacar: ");
                                    valor = double.Parse(Console.ReadLine());
                                    if(cc.sacar(valor))
                                    {
                                        Console.WriteLine("Saque foi efetuado com sucesso!");
                                    }else
                                    {
                                        Console.WriteLine("Saque não foi efetuado!");
                                    }
                                    break;
                                case 3:
                                    Conta destino = new Conta();
                                    Console.WriteLine("Digite o número da conta para transferência: ");
                                    destino.setNumero(int.Parse(Console.ReadLine()));
                                    Console.WriteLine("Digite o valor da transferência: ");
                                    valor = double.Parse(Console.ReadLine());
                                    cc.transferir(valor, destino);
                                    break;
                                case 4:
                                    Console.Write(cc.consultarSaldo());
                                    break;
                                case 5:
                                    Console.WriteLine("Digite o valor da taxa em %: ");
                                    double taxa = double.Parse(Console.ReadLine());
                                    cc.calcularJuros(taxa);
                                    break;
                            }
                            Console.ReadKey();
                        } while (op2!=0);
                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("1 - Depositar\n2 - Sacar\n3 - Transferir\n4 - Consultar Saldo\n5 - Calcular Rendimentos\n0 - Voltar para Menu inicial");
                            op2 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            switch (op2)
                            {
                                case 0:
                                    break;
                                case 1:
                                    Console.WriteLine("Digite o valor para depósito: ");
                                    double valor = double.Parse(Console.ReadLine());
                                    cp.depositar(valor);
                                    Console.WriteLine("Valor depositado com sucesso!");
                                    break;
                                case 2:
                                    Console.WriteLine("Digite o valor para sacar: ");
                                    valor = double.Parse(Console.ReadLine());
                                    if (cp.sacar(valor))
                                    {
                                        Console.WriteLine("Saque foi efetuado com sucesso!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Saque não foi efetuado!");
                                    }
                                    break;
                                case 3:
                                    Conta destino = new Conta();
                                    Console.WriteLine("Digite o número da conta para transferência: ");
                                    destino.setNumero(int.Parse(Console.ReadLine()));
                                    Console.WriteLine("Digite o valor da transferência: ");
                                    valor = double.Parse(Console.ReadLine());
                                    cp.transferir(valor, destino);
                                    break;
                                case 4:
                                    Console.Write(cp.consultarSaldo());
                                    break;
                                case 5:
                                    Console.WriteLine("Digite o valor da taxa em %: ");
                                    double taxa = double.Parse(Console.ReadLine());
                                    cp.calcularRendimento(taxa);
                                    break;
                            }
                            Console.ReadKey();
                        } while (op2 != 0);
                        break;
                }
          
  
            } while(op!=0);
        }
    }
}
