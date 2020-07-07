using System;
using gameTOP.Interface;

namespace gameTOP.lib
{
    public class Jogador2 : IJogador
    {
       private readonly string _nome;

        public Jogador2(string Nome)
        {
            this._nome = Nome;

        }


        //Correr
        public string Correr()
        {
            return $"{_nome} está corriendo\n";
        }
        //chuta
        public string Chutar()
        {
            return $"{_nome} está Patiando\n";
        }

        //passe
        public string Passar()
        {
            return $"{_nome} está pasando\n";
        }
    }
}