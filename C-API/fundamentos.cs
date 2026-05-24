// HTTP
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class ApiService
{
    private readonly HttpClient _client;

    public ApiService(HttpClient client)
    {
        _client = client;
        // Configurações padrão podem ser feitas aqui
        _client.BaseAddress = new Uri("https://exemplo.com");
    }

    public async Task<MeuDado?> ObterDadosAsync()
    {
        // Realiza a requisição e desserializa o JSON automaticamente
        var resultado = await _client.GetFromJsonAsync<MeuDado>("recurso/1");
        return resultado;
    }
}

public class MeuDado
{
    public int Id { get; set; }
    public string? Nome { get; set; }
}


// Headers

// Status code

// Request/Response lifecycle

// JSON

// Cookies vs tokens

// Stateless vs stateful
