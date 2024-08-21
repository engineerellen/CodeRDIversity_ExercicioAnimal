namespace Domain
{
    public abstract class Mamifero : IAnimal
    {
        public int ID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public ETipoIdade TipoIdade { get; set; }

        public Mamifero()
        {

        }

        public virtual string Nascer() => $"Silvio Santos acabou de reeencarnar em: {Nome} ";

        public virtual string Crescer(int idade, ETipoIdade tipoIdade) =>
            $"Está crescendo!";

        public virtual string Morrer() => $"Bem vindo ao Gigante Vascão, {Nome}! ";

    }
}