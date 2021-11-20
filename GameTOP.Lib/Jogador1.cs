using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1: IJogador
{
    public readonly string _Nome;

    public Jogador1(string Nome = "Ronaldo") //Construtor
    {
        _Nome = Nome;
    }
    //Chuta
    public string Chuta()
    {
        return $"{_Nome} está Chutando\n";
    }
    //Corre
    public string Corre()
    {
       return $"{_Nome} está Correndo\n";
    }
    //Passe
    public string Passe()
    {
        return $"{_Nome} está Passando\n";
    }

}
}