using Application.Validations;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class GameDTO
    {
        /// <summary>
        /// Nome do primeiro jogador.
        /// </summary>
        [Required(ErrorMessage = "O nome do primeiro jogador é obrigatório.")]
        public string FirstPlayerName { get; set; }
        /// <summary>
        /// Elementos permitidos: "pedra", "papel", "tesoura", "spock", "lagarto".
        /// </summary>
        [Required]
        [StringRange(AllowableValues = new[] { "pedra", "papel", "tesoura", "spock", "lagarto" })]
        public string FirstPlayerElement { get; set; }
        /// <summary>
        /// Nome do segundo jogador.
        /// </summary>
        [Required(ErrorMessage = "O nome do segundo jogador é obrigatório.")]
        public string SecondPlayerName { get; set; }
        /// <summary>
        /// Elementos permitidos: "pedra", "papel", "tesoura", "spock", "lagarto".
        /// </summary>
        [Required]
        [StringRange(AllowableValues = new[] { "pedra", "papel", "tesoura", "spock", "lagarto" })]
        public string SecondPlayerElement { get; set; }
    }
}
