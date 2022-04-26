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

    public void FaixaPeso (double imc)
    {
        if (imc < 18.5)
        {
            Console.WriteLine("A sua faixa é: 'abaixo do peso'");
        }else
        {
            if (imc >= 18.5 && imc <= 24.9) 
            {
                Console.WriteLine("A sua faixa é: 'peso saudável'");
            }else
            {
                if (imc >= 25 && imc <=29.9)
                {
                    Console.WriteLine("A sua faixa é: 'sobrepeso'");
                }else
                {
                    if (imc >= 30 && imc <=39.9)
                    {   
                        Console.WriteLine("A sua faixa é: 'obeso'");
                    }else
                    {
                        if (imc >= 40)
                        {
                            Console.WriteLine("A sua faixa é: 'muito obeso'");
                        }
                    }
                }
            }
        }
    }
    public void PesoIdeal (double imc)
    {
        if (imc < 18.5)
        {
            double pesoIdeal = ((Altura*Altura)*18.5)-Peso;
            Console.WriteLine("É preciso ganhar {0} quilos para chegar ao seu peso ideal", pesoIdeal);
        }
        else
        {
            double pesoIdeal = Peso-((Altura*Altura)*24.99);
            Console.WriteLine("É preciso perder {0} quilos para chegar ao seu peso ideal", pesoIdeal);
        }
    }
}