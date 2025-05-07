namespace CandidatosModel;
public class CandidatoModel
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required string Partido { get; set; }
    public int Idade { get; set; }
}