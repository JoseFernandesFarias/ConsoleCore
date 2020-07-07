using System;
using gameTOP.Interface;
using gameTOP.lib;
namespace gameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador1("JOSE FERNANDES FARIAS"), new Jogador2("Jose Fernandes Farias"));
            jogo.IniciarJogo();
        }
    }   



    
}
