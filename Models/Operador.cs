using System;
using System.Collections.Generic;

namespace ManageRest.Models {
    public class Operador
    {
        public int Id {get; set;}
        public int Nome {get;set;}
        public string Email { get; set; }
        public string HashSenha {get; set;}
        public string Fixo {get; set;}
        public string Celular {get; set;}
        public string Observacao {get; set;}
        public string Cpf {get; set;}
        public DateTime DataCadastro {get;set;}
        public int PerfilId { get; set; }
        public Perfil Perfil {get;set;}
    }
}