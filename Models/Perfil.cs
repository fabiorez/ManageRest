using System;
using System.Collections.Generic;

namespace ManageRest.Models {
    public class Perfil
    {
        public int Id {get; set;}
        public int Nome {get;set;}
        public DateTime DataCadastro {get;set;}
        public string Descricao { get; set; }
        public IEnumerable<Operador> Operadores {get;set;}
    }
}