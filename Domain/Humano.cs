namespace Domain
{
    public class Humano : Mamifero
    {
        public Humano(int id, string nome, int idade, ETipoIdade tipoIdade)
        {
            ID = id;
            Nome = nome;
            Idade = idade;
            TipoIdade = tipoIdade;
        }

        public override string Nascer() => $"Meu presente de Deus chegou! Bem vindo ao mundo {Nome}";

        public override string Crescer(int idade, ETipoIdade tipoIdade)
        {
            switch (tipoIdade)
            {
                case ETipoIdade.dia:
                    return $"Meu bebê {Nome} está completando mais um dia de vida. Agora são {idade + 1} dias.";

                case ETipoIdade.mes:
                    return $"Meu bebê {Nome} está completando mais um mesversário de {idade + 1} mês(es).";
                case ETipoIdade.ano:
                    return $"Feliz aniverário {Nome} está completando {idade + 1} anos";
            }
            return "Tipo de idade inválido!";
        }

        public override string Morrer() => base.Morrer();

    }
}