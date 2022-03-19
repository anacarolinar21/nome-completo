string nome, sobrenome, SOBRENOME;

Console.WriteLine("digite seub primeiro nome:");
nome = Console.ReadLine()!;

Console.WriteLine("digite seu sobrenome:");
sobrenome = Console.ReadLine()!;

SOBRENOME=sobrenome.ToUpper();

Console.WriteLine ($"nome completo: {nome} {sobrenome}"!);
Console.WriteLine($"nome de catalogo: {SOBRENOME} {nome} "!);