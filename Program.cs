using System;
using System.Collections.Generic;

namespace Projeto_Whats_POO
{
    class Program
    {
        static void Main(string[] args)
        {
           Contato agenda = new Contato();
           agenda.Nome = "Vitor";
           agenda.Numero = 987654321;
           agenda.Status = "Disponível";
           

           Agenda agenda1 = new Agenda();

           agenda1.Cadastrar(agenda);

           agenda1.Excluir("Vitor");

           List<Contato> agenda2 = new List<Contato>();
           agenda2 = agenda1.Listar();

           foreach(Contato item in agenda2){
               Console.WriteLine($"{item.Nome} - {item.Numero} - {item.Status}");
           }

           

          

           
        }
    }
}
