using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implemente o calculo de divisao

            Calculadora calculadora = new Calculadora();

            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue(); //Substituição do metodo Peek para o metodo Dequeue
                calculadora.calcular(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);

            }
            /*
            // vamos criar uma nova pilha com capacidade para 5 elementos
            Operacoes pilha = new Operacoes();

            // vamos empilhar 3 elementos
            pilha.empilhar(12);

            // vamos mostrar os elementos na pilha
            Console.WriteLine("Itens presentes na Pilha\n");
            pilha.imprimirPilha();

            // agora vamos remover e retornar dois elementos da pilha
            Console.WriteLine();
            pilha.desempilhar();
            pilha.desempilhar();

            // vamos mostrar os elementos na pilha novamente
            Console.WriteLine("\nItens presentes na Pilha\n");
            pilha.imprimirPilha();

            Console.WriteLine("Pressione uma tecla para sair...");
            Console.ReadKey();*/
        }
    }
}




/*filaOperacoes.Add(2);

            string strFilaOperacoes = String.Empty;

            foreach (int numero in filaOperacoes)
            {
                strFilaOperacoes += "\n" + numero.ToString();
            }

            Console.WriteLine("Lista de valores: " + strFilaOperacoes);*/