using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("history")]
    public class History
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("game_result", TypeName = "varchar(20)")]
        public string GameResult { get; set; }
        [Required]
        [Column("first_player_name", TypeName = "varchar(150)")]
        public string FirstPlayerName { get; set; }
        [Required]
        [Column("first_player_element", TypeName = "varchar(10)")]
        public string FirstPlayerElement { get; set; }
        [Required]
        [Column("second_player", TypeName = "varchar(150)")]
        public string SecondPlayerName { get; set; }
        [Required]
        [Column("second_player_element", TypeName = "varchar(10)")]
        public string SecondPlayerElement { get; set; }
        [Column("game_date")]
        public DateTime GameDate { get; set; }
    }
}
