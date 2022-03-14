using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Cadastro.API.Model
{
    public class Usuario
    {
        public long Id { get; set; }
        
        public string socioCad { get; set; }
        
        public string cargoCad { get; set; }
        
        public string cpf1Cad { get; set; }
        
        public string rg1Cad { get; set; }
        
        public string percentPart1 { get; set; }
        //[Required]
        //public string socio2Cad { get; set; }
        //[Required]
        //public string cargo2Cad { get; set; }
        //[Required]
        //public string cpf2Cad { get; set; }
        //[Required]
        //public string rg2Cad { get; set; }
        //[Required]
        //public string percentPart2 { get; set; }
        
        public string end2Cad { get; set; }
        
        public string cep2Cad { get; set; }
        [Required]
        public string numFunc { get; set; }
        [Required]
        public string data { get; set; }
        [Required]
        public string razSoc { get; set; }
        [Required]
        public string cnpj { get; set; }
        [Required]
        public string inscEst { get; set; }
        [Required]
        public string inscMun { get; set; }
        [Required]
        public string fone { get; set; }
        [Required]
        public string fone2 { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string nomeFin { get; set; }
        [Required]
        public string fone3 { get; set; }
        [Required]
        public string emailFin { get; set; }
        [Required]
        public string cargo { get; set; }
        [Required]
        public string contMv { get; set; }
        [Required]
        public string cep { get; set; }
        [Required]
        public int? numero { get; set; }
        public string complemento { get; set; }
        [Required]
        public string rua { get; set; }
        [Required]
        public string bairro { get; set; }
        [Required]
        public string cidade { get; set; }
        [Required]
        public string estado { get; set; }
        [Required]
        public string conta { get; set; }
        [Required]
        public string agencia { get; set; }
        [Required]
        public string op { get; set; }
        [Required]
        public string banco { get; set; }
        [Required]
        public string favorecido { get; set; }
        [Required]
        public bool Quest1 { get; set; }
        [Required]
        public bool Quest2 { get; set; }
        [Required]
        public bool Quest3 { get; set; }
        [Required]
        public bool Quest4 { get; set; }
        public string textarea5 { get; set; }
        public string textarea6 { get; set; }
        [Required]
        public bool Quest7 { get; set; }
        public string textarea7 { get; set; }
        [Required]
        public bool Quest8 { get; set; }
        public string textarea8 { get; set; }
        [Required]
        public bool Quest9 { get; set; }
        public string textarea9 { get; set; }
        [Required]
        public bool Quest10 { get; set; }
        public string textarea10 { get; set; }
        [Required]
        public bool Quest11 { get; set; }
        public string textarea11 { get; set; }
        [Required]
        public bool Quest12 { get; set; }
        public string textarea12 { get; set; }
        [Required]
        public bool Quest13 { get; set; }
        public string textarea13 { get; set; }
        [Required]
        public bool Quest14 { get; set; }
        [Required]
        public bool Quest15 { get; set; }
        public string textarea15 { get; set; }
        [Required]
        public bool Quest16 { get; set; }
        public string textarea16 { get; set; }
        [Required]
        public bool Quest17 { get; set; }
        [Required]
        public bool Quest18 { get; set; }
        [Required]
        public bool Quest19 { get; set; }
        public string textarea19 { get; set; }
        [Required]
        public bool Quest20 { get; set; }
        [Required]
        public string data2 { get; set; }
        [Required]
        public string nomeLeg { get; set; }
        [Required]
        public string rgRep { get; set; }
        [Required]
        public string cargoRep { get; set; }

        public Socio Socios { get; set; }
    }

}