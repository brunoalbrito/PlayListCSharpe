using System;
using System.Collections.Generic;

namespace PlayList{
    public class Autor{
        public int IdAutor{get;set;}

        public string Nome{get;set;}

        public string Sobrenome{get;set;}

        public string Nacionalidade{get;set;}

        public IList<Musica> Musicas{get;set;}
    }
}