namespace Domain
{
    public class Doguinho : Mamifero
    {
        public string Raca { get; set; }
        public Doguinho(int id, string nome, int idade, ETipoIdade tipoIdade, string raca)
        {
            ID = id;
            Nome = nome;
            Idade = idade;
            TipoIdade = tipoIdade;
            Raca = raca;
        }

        public override string Nascer() => base.Nascer() + $"da raça {Raca}";

        public override string Crescer(int idade, ETipoIdade tipoIdade) => base.Crescer(idade, tipoIdade);

        public override string Morrer() => base.Morrer();

    }
}
