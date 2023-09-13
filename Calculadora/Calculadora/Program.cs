using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando empilhamento da fila de operações
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });

            // Criando empilhamento dos resultados das operações
            Stack<Operacoes> pilhaOperacoes = new Stack<Operacoes>();

            Calculadora calculadora = new Calculadora();

            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);

                // Inserindo o resultado na pilha
                pilhaOperacoes.Push(operacao);
            }

            Console.WriteLine("Inicio da Pilha:");

            // Laço de repetição que percorre toda a pilha com os resultados da operação
            while (pilhaOperacoes.Count > 0)
            {
                Operacoes operacao = pilhaOperacoes.Pop();
                Console.WriteLine("{0}", operacao.resultado);
            }
           
        }
    }
}
