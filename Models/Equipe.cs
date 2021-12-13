using e_jogos.Interface;
using System.IO;

namespace e_jogos.Models
{
    public class Equipe : EjogosBase, IEquipe
    {

        private const string path = "Database/equipe.csv";

        public Equipe()
        {
            CreateFolderAndFile(path);
        }

        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        //criar uma função que vai converter de string para o tipo equipe;

        private string Prepare(Equipe e)
        {
            return $"{e.IdEquipe};{e.Nome};{e.Imagem}";
        }


        public void Create(Equipe nova_equipe)
        {
            //receber um objeto de equipe.
            //e gravar no CSV.
            //

            //  "item;item;item;";

            string[] linha = { Prepare(nova_equipe) };

            File.AppendAllLines(path, linha);
        }


        public void Delete(int dEquipe)
        {
            throw new System.NotImplementedException();
        }

        public list<Equipe> ReadAll()
        {
            list<Equipe> equipe = new list<Equipe>();
            string[] linhas = File.ReadAllLines(path);

            foreach (string item in linhas)
            {
                Equipe equipe = new Equipe();
                equipe.IdEquipe = int.Parse(item.Split(';')[0]);
                equipe.Nome = item.Split(';')[1];
                equipe.Imagem = item.Split(';')[2];

                equipes.Add(equipe);
            }

            return equipes;

        }

        public void Update(Equipe equipe)
        {
            throw new System.NotImplementedException();
        }
    }
}
