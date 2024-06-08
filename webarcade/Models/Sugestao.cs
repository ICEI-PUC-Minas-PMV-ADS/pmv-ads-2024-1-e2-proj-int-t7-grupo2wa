using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webarcade.Models
{
    [Table("Sugestoes")]
    public class Sugestao
    {
        [Key]
        public int Id{ get; set; }


        [Required(ErrorMessage = "Obrigatorio deixar sua sugestão")]
        [Display(Name = "Sugestão")]
        public string Sugestaoo { get; set; }

        [Required(ErrorMessage = "Obrigatorio deixar sua avaliação ")]
        [Display(Name = "Avaliação ")]
        public int Avaliacao { get; set; }
    }
}
