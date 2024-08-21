
using Domain;

var bebe = new Humano(1, "Noah", 0, ETipoIdade.mes);
var adultoHomemCis = new Humano(2, "Ricardo", 35, ETipoIdade.ano);

Mamifero doguinho = new Doguinho(3, "Totó", 1, ETipoIdade.ano, "shtizu");

Console.WriteLine(bebe.Nascer());
Console.WriteLine(bebe.Crescer(0, ETipoIdade.mes));

Console.WriteLine(adultoHomemCis.Crescer(35, ETipoIdade.ano));
Console.WriteLine(adultoHomemCis.Morrer());

Console.WriteLine(doguinho.Nascer());
Console.WriteLine(doguinho.Crescer(1, ETipoIdade.ano));
Console.WriteLine(doguinho.Morrer());