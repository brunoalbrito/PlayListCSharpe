using System;
using System.Collections.Generic;

namespace PlayList
{
    public class Musica
    {
        public int IdMusica{get;set;}

        public string Nome{get;set;}

        public double Duracao{get;set;}

        public IList<Autor> Autores{get;set;}
    }
}
