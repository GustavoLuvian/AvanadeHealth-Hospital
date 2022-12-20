using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvanadeHealth.Models
{
    public class Hospital
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "A ID (Identificação) do Hospital é obrigatória")]
        public int IdHospital { get; set; }
        [Required(ErrorMessage = "O nome do paciente é obrigatório")]
        [StringLength(50, ErrorMessage = "O nome do Paciente deve ter no máximo 50 caracteres")]
        [Display(Name = "Nome do Paciente é Obrigatório")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O CNPJ é obrigatório")]
        [StringLength(14, ErrorMessage = "O CNPJ deve ter no máximo 14 caracteres")]
        [Display(Name = "CNPJ é Obrigatório")]
        public byte CNPJ { get; set; }
        [Required(ErrorMessage = "O endereço é obrigatório")]
        [StringLength(50, ErrorMessage = "O endereço deve ter no máximo 50 caracteres")]
        [Display(Name = "Endereço é Obrigatório")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "O telefone é obrigatório")]
        [StringLength(11, ErrorMessage = "O telefone deve ter no máximo 11 caracteres")]
        [Display(Name = "Telefone é Obrigatório")]
        public byte Telefone { get; set; }
        [Required(ErrorMessage = "O CNES é obrigatório")]
        [StringLength(7, ErrorMessage = "O CNES deve ter no máximo 11 caracteres")]
        [Display(Name = "Cadastro Nacional de Estabelecimento de Saúde é Obrigatório")]
        public byte CNES { get; set; }
        [Required(ErrorMessage = "É necessário informar a situação do Cadastro")]
        [Display(Name = "Situação do Cadastro é Obrigatória")]
        public bool Ativo { get; set; }
    }
}
