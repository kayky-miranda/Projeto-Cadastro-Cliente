using System.ComponentModel.DataAnnotations;

namespace BlueSeas.Models
{
    public class CadastrosModel
    {
        public int Id {  get; set; }

        [Required(ErrorMessage="Campo obrigatório.")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string NomeFantasia {  get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string CNPJ { get; set; }

        public string? InscricaoEstadual { get; set; }
        public string? InscricaoSocial { get; set; }
        public string? InscricaoMunicipal { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public int Numero { get; set; }
        public string? Complemento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string UF { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Email {  get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Telefone { get; set; }
        public string? Celular { get; set; }

        public bool? WhatsApp { get; set; }
        public string? URL { get; set; }

        public DateTime UltimaAtualizacao { get; set; } = DateTime.Now;


    }

}
