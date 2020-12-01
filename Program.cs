using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Personagem objetoPersonagem1 = new Personagem();

            objetoPersonagem1.nome = "Renato";
            objetoPersonagem1.idade = 23;
            objetoPersonagem1.armadura = "Fulltec Ancient";

            Personagem objetoPersonagem2 = new Personagem();

            objetoPersonagem2.nome = "Tiago";
            objetoPersonagem2.idade = 20;
            objetoPersonagem2.armadura = " Relikia full Ancient";


            Console.WriteLine($"Personagem 1 = {objetoPersonagem1.nome} - {objetoPersonagem1.Atacar()}");
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem1.Defender()}");
            
            Console.WriteLine($"Personagem 1 = {objetoPersonagem1.nome} - {objetoPersonagem1.Atacar1()}");
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem1.Defender1()}");



        }
    }
}
