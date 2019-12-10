using Game.Interface;

namespace Game.Lib
{
    public class Jogador2 : IJogador
    {
        public string _Nome { get; set; }

        public Jogador2(string nome)
        {
            _Nome = nome;
        }
        public string Chuta()
        {
            return $"{_Nome} está Chutando. \n";
        }

        public string Corre()
        {
            return $"{_Nome} está Correndo. \n";
        }

        public string Passe()
        {
            return $"{_Nome} está dando um Passe..";
        }
    }
}
