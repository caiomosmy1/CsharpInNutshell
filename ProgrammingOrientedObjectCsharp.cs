/*# FUNDAMENTO
### Abstração
#### Processo a qual se isolam características de um objeto, considerando os que tenham em comum certos grupos de objetos.

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
No caso, a complexidade que desejamos esconder é a de implemetação de alguma necessidade. Com o encapsulamento, podemos 
esconder a forma como algo foi feito, dadno a quem precisa apenas o resultado gerado, apena o resultado é relevante

*/
