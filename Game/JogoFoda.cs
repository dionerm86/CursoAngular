using Game.Interface;

namespace Game
{
    public class JogoFoda
    {
        private IJogador _jogador1;

        private IJogador _jogador2;

        public JogoFoda(IJogador jogador1, IJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }

        public void IniciarJogo()
        {
            System.Console.Write(_jogador1.Corre());
            System.Console.Write(_jogador1.Chuta());
            System.Console.Write(_jogador1.Passe());
            System.Console.Write("\nPróximo Jogador n");
            System.Console.Write(_jogador2.Corre());
            System.Console.Write(_jogador2.Chuta());
            System.Console.Write(_jogador2.Passe());
        }
    }
}