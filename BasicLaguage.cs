/*
Sintaxe básica
Tipos básicos
Tipos númericos
Boolean type e operatores
String Characters
Array
Variaveis e Parameters
Expressions e operatores
Operadores Nulos (Null Operators)
Statements
Namespaces

*/
//1. SINTAXE BÁSICA
using System; // importando bibliotecas básicas do sistema

namespace MeuPrimeiroProjeto {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Olá mundo!");
        }
    }
}

// using System: Permite usar comandos como Console.
// namespace: Organiza o código em "caixas" para evitar conflitos de nomes
// class: Onde o comportamento do código é definido
// Static void Main: O ponto de partida obrigatório

//VARIÁVEIS E TIPOS DE DADOS
  // O C# é fortemente tipado, o que significa que você precisa declarar o tipo da variável (embora o var ajude a simplificar).

/*
TIPO                                 DESCRIÇÃO                                      EXEMPLO
int                              números inteiros                              int idade = 25;
double                    números decimais(precisão simples)                   double preco = 19.90;
string                               textos                                    string nome = "Ana";
bool                            Verdadeiro ou falso                            bool estaAtivo = true;
char                            Um único caractere                             char inicial = "A";

*/

//Estrutura de controle(lógica)
// É como o programa toma decisões ou repete tarefas
// Codicionais
int hora = 14;
if (hora < 12) {
    Console.WriteLine("Bom dia!");
} else {
    Console.WriteLine("Boa Tarde!");
}

//Laço de repetições(Loops)

for (int i = 0; i < 5; i++) {
  Console.WriteLine($"Repetição número:{i}");
}

//Método(função)
//Métodos são blocos de código que realizam uma tarefa especifica e poem ser reutilizadas
// Estrutura: Tipo Retorno NomeMetodo(parametros)
public int Somar(int a + int b) {
  return a + b;
}

/*Aplicação Prática: Mini Calculadora
Método são bloco*/

using System;
class Calculadora {
  static void Main() {
    Console.WriteLine("---Calculadora de Soma");

    // Entrada de dados
    Console.Write("Digite o primeiro número: ");

    Console.Write("Digite o segundo número: ");

    // Processamento
    double resultado =num1 + num2;

    // Saída formatada(Interpolação de string)
    Console.WriteLine($"O resultado da soma entre {num1} e {num2} é: {resultado}");

    // Mantém o console aberto
    Console.WriteLine("Pressione qualquer tecla para sair...");
    Console.ReadKey();
    
  }
}




