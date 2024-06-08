using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webarcade.Models
{
    [Table("Games")]
    public class Game
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o nome do jogo")]
        [Display(Name = "Nome do jogo")]
        public string Desenvolvedora { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a desenvolvedora")]
        [Display(Name = "Desenvolvedora")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o ano de criação")]
        [Display(Name = "Ano de Criação")]
        public int AnoCriacao { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o gênero")]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        public ICollection<Rank> Ranks { get; set; }


    }
}
