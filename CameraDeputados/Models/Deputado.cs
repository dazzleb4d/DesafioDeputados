namespace CameraDeputados.Models;

public class Deputado
{
    public Deputado(string nome, string uf, string cpf, string partido)
    {
        Nome = nome;
        Uf = uf;
        CPF = cpf;
        Partido = partido;
    }

    private Deputado()
    {
    }
    
    public int Id { get; init; }
    public string Nome { get; set; }
    public string Uf { get; set; }
    public string CPF { get; set; }
    public string Partido { get; set; }
    public ICollection<Despesa> Despesas { get; set; }
}