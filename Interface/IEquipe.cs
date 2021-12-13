using e_jogos.Models;

namespace e_jogos.Interface
{
    public interface IEquipe
    {
        void Create(Equipe nova_equipe);

        list<Equipe> ReadAll();

        void Update(Equipe equipe);

        void Delete(int dEquipe);



    }
}
