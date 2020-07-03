using System.Collections.Generic;

namespace Projeto_Whats_POO
{
    public interface IAgenda
    {
         void Cadastrar(Contato _cont);
         void Excluir(string _contato);
         List<Contato> Listar();
    }
}