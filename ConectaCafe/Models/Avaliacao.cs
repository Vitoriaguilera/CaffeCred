using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConectaCafe.Models;

[Table("Avaliacao")]
public class Avaliacao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int Id { get; set; }

    [Display(Name = "Nome")]
    [Required(ErrorMessage = "Por favor, informe o nome")]
    [StringLength(60, ErrorMessage = " O nome deve possuir no máximo 60 caracteres.")]
    public string Pessoa { get; set; }


    [Required(ErrorMessage = "Por favor, informe o texto")]
    [StringLength(500, ErrorMessage = " O nome deve possuir no máximo 500 caracteres.")]
    public string Texto { get; set; }


    [Required(ErrorMessage = "Por favor, informe a nota")]
    [Column(TypeName = "decimal(1,0)")]
    public decimal Nota { get; set; }


    [DataType(DataType.Date)]
    [Display(Name = "Data de Avaliação")]    
    public DateTime DataAvaliacao { get; set; } = DateTime.Now;


    [StringLength(200)]
    public string Foto { get; set; }

}