using System;

namespace Academico.models;

public class Aluno : Pessoa
{
    public void DefinirNome(string nome)
    {
        Nome = nome;
    }

    public override void Respirar()
    {
        Console.WriteLine("Respirando...");
        Envelhecer();
    }
}
