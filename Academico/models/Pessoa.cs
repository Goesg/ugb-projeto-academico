using System;

namespace Academico.models;

public abstract class Pessoa
{
    public string Nome { get; protected set; }
    public float Altura {get; set;}
    
    public abstract void Respirar();
    public void Envelhecer(){
        Console.WriteLine("Voce ficou mais velho");
    }
}
