using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "\nMaradona estas pateando";
        }

        public string Corre()
        {
            return "\nMaradona estas corriendo";
        }

        public string Passe()
        {
            return "\nMaradona estas pasando";
        }
    }
}