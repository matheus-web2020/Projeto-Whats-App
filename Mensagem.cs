using System;

namespace Projeto_Whats_POO
{
    public class Mensagem 
    {
        public string Texto { get; set; }

        public Contato destinatário { get; set; }

        public void Enviar(Contato desti){
             
            Console.WriteLine($"Fulano: Olá {desti.Nome}, tudo bem?");
            Console.WriteLine($"Fulano: Sim, e você, como está?");
            Console.WriteLine($"{desti.Nome}: Estou bem. O que você está aprendendo no seu curso técnico {desti.Nome}?");
            Console.WriteLine($"Fulano: Nós estamos aprendendo linguagem C#. Já ouviu falar?");
            Console.WriteLine($"{desti.Nome}: Para falar a verdade não, mas e aí, está gostando?");
            Console.WriteLine($"Fulano: Sim, acho bem divertido programar.");
            Console.WriteLine($"{desti.Nome}: Ah, legal pô.");
            Console.WriteLine($"{desti.Nome}: Bom eu tenho que ir, preciso ir trabalhar, mas tarde conversamos, ok?");
            Console.WriteLine($"Fulano: Ok, até mais tarde então.");
        }


    }
}