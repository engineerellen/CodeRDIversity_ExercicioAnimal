namespace Domain
{
    internal interface IAnimal
    {
        int ID { get; set; }
        string Nome { get; set; }
        int Idade { get; set; }
        ETipoIdade TipoIdade { get; set; }

        string Nascer();
        string Crescer(int idade, ETipoIdade tipoIdade);
        string Morrer();
    }
}
