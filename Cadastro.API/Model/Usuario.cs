/*using System.ComponentModel.DataAnnotations;

namespace Cadastro.API.Model
{
    public class Usuario
    {
        public long Id { get; set; }
        [Required]
        public string razSocCad { get; set; }
        [Required]
        public string cnpjCad { get; set; }
        [Required]
        public string endCad { get; set; }
        [Required]
        public string cepCad { get; set; }
        [Required]
        public string cidadeCad { get; set; }
        [Required]
        public string estadoCad { get; set; }
        [Required]
        public string socioCad { get; set; }
        [Required]
        public string cargoCad { get; set; }
        [Required]
        public string cpf1Cad { get; set; }
        [Required]
        public string rg1Cad { get; set; }
        [Required]
        public string cpf2Cad { get; set; }
        [Required]
        public string rg2Cad { get; set; }
        [Required]
        public string end2Cad { get; set; }
        [Required]
        public string cep2Cad { get; set; }
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
        public string razSoc3 { get; set; }
        [Required]
        public bool radio1 { get; set; }
        [Required]
        public bool radio2 { get; set; }
        [Required]
        public bool radio3 { get; set; }
        [Required]
        public bool radio4 { get; set; }
        public string textarea5 { get; set; }
        public string textarea6 { get; set; }
        [Required]
        public bool radio7 { get; set; }
        public string textarea7 { get; set; }
        [Required]
        public bool radio8 { get; set; }
        public string textarea8 { get; set; }
        [Required]
        public bool radio9 { get; set; }
        public string textarea9 { get; set; }
        [Required]
        public bool radio10 { get; set; }
        public string textarea10 { get; set; }
        [Required]
        public bool radio11 { get; set; }
        public string textarea11 { get; set; }
        [Required]
        public bool radio12 { get; set; }
        public string textarea12 { get; set; }
        [Required]
        public bool radio13 { get; set; }
        public string textarea13 { get; set; }
        [Required]
        public bool radio14 { get; set; }
        [Required]
        public bool radio15 { get; set; }
        public string textarea15 { get; set; }
        [Required]
        public bool radio16 { get; set; }
        public string textarea16 { get; set; }
        [Required]
        public bool radio17 { get; set; }
        [Required]
        public bool radio18 { get; set; }
        [Required]
        public bool radio19 { get; set; }
        public string textarea19 { get; set; }
        [Required]
        public bool radio20 { get; set; }
        [Required]
        public string data2 { get; set; }
        [Required]
        public string nomeLeg { get; set; }
        [Required]
        public string rgRep { get; set; }
        [Required]
        public string cargoRep { get; set; }
    }

}
*/

using System.ComponentModel.DataAnnotations;

namespace Cadastro.API.Model
{
    public class Usuario
    {
        public long Id { get; set; }
        [Required]
        public string razSocCad { get; set; }
        [Required]
        public string cnpjCad { get; set; }
        [Required]
        public string endCad { get; set; }
        [Required]
        public string cepCad { get; set; }
        [Required]
        public string cidadeCad { get; set; }
        [Required]
        public string estadoCad { get; set; }
        [Required]
        public string socioCad { get; set; }
        [Required]
        public string cargoCad { get; set; }
        [Required]
        public string cpf1Cad { get; set; }
        [Required]
        public string rg1Cad { get; set; }
        [Required]
        public string cpf2Cad { get; set; }
        [Required]
        public string rg2Cad { get; set; }
        [Required]
        public string end2Cad { get; set; }
        [Required]
        public string cep2Cad { get; set; }
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
        public string razSoc3 { get; set; }
        [Required]
        public bool PossCapTecExecCont { get; set; }
        [Required]
        public bool EmpPossProgInteComp { get; set; }
        [Required]
        public bool EmpPossHistEnvFrau { get; set; }
        [Required]
        public bool EmpListCeisCnep { get; set; }
        public string textarea5 { get; set; }
        public string textarea6 { get; set; }
        [Required]
        public bool AlgumSocPossVincMv { get; set; }
        public string textarea7 { get; set; }
        [Required]
        public bool FuncPrestServVinMV { get; set; }
        public string textarea8 { get; set; }
        [Required]
        public bool AlgumSocFuncPubl { get; set; }
        public string textarea9 { get; set; }
        [Required]
        public bool AlgumSocConcCargPub { get; set; }
        public string textarea10 { get; set; }
        [Required]
        public bool AlgumSocConjFuncMv { get; set; }
        public string textarea11 { get; set; }
        [Required]
        public bool EmpPossRelOutPais { get; set; }
        public string textarea12 { get; set; }
        [Required]
        public bool EmpUsaIntFechNeg { get; set; }
        public string textarea13 { get; set; }
        [Required]
        public bool EmpRealizTreinLgpdMv { get; set; }
        [Required]
        public bool EmpPossCertLgpd { get; set; }
        public string textarea15 { get; set; }
        [Required]
        public bool EmpPossEncarProtDad { get; set; }
        public string textarea16 { get; set; }
        [Required]
        public bool EmpEnconAptaAvalDanPess { get; set; }
        [Required]
        public bool OsColabTreiCapacLgpd { get; set; }
        [Required]
        public bool DescTecSegAdotPreserLgpd { get; set; }
        public string textarea19 { get; set; }
        [Required]
        public bool TransfeCompartLgpdAcordLei { get; set; }
        [Required]
        public string data2 { get; set; }
        [Required]
        public string nomeLeg { get; set; }
        [Required]
        public string rgRep { get; set; }
        [Required]
        public string cargoRep { get; set; }
    }

}