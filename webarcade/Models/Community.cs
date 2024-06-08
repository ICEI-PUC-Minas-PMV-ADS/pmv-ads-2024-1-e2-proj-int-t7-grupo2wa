using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webarcade.Models
{
    [Table("Communitys")]
    public class Community
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Obrigatorio informar o nome do jogo")]
        [Display(Name = "Nome do jogo")]
        public string game { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a desenvolvedora")]
        [Display(Name = "Criador")]
        public string Criador { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o gênero")]
        [Display(Name = "Link do jogo")]
        public string Link { get; set; }
    }
}
