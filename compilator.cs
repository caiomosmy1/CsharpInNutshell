using System;
using System.Threading;

class Program
{
    static void Main()
    {
        //Criacao dd thread apontando para o mesmo metodo de distribuição 
        Thread novaThread = new Threand(ExecutarTarefa)

        // Inicia execução
        novaThread.Start();

        Console.WriteLine("Thread principal continua rodando");
    
    }
    static void ExecutarTarefa()
    {
        Console.WriteLine("Tarefa Executada em um nova Thread");
    }
}