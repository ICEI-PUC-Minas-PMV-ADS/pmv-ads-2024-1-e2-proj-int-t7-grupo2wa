using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webarcade.Models
{
    [Table("Ranks")]
    public class Rank
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a pontuação")]
        [Display(Name = "Pontuação")]
        public int Pontuacao { get; set; }

        public Plataforma Plataforma { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a pontuação")]
        [Display(Name = "Game")]
        public int GameId { get; set; }

        [ForeignKey("GameId")]
        public Game Game { get; set; }


    }
    public enum Plataforma
    {
        Pc,
        Mobile
    }
}
