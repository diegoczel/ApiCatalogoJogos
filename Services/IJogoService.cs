using ApiCatalogoJogos.InputModel;
using ApiCatalogoJogos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Services
{
    public interface IJogoService : IDisposable
    {
        // seria um get all com paginação
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);

        // seria get de 1 jogo
        Task<JogoViewModel> Obter(Guid id);

        // seria o post
        Task<JogoViewModel> Inserir(JogoInputModel jogo);

        // seria o put
        Task Atualizar(Guid id, JogoInputModel jogo);

        // seria o patch
        Task Atualizar(Guid id, double preco);

        // seria o delete
        Task Remover(Guid id);
    }
}
