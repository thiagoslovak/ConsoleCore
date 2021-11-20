using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA 
{
    private readonly IJogador _jogadorA;
    private readonly IJogador _jogadorB;
    public JogoFODA(IJogador jogadorA, IJogador jogadorB) 
    {
        _jogadorA = jogadorA;
        _jogadorB = jogadorB;
    }
    public void IniciarJogo()
    {
        Console.Write(_jogadorA.Corre());
        Console.Write(_jogadorA.Chuta());
        Console.Write(_jogadorA.Passe());

        Console.Write("\n ---------------------- PROXIMO JOGADOR ---------------------- \n");

        Console.Write(_jogadorB.Corre());
        Console.Write(_jogadorB.Chuta());
        Console.Write(_jogadorB.Passe());
    }
}
}