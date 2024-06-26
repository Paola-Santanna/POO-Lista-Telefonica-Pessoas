﻿// Lista telefônica que cadastre 3 pessoas
string nome, sobrenome, telefone, celular, email;
int idade;

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();
Pessoa p3 = new Pessoa();

Pessoa CriarPessoa()
{
    Pessoa p = new Pessoa();

    Console.Write("Digite o seu nome: ");
    nome = Console.ReadLine();
    p.DefinirNome(nome);

    Console.Write("Digite o seu sobrenome: ");
    sobrenome = Console.ReadLine();
    p.DefinirSobrenome(sobrenome);

    Console.Write("Digite a sua idade: ");
    idade = int.Parse(Console.ReadLine());
    p.DefinirIdade(idade);

    Console.Write("Digite o seu telefone: ");
    telefone = Console.ReadLine();
    p.DefinirTelefone(telefone);

    Console.Write("Digite o seu celular: ");
    celular = Console.ReadLine();
    p.DefinirCelular(celular);

    Console.Write("Digite o seu email: ");
    email = Console.ReadLine();
    p.DefinirEmail(email);

    return p;
}

#region p1
p1 = CriarPessoa();
Console.WriteLine();
p1.MostrarDados();
#endregion

Console.WriteLine();
#region p2
p2 = CriarPessoa();
Console.WriteLine();
p2.MostrarDados();
#endregion

Console.WriteLine();
#region p3
p3 = CriarPessoa();
Console.WriteLine();
p3.MostrarDados();
#endregion