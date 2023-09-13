using System;
namespace Calculadora
{
    public class Calculadora
    {
        
        public Operacoes calcular(Operacoes operacao)
        {

            switch(operacao.operador)
            {
                case '+': operacao.resultado = soma(operacao); break;
                case '-': operacao.resultado = subtracao(operacao); break;
                case '*': operacao.resultado = multiplicacao(operacao); break;
                case '/': operacao.resultado = divisao(operacao); break;  //Implementação da operação divisão
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }
        public long soma(Operacoes operacao)  //Alteração dos tipos de dados de int para long
        {
            return operacao.valorA + operacao.valorB;
        }
        public long subtracao(Operacoes operacao)  //Alteração dos tipos de dados de int para long
        {
            return operacao.valorA - operacao.valorB;
        }
        public long multiplicacao(Operacoes operacao)  //Alteração dos tipos de dados de int para long
        {
            return operacao.valorA * operacao.valorB;
        }
        public decimal divisao(Operacoes operacao)  //Inclusão do metodo divisão
        {
            return operacao.valorA / operacao.valorB;
        }

    }
}
