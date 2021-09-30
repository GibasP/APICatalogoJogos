using APICatalogoJogos.InputModel;
using APICatalogoJogos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogoJogos.Service
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInpultModel jogo);
        Task Atualizar(Guid id, JogoInpultModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}
