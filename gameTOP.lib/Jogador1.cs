using System;
using gameTOP.Interface;

namespace gameTOP.lib
{
     public class Jogador1 : IJogador
    {
        private readonly string _nome;

        public Jogador1(string Nome)
        {
            this._nome = Nome;

        }


        //Correr
        public string Correr()
        {
             return  $"{_nome} está correndo\n";
        }
        //chuta
        public string Chutar()
        {
             return  $"{_nome} está chutando\n";
        }

        //passe
        public string Passar()
        {
             return  $"{_nome} está passando\n";
        }
    }

}