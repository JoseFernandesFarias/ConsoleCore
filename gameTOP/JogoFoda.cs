using System;
using gameTOP.lib;
using gameTOP.Interface;
namespace gameTOP
{
    public class JogoFODA
    {

        private readonly IJogador _jogador1;
        private readonly IJogador _jogador2;

        public JogoFODA(IJogador jogador1, IJogador jogador2)
        {
            this._jogador1 = jogador1;
            this._jogador2 = jogador2;
        }


        public void IniciarJogo()
        {
            Console.Write(_jogador1.Correr());
            Console.Write(_jogador1.Chutar());
            Console.Write(_jogador1.Passar());
            Console.Write("SE DEUS QUISER EU VENCEREI\n");
            Console.Write(_jogador2.Correr());
            Console.Write(_jogador2.Chutar());
            Console.Write(_jogador2.Passar());


        }

    }
}