/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    // Esta classe representa uma pilha usando array (vetor)
    public class Pilha
    {
            private int[] resultado; // elementos na pilha
            private int topo; // o elemento no topo da pilha
            private int maximo; // a quantidade máxima de elementos na pilha

            // construtor da classe Pilha
            public Pilha(int tamanho)
            {
                // constrói o vetor
                resultado = new int[tamanho];
                // define o topo como -1
                topo = -1;
                // ajusta o tamanho da pilha para o valor recebido
                maximo = tamanho;
            }

            // método usado para empilhar um novo elemento na pilha
            public void empilhar(int item)
            {
                // a pilha já está cheia?
                if (topo == (maximo - 1))
                {
                    Console.WriteLine("\nA pilha está cheia\n");
                    return;
                }
                else
                {
                    // vamos inserir este elemento no topo da pilha
                    resultado[++topo] = item;
                }
            }

            // méodo usado para desempilhar um elemento da pilha
            public int desempilhar()
            {
                // a pilha está vazia
                if (topo == -1)
                {
                    Console.WriteLine("\nA pilha está vazia\n");
                    return -1;
                }
                else
                {
                    Console.WriteLine("Elemento desempilhado: " + resultado[topo]);
                    return resultado[topo--];
                }
            }

            // método que permite imprimir o conteúdo da pilha
            public void imprimirPilha()
            {
                // pilha vazia
                if (topo == -1)
                {
                    Console.WriteLine("\nA pilha está vazia\n");
                    return;
                }
                else
                {
                    // vamos percorrer todos os elementos da pilha
                    for (int i = 0; i <= topo; i++)
                    {
                        Console.WriteLine("Item[" + (i + 1) + "]: " + resultado[i]);
                    }
                }
            }
        }
    }*/