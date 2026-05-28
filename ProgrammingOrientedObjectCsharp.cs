/*# FUNDAMENTO
### Abstração
#### Processo a qual se isolam características de um objeto, considerando os que tenham em comum certos grupos de objetos.
Classe abstrata (não pode ser instanciada)*/

public abstract class Veiculo
{
    public string Marca { get; set; }

    // Método abstrato (as classes filhas são OBRIGADAS a implementar)
    public abstract void LigarMotor();

    // Método comum (padrão para todos)
    public void DesligarMotor()
    {
        Console.WriteLine("Motor desligado.");
    }
}

// Classe concreta (herda de Veiculo e implementa o método abstrato)
public class Carro : Veiculo
{
    public override void LigarMotor()
    {
        Console.WriteLine("O motor do carro foi ligado com a chave.");
    }
}






// ### REUSO
// #### Herança, criando classes a partir de outra classe, aproveitando o código (dados ou comportamento) da camada classe mãe*/

public class Animal 
{
    public string Nome { get; set; }
    
    public void Alimentar() 
    {
        Console.WriteLine($"{Nome} está comendo.");
    }
}

// A classe Cachorro reutiliza os dados e métodos de Animal
public class Cachorro : Animal 
{
    public void Latir() 
    {
        Console.WriteLine("Au Au!");
    }
}


// ESCAPSULAMENTO
/*No caso, a complexidade que desejamos esconder é a de implemetação de alguma necessidade. Com o encapsulamento, podemos 
esconder a forma como algo foi feito, dadno a quem precisa apenas o resultado gerado, apena o resultado é */

public class ContaBancaria
{
    // O saldo é privado, escondido do mundo exterior
    private decimal saldo;

    // Propriedade pública para interagir com o saldo privado
    public decimal Saldo
    {
        get { return saldo; }
        set 
        {
            // Regra de negócio: não permite saldo negativo
            if (value >= 0)
            {
                saldo = value;
            }
        }
    }
}



