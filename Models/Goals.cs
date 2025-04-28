using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Fitness_Tracker.Models
{
    public class Goals
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        public int Goal { get; set; }

        [Required]
        [StringLength(50)]
        public string StartDate { get; set; }

        [Required]
        [StringLength(50)]
        public string EndDate { get; set; }

        [Required]
        [StringLength(50)]
        public string IsAchieve { get; set; }

        public int CaloriesBurned { get; set; }
    }
}
