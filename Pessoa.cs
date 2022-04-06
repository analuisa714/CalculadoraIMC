public class Pessoa
{
    public string Nome { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }
    
    public Pessoa(string nome, float altura, float peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = peso;
    }
    public double CalcularIMC { get => Peso / (Altura*Altura); }
}