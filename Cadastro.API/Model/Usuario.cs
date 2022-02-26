using System;

namespace Cadastro.API.Model
{
    public class Usuario
    {

        [Key]
        public int Id { get; set; }
        private string razSocCad { get; set; }
        private string cnpjCad { get; set; }
        private string endCad { get; set; }
        private string cepCad { get; set; }
        private string cidadeCad { get; set; }
        private string estadoCad { get; set; }
        private string socioCad { get; set; }
        private string cargoCad { get; set; }
        private string cpf1Cad { get; set; }
        private string rg1Cad { get; set; }
        private string cpf2Cad { get; set; }
        private string rg2Cad { get; set; }
        private string end2Cad { get; set; }
        private string cep2Cad { get; set; }
        private string data { get; set; }
        private string razSoc { get; set; }
        private string cnpj { get; set; }
        private string inscEst { get; set; }
        private string inscMun { get; set; }
        private string fone { get; set; }
        private string fone2 { get; set; }
        private string email { get; set; }
        private string nomeFin { get; set; }
        private string fone3 { get; set; }
        private string emailFin { get; set; }
        private string cargo { get; set; }
        private string contMv { get; set; }
        private string cep { get; set; }
        private int numero { get; set; }
        private string complemento { get; set; }
        private string rua { get; set; }
        private string bairro { get; set; }
        private string cidade { get; set; }
        private string estado { get; set; }
        private string conta { get; set; }
        private string agencia { get; set; }
        private int op { get; set; }
        private string banco { get; set; }
        private string favorecido { get; set; }
        private string razSoc3 { get; set; }
        private bool radio1 { get; set; }
        private bool radio2 { get; set; }
        private bool radio3 { get; set; }
        private bool radio4 { get; set; }
        private string textarea5 { get; set; }
        private string textarea6 { get; set; }
        private bool radio7 { get; set; }
        private string textarea7 { get; set; }
        private bool radio8 { get; set; }
        private string textarea8 { get; set; }
        private bool radio9 { get; set; }
        private string textarea9 { get; set; }
        private bool radio10 { get; set; }
        private string textarea10 { get; set; }
        private bool radio11 { get; set; }
        private string textarea11 { get; set; }
        private bool radio12 { get; set; }
        private string textarea12 { get; set; }
        private bool radio13 { get; set; }
        private string textarea13 { get; set; }
        private bool radio14 { get; set; }
        private bool radio15 { get; set; }
        private string textarea15 { get; set; }
        private bool radio16 { get; set; }
        private string textarea16 { get; set; }
        private bool radio17 { get; set; }
        private bool radio18 { get; set; }
        private bool radio19 { get; set; }
        private string textarea19 { get; set; }
        private bool radio20 { get; set; }
        private string data2 { get; set; }
        private string nomeLeg { get; set; }
        private string rgRep { get; set; }
        private string cargoRep { get; set; }
    }

    internal class KeyAttribute : Attribute
    {
    }
}