namespace CameraDeputados.Models;

public class Despesa
{
    public Guid Id { get; init; }
    public int DeputadoId { get; set; }
    public string DataEmissao { get; set; }
    public string Fornecedor { get; set; }
    public decimal ValorLiquido { get; set; }
    public string UrlNotaFiscal { get; set; }
    public Deputado? Deputado { get; set; }
    
    public Despesa(int deputadoId, string dataEmissao, string fornecedor, decimal valorLiquido, string urlDocumento)
    {
        Id = Guid.NewGuid();
        DeputadoId = deputadoId;
        DataEmissao = dataEmissao;
        Fornecedor = fornecedor;
        ValorLiquido = valorLiquido;
        UrlNotaFiscal = urlDocumento;
    }
    private Despesa() {}
}