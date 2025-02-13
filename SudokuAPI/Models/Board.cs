using System.ComponentModel.DataAnnotations;

namespace SudokuAPI.Models
{
    public class Board
    {
        [Key]
        public int BoardId { get; set; }
        [Required]
        [MaxLength(81)]
        public string Numbers { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
    }
}