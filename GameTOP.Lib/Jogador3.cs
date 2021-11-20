using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : IJogador
    {
        public string Chuta()
        {
            return "Teste Chuta \n";
        }

        public string Corre()
        {
            return "Teste Corre \n";
        }

        public string Passe()
        {
            return "Teste Passe \n";
        }
    }
}